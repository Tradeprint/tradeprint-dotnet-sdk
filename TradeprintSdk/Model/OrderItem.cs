using System.Collections.Generic;

namespace Tradeprint.Model
{
    public class OrderItem
    {
        public List<string> fileUrls { get; set; } = new List<string>();
        public string productId { get; set; }
        public string serviceLevel { get; set; }
        public string artworkService { get; set; }
        public int quantity { get; set; }
        public Dictionary<string, string> productionData { get; set; }
        public DeliveryAddress deliveryAddress { get; set; }
        public PartnerContactDetails partnerContactDetails { get; set; }
        public ExtraData extraData { get; set; }

        public OrderItem AddFileUrl(string url)
        {
            fileUrls.Add(url);

            return this;
        }

        public OrderItem SetArtworkService(string artworkService)
        {
            this.artworkService = artworkService;

            return this;
        }

        public OrderItem SetServiceLevel(string serviceLevel)
        {
            this.serviceLevel = serviceLevel;

            return this;
        }

        public OrderItem SetProductId(string productId)
        {
            this.productId = productId;

            return this;
        }

        public OrderItem SetQuantity(int quantity)
        {
            this.quantity = quantity;

            return this;
        }

        public OrderItem SetProductionData(Dictionary<string, string> productionData)
        {
            this.productionData = productionData;

            return this;
        }

        public OrderItem SetDeliveryAddress(DeliveryAddress deliveryAddress)
        {
            this.deliveryAddress = deliveryAddress;

            return this;
        }

        public OrderItem SetPartnerContactDetails(PartnerContactDetails partnerContactDetails)
        {
            this.partnerContactDetails = partnerContactDetails;

            return this;
        }

        public OrderItem SetExtraData(ExtraData extraData)
        {
            this.extraData = extraData;

            return this;
        }
    }
}
