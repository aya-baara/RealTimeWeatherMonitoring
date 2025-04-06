using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Services.Bots;
class BotResponseHandler
{
    public static void HandleBotResponse(BotResponse response)
    {
        if (response.IsActivated)
        {
            Console.WriteLine(response.Message);
        }
    }
}

