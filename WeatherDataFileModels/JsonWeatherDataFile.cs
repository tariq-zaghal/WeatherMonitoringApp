using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http.Json;
using WeatherMonitoringApp.WeatherDataModels;

namespace WeatherMonitoringApp.WeatherDataFileModels
{
    public class JsonWeatherDataFile : IWeatherDataFile
    {
        private string _fileContent { get; set; }

        internal JsonWeatherDataFile(string fileContent)
        {
            _fileContent = fileContent;
        }

        public IWeatherData? ConvertToWeatherData()
        {
            return JsonConvert.DeserializeObject<WeatherData>(_fileContent);
        }
    }
}
