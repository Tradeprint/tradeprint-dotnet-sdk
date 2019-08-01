using Newtonsoft.Json;
using System.Collections.Generic;
using Tradeprint.Handlers;
using Tradeprint.Model;
using Tradeprint.Model.Payload;

namespace Tradeprint.Requests.Products
{
    public class ProductQuantitiesRequest : PostRequest
    {
        private readonly ProductQuantitiesPayload payload;

        public override ApiPayload Payload => this.payload;

        public ProductQuantitiesRequest(IRequestHandler requestHandler) 
            : base(requestHandler, "products/quantities")
        {
            payload = new ProductQuantitiesPayload();
        }

        public override ApiResponse DeserializeResponse(string callResponseAsString)
         {
            return JsonConvert.DeserializeObject<ApiNumberArrayResponse>(callResponseAsString);
        }

        public ProductQuantitiesRequest SetProductId(string productId)
        {
            payload.productId = productId;

            return this;
        }

        public ProductQuantitiesRequest SetServiceLevel(string serviceLevel)
        {
            payload.serviceLevel = serviceLevel;

            return this;
        }

        public ProductQuantitiesRequest SetProductionData(Dictionary<string, string> productionData)
        {
            payload.productionData = productionData;

            return this;
        }
    }
}
