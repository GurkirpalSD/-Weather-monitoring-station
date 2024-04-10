namespace WeatherStation.Factory;


    public interface IDisplay
    {
        void Update(int temperature, int humidity, int pressure);
    }
