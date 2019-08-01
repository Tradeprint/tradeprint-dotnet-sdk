using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Tradeprint;
using Tradeprint.Environments;
using Tradeprint.Errors;
using Tradeprint.Handlers;
using Tradeprint.Model;

namespace TradeprintSdk.Tests.Handlers
{
    [TestClass]
    public class RequestHandlerTests
    {
        private RequestHandler subject;

        [TestInitialize]
        public void Initialize()
        {
            var authHandler = new Mock<IAuthHandler>();

            var fakeAuthDetails = new AuthDetails
            {
                Token = "SAMPLE_TOKEN",
                Timestamp = DateTime.Now
            };

            authHandler.Setup(ah => ah.Handle(It.IsAny<AuthDetails>(), It.IsAny<HttpClient>()))
                .Returns(Task.FromResult(fakeAuthDetails));

            subject = RequestHandler.GetInstance(authHandler.Object);
            
            var sdk = SDK.GetInstance();
            sdk.SetEnvironment(EnvironmentName.Sandbox);
        }

        [TestMethod]
        public async Task HandlerRequestSuccess()
        {
            // ARRANGE
            var httpMessageHandlerMock = new Mock<HttpMessageHandler>(MockBehavior.Loose);

            var response = "{\"success\":true,\"result\":{\"all\":\"good\"}}";

            TestUtils.GetProtectedHttpResponseMessageMock(httpMessageHandlerMock)
               .ReturnsAsync(new HttpResponseMessage()
               {
                   StatusCode = HttpStatusCode.OK,
                   Content = new StringContent(response),
               })
               .Verifiable();

            var httpClient = TestUtils.GetMockedClient(httpMessageHandlerMock);

            // ACT
            var result = await subject.Handle(new TestRequest(subject), httpClient);

            // ASSERT
            result.Success.Should().Be(true);
        }

        [TestMethod]
        public void HandlerRequestFail()
        {
            // ARRANGE
            var httpMessageHandlerMock = new Mock<HttpMessageHandler>(MockBehavior.Loose);

            var response = "{\"success\":false}";

            TestUtils.GetProtectedHttpResponseMessageMock(httpMessageHandlerMock)
               .ReturnsAsync(new HttpResponseMessage()
               {
                   StatusCode = HttpStatusCode.OK,
                   Content = new StringContent(response),
               })
               .Verifiable();

            var httpClient = TestUtils.GetMockedClient(httpMessageHandlerMock);

            // ACT
            Func<Task> funcWrapper = async () => {
                await subject.Handle(new TestRequest(subject), httpClient);
            };

            // ASSERT
            funcWrapper.Should().Throw<SdkRequestError>();
        }
    }
}
