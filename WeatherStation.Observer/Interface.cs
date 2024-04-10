namespace WeatherStation.Observer;


    public interface IDisplay
    {
        void Update(float temperature, float humidity, float pressure);
    }
