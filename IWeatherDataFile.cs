﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    public interface IWeatherDataFile
    {
        public IWeatherData? ConvertToData(string fileContent);
    }
}
