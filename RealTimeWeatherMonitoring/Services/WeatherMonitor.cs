using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Services.Bots;

namespace RealTimeWeatherMonitoring.Services;
class WeatherMonitor : IWeatherMonitor
{
    private List<IWeatherBot> _weatherBots = new List<IWeatherBot>();
    private WeatherData _currentWeatherData;
    private WeatherData CurrentWeatherData
    {
        set
        {
            _currentWeatherData = value;
            Notify();
        }
    }

    public WeatherMonitor(BotsConfig botsConfig)
    {
        _weatherBots = (List<IWeatherBot>)botsConfig.WeatherBots;

    }
    public void Attach(IWeatherBot bot)
    {
        _weatherBots.Add(bot);
    }

    public void Detach(IWeatherBot bot)
    {
        _weatherBots.Remove(bot);
    }
    
    public void Notify( )
    {
        foreach (var bot in _weatherBots)
        {
            BotResponseHandler.HandleBotResponse(bot.Update(_currentWeatherData));
        }
    }

    public void UpdateWeather(WeatherData weatherData)
    {
        CurrentWeatherData = weatherData;
   
    }
}

