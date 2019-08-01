using System.Collections.Generic;

namespace Tradeprint.Model
{
    public class ApiResponseOrderItem
    {
        public List<string> fileUrls { get; set; }
        public string itemReference { get; set; }
        public string status { get; set; }
        public string hasError { get; set; }
        public string serviceLevel { get; set; }
        public int quantity { get; set; }
        public float productNetPrice { get; set; }
        public bool? serviceLevelDowngraded { get; set; }
        public ExtraData extraData { get; set; }
    }
}
