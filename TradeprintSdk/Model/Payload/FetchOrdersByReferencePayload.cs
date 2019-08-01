using System.Collections.Generic;

namespace Tradeprint.Model.Payload
{
    public class FetchOrdersByReferencePayload : ApiPayload
    {
        public List<string> orderReferences { get; set; } = new List<string>();
    }
}
