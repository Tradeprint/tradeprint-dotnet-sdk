using Tradeprint.Requests.Orders;

namespace Tradeprint.Services
{
    public class OrderService : ApiService
    {
        private OrderService() { }

        private static OrderService instance;

        public static OrderService GetInstance()
        {
            if (instance == null) instance = new OrderService();

            return instance;
        }

        public SubmitNewOrderRequest SubmitNewOrder()
        {
            return new SubmitNewOrderRequest(this.RequestHandler);
        }

        public ValidateOrderRequest ValidateOrder()
        {
            return new ValidateOrderRequest(this.RequestHandler);
        }

        public UploadReplaceArtwokRequest UploadReplaceArtwork(string orderReference, string itemReference)
        {
            return new UploadReplaceArtwokRequest(this.RequestHandler, orderReference, itemReference);
        }

        public GetOrderStatusByIdRequest GetOrderStatusById(string orderReference)
        {
            return new GetOrderStatusByIdRequest(this.RequestHandler, orderReference);
        }

        public FetchOrdersByReferenceRequest FetchOrdersByReference()
        {
            return new FetchOrdersByReferenceRequest(this.RequestHandler);
        }

        public CancelOrderItemRequest CancelOrderItem(string orderReference, string itemReference)
        {
            return new CancelOrderItemRequest(this.RequestHandler, orderReference, itemReference);
        }

        public RetryPaymentRequest RetryPayment(string orderReference)
        {
            return new RetryPaymentRequest(this.RequestHandler, orderReference);
        }
    }
}
 