using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Interfaces;
interface IWeatherDataReader
{
    public WeatherData ReadWeatherData(string weatherData);
}

