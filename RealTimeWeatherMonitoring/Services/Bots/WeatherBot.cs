using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Services.Bots;
 abstract class WeatherBot : IWeatherBot
{
    protected BotConfig _botConfig;

    public WeatherBot() { }

    public WeatherBot(BotConfig botConfig)
    {
        _botConfig = botConfig;
    }

    public BotResponse Update(WeatherData weatherData)
    {
        if (_botConfig.Enabled && IsSatisfyBotCondition(weatherData))
        {
            return new BotResponse() { IsActivated = true, Message = _botConfig.Message };
        }
        return new BotResponse() { IsActivated = false, Message = "" };
    }

    protected abstract bool IsSatisfyBotCondition(WeatherData weatherData);

}

