using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp.WeatherDataFileModels
{
    public class WeatherDataFileFactory
    {
        public static IWeatherDataFile? GetDataFileInstance(string filePath, string fileContent)
        {
            if (DataFileFormatChecker.IsFileJson(filePath))
                return new JsonWeatherDataFile(fileContent);
            
            if(DataFileFormatChecker.IsFileXml(filePath))
                return new XmlWeatherDataFile(fileContent);

            return null;
        }
    }
}
