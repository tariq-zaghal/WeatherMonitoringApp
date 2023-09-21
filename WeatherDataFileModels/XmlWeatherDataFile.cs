using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WeatherMonitoringApp.WeatherDataModels;

namespace WeatherMonitoringApp.WeatherDataFileModels
{
    public class XmlWeatherDataFile : IWeatherDataFile
    {
        private string _fileContent { get; set; }

        internal XmlWeatherDataFile(string fileContent)
        {
            _fileContent = fileContent;
        }

        public IWeatherData? ConvertToWeatherData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(WeatherData));

            WeatherData? output = null;

            using (StringReader stringReader = new StringReader(_fileContent))
            {
                output = (WeatherData)serializer.Deserialize(stringReader);
            }

            return output;
        }
    }
}
