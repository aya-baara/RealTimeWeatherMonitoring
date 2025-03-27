using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Services.Bots;

namespace RealTimeWeatherMonitoring.Services;
class WeatherBotFactory
{
    public static IWeatherBot CreateBot(WeatherBots botType, BotConfig config)
    {
        switch (botType)
        {
            case WeatherBots.RainBot:
                return new RainBot(config);
            case WeatherBots.SnowBot:
                return new SnowBot(config);
            case WeatherBots.SunBot:
                return new SunBot(config);
            default:
                throw new ArgumentException($"Unknown bot type: {botType}");
        }
    }
    public static List<IWeatherBot> GetBotConfigList(Dictionary<WeatherBots, BotConfig> botsConfig)
    {
        var bots = new List<IWeatherBot>();

        if (botsConfig.TryGetValue(WeatherBots.RainBot, out var rainConfig))
            bots.Add(CreateBot(WeatherBots.RainBot, rainConfig));
        else
            throw new ArgumentException("Missing configuration for RainBot.");

        if (botsConfig.TryGetValue(WeatherBots.SnowBot, out var snowConfig))
            bots.Add(CreateBot(WeatherBots.SnowBot, snowConfig));
        else
            throw new ArgumentException("Missing configuration for SnowBot.");

        if (botsConfig.TryGetValue(WeatherBots.SunBot, out var sunConfig))
            bots.Add(CreateBot(WeatherBots.SunBot, sunConfig));
        else
            throw new ArgumentException("Missing configuration for SunBot.");

        return bots;
    }


}

