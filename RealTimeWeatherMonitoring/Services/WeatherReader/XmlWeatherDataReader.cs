using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;
using System.Xml.Serialization;

namespace RealTimeWeatherMonitoring.Services.WeatherReader;
class XmlWeatherDataReader : IWeatherDataReader
{
    public WeatherData Read(string xmlWeatherData)
    {
        var serializer = new XmlSerializer(typeof(WeatherData), new XmlRootAttribute("Weather"));
        using StringReader reader = new StringReader(xmlWeatherData);
        return (WeatherData)serializer.Deserialize(reader);
    }
}

