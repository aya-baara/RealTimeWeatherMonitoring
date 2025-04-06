using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Services.Bots;
class SunBot : WeatherBot
{
    public SunBot() : base() { }

    public SunBot(BotConfig botConfig) : base(botConfig) { }

    protected override bool IsSatisfyBotCondition(WeatherData weatherData)
    {
        return weatherData.Temperature > _botConfig.Threshold;
    }
}

