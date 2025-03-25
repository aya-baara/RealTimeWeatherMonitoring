using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Services.Bots;
class SnowBot : IWeatherBot
{
    private BotConfig _botConfig;

    public SnowBot(BotConfig botConfig)
    {
        _botConfig = botConfig;
    }

    public (bool, string) Update(WeatherData weatherData)
    {
        if (_botConfig.Enabled && weatherData.Temperature < _botConfig.Threshold)
        {
            return (true, _botConfig.Message);
        }
        return (false, "");
    }
}

