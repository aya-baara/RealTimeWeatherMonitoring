using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Interfaces;
public interface IWeatherBot
{
    public BotResponse Update(WeatherData weatherData);
}

