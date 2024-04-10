namespace WeatherStation.Observer;

    public class StatisticsDisplayObserver : IDisplay
    {
        public void Update(int temperature, int humidity, int pressure)
        {
            // Display weather statistics
            Console.WriteLine($"Weather statistics: Average temperature, max temperature, min temperature, etc.");
        }
    }
