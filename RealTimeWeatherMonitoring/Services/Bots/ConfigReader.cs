using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;
using System.Text.Json;

namespace RealTimeWeatherMonitoring.Services.Bots;

class ConfigReader
{
    public static  Dictionary<WeatherBots, BotConfig> ReadBotsConfig(string filePath)
    {
        var result = new Dictionary<WeatherBots, BotConfig>();

        try
        {
            var json = File.ReadAllText(filePath);
            var Configs = JsonSerializer.Deserialize<Dictionary<string, BotConfig>>(json);

            foreach (var c in Configs)
            {
                if (Enum.TryParse(c.Key, out WeatherBots botType))
                {
                    result[botType] = c.Value;
                }
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"Error: The file at path '{filePath}' was not found. {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($" unexpected error occurred: {e.Message}");
        }

        return result;
    }
}

