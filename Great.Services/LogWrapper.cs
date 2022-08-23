using NLog;

namespace Great.Services
{
    internal static class LogWrapper
    {
        public static ILogger Log { get; private set; }

        internal static void Configure()
        {
            Log = LogManager.GetLogger(Service.ServiceName);
        }

    }
}
