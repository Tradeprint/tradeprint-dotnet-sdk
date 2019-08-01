using System.Net.Http;
using Tradeprint.Handlers;

namespace Tradeprint.Requests
{
    public abstract class PostRequest : Request
    {
        public PostRequest(IRequestHandler requestHandler, string endpoint) 
            : base(requestHandler, endpoint, HttpMethod.Post)
        {
        }
    }
}
