using System.Collections.Generic;

namespace Tradeprint.Model.Payload
{
    public class SubmitValidateOrderPayload: ApiPayload
    {
        public string orderReference { get; set; }
        public string currency { get; set; }
        public List<OrderItem> orderItems { get; set; } = new List<OrderItem>();
        public BillingAddress billingAddress { get; set; }
    }
}
