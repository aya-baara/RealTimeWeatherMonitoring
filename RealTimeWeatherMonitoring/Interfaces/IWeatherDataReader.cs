using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Interfaces;
public interface IWeatherDataReader
{
    public WeatherData Read(string weatherData);
}

