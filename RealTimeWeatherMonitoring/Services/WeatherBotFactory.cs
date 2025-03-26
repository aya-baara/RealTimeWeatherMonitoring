using RealTimeWeatherMonitoring.Services.Bots;

namespace RealTimeWeatherMonitoring.Services;
class WeatherBotFactory
{
    public static BotsConfig CreateBotsConfig(string filePath)
    {
        var botConfigData = ConfigReader.ReadBotsConfig(filePath);

        return new BotsConfig(botConfigData);
    }
}

