﻿namespace WeatherMonitoringApp
{
    public interface IWeatherData
    {
        decimal Humidity { get; set; }
        string Location { get; set; }
        decimal Temperature { get; set; }
    }
}