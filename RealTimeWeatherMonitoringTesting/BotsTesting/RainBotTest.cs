using AutoFixture;
using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Services.Bots;

namespace RealTimeWeatherMonitoringTesting.BotsTesting
{
    public class RainBotTest
    {
        [Theory]
        [InlineData (50 , true)]
        [InlineData( 30, false)]
        public void IsSatisfyRainBotCondition_ReturnsExpectedResult_BasedOnHumidity( int weatherHumidity, bool expected)
        {
            var fixture = new Fixture();

            BotConfig botConfig = fixture.Build<BotConfig>().With(b => b.Threshold , 40).Create();
            TestableRainBot rainBot = new TestableRainBot(botConfig);

            WeatherData weather = fixture.Build<WeatherData>().With(b => b.Humidity, weatherHumidity).Create();
            bool IsSatisfying = rainBot.CallIsSatisfyBotCondition(weather);

            Assert.Equal( expected, IsSatisfying);

        }
    }
}