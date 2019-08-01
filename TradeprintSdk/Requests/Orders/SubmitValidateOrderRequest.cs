using Tradeprint.Handlers;
using Tradeprint.Model;
using Tradeprint.Model.Payload;

namespace Tradeprint.Requests.Orders
{
    public class SubmitValidateOrderRequest : PostRequest
    {
        private const string DEFAULT_CURRENCY = "GBP";
        private readonly SubmitValidateOrderPayload payload;

        public override ApiPayload Payload => this.payload;

        public SubmitValidateOrderRequest(IRequestHandler requestHandler, string endpoint) 
            : base(requestHandler, endpoint)
        {
            payload = new SubmitValidateOrderPayload();
        }

        public SubmitValidateOrderRequest SetOrderReference(string orderReference)
        {
            payload.orderReference = orderReference;

            return this;
        }

        public SubmitValidateOrderRequest SetBillingAddress(BillingAddress billingAddress)
        {
            payload.billingAddress = billingAddress;

            return this;
        }

        public SubmitValidateOrderRequest SetCurrency(string currency = DEFAULT_CURRENCY)
        {
            payload.currency = currency;

            return this;
        }

        public OrderItem AddOrderItem()
        {
            var orderItem = new OrderItem();

            payload.orderItems.Add(orderItem);

            return orderItem;
        }
    }
}
