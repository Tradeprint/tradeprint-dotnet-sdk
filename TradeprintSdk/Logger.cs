using NLog;

namespace Tradeprint
{
    public class Logger
    {
        private NLog.Logger logger;

        public Logger()
        {
            var config = new NLog.Config.LoggingConfiguration();

            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");
     
            config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
    
            NLog.LogManager.Configuration = config;

            logger = NLog.LogManager.GetCurrentClassLogger();
        }

        public void debug(string msg)
        {
            if (Config.Debugging)
            {
                logger.Info(msg);
            }
        }

        public void error(string msg)
        {
            logger.Error(msg);
        }
    }
}
