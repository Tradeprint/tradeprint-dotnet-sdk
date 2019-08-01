using System.Collections.Generic;
using Tradeprint.Handlers;
using Tradeprint.Model.Payload;

namespace Tradeprint.Requests.Products
{
    public class GetExpectedDeliveryDateRequest : PostRequest
    {
        private readonly GetExpectedDeliveryDatePayload payload;

        public override ApiPayload Payload => this.payload;

        public GetExpectedDeliveryDateRequest(IRequestHandler requestHandler) 
            : base(requestHandler, "products/expectedDeliveryDate")
        {
            payload = new GetExpectedDeliveryDatePayload();
        }

        public GetExpectedDeliveryDateRequest SetQuantity(int quantity)
        {
            payload.quantity = quantity;

            return this;
        }

        public GetExpectedDeliveryDateRequest SetArtworkService(string artworkService)
        {
            payload.artworkService = artworkService;

            return this;
        }

        public GetExpectedDeliveryDateRequest SetProductId(string productId)
        {
            payload.productId = productId;

            return this;
        }

        public GetExpectedDeliveryDateRequest SetServiceLevel(string serviceLevel)
        {
            payload.serviceLevel = serviceLevel;

            return this;
        }

        public GetExpectedDeliveryDateRequest SetProductionData(Dictionary<string, string> productionData)
        {
            payload.productionData = productionData;

            return this;
        }
    }
}
