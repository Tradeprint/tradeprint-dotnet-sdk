using Newtonsoft.Json;
using Tradeprint.Handlers;
using Tradeprint.Model;
using Tradeprint.Model.Payload;

namespace Tradeprint.Requests.Orders
{
    public class FetchOrdersByReferenceRequest : PostRequest
    {
        private readonly FetchOrdersByReferencePayload payload;

        public FetchOrdersByReferenceRequest(IRequestHandler requestHandler) 
            : base(requestHandler, "orders/ordersStatus")
        {
            payload = new FetchOrdersByReferencePayload();
        }

        public override ApiResponse DeserializeResponse(string callResponseAsString)
        {
            return JsonConvert.DeserializeObject<ApiArrayResponse>(callResponseAsString);
        }

        public override ApiPayload Payload => this.payload;

        public FetchOrdersByReferenceRequest AddOrderReference(string orderReference)
        {
            payload.orderReferences.Add(orderReference);

            return this;
        }
    }
}
