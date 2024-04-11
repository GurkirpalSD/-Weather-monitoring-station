
namespace WeatherStation.Observer;
///<summary>
/// This class is an observer responsible for displaying weather statistics based on current data.
///</summary>


    public class StatisticsDisplayObserver : IDisplay
    {
    public bool Display()
    {
        throw new NotImplementedException();
    }

    public void Update(float temperature, float humidity, float pressure)
        {
            // Display weather statistics
            Console.WriteLine($"Weather statistics: Average temperature, max temperature, min temperature, etc.");
        }
        
    }
