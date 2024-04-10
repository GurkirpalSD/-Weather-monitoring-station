
using WeatherStation.Observer;

 
WeatherData weatherData = (WeatherData)WeatherData.GetInstance();

var statisticsdisplayobserver = new StatisticsDisplayObserver();
var forecastdisplayobserver = new ForecastDisplayObserver();
var currentConditionsDisplay = new CurrentConditionsDisplay();


weatherData.RegisterObserver(forecastdisplayobserver);
weatherData.RegisterObserver(currentConditionsDisplay);
weatherData.RegisterObserver(statisticsdisplayobserver);

currentConditionsDisplay.Update(GetRandomTemp(),GetRandomHum(),GetRandomPre());

float GetRandomPre()
{
    Random r = new Random();
    return (float)(r.NextDouble()*8);
}

float GetRandomHum()
{
    Random r = new Random();
    return (float)(r.NextDouble()*4);
}

float GetRandomTemp()
{
    Random r = new Random();
    return (float)(r.NextDouble()*6);
}

Console.WriteLine(forecastdisplayobserver.Display());
Console.WriteLine(statisticsdisplayobserver.Display());


