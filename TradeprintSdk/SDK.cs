using Tradeprint.Environments;
using Tradeprint.Services;

namespace Tradeprint
{
    public class SDK
    {
        private static SDK instance;

        public static SDK GetInstance()
        {
            if (instance == null) instance = new SDK();

            return instance;
        }

        private SDK()
        {
            this.OrderService = OrderService.GetInstance();
            this.ProductService = ProductService.GetInstance();
        }

        public OrderService OrderService { get; }

        public ProductService ProductService { get; }

        public void SetEnvironment(EnvironmentName environmentName)
        {
            Config.Environemnt = ApiEnvironment.GetEnvironment(environmentName);
        }

        public void SetCredentials(string username, string password)
        {
            Config.Username = username;
            Config.Password = password;
        }

        public void SetDebugging(bool debug)
        {
            Config.Debugging = debug;
        }
    }
}
