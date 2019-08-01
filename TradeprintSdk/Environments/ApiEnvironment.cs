using System.Collections.Generic;

namespace Tradeprint.Environments
{
    public abstract class ApiEnvironment
    {
        private const string PROTOCOL = "https";
        private const string VERSION_V2 = "v2";
        private static readonly List<ApiEnvironment> ENVIRONMENTS = new List<ApiEnvironment> { new Sandbox(), new Production() };

        public abstract EnvironmentName EnvironmentName { get; }
        protected abstract string Host { get; }

        public string BaseUrl { get  { return $"{PROTOCOL}://{this.Host}/{VERSION_V2}"; } }

        public static ApiEnvironment GetEnvironment(EnvironmentName name)
        {
            return ENVIRONMENTS.Find(e => e.EnvironmentName == name);
        }
    }

    public enum EnvironmentName
    {
        Sandbox,
        Production
    }
}
