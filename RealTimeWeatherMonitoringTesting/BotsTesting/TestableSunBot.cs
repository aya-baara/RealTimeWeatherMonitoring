using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Services.Bots;

namespace RealTimeWeatherMonitoringTesting.BotsTesting;
public class TestableSunBot : SunBot
{
    public TestableSunBot(BotConfig botConfig) : base(botConfig) { }

    public bool CallIsSatisfyBotCondition(WeatherData weatherData)
    {
        return base.IsSatisfyBotCondition(weatherData);
    }
}
