using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringApp.WeatherDataModels;

namespace WeatherMonitoringApp.WeatherDataFileModels
{
    public interface IWeatherDataFile
    {
        public IWeatherData? ConvertToWeatherData();
    }
}
