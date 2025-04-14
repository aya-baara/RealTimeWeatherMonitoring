using AutoFixture;
using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoringTesting.BotsTesting;
public class SunBotTest
{
    [Theory]
    [InlineData(50, true)]
    [InlineData(30, false)]
    public void IsSatisfySunBotCondition_ReturnsExpectedResult_BasedOnTemperature(int weatherTemperature, bool expected)
    {
        var fixture = new Fixture();

        BotConfig botConfig = fixture.Build<BotConfig>().With(b => b.Threshold, 40).Create();
        TestableSunBot sunBot = new TestableSunBot(botConfig);

        WeatherData weather = fixture.Build<WeatherData>().With(b => b.Temperature, weatherTemperature).Create();
        bool IsSatisfying = sunBot.CallIsSatisfyBotCondition(weather);

        Assert.Equal(expected, IsSatisfying);

    }
}

