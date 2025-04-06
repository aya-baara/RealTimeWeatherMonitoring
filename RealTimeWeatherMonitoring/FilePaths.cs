using Microsoft.Extensions.Configuration;

namespace RealTimeWeatherMonitoring;
    class FilePaths
    {
        public static string ConfigFilePath { get; private set; }

        public static void LoadConfiguration()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            ConfigFilePath = configuration["FilePaths:ConfigFilePath"];
        }
    }


