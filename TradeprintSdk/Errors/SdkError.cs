using System;

namespace Tradeprint.Errors
{
    public abstract class SdkError: Exception
    {
        public string ErrorDetails { get; }

        public SdkError(string exType, string errMsg, string errDetails)
            : base($"Tradeprint SDK {exType} Exception: {errMsg}")
        {
            this.ErrorDetails = errDetails;
        }
    }
}
