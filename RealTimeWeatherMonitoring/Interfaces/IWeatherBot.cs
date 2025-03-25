using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Interfaces;
interface IWeatherBot
{
    public (bool, string) Update(WeatherData weatherData);
}

