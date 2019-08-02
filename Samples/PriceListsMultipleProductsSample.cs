using System;
using System.Threading.Tasks;
using Tradeprint;
using Tradeprint.Model;

namespace Samples
{
    /**
     * Tradeprint API - Request Price Lists for Multiple Products
     * https://docs.sandbox.tradeprint.io/?version=latest#2206363e-3668-4c2e-b1ec-e9523416916a
     */
    static class PriceListsMultipleProductsSample
    {
        public async static Task<SdkResult> CallRequest(SDK sdk)
        {
            return await sdk.ProductService
                .PriceListsMultipleProducts()
                .AddProductName(TestData.TEST_PRODUCT_ONE)
                .AddProductName(TestData.TEST_PRODUCT_TWO)
                .SetEmailAddress(TestData.TEST_EMAIL)
                .SetFormatJson()
                .SetMarkup(10)                          // Optional
                .SetFromDate(DateTime.Now.AddDays(-14)) // Optional
                .Call();
    }
}
}
