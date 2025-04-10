using RealTimeWeatherMonitoring.Services.WeatherReader;
namespace RealTimeWeatherMonitoringTesting.ReadingTest;
public class WeatherDataReaderFactoryTest
{
    [Fact]
    public void GetReader_ReturnsJsonReader_WhenInputStartsWithCurlyBrace()
    {
        var reader = WeatherDataReaderFactory.GetReader("{ \"Temperature\": 25, \"Humidity\": 50 }");
        Assert.IsType<JsonWeatherDataReader>(reader);
    }

    [Fact]
    public void GetReader_ReturnsXmlReader_WhenInputStartsWithAngle()
    {
        var reader = WeatherDataReaderFactory.GetReader("<Weather><Temperature>25</Temperature><Humidity>50</Humidity></Weather>");
        Assert.IsType<XmlWeatherDataReader>(reader);
    }

    [Fact]
    public void GetReader_ThrowExeption_WhenInputDoesNotStartWithJsonOrXmlFormat()
    {
        Assert.Throws<Exception>(() => WeatherDataReaderFactory.GetReader("[ ]"));
    }



}

