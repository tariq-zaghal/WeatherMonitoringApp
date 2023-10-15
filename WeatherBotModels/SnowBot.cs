using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringApp.WeatherDataModels;

namespace WeatherMonitoringApp.WeatherBotModels
{
    public class SnowBot : WeatherBot,IWeatherBot
    {
        private decimal _temperatureThreshold;

        public SnowBot() : base(true, "message")
        {
        }

        public SnowBot(bool enabled, string message, decimal temperatureThreshold) : base(enabled, message)
        {
            _temperatureThreshold = temperatureThreshold;
        }

        public virtual string? GetInfo(IWeatherData weatherData)
        {
            if (_enabled && weatherData.Temperature < _temperatureThreshold)
                return _message;

            return null;
        }
    }
}
