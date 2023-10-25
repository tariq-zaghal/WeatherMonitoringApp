using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp.WeatherDataFileModels
{
    public class WeatherDataFileConsoleLogic
    {
        public static IWeatherDataFile? GetWeatherDataFile(string filePath)
        {
            string fileContent = FileContentProcessor.ConvertFileToString(filePath);

            IWeatherDataFile? weatherDataFile = WeatherDataFileFactory.GetDataFileInstance(filePath, fileContent);

            return weatherDataFile;
        }
    }
}
