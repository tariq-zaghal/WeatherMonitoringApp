using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    public class SunBot : WeatherBot
    {
        private decimal _temperatureThreshold;

        public SunBot(bool enabled, string message, decimal temperatureThreshold) : base(enabled,message)
        {
            _temperatureThreshold = temperatureThreshold;
        }

        public override string? GetInfo(IWeatherData weatherData)
        {
            if (_enabled && weatherData.Temperature > _temperatureThreshold)
                return _message;
            
            return null;
        }
    }
}
