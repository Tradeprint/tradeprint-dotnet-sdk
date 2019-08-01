using Tradeprint.Handlers;

namespace Tradeprint.Requests.Orders
{
    public class GetOrderStatusByIdRequest : GetRequest
    {
        public GetOrderStatusByIdRequest(IRequestHandler requestHandler, string orderReference) 
            : base(requestHandler, $"orders/{orderReference}")
        {
        }
    }
}
