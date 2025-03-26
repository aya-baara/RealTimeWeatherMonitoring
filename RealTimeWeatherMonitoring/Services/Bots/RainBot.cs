using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Services.Bots;
class RainBot : IWeatherBot
{
    private BotConfig _botConfig;

    public RainBot() { }

    public RainBot(BotConfig botConfig)
    {
        _botConfig = botConfig;
    }
    public BotResponse Update(WeatherData weatherData)
    {
        if (_botConfig.Enabled && weatherData.Humidity > _botConfig.Threshold)
        {
            return new BotResponse() { IsActivated = true, Message = _botConfig.Message };
        }
        return new BotResponse() { IsActivated = false, Message = "" };
    }
}

