using Moq;
using Moq.Language.Flow;
using Moq.Protected;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace TradeprintSdk.Tests
{
    class TestUtils
    {
        private static readonly string FAKE_URL = "http://test.com/";

        internal static ISetup<HttpMessageHandler, Task<HttpResponseMessage>> GetProtectedHttpResponseMessageMock(Mock<HttpMessageHandler> mock)
        {
            return mock
                .Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                );
        }

        internal static HttpClient GetMockedClient(Mock<HttpMessageHandler> mockMessageHandler)
        {
            var httpClient = new HttpClient(mockMessageHandler.Object)
            {
                BaseAddress = new Uri(FAKE_URL),
            };

            return httpClient;
        }
    }
}
