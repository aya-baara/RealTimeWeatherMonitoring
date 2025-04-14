using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Services.Bots;
public class SnowBot : WeatherBot
{
    public SnowBot() : base() { }

    public SnowBot(BotConfig botConfig) : base(botConfig) { }

    protected override bool IsSatisfyBotCondition(WeatherData weatherData)
    {
        return weatherData.Temperature < _botConfig.Threshold;
    }
}

