using System.Net.Http;
using System.Threading.Tasks;
using Tradeprint.Model;
using Tradeprint.Requests;

namespace Tradeprint.Handlers
{
    public interface IRequestHandler
    {
        Task<SdkResult> Handle(Request request, HttpClient httpClient = null);
    }
}
