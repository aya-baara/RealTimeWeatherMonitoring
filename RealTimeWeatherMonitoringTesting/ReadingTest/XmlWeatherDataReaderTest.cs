using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Services.WeatherReader;
using System.Reflection.PortableExecutable;
using System.Xml;

namespace RealTimeWeatherMonitoringTesting.ReadingTest;

public class XmlWeatherDataReaderTest
{
    private readonly XmlWeatherDataReader reader;

    public XmlWeatherDataReaderTest()
    {
        reader = new XmlWeatherDataReader();
    }
    [Fact]
    public void Read_ValidXml_ReturnsCorrectWeatherData()
    {
        var xml = @"<Weather>
                <Location>Palestine</Location>
                <Temperature>35.5</Temperature>
                <Humidity>70</Humidity>
                </Weather>";
        
        WeatherData result = reader.Read(xml);

        Assert.NotNull(result);
        Assert.Equal("Palestine", result.Location);
        Assert.Equal(35.5, result.Temperature);
        Assert.Equal(70, result.Humidity);
    }

    [Fact]
    public void Read_NotValidXml_ThrowsXmlException()
    {
        Assert.Throws<InvalidOperationException>(() => reader.Read("not a xml"));
    }
}

