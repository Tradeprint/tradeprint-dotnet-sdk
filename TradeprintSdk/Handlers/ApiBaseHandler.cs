using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace Tradeprint.Handlers
{
    public class ApiBaseHandler
    {
        protected const string HEADER_JSON = "applicataion/json";

        protected static JsonSerializerSettings JSON_SERIAL_SETTINGS = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

        protected Logger logger { get; }

        public ApiBaseHandler()
        {
            logger = new Logger();
        }

        protected StringContent GetJsonPayload(object payloadObject)
        {
            var payloadString = JsonConvert.SerializeObject(payloadObject, JSON_SERIAL_SETTINGS);

            logger.debug($"Using \"{payloadString}\" payload");

            var payloadContent = new StringContent(payloadString, Encoding.UTF8, HEADER_JSON);

            return payloadContent;
        }

        protected bool IsSuccess(object resultObject)
        {
            bool.TryParse(resultObject.ToString(), out bool isSuccess);

            return isSuccess;
        }
    }
}
