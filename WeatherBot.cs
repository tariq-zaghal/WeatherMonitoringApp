using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    public abstract class WeatherBot
    {
        protected bool _enabled { get; init; }
        protected string _message { get; init; }

        public WeatherBot(bool enabled, string message)
        {
            _enabled = enabled;
            _message = message;
        }

        public abstract void GetInfo(WeatherData weatherData);
    }
}
