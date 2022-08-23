using Config.Net;
using System.ComponentModel;

namespace Great.Services
{
    internal static class ConfigWrapper
    {
        public static IServiceConfig Config { get; private set; }

        internal static void Configure()
        {
            Config = new ConfigurationBuilder<IServiceConfig>()
                .UseCommandLineArgs()
                .UseIniFile($"{Service.ServiceName}.config")
                .Build();

            WriteConfigValuesToLog();

        }

        internal static void WriteConfigValuesToLog()
        {
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(Config))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(Config);
                LogWrapper.Log.Debug("Config Value | {0}={1}", name, value);
            }
        }

    }
}
