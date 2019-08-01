namespace Tradeprint.Model
{
    public class SdkResult
    {
        public bool Success { get; set; }
        public string SerializedResult { get; set; }
        public ApiResponseResult Result { get; set; }
    }
}
