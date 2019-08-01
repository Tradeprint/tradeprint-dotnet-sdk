using System.Net.Http;
using Tradeprint.Handlers;
using Tradeprint.Model.Payload;
using Tradeprint.Requests;

namespace TradeprintSdk.Tests
{
    internal class TestRequest : Request
    {
        public override ApiPayload Payload => null;

        public TestRequest(IRequestHandler requestHandler)
            : base(requestHandler, "testEndpoint", HttpMethod.Post)
        {
        }
    }
}
