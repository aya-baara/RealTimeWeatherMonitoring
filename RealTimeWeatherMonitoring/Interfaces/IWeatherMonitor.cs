namespace RealTimeWeatherMonitoring.Interfaces;
interface IWeatherMonitor
{
    void Attach(IWeatherBot bot);
    void Detach(IWeatherBot bot);
    void Notify();
}

