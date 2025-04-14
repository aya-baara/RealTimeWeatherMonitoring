using AutoFixture;
using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoringTesting.BotsTesting
{
    public class RainBotTest
    {
        private readonly Fixture fixture;

        RainBotTest()
        {
            fixture = new Fixture();
        }

        [Theory]
        [InlineData(50, true)]
        [InlineData(30, false)]
        public void IsSatisfyRainBotCondition_ReturnsExpectedResult_BasedOnHumidity(int weatherHumidity, bool expected)
        {
            BotConfig botConfig = fixture.Build<BotConfig>().With(b => b.Threshold, 40).Create();
            TestableRainBot rainBot = new TestableRainBot(botConfig);

            WeatherData weather = fixture.Build<WeatherData>().With(b => b.Humidity, weatherHumidity).Create();
            bool isSatisfying = rainBot.CallIsSatisfyBotCondition(weather);

            Assert.Equal(expected, isSatisfying);
        }

        [Theory]
        [InlineData(true, true,40)]
        [InlineData(false, false,40)]
        public void UpdateTest_BasedOnBotEnable(bool enabled, bool expected, int threshold)
        {
            BotConfig botConfig = fixture.Build<BotConfig>().With(b => b.Enabled, enabled).With(b => b.Threshold, threshold).Create();
            TestableRainBot rainBot = new TestableRainBot(botConfig);

            WeatherData weather = fixture.Build<WeatherData>().With(b => b.Humidity, 50).Create();

            var response = rainBot.Update(weather);
            Assert.Equal(expected, response.IsActivated);

        }
    }

}