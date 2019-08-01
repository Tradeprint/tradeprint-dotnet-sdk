using Tradeprint.Requests.Products;

namespace Tradeprint.Services
{
    public class ProductService : ApiService
    {
        private ProductService() { }

        private static ProductService instance;

        public static ProductService GetInstance()
        {
            if (instance == null) instance = new ProductService();

            return instance;
        }

        public PriceListsMultipleProductsRequest PriceListsMultipleProducts()
        {
            return new PriceListsMultipleProductsRequest(this.RequestHandler);
        }

        public PriceListSingleProductRequest PriceListSingleProduct(string productName)
        {
            return new PriceListSingleProductRequest(this.RequestHandler, productName);
        }

        public GetAllProductsAttributesRequest GetAllProductsAttributes()
        {
            return new GetAllProductsAttributesRequest(this.RequestHandler);
        }

        public GetSpecificProductAttributesRequest GetSpecificProductAttributes(string productName)
        {
            return new GetSpecificProductAttributesRequest(this.RequestHandler, productName);
        }

        public ProductQuantitiesRequest ProductQuantities()
        {
            return new ProductQuantitiesRequest(this.RequestHandler);
        }

        public GetExpectedDeliveryDateRequest GetExpectedDeliveryDate()
        {
            return new GetExpectedDeliveryDateRequest(this.RequestHandler);
        }
    }
}
 