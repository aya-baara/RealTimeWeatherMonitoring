using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Services.Bots;

namespace RealTimeWeatherMonitoring.Services;
class WeatherMonitor : IWeatherMonitor
{
    private List<IWeatherBot> _weatherBots = new List<IWeatherBot>();
    public WeatherData CurrentWeatherData { get; private set; }

    public WeatherMonitor(BotsConfig botsConfig)
    {
        _weatherBots.Add(botsConfig.SnowBot);
        _weatherBots.Add(botsConfig.RainBot);
        _weatherBots.Add(botsConfig.SunBot);

    }
    public void Attach(IWeatherBot bot)
    {
        _weatherBots.Add(bot);
    }

    public void Detach(IWeatherBot bot)
    {
        _weatherBots.Remove(bot);
    }

    public void Notify()
    {
        foreach (var bot in _weatherBots)
        {
            bot.Update(CurrentWeatherData);
        }
    }

    public void UpdateWeather(WeatherData weatherData)
    {
        CurrentWeatherData = weatherData;
        Notify();
    }
}

