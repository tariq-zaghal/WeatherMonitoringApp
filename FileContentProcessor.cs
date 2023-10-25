using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    public class FileContentProcessor
    {
        public static string ConvertFileToString(string filePath)
        {
            string fileContent = File.ReadAllText(filePath);
            return fileContent;
        }
    }
}
