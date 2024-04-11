
namespace WeatherStation.Observer;

///<summary>
/// This class is an observer responsible for displaying the forecasted weather conditions based on current data.
///</summary>

    public class ForecastDisplayObserver : IDisplay
    {
        private string forecast;
        private readonly WeatherData weatherData;
    public bool Display()
    {
        throw new NotImplementedException();
    }

   
        public void UpdateForecast()
        {
            float temperature = weatherData.GetTemperature();
            if (temperature > 30)
            {
                forecast = "Hot and Sunny";
            }
            else if (temperature < 10)
            {
                forecast = "Cold and Cloudy";
            }
            else
            {
                forecast = "Mild";
            }
        }
         public void Update(float temperature, float humidity, float pressure)
        {
            // Display weather forecast
            UpdateForecast();
            Console.WriteLine($"Weather forecast: Sunny, rainy, snowy, etc.");
        }
    }

