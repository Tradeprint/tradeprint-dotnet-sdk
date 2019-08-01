using Tradeprint.Handlers;

namespace Tradeprint.Requests.Products
{
    public class GetSpecificProductAttributesRequest : GetRequest
    {
        private string productName;

        public GetSpecificProductAttributesRequest(IRequestHandler requestHandler, string productName) 
            : base(requestHandler, $"products/attributes/{productName}")
        {
            this.productName = productName;
        }
    }
}
