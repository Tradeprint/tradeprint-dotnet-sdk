using System;
using System.Collections.Generic;
using Tradeprint.Handlers;

namespace Tradeprint.Requests.Products
{
    public class PriceListsMultipleProductsRequest : PriceListProductRequest
    {
        public PriceListsMultipleProductsRequest(IRequestHandler requestHandler) 
            : base(requestHandler, "products")
        {
        }

        public PriceListsMultipleProductsRequest SetEmailAddress(string email)
        {
            payload.email = email;

            return this;
        }

        public PriceListsMultipleProductsRequest AddProductName(string productName)
        {
            if (payload.productNames == null) payload.productNames = new List<string>();

            payload.productNames.Add(productName);

            return this;
        }
    }
}
