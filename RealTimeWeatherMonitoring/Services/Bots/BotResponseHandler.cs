namespace RealTimeWeatherMonitoring.Services.Bots;
class BotResponseHandler
{
    public static void HandleBotResponse((bool, string) response)
    {
        if (response.Item1)
        {
            Console.WriteLine(response.Item2);
        }
    }
}

