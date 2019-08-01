using System;
using Tradeprint.Handlers;
using Tradeprint.Model.Payload;

namespace Tradeprint.Requests.Products
{
    public class PriceListProductRequest : PostRequest
    {
        protected readonly PriceListProductPayload payload;

        public override ApiPayload Payload => this.payload;

        public PriceListProductRequest(IRequestHandler requestHandler, string endpoint) 
            : base(requestHandler, endpoint)
        {
            payload = new PriceListProductPayload();
        }

        public PriceListProductRequest SetFormatJson()
        {
            payload.format = "json";

            return this;
        }

        public PriceListProductRequest SetFormatCsv()
        {
            payload.format = "csv";

            return this;
        }

        public PriceListProductRequest SetMarkup(int markup)
        {
            payload.markup = markup;

            return this;
        }

        public PriceListProductRequest SetFromDate(DateTime fromDate)
        {
            payload.fromDate = fromDate.ToString("dd/MM/yyyy");

            return this;
        }
    }
}
