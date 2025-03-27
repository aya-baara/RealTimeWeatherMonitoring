using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Services.Bots;
class BotsConfig
{
    public IReadOnlyList<IWeatherBot> WeatherBots { get; private set; }

    public BotsConfig()
    {
        try
        {
            WeatherBots = WeatherBotFactory.GetBotConfigList(ConfigReader.ReadBotsConfig(FilePaths.ConfigFilePath));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }


}

