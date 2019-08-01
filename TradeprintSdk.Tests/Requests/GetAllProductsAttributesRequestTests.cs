using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;
using Tradeprint.Handlers;
using Tradeprint.Requests;
using Tradeprint.Requests.Products;

namespace TradeprintSdkTests
{
    [TestClass]
    public class GetAllProductsAttributesRequestTests
    {
        [TestMethod]
        public async Task RequestRunsTheHandler()
        {
            // ARRANGE
            var requestHandlerMock = new Mock<IRequestHandler>();
            requestHandlerMock.Setup(m => m.Handle(It.IsAny<Request>(), null));

            var subject = new GetAllProductsAttributesRequest(requestHandlerMock.Object);

            // ACT
            await subject.Call();
            
            // ASSERT
            requestHandlerMock.Verify(m => m.Handle(It.IsAny<Request>(), null), Times.Once());
        }
    }
}
