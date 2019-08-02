using System.Threading.Tasks;
using Tradeprint;
using Tradeprint.Model;

namespace Samples
{
    /**
     * Tradeprint API - Retry Payment
     * https://docs.sandbox.tradeprint.io/?version=latest#a4c34bda-065c-4d94-8125-db51304d7b7f7
     */
    static class RetryPaymentSample
    {
        public async static Task<SdkResult> CallRequest(SDK sdk)
        {
            return await sdk.OrderService
                .RetryPayment("ORDER_REFENCE")
                .Call();
        }
    }
}
