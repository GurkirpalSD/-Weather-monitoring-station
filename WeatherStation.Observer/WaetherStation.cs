namespace WeatherStation.Observer;


    public class WeatherStation
    {
        public IDisplay CreateDisplay(string type)
        {
            if (type.Equals("CurrentConditions"))
            {
                return new CurrentConditionsDisplay();
            }
            else if (type.Equals("Statistics"))
            {
                return new StatisticsDisplayObserver();
            }
            else if (type.Equals("Forecast"))
            {
                return new ForecastDisplayObserver();
            }
            else
            {
                throw new ArgumentException("Invalid display type");
            }
        }
    }
