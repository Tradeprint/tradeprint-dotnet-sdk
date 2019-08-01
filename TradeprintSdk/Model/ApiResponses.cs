using System.Collections.Generic;

namespace Tradeprint.Model
{
    // This is essantially an adapter pattern for varying inputs in the JSON

    public abstract class ApiResponse
    {
        public bool success { get; set; }
        public string errorMessage { get; set; }
        public object errorDetails { get; set; }
        public abstract ApiResponseResult ResultObject { get; }
    }

    public class ApiObjectResponse : ApiResponse
    {
        public ApiResponseResult result { get; set; }

        public override ApiResponseResult ResultObject => result;
    }

    public class ApiArrayResponse : ApiResponse
    {
        public List<ApiResponseResult> result { get; set; }

        public override ApiResponseResult ResultObject
        {
            get
            {
                var transformedApiResult = new ApiResponseResult();
                transformedApiResult.OrdersForReferences = new List<ApiResponseResult>();

                result.ForEach(ri =>
                {
                    transformedApiResult.OrdersForReferences.Add(ri);
                });

                return transformedApiResult;
            }
        }
    }

    public class ApiNumberArrayResponse : ApiResponse
    {
        public List<int> result { get; set; }

        public override ApiResponseResult ResultObject
        {
            get
            {
                var transformedApiResult = new ApiResponseResult();
                transformedApiResult.Quantities = new List<int>();

                result.ForEach(ri =>
                {
                    transformedApiResult.Quantities.Add(ri);
                });

                return transformedApiResult;
            }
        }
    }

    public class ApiDictionaryResponse : ApiResponse
    {
        public Dictionary<string, ProductProperty> result { get; set; }

        public override ApiResponseResult ResultObject
        {
            get
            {
                var transformedApiResult = new ApiResponseResult();

                transformedApiResult.ProductAttributes = result;

                return transformedApiResult;
            }
        }
    }

    public class ProductProperty
    {
        public ProductValues values { get; set; }
    }

    public class ProductValues
    {
        public string productKey { get; set; }
        public dynamic attributes { get; set; }
    }
}
