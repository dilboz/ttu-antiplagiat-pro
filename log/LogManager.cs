using contracts.LogService;
using Serilog;
using ILogger = Serilog.ILogger;

namespace log
{
    public class LoggerManager : ILoggerManager
    {
        public static readonly ILogger Logger;

        static LoggerManager()
        {
            var logDirectory = Path.Combine(Directory.GetCurrentDirectory(), "logs");
            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(Path.Combine(logDirectory, "log-.txt"), rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }

        public void LogDebug(string message)
        {
            Logger.Debug(message);
        }

        public void LogError(string message)
        {
            Logger.Error(message);
        }

        public void LogInfo(string message)
        {
            Logger.Information(message);
        }

        public void LogWarn(string message)
        {
            Logger.Warning(message);
        }
    }
}