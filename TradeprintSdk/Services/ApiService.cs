using Tradeprint.Handlers;

namespace Tradeprint.Services
{
    public abstract class ApiService
    {
        protected ApiService()
        {
            this.RequestHandler = RequestHandler.GetInstance();
        }

        protected RequestHandler RequestHandler { get; }
    }
}
