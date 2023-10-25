using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringApp.WeatherDataModels;

namespace WeatherMonitoringApp.WeatherBotModels
{
    public class RainBot : WeatherBot,IWeatherBot
    {
        private decimal _humidityThreshold;

        public RainBot() : base(true, "message")
        {
        }

        public RainBot(bool enabled, string message, decimal humidityThreshold) : base(enabled, message)
        {
            _humidityThreshold = humidityThreshold;
        }

        public virtual string? GetInfo(IWeatherData weatherData)
        {
            if (_enabled && weatherData.Humidity > _humidityThreshold)
                return _message;

            return null;
        }
    }
}
