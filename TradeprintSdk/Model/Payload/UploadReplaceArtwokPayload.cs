using System.Collections.Generic;

namespace Tradeprint.Model.Payload
{
    public class UploadReplaceArtwokPayload : ApiPayload
    {
        public List<string> fileUrls { get; set; } = new List<string>();
    }
}
