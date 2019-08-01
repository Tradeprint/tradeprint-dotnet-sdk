using System.Collections.Generic;

namespace Tradeprint.Model.Payload
{
    public class ProductQuantitiesPayload: ApiPayload
    {
        public string productId { get; set; }
        public string serviceLevel { get; set; }
        public Dictionary<string, string> productionData { get; set; }
    }
}
