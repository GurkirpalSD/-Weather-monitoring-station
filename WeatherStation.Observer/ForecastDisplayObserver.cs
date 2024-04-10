
namespace WeatherStation.Observer;

    public class ForecastDisplayObserver : IDisplay
    {
    public bool Display()
    {
        throw new NotImplementedException();
    }

    public void Update(float temperature, float humidity, float pressure)
        {
            // Display weather forecast
            Console.WriteLine($"Weather forecast: Sunny, rainy, snowy, etc.");
        }
    }
