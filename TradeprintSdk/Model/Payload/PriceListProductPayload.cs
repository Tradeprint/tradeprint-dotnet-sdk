using System.Collections.Generic;

namespace Tradeprint.Model.Payload
{
    public class PriceListProductPayload: ApiPayload
    {
        public string email { get; set; }
        public string format { get; set; }
        public string fromDate { get; set; }
        public int? markup { get; set; }
        public List<string> productNames { get; set; }
    }
}
