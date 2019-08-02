using System.Threading.Tasks;
using Tradeprint;
using Tradeprint.Model;

namespace Samples
{
    /**
     * Tradeprint API - Get All Products Attributes
     * https://docs.sandbox.tradeprint.io/?version=latest#6ebfb248-8ef8-467a-9484-83b40114b26b
     */
    static class GetAllProductsAttributesSample
    {
        public async static Task<SdkResult> CallRequest(SDK sdk)
        {
            return await sdk.ProductService
                .GetAllProductsAttributes()
                .Call();
        }
    }
}
