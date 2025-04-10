using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Services.Bots;

namespace RealTimeWeatherMonitoringTesting.BotsTesting;
public class TestableSnowBot : SnowBot
{
    public TestableSnowBot(BotConfig botConfig) : base(botConfig) { }

    public bool CallIsSatisfyBotCondition(WeatherData weatherData)
    {
        return base.IsSatisfyBotCondition(weatherData);
    }
}