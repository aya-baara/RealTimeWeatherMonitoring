using RealTimeWeatherMonitoring.Services.Bots; 
using RealTimeWeatherMonitoring; 
namespace RealTimeWeatherMonitoringTesting.BotsTesting;
public class BotsConfigTest
{
    [Fact]
    public void Constructor_ShouldInitializeWeatherBots_FromConfigFile()
    {
        FilePaths.LoadConfiguration();
        BotsConfig bots = new BotsConfig();
        Assert.NotNull(bots.WeatherBots);
    }

}

