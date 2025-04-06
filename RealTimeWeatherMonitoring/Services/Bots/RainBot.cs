using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Services.Bots;
class RainBot : WeatherBot
{
    public RainBot() : base() { }

    public RainBot(BotConfig botConfig) : base(botConfig) { }

    protected override bool IsSatisfyBotCondition(WeatherData weatherData)
    {
        return weatherData.Humidity > _botConfig.Threshold;
    }
  
}

