using System;
using System.Collections.Generic;
using System.Text;

namespace Tradeprint.Model.Payload
{
    class GetExpectedDeliveryDatePayload: ApiPayload
    {
        public string productId { get; set; }
        public string serviceLevel { get; set; }
        public string artworkService { get; set; }
        public int quantity { get; set; }
        public Dictionary<string, string> productionData { get; set; }
    }
}
