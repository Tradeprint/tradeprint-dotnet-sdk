namespace Tradeprint.Errors
{
    public class SdkRequestError : SdkError
    {
        public SdkRequestError(string errMsg, string errDetails)
            : base("Request", errMsg, errDetails)
        {
        }
    }
}
