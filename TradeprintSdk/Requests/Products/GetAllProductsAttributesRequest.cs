using Newtonsoft.Json;
using Tradeprint.Handlers;
using Tradeprint.Model;

namespace Tradeprint.Requests.Products
{
    public class GetAllProductsAttributesRequest : GetRequest
    {
        public GetAllProductsAttributesRequest(IRequestHandler requestHandler) 
            : base(requestHandler, "products/attributes")
        {
        }

        public override ApiResponse DeserializeResponse(string callResponseAsString)
        {
            return JsonConvert.DeserializeObject<ApiDictionaryResponse>(callResponseAsString);
        }
    }
}
