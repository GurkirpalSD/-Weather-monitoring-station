


namespace WeatherStation.Observer;



    public class CurrentConditionsDisplay : IDisplay
    {
    public bool Display()
    {
        throw new NotImplementedException();
    }

    public void Update(float temperature, float humidity, float pressure)
        {
            // Display current weather conditions
            Console.WriteLine($"Current conditions: Temperature {temperature}°C, Humidity {humidity}%, Pressure {pressure}hPa");
        }
    }

