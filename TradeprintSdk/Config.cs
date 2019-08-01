using Tradeprint.Environments;

namespace Tradeprint
{
    static class Config
    {
        public static ApiEnvironment Environemnt { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static bool Debugging { get; set; }
    }
}
