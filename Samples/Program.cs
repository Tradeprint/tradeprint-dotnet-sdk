using dotenv.net;
using System;
using System.Threading.Tasks;
using Tradeprint;
using Tradeprint.Environments;
using Tradeprint.Errors;
using Tradeprint.Model;
using Tradeprint.Services;

namespace Samples
{
    class Program
    {
        private static OrderService orderService;
        private static ProductService productService;

        static async Task Main(string[] args)
        {
            DotEnv.Config(false);

            var username = Environment.GetEnvironmentVariable("API_USERNAME");
            var password = Environment.GetEnvironmentVariable("API_PASSWORD");

            var sdk = SDK.GetInstance();
            sdk.SetEnvironment(EnvironmentName.Sandbox);
            sdk.SetCredentials(username, password);
            sdk.SetDebugging(true);

            orderService = sdk.OrderService;
            productService = sdk.ProductService;

            try
            {
                await CallTradeprintApi();
            }
            catch (SdkError e)
            {
                Console.WriteLine("SDK ERROR");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorDetails);
                Console.WriteLine(e.StackTrace.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("UNKNOWN ERROR");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace.ToString());
            }
        }

        private static async Task CallTradeprintApi()
        {
            // TODO: refactor and include all samples
        }

        private static void PrintSerialized(SdkResult sdkResult)
        {
            Console.WriteLine($"{Environment.NewLine}{sdkResult.SerializedResult}{Environment.NewLine}");
        }
    }
}
