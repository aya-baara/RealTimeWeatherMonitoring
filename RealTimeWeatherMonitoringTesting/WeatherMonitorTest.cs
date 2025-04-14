using AutoFixture;
using Moq;
using RealTimeWeatherMonitoring;
using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Services;
using RealTimeWeatherMonitoring.Services.Bots;

namespace RealTimeWeatherMonitoringTesting;

public class WeatherMonitorTest
{
    [Fact]
    public void UpdateWeather_ShouldNotifyAllBots()
    {
        var fixture = new Fixture();
        var botMock1 = new Mock<IWeatherBot>();
        var botMock2 = new Mock<IWeatherBot>();

        botMock1.Setup(bot => bot.Update(It.IsAny<WeatherData>())).Returns(fixture.Create<BotResponse>());
        botMock2.Setup(bot => bot.Update(It.IsAny<WeatherData>())).Returns(fixture.Create<BotResponse>());

        var bots = new List<IWeatherBot> {
        botMock1.Object,
        botMock2.Object,
        };

        var config = new BotsConfig(bots);
        var monitor = new WeatherMonitor(config);

        monitor.UpdateWeather(fixture.Create<WeatherData>());

        //Assert.
        foreach (var botMock in new List<Mock<IWeatherBot>> { botMock1, botMock2 })
        {
            botMock.Verify(bot => bot.Update(It.IsAny<WeatherData>()), Times.Once);
        }
    }
}

