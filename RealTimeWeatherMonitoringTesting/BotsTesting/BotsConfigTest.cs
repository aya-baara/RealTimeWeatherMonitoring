using RealTimeWeatherMonitoring.Services.Bots; 
using RealTimeWeatherMonitoring;
using AutoFixture;
using RealTimeWeatherMonitoring.Models;
namespace RealTimeWeatherMonitoringTesting.BotsTesting;
public class BotsConfigTest
{
    [Fact]
    public void Constructor_ShouldInitializeWeatherBots_FromConfigFile()
    {
        var fixture = new Fixture();

        var sampleConfig = new Dictionary<WeatherBots, BotConfig>
        {
            {WeatherBots.SunBot, fixture.Create<BotConfig>() },
            { WeatherBots.RainBot, fixture.Create<BotConfig>() },
            { WeatherBots.SnowBot, fixture.Create<BotConfig>() }
        };

        var bots = new BotsConfig(sampleConfig);

        Assert.NotNull(bots.WeatherBots);
        Assert.NotEmpty(bots.WeatherBots);
    }

}

