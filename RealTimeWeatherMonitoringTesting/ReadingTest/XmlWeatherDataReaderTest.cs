using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Services.WeatherReader;

namespace RealTimeWeatherMonitoringTesting.ReadingTest;

public class XmlWeatherDataReaderTest
{
    [Fact]
    public void Read_ValidJson_ReturnsCorrectWeatherData()
    {
        var xml = @"<Weather>
                <Location>Palestine</Location>
                <Temperature>35.5</Temperature>
                <Humidity>70</Humidity>
                </Weather>";

        var reader = new XmlWeatherDataReader();

        WeatherData result = reader.Read(xml);


        Assert.NotNull(result);
        Assert.Equal("Palestine", result.Location);
        Assert.Equal(35.5, result.Temperature);
        Assert.Equal(70, result.Humidity);
    }
}

