# Tradeprint .NET SDK Code Samples

## General Usage

Welcome to the code samples repository. All of the sample follow the same initilisation procedure:
```
using Tradeprint;
using Tradeprint.Environments;

namespace ClientApplication
{
    static class SdkClient
    {
        public async static void Main()
        {
            var sdk = SDK.GetInstance();
            sdk.SetEnvironment(EnvironmentName.Sandbox);
            sdk.SetCredentials("YOUR_API_USERNAME", "YOUR_API_PASSWORD");
            sdk.SetDebugging(true);

            var orderService = sdk.OrderService;
            var productService = sdk.ProductService; 
        }
    }
}
```
With those statements in place you can use the `productService` or the `orderService` to get specific `Request` objects and execute them.

You can use the main [Program.cs](Program.cs) entry point in the **Samples** project to test the sample requests individually or to construct call sequences.

When you download the repository make sure you copy the `.env` file template from [EnvTemplate/.env](EnvTemplate/.env) to the top of the **Samples** project directory.
Fill in the values with correct ones obtained from the Tradeprint API team and you are all set to run the code samples using the hanress provided.

## Samples

The samples provided below reflect the calls available in the Tradeprint API (https://docs.sandbox.tradeprint.io).

### Order Service

* [Submit New Order](SubmitNewOrderSample.cs)
* [Validate Order](ValidateOrderSample.cs)
* [Upload or Replace Artwork](UploadReplaceArtworkSample.cs)
* [Get Order Status by ID](GetOrderStatusByIdSample.cs)
* [Fetch Orders by References](FetchOrdersByReferenceSample.cs)
* [Cancel an Order Item](TODO)
* [Retry Payment](TODO)

### Product Service

* [Request Price Lists for Multiple Products](TODO)
* [Request Price List for Single Product](TODO)
* [Get All Products Attributes](TODO)
* [Get Attributes for Specific Product](TODO)
* [Request Product Quantities](TODO)
* [Get Expected Delivery Date](TODO)

## Production Environment

When you are ready to integrate your solution with the production Tradeprint API you can switch out the environment statement to:
```
sdk.SetEnvironment(EnvironmentName.Production);
```
All the requests within your code will now be calling the real ordering systems within Tradeprint.
