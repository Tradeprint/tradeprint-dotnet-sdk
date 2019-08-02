using System.Threading.Tasks;
using Tradeprint;
using Tradeprint.Model;

namespace Samples
{
    /**
     * Tradeprint API - Request Product Quantities
     * https://docs.sandbox.tradeprint.io/?version=latest#9f8758a3-da77-4fd5-b307-9df28e5e9b4b
     */
    static class ProductQuantitiesSample
    {
        public async static Task<SdkResult> CallRequest(SDK sdk)
        {
            return await sdk.ProductService
                .ProductQuantities()
                .SetProductId(TestData.TEST_PRODUCT_ID)
                .SetServiceLevel(TestData.TEST_SERVICE_LEVEL)
                .SetProductionData(TestData.TEST_PRODUCTION_DATA)
                .Call();
        }
    }
}
