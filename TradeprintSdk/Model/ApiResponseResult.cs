using System.Collections.Generic;

namespace Tradeprint.Model
{
    public class ApiResponseResult
    {
        public string message { get; set; }
        public string url { get; set; }
        public bool? productsAvailable { get; set; }
        public string token { get; set; }
        public string tpCustomerId { get; set; }
        public string expiresIn { get; set; }
        public string orderReference { get; set; }
        public string dateCreated { get; set; }
        public string status { get; set; }
        public string deduplicationHash { get; set; }
        public ApiPayment payment { get; set; }
        public ApiTpOrderDetails tpOrderDetails { get; set; }
        public List<ApiResponseOrderItem> orderItems { get; set; }
        public bool? hasError { get; set; }
        public dynamic errorDetails { get; set; }
        public string timestamp { get; set; }
        public string formattedDate { get; set; }

        // To handle sumit/validate responses
        public ApiResponseResult order { get; set; }

        // Helper property to handle result as array
        public List<ApiResponseResult> OrdersForReferences { get; set; }

        // Helper property to handle result as dictionary
        public Dictionary<string, ProductProperty> ProductAttributes { get; set; }

        // Helper property to handle result as a number dictionary
        public List<int> Quantities { get; set; }
    }
}
