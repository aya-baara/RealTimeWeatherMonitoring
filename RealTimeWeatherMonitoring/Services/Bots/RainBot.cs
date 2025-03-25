using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Services.Bots;
class RainBot : IWeatherBot
{
    private BotConfig _BotConfig;

    public RainBot(BotConfig botConfig)
    {
        _BotConfig = botConfig;
    }
    public (bool, string) Update(WeatherData weatherData)
    {
        if (_BotConfig.Enabled && weatherData.Humidity > _BotConfig.Threshold)
        {
            return (true, _BotConfig.Message);
        }
        return (false, "");
    }
}

