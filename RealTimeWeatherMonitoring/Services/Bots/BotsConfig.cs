using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Services.Bots;
public class BotsConfig
{
    public IReadOnlyList<IWeatherBot> WeatherBots { get; private set; }

    public BotsConfig(Dictionary<WeatherBots, BotConfig> botsConfig)
    {
        try
        {
            WeatherBots = WeatherBotFactory.GetBotConfigList(botsConfig);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
    public BotsConfig (List<IWeatherBot> weatherBots)
    {
        WeatherBots = weatherBots;
    }


}

