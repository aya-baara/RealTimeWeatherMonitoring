
using RealTimeWeatherMonitoring.Interfaces;
using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Services.WeatherReader;

namespace RealTimeWeatherMonitoring.Services;
class Menu
{
    private IWeatherDataReader _weatherDataReader;
    private IWeatherMonitor _weatherMonitor;

    public Menu(IWeatherMonitor weatherMonitor)
    {
        _weatherMonitor = weatherMonitor;
        DisplayMenu();
    }
    public void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("1. Enter weather data");
            Console.WriteLine("2. Exit");
            Console.Write("Please select an option (1 or 2): ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int option))
            {
                switch (option)
                {
                    case 1:
                        EnterWeatherData();
                        break;

                    case 2:
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please select 1 or 2.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    private void EnterWeatherData()
    {
        Console.WriteLine("Enter Weather Data as Json or Xml format .. send it in one line");
        string weatherDataInput = Console.ReadLine();
        try
        {
            _weatherDataReader = WeatherDataReaderFactory.GetReader(weatherDataInput);
            WeatherData inputWeatherData = _weatherDataReader.Read(weatherDataInput);
            _weatherMonitor.UpdateWeather(inputWeatherData);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
    }
}

