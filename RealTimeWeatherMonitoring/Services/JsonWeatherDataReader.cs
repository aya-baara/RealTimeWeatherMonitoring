using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;
using System.Text.Json;

namespace RealTimeWeatherMonitoring.Services;
class JsonWeatherDataReader : IWeatherDataReader
{
    public WeatherData ReadWeatherData(string jsonWeatherData)
    {
        return JsonSerializer.Deserialize<WeatherData>(jsonWeatherData);
    }
}

