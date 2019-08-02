using System.Threading.Tasks;
using Tradeprint;
using Tradeprint.Model;

namespace Samples
{
    /**
     * Tradeprint API - Get Order Status by ID
     * https://docs.sandbox.tradeprint.io/?version=latest#ca75104b-eb43-40f8-9205-109dc2297327
     */
    static class GetOrderStatusByIdSample
    {
        public async static Task<SdkResult> CallRequest(SDK sdk)
        {
            return await sdk.OrderService
                .GetOrderStatusById("ORDER_REFENCE")
                .Call();
        }
    }
}
