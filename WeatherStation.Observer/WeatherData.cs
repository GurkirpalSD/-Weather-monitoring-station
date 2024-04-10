namespace WeatherStation.Observer
{

    public class WeatherData
    {
        private static WeatherData instance;
        private List<IDisplay> observers;
        private Random random;

        public WeatherData()
        {
            observers = new List<IDisplay>();
            random = new Random();
        }

        public static WeatherData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WeatherData();
                }
                return instance;
            }
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
            int temperature = random.Next(-20, 40);
            int humidity = random.Next(0, 100);
            int pressure = random.Next(900, 1100);

            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

    public static object GetInstance()
    {
        throw new NotImplementedException();
    }
    
}
}