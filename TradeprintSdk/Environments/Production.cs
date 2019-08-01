namespace Tradeprint.Environments
{
    public class Production : ApiEnvironment
    {
        public override EnvironmentName EnvironmentName
        {
            get
            {
                return EnvironmentName.Production;
            }
        }

        protected override string Host
        {
            get
            {
                return "orders.tradeprint.io";
            }
        }
    }
}
