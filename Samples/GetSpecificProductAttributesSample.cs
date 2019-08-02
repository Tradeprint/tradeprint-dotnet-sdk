using System.Threading.Tasks;
using Tradeprint;
using Tradeprint.Model;

namespace Samples
{
    /**
     * Tradeprint API - Get Attributes for Specific Product
     * https://docs.sandbox.tradeprint.io/?version=latest#99ef2585-9784-41b7-a086-2b174cc001b8
     */
    static class GetSpecificProductAttributesSample
    {
        public async static Task<SdkResult> CallRequest(SDK sdk)
        {
            return await sdk.ProductService
                .GetSpecificProductAttributes(TestData.TEST_PRODUCT_ONE)
                .Call();
        }
    }
}
