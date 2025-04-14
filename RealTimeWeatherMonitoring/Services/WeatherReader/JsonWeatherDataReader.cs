using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;
using System.Text.Json;

namespace RealTimeWeatherMonitoring.Services.WeatherReader;
public class JsonWeatherDataReader : IWeatherDataReader
{
    public WeatherData Read(string jsonWeatherData)
    {
        return JsonSerializer.Deserialize<WeatherData>(jsonWeatherData);
    }
}

