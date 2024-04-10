
using WeatherStation.Observer;

 
WeatherData weatherData = (WeatherData)WeatherData.GetInstance();

var statisticsdisplayobserver = new StatisticsDisplayObserver();
var forecastdisplayobserver = new ForecastDisplayObserver();
var currentConditionsDisplay = new CurrentConditionsDisplay();

//weatherData.Value = 80f;

weatherData.RegisterObserver(forecastdisplayobserver);
weatherData.RegisterObserver(currentConditionsDisplay);

Console.WriteLine(statisticsdisplayobserver.Display());
Console.WriteLine(forecastdisplayobserver.Display());
Console.WriteLine(currentConditionsDisplay.Display());