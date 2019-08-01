namespace Tradeprint.Environments
{
    public class Sandbox: ApiEnvironment
    {
        public override EnvironmentName EnvironmentName
        {
            get
            {
                return EnvironmentName.Sandbox;
            }
        }

        protected override string Host
        {
            get
            {
                return "sandbox.orders.tradeprint.io";
            }
        }
    }
}
