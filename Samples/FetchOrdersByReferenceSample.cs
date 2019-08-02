using System.Threading.Tasks;
using Tradeprint;
using Tradeprint.Model;

namespace Samples
{
    /**
     * Tradeprint API - Fetch Orders by References
     * https://docs.sandbox.tradeprint.io/?version=latest#06cc541c-cd0e-48dc-864a-3d32c6cf173f
     */
    static class FetchOrdersByReferenceSample
    {
        public async static Task<SdkResult> CallRequest(SDK sdk)
        {
            return await sdk.OrderService
                .FetchOrdersByReference()
                .AddOrderReference("ORDER_REFENCE")
                .Call();
        }
    }
}
