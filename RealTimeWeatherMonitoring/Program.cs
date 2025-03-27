using RealTimeWeatherMonitoring;
using RealTimeWeatherMonitoring.Services;
using RealTimeWeatherMonitoring.Services.Bots;

FilePaths.LoadConfiguration();
Menu menu = new Menu(new WeatherMonitor(new BotsConfig()));



