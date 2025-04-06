namespace RealTimeWeatherMonitoring.Models;
class BotConfig
{
    public bool Enabled { get; set; }
    public double Threshold { get; set; }
    public string Message { get; set; } = string.Empty;
}
