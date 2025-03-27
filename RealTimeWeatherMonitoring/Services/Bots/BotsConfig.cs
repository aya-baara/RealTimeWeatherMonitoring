using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Services.Bots;
class BotsConfig
{
    public IReadOnlyList<IWeatherBot> WeatherBots { get; private set; }

    public BotsConfig() {
        WeatherBots=WeatherBotFactory.GetBotConfigList(ConfigReader.ReadBotsConfig(FilePaths.ConfigFilePath));
    }


}

