using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Interfaces;
interface IWeatherDataReader
{
    public WeatherData Read(string weatherData);
}

