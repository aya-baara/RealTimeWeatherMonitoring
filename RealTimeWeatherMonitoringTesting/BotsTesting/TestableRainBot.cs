using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Services.Bots;

namespace RealTimeWeatherMonitoringTesting.BotsTesting;
public class TestableRainBot : RainBot
{
    public TestableRainBot(BotConfig botConfig) : base(botConfig) { }

    public bool CallIsSatisfyBotCondition(WeatherData weatherData)
    {
        return base.IsSatisfyBotCondition(weatherData);
    }
}
