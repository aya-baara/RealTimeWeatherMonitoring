namespace RealTimeWeatherMonitoring.Models;
class BotConfig
{
    public bool Enabled { get; set; }
    public double Threshold { get; set; }
    public required string Message { get; set; }
}
