namespace WeatherStation.Observer;
///<summary>
/// This interface defines the contract for classes that display current weather conditions.
///</summary>

    public interface IDisplay
    {
        void Update(float temperature, float humidity, float pressure);
    }
