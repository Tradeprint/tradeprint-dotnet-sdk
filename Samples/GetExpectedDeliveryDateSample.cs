using System.Threading.Tasks;
using Tradeprint;
using Tradeprint.Model;

namespace Samples
{
    /**
     * Tradeprint API - Get Expected Delivery Date
     * https://docs.sandbox.tradeprint.io/?version=latest#1b94aa3e-c028-47b0-8502-04035a1f9490
     */
    static class GetExpectedDeliveryDateSample
    {
        public async static Task<SdkResult> CallRequest(SDK sdk)
        {
            return await sdk.ProductService
                .GetExpectedDeliveryDate()
                .SetProductId(TestData.TEST_PRODUCT_ID)
                .SetServiceLevel(TestData.TEST_SERVICE_LEVEL)
                .SetArtworkService(TestData.TEST_ARTWORK_SERVICE)
                .SetQuantity(500)
                .SetProductionData(TestData.TEST_PRODUCTION_DATA)
                .Call();
        }
    }
}
