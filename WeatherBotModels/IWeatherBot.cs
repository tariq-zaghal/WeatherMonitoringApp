using WeatherMonitoringApp.WeatherDataModels;

namespace WeatherMonitoringApp.WeatherBotModels
{
    public interface IWeatherBot
    {
        string? GetInfo(IWeatherData weatherData);
    }
}