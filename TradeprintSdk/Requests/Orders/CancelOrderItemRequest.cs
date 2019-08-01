using System.Net.Http;
using Tradeprint.Handlers;
using Tradeprint.Model.Payload;

namespace Tradeprint.Requests.Orders
{
    public class CancelOrderItemRequest : Request
    {
        // Dummy implementation for a non-used payload
        public override ApiPayload Payload => null;

        public CancelOrderItemRequest(IRequestHandler requestHandler, string orderReference, string itemReference) 
            : base(requestHandler, $"orders/{orderReference}/orderItems/{itemReference}", HttpMethod.Delete)
        {
        }
    }
}
