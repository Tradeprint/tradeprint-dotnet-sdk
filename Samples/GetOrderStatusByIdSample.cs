using dotenv.net;
using System;
using System.Threading.Tasks;
using Tradeprint;
using Tradeprint.Environments;
using Tradeprint.Model;

namespace Samples
{
    /*
     * Tradeprint API - Get Order Status by ID
     * https://docs.sandbox.tradeprint.io/?version=latest#ca75104b-eb43-40f8-9205-109dc2297327
     */
    static class GetOrderStatusByIdSample
    {
        public async static Task<SdkResult> CallRequest()
        {
            DotEnv.Config(false);

            var username = Environment.GetEnvironmentVariable("API_USERNAME");
            var password = Environment.GetEnvironmentVariable("API_PASSWORD");

            var sdk = SDK.GetInstance();
            sdk.SetEnvironment(EnvironmentName.Sandbox);
            sdk.SetCredentials(username, password);
            sdk.SetDebugging(true);

            return await sdk.OrderService
                .GetOrderStatusById("ORDER_REFENCE")
                .Call();
        }
    }
}
