namespace WeatherStation.Factory;
{
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
                return new StatisticsDisplay();
            }
            else if (type.Equals("Forecast"))
            {
                return new ForecastDisplay();
            }
            else
            {
                throw new ArgumentException("Invalid display type");
            }
        }
    }
}