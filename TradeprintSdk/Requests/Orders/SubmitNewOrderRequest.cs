using System.Collections.Generic;
using Tradeprint.Handlers;
using Tradeprint.Model;

namespace Tradeprint.Requests.Orders
{
    public class SubmitNewOrderRequest : SubmitValidateOrderRequest
    {
        public SubmitNewOrderRequest(IRequestHandler requestHandler) 
            : base(requestHandler, "orders")
        {
        }
    }
}
