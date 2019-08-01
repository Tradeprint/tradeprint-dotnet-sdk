using Tradeprint.Handlers;
using Tradeprint.Model.Payload;

namespace Tradeprint.Requests.Orders
{
    public class RetryPaymentRequest: PostRequest
    {
        // Dummy implementation
        public override ApiPayload Payload => null;

        public RetryPaymentRequest(IRequestHandler requestHandler, string orderReference)
            : base(requestHandler, $"orders/{orderReference}/retryPayment")
        {
        }
    }
}
