using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Tradeprint;
using Tradeprint.Environments;
using Tradeprint.Handlers;
using Tradeprint.Model;
using TradeprintSdk.Tests;

namespace TradeprintSdkTests
{
    [TestClass]
    public class AuthHandlerTests
    {
        private AuthHandler subject;

        [TestInitialize]
        public void Initialize()
        {
            var sdk = SDK.GetInstance();

            sdk.SetEnvironment(EnvironmentName.Sandbox);
            sdk.SetCredentials("API_USERNAME", "API_PASSWORD");

            subject = new AuthHandler(TimeSpan.FromSeconds(5));
        }

        [TestMethod]
        public async Task AuthHandlerReturnsSameDetails()
        {
            // ARRANGE
            var httpMessageHandlerMock = new Mock<HttpMessageHandler>(MockBehavior.Strict);

            TestUtils.GetProtectedHttpResponseMessageMock(httpMessageHandlerMock)
               .Verifiable();

            var httpClient = TestUtils.GetMockedClient(httpMessageHandlerMock);

            var currentTimeStamp = DateTime.Now;
            var existingAuthDetails = new AuthDetails { Token = "OLD_TOKEN", Timestamp = currentTimeStamp };

            // ACT
            var result = await subject.Handle(existingAuthDetails, httpClient);

            // ASSERT
            result.Token.Should().Be("OLD_TOKEN");
            result.Timestamp.Should().Be(currentTimeStamp);

            httpMessageHandlerMock.Invocations.Should().HaveCount(0);
        }

        [TestMethod]
        public async Task AuthHandlerReturnsNewDetails()
        {
            // ARRANGE
            var httpMessageHandlerMock = new Mock<HttpMessageHandler>(MockBehavior.Strict);

            var response = "{\"success\":true,\"result\":{\"token\":\"SAMPLE_TOKEN\",\"tpCustomerId\":\"SAMPLE_ID\",\"expiresIn\":\"8h\"}}";

            TestUtils.GetProtectedHttpResponseMessageMock(httpMessageHandlerMock)
               .ReturnsAsync(new HttpResponseMessage()
               {
                   StatusCode = HttpStatusCode.OK,
                   Content = new StringContent(response),
               })
               .Verifiable();

            var httpClient = TestUtils.GetMockedClient(httpMessageHandlerMock);

            // ACT
            var result = await subject.Handle(null, httpClient);

            // ASSERT
            result.Token.Should().Be("SAMPLE_TOKEN");
            result.Timestamp.Should().HaveValue();

            httpMessageHandlerMock.Invocations.Should().HaveCount(1);
        }

        [TestMethod]
        public async Task AuthHandlerReloginsDueToTimeout()
        {
            // ARRANGE
            var httpMessageHandlerMock = new Mock<HttpMessageHandler>(MockBehavior.Strict);

            var response = "{\"success\":true,\"result\":{\"token\":\"FRESH_SAMPLE_TOKEN\",\"tpCustomerId\":\"SAMPLE_ID\",\"expiresIn\":\"8h\"}}";

            TestUtils.GetProtectedHttpResponseMessageMock(httpMessageHandlerMock)
               .ReturnsAsync(new HttpResponseMessage()
               {
                   StatusCode = HttpStatusCode.OK,
                   Content = new StringContent(response),
               })
               .Verifiable();

            var httpClient = TestUtils.GetMockedClient(httpMessageHandlerMock);

            var currentTimeStamp = DateTime.Now;
            var existingAuthDetails = new AuthDetails { Token = "OLD_TOKEN", Timestamp = currentTimeStamp.AddSeconds(-10) };

            // ACT
            var result = await subject.Handle(existingAuthDetails, httpClient);

            // ASSERT
            result.Token.Should().Be("FRESH_SAMPLE_TOKEN");
            result.Timestamp.Should().HaveValue();

            httpMessageHandlerMock.Invocations.Should().HaveCount(1);
        }
    }
}
