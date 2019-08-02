using System.Threading.Tasks;
using Tradeprint;
using Tradeprint.Model;

namespace Samples
{
    /**
     * Tradeprint API - Upload or Replace Artwork
     * https://docs.sandbox.tradeprint.io/?version=latest#03d1f33a-53d2-43f0-b45a-8b44f600a270
     */
    static class UploadReplaceArtworkSample
    {
        public async static Task<SdkResult> CallRequest(SDK sdk)
        {
            return await sdk.OrderService
                .UploadReplaceArtwork("ORDER_REFENCE", "ITEM_REFERENCE")
                .AddFileUrl(TestData.TEST_FILE_URL)
                .Call();
        }
    }
}
