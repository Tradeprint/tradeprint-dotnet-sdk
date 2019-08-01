using System.Net.Http;
using Tradeprint.Handlers;
using Tradeprint.Model.Payload;

namespace Tradeprint.Requests.Orders
{
    public class UploadReplaceArtwokRequest : Request
    {
        private readonly UploadReplaceArtwokPayload payload;

        public UploadReplaceArtwokRequest(IRequestHandler requestHandler, string orderReference, string itemReference) 
            : base(requestHandler, $"orders/{orderReference}/orderItems/{itemReference}/fileUrls", HttpMethod.Put)
        {
            payload = new UploadReplaceArtwokPayload();
        }

        public override ApiPayload Payload => this.payload;

        public UploadReplaceArtwokRequest AddFileUrl(string fileUrl)
        {
            payload.fileUrls.Add(fileUrl);

            return this;
        }
    }
}
