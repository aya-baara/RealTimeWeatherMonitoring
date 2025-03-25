using System.Diagnostics.CodeAnalysis;

namespace RealTimeWeatherMonitoring.Models;
public class WeatherData
{
    public required string Location { get; set; }
    public required double Temperature { get; set; }
    public required double Humidity { get; set; }

    [SetsRequiredMembers]
    public WeatherData(string location, double temperature, double humidity)
    {
        Location = location;
        Temperature = temperature;
        Humidity = humidity;
    }

    //XmlSerializer needs a parameterless constructor
    public WeatherData() { }
}

