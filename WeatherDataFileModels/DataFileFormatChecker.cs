using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp.WeatherDataFileModels
{
    internal class DataFileFormatChecker
    {
        internal static bool IsFileJson(string filePath)
        {
            return filePath.EndsWith(".json");
        }

        internal static bool IsFileXml(string filePath)
        {
            return filePath.EndsWith(".xml");
        }
    }
}
