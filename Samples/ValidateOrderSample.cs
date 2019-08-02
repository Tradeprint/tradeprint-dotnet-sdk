using System.Threading.Tasks;
using Tradeprint;
using Tradeprint.Model;

namespace Samples
{
    /**
     * Tradeprint API - Validate Order
     * https://docs.sandbox.tradeprint.io/?version=latest#b1822b88-b0f1-4fb2-b94d-de717a2971b7
     */
    static class ValidateOrderSample
    {
        public async static Task<SdkResult> CallRequest(SDK sdk)
        {
            var sdkSubmitNewOrderRequest = sdk.OrderService
                .ValidateOrder()
                .SetOrderReference("OPTIONAL_ORDER_REFERENCE")  // Optional
                .SetCurrency()
                .SetBillingAddress(TestData.TEST_BILLING_ADDRESS);

            sdkSubmitNewOrderRequest
                .AddOrderItem()
                .AddFileUrl(TestData.TEST_FILE_URL)
                .SetArtworkService(TestData.TEST_ARTWORK_SERVICE)
                .SetServiceLevel(TestData.TEST_SERVICE_LEVEL)
                .SetProductId(TestData.TEST_PRODUCT_ID)
                .SetQuantity(500)
                .SetProductionData(TestData.TEST_PRODUCTION_DATA)
                .SetDeliveryAddress(TestData.TEST_DELIVERY_ADDRESS)
                .SetPartnerContactDetails(TestData.TEST_PARTNET_CONTACT_DETAILS)
                .SetExtraData(TestData.TEST_EXTRA_DATA);

            return await sdkSubmitNewOrderRequest.Call();
        }
    }
}
