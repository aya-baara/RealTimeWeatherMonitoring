using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Services.Bots;
class BotsConfig
{
    public RainBot RainBot { get; private set; }
    public SnowBot SnowBot { get; private set; }
    public SunBot SunBot { get; private set; }

    public BotsConfig() { }
    public BotsConfig(Dictionary<WeatherBots, BotConfig> botsConfig)
    {
        botsConfig.TryGetValue(WeatherBots.RainBot, out BotConfig rainConfig);
        RainBot = new RainBot(rainConfig!);

        botsConfig.TryGetValue(WeatherBots.RainBot, out BotConfig snowConfig);
        SnowBot = new SnowBot(snowConfig!);

        botsConfig.TryGetValue(WeatherBots.RainBot, out BotConfig sunConfig);
        SunBot = new SunBot(sunConfig!);



    }

}

