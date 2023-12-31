﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    public class RainBot: WeatherBot
    {
        private decimal _humidityThreshold;

        public RainBot(bool enabled, string message, decimal humidityThreshold) : base(enabled, message)
        {
            _humidityThreshold = humidityThreshold;
        }

        public override string? GetInfo(WeatherData weatherData)
        {
            if(_enabled && weatherData.Humidity > _humidityThreshold) 
                return _message; 
            
            return null;
        }
    }
}
