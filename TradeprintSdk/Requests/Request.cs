using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Tradeprint.Handlers;
using Tradeprint.Model;
using Tradeprint.Model.Payload;

namespace Tradeprint.Requests
{
    public abstract class Request
    {
        private readonly IRequestHandler requestHandler;

        public HttpMethod Method { get; }
        public string Endpoint { get; }
        public abstract ApiPayload Payload { get; }

        public Request(IRequestHandler requestHandler, string endpoint, HttpMethod method)
        {
            this.requestHandler = requestHandler;
            this.Endpoint = endpoint;
            this.Method = method;
        }

        public async Task<SdkResult> Call()
        {
            return await this.requestHandler.Handle(this);
        }

        public virtual ApiResponse DeserializeResponse(string callResponseAsString)
        {
            return JsonConvert.DeserializeObject<ApiObjectResponse>(callResponseAsString);
        }
    }
}
