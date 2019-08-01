using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Tradeprint.Errors;
using Tradeprint.Model;

namespace Tradeprint.Handlers
{
    public class AuthHandler: ApiBaseHandler, IAuthHandler
    { 
        private TimeSpan tokenTimeout;

        public static TimeSpan DefaultTokenTimeout
        {
            get
            {
                return new TimeSpan(TimeSpan.TicksPerHour * 4);
            }
        }

        public AuthHandler(TimeSpan tokenIimeout)
        {
            if (tokenIimeout == null)
            {
                this.tokenTimeout = DefaultTokenTimeout;
            }
            else
            {
                this.tokenTimeout = tokenIimeout;
            }
        }

        public async Task<AuthDetails> Handle(AuthDetails currentDetails, HttpClient httpClient)
        {
            if (currentDetails == null || currentDetails.Token == null || !currentDetails.Timestamp.HasValue)
            {
                return await LoginToApi(httpClient);
            }
            else if (currentDetails.Timestamp.HasValue && DateTime.Now - currentDetails.Timestamp > tokenTimeout)
            {
                return await LoginToApi(httpClient);
            }
            else
            {
                return currentDetails;
            }
        }

        private async Task<AuthDetails> LoginToApi(HttpClient httpClient)
        {
            var loginEndpoint = $"{Config.Environemnt.BaseUrl}/login";
            var loginPayload = new { username = Config.Username, password = Config.Password };

            logger.debug($"{HttpMethod.Post.ToString()} {loginEndpoint} with \"{loginPayload.ToString()}\"");

            var loginContent = GetJsonPayload(loginPayload);

            var loginResponse = await httpClient.PostAsync(loginEndpoint, loginContent);
            var loginResponseAsString = await loginResponse.Content.ReadAsStringAsync();

            var loginResponseAsJson = JsonConvert.DeserializeObject<ApiObjectResponse>(loginResponseAsString);

            if (IsSuccess(loginResponseAsJson.success))
            {
                string token = loginResponseAsJson.ResultObject.token;

                logger.debug($"Got authentication token \"{token}\"");

                return new AuthDetails
                {
                    Token = token,
                    Timestamp = DateTime.Now
                };
            }
            else
            {
                logger.error($"Failed {Config.Environemnt.EnvironmentName} Authentication");

                var errorDetails = JsonConvert.SerializeObject(loginResponseAsJson.errorDetails);

                throw new SdkLoginError(loginResponseAsJson.errorMessage, errorDetails);
            }
        }
    }
}
