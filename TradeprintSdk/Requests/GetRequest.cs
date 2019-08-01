using System.Net.Http;
using Tradeprint.Handlers;
using Tradeprint.Model.Payload;

namespace Tradeprint.Requests
{
    public abstract class GetRequest : Request
    {
        // Dummy implementation for a non-used payload
        public override ApiPayload Payload => null;

        public GetRequest(IRequestHandler requestHandler, string endpoint) 
            : base(requestHandler, endpoint, HttpMethod.Get)
        {
        }
    }
}
