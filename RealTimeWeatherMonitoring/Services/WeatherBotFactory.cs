using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Services.Bots;

namespace RealTimeWeatherMonitoring.Services;
class WeatherBotFactory
{
    public static List<IWeatherBot> GetBotConfigList(Dictionary<WeatherBots, BotConfig> botsConfig)
    {
        var Bots = new List<IWeatherBot>();
        botsConfig.TryGetValue(WeatherBots.RainBot, out BotConfig rainConfig);
        Bots.Add(new RainBot(rainConfig!));

        botsConfig.TryGetValue(WeatherBots.SnowBot, out BotConfig snowConfig);
        Bots.Add(new SnowBot(snowConfig!));

        botsConfig.TryGetValue(WeatherBots.SunBot, out BotConfig sunConfig);
        Bots.Add(new SunBot(sunConfig!));
        return Bots;
    }

}

