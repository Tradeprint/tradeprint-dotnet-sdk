using System.Threading.Tasks;
using Tradeprint;
using Tradeprint.Model;

namespace Samples
{
    /**
     * Tradeprint API - Cancel an Order Item
     * https://docs.sandbox.tradeprint.io/?version=latest#4dc388f6-26b4-4141-b71e-0885c3532dd0
     */
    static class CancelOrderItemSample
    {
        public async static Task<SdkResult> CallRequest(SDK sdk)
        {
            return await sdk.OrderService
                .CancelOrderItem("ORDER_REFENCE", "ITEM_REFERENCE")
                .Call();
        }
    }
}
