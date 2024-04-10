
using WeatherStation.Observer;

 
var weatherData = new WeatherData();

var statisticsdisplayobserver = new StatisticsDisplayObserver();
var forecastdisplayobserver = new ForecastDisplayObserver();
var currentConditionsDisplay = new CurrentConditionsDisplay();

weatherData.Value = 80f;

weatherData.RegisterObserver(forecastdisplayobserver);
weatherData.RegisterObserver(currentConditionsDisplay);

Console.WriteLine(statisticsdisplayobserver.Update());
Console.WriteLine(forecastdisplayobserver.Display());
Console.WriteLine(currentConditionsDisplay.Display());