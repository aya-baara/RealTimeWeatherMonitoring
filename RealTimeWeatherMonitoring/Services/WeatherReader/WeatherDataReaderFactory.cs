using RealTimeWeatherMonitoring.Interfaces;

namespace RealTimeWeatherMonitoring.Services.WeatherReader;
class WeatherDataReaderFactory
{
    public static IWeatherDataReader GetReader(string wethearDataInput)
    {
        if (wethearDataInput.StartsWith("{"))
            return new JsonWeatherDataReader();

        if (wethearDataInput.StartsWith("<"))
            return new XmlWeatherDataReader();

        throw new Exception("Unsupported weather data format.");

    }
}
