// See https://aka.ms/new-console-template for more information

using RealTimeWeatherMonitoring.Services;
using RealTimeWeatherMonitoring.Services.Bots;
Console.WriteLine("Hello, World!");

// <<Json input example>>
//{"Location": "City Name", "Temperature": 35.8, "Humidity": 20.4}


//// <<XML input example>>
//<Weather><Location>City Name</Location><Temperature>23.7</Temperature><Humidity>85.5</Humidity></Weather>

Menu menu = new Menu();