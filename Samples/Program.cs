using System;
using System.Threading.Tasks;
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
                SdkResult result = null;

                //result = await SubmitNewOrderSample.CallRequest();
                //result = await GetOrderStatusByIdSample.CallRequest();

                // TODO: add more calls to execute

                Console.WriteLine($"JSON result: \"{result.SerializedResult}\"");
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
    }
}
