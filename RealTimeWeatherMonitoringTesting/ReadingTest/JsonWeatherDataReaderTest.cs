using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Services.WeatherReader;
using System.Text.Json;

namespace RealTimeWeatherMonitoringTesting.ReadingTest;
public class JsonWeatherDataReaderTest
{
    private readonly JsonWeatherDataReader reader;

    JsonWeatherDataReaderTest()
    {
        reader = new JsonWeatherDataReader();
    }
    [Fact]
    public void Read_ValidJson_ReturnsCorrectWeatherData()
    {
        var json = @"{
                ""Location"": ""Palestine"",
                ""Temperature"": 35.5,
                ""Humidity"": 70
            }";

        WeatherData result = reader.Read(json);

        Assert.NotNull(result);
        Assert.Equal("Palestine", result.Location);
        Assert.Equal(35.5, result.Temperature);
        Assert.Equal(70, result.Humidity);
    }

    [Fact]
    public void Read_NotValidJson_ReturnsNull()
    {
        Assert.Throws<JsonException>(() => reader.Read("not a json"));
    }
}

