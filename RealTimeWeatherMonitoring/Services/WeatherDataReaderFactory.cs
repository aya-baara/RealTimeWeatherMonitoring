using RealTimeWeatherMonitoring.Interfaces;

namespace RealTimeWeatherMonitoring.Services;
class WeatherDataReaderFactory
{
    public static IWeatherDataReader GetReader(string s)
    {
        if (s.StartsWith("{"))
        {
            return new JsonWeatherDataReader();

        }
        else if (s.StartsWith("<"))
        {
            return new XmlWeatherDataReader();
        }
        else
        {
            throw new Exception("Unsupported weather data format.");
        }
    }
}
