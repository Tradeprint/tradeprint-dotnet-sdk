namespace Tradeprint.Errors
{
    public class SdkLoginError : SdkError
    {
        public SdkLoginError(string errMsg, string errDetails)
            : base("Authentication", errMsg, errDetails)
        {
        }
    }
}
