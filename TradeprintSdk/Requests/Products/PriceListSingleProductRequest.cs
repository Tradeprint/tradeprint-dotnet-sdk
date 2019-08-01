using Tradeprint.Handlers;

namespace Tradeprint.Requests.Products
{
    public class PriceListSingleProductRequest : PriceListProductRequest
    {
        private string productName;

        public PriceListSingleProductRequest(IRequestHandler requestHandler, string productName) 
            : base(requestHandler, $"products/{productName}")
        {
            this.productName = productName;
        }
    }
}
