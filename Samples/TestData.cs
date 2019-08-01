using System.Collections.Generic;
using Tradeprint.Model;

namespace Samples
{
    static class TestData
    {
        public static string TEST_EMAIL = "tradeprint-qa@tradeprint.co.uk";
        public static string TEST_PRODUCT_ID = "PRD-SRJ3LY4F";
        public static string TEST_PRODUCT_ONE = "Flyers";
        public static string TEST_PRODUCT_TWO = "Standard BC";
        public static string TEST_ARTWORK_SERVICE = "Just Print";
        public static string TEST_SERVICE_LEVEL = "Saver";
        public static string TEST_FILE_URL = "https://s3-eu-west-1.amazonaws.com/filestacksupplytest/api-tests/test.pdf";

        public static BillingAddress TEST_BILLING_ADDRESS = new BillingAddress
        {
            firstName = "John",
            lastName = "Smith",
            streetName = "1 Fake Street",
            additionalStreetInfo = "Fake Technology Park",
            postalCode = "DD2 1TP",
            city = "Faketown",
            country = "GB",
            company = "Fake Company Ltd",
            email = TEST_EMAIL,
            phone = "0123456879",
            mobile = "0987654321"
        };

        public static DeliveryAddress TEST_DELIVERY_ADDRESS = new DeliveryAddress
        {
            firstName = "John",
            lastName = "Smith",
            add1 = "1 Fake Street",
            add2 = "Fake Technology Park",
            postcode = "DD2 1TP",
            town = "Faketown",
            country = "GB",
            company = "Fake Company Ltd",
            contactPhone = "0123456879",
            deliveryComments = "SAMPLE_COMMENT"
        };

        public static Dictionary<string, string> TEST_PRODUCTION_DATA = new Dictionary<string, string>
        {
            { "Sides Printed", "Double Sided" },
            { "Paper Type", "100gsm Premium Smooth White Paper" },
            { "Sets", "1" }
        };

        public static ExtraData TEST_EXTRA_DATA = new ExtraData
        {
            comments = "This is the extra data comments",
            partnerItemId = "fakeCompany123",
            merchandisingProductName = "My Special Product",
            referenceLabel = "CUSTOMER_LABEL",
            purchaseOrder = "PURCHASE_ORDER"
        };

        public static PartnerContactDetails TEST_PARTNET_CONTACT_DETAILS = new PartnerContactDetails
        {
            firstName = "John",
            lastName = "Smith",
            phone = "0123456879",
            email = TEST_EMAIL,
            company = "Fake Company Ltd"
        };
    }
}
