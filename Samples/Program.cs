using dotenv.net;
using System;
using System.Threading.Tasks;
using Tradeprint;
using Tradeprint.Environments;
using Tradeprint.Errors;
using Tradeprint.Model;

namespace Samples
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                /**
                 * Using DotEnv to try and get environment variables from a local ".env" file
                 * See the EnvTemplate\.env file an example
                 */
                DotEnv.Config(false);

                var username = Environment.GetEnvironmentVariable("API_USERNAME");
                var password = Environment.GetEnvironmentVariable("API_PASSWORD");

                var sdk = SDK.GetInstance();
                sdk.SetEnvironment(EnvironmentName.Sandbox);
                sdk.SetCredentials(username, password);
                sdk.SetDebugging(true);

                SdkResult result = null;

                // Uncomment the call you want to test and edit the relevant "Sample" code file

                //result = await SubmitNewOrderSample.CallRequest(sdk);
                //result = await ValidateOrderSample.CallRequest(sdk);
                //result = await GetOrderStatusByIdSample.CallRequest(sdk);
                //result = await FetchOrdersByReferenceSample.CallRequest(sdk);
                //result = await UploadReplaceArtworkSample.CallRequest(sdk);
                //result = await CancelOrderItemSample.CallRequest(sdk);
                //result = await RetryPaymentSample.CallRequest(sdk);

                Console.WriteLine($"JSON result: \"{result.SerializedResult}\"");
            }
            catch (SdkLoginError e)
            {
                Console.WriteLine("SDK LOGIN ERROR");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorDetails);
                Console.WriteLine(e.StackTrace.ToString());
            }
            catch (SdkRequestError e)
            {
                Console.WriteLine("SDK REQUEST ERROR");
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
    }
}
