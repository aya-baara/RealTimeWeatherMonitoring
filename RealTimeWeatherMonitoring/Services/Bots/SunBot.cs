using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Services.Bots;
class SunBot : IWeatherBot
{
    private BotConfig _botConfig;

    public SunBot(BotConfig botConfig)
    {
        _botConfig = botConfig;
    }

    public (bool, string) Update(WeatherData weatherData)
    {
        if (_botConfig.Enabled && weatherData.Temperature > _botConfig.Threshold)
        {
            return (true, _botConfig.Message);
        }
        return (false, "");
    }
}

