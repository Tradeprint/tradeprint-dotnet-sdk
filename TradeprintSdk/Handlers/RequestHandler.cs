using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Tradeprint.Errors;
using Tradeprint.Model;
using Tradeprint.Requests;

namespace Tradeprint.Handlers
{
    public class RequestHandler: ApiBaseHandler, IRequestHandler
    {
        private const string HEADER_AUTH = "Authorization";

        private static RequestHandler instance;

        private IAuthHandler authHandler;
        private AuthDetails authDetails;

        public static RequestHandler GetInstance(IAuthHandler authHandler = null)
        {
            if (instance == null) instance = new RequestHandler(authHandler);

            return instance;
        }

        private RequestHandler(IAuthHandler authHandler) {
            if (authHandler == null)
            {
                this.authHandler = new AuthHandler(AuthHandler.DefaultTokenTimeout);
            } else
            {
                this.authHandler = authHandler;
            }
        }

        public async Task<SdkResult> Handle(Request request, HttpClient httpClient = null)
        {
            using (httpClient != null ? httpClient : httpClient = new HttpClient())
            {
                this.authDetails = await this.authHandler.Handle(this.authDetails, httpClient);

                return await CallApiEndpoint(httpClient, request);
            }
        }

        private async Task<SdkResult> CallApiEndpoint(HttpClient httpClient, Request request)
        {
            var requestName = request.GetType().Name;
            var requestEndpoint = $"{Config.Environemnt.BaseUrl}/{request.Endpoint}";
            var authHeaderValue = $"Bearer {this.authDetails.Token}";

            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add(HEADER_AUTH, authHeaderValue);

            var requestMessage = new HttpRequestMessage
            {
                Method = request.Method,
                RequestUri = new Uri(requestEndpoint)
            };

            logger.debug($"Running {request.Method.ToString()} call to {requestEndpoint} endpoint using \"{requestName}\" request class");

            if (request.Method != HttpMethod.Get && request.Payload != null)
            {
                requestMessage.Content = GetJsonPayload(request.Payload);
            }

            var callResponse = await httpClient.SendAsync(requestMessage);

            var callResponseAsString = await callResponse.Content.ReadAsStringAsync();
            var callResponseAsJson = request.DeserializeResponse(callResponseAsString);

            if (IsSuccess(callResponseAsJson.success))
            {
                var apiResult = callResponseAsJson.ResultObject;

                return new SdkResult
                {
                    Success = true,
                    SerializedResult = JsonConvert.SerializeObject(apiResult, JSON_SERIAL_SETTINGS),
                    Result = apiResult
                };
            }

            logger.error($"Failed {Config.Environemnt.EnvironmentName} {requestName} Request");

            var errorDetails = JsonConvert.SerializeObject(callResponseAsJson.errorDetails);

            throw new SdkRequestError(callResponseAsJson.errorMessage, errorDetails);
        }
    }
}
