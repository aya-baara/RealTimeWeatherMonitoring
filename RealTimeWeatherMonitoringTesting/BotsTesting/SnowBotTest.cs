using AutoFixture;
using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoringTesting.BotsTesting;
public class SnowBotTest
{
    [Theory]
    [InlineData(-3, true)]
    [InlineData(30, false)]
    public void IsSatisfySunBotCondition_ReturnsExpectedResult_BasedOnTemperature(int weatherTemperature, bool expected)
    {
        var fixture = new Fixture();

        BotConfig botConfig = fixture.Build<BotConfig>().With(b => b.Threshold, 2).Create();
        TestableSnowBot sunBot = new TestableSnowBot(botConfig);

        WeatherData weather = fixture.Build<WeatherData>().With(b => b.Temperature, weatherTemperature).Create();
        bool IsSatisfying = sunBot.CallIsSatisfyBotCondition(weather);

        Assert.Equal(expected, IsSatisfying);

    }
}

