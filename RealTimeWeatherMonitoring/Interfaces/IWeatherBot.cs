using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Interfaces;
interface IWeatherBot
{
    public BotResponse Update(WeatherData weatherData);
}

