namespace WeatherStation.Observer
{

    public class WeatherData
    {
        private static WeatherData instance;
        private List<IDisplay> observers;
        private Random random;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IDisplay>();
            random = new Random();
        }

        public static WeatherData GetInstance()
        {
        
            
                if (instance == null)
                {
                    instance = new WeatherData();
                }
                return instance;
            
        }

        public void RegisterObserver(IDisplay observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IDisplay observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            // Simulate weather data changes
            float temperature = random.Next(-20, 40);
            float humidity = random.Next(0, 100);
            float pressure = random.Next(900, 1100);

            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public float GetTemperature()
        {
            return temperature;
        }

        public float GetHumidity()
        {
            return humidity;
        }

        public float GetPressure()
        {
            return pressure;
        }

 
}
}