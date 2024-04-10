


namespace WeatherStation.Observer;



    public class CurrentConditionsDisplay : IDisplay
    {
    public bool Display()
    {
        throw new NotImplementedException();
    }

    public void Update(int temperature, int humidity, int pressure)
        {
            // Display current weather conditions
            Console.WriteLine($"Current conditions: Temperature {temperature}°C, Humidity {humidity}%, Pressure {pressure}hPa");
        }
    }

