using Tradeprint.Handlers;

namespace Tradeprint.Requests.Orders
{
    public class ValidateOrderRequest : SubmitValidateOrderRequest
    {
        public ValidateOrderRequest(IRequestHandler requestHandler) 
            : base(requestHandler, "validate/orders")
        {
        }
    }
}
