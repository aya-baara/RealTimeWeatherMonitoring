using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Services.Bots;
class SnowBot : IWeatherBot
{
    private BotConfig _botConfig;

    public SnowBot() { }

    public SnowBot(BotConfig botConfig)
    {
        _botConfig = botConfig;
    }

    public BotResponse Update(WeatherData weatherData)
    {
        if (_botConfig.Enabled && weatherData.Temperature < _botConfig.Threshold)
        {
            return new BotResponse() { IsActivated = true, Message = _botConfig.Message };
        }
        return new BotResponse() { IsActivated = false, Message = "" };
    }
}

