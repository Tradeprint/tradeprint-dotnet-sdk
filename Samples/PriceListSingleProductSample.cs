using System;
using System.Threading.Tasks;
using Tradeprint;
using Tradeprint.Model;

namespace Samples
{
    /**
     * Tradeprint API - Request Price List for Single Product
     * https://docs.sandbox.tradeprint.io/?version=latest#80cd6377-af47-4ace-8e26-cff1884b1acf
     */
    static class PriceListSingleProductSample
    {
        public async static Task<SdkResult> CallRequest(SDK sdk)
        {
            return await sdk.ProductService
                .PriceListSingleProduct(TestData.TEST_PRODUCT_ONE)
                .SetFormatCsv()
                .SetMarkup(5)                          // Optional
                .SetFromDate(DateTime.Now.AddDays(-7)) // Optional
                .Call();
    }
}
}
