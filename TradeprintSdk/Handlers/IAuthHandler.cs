using System.Net.Http;
using System.Threading.Tasks;
using Tradeprint.Model;

namespace Tradeprint.Handlers
{
    public interface IAuthHandler
    {
        Task<AuthDetails> Handle(AuthDetails currentDetails, HttpClient httpClient);
    }
}
