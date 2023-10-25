using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp.ConsoleLoggingModels
{
    public class FileValidationLogger
    {
        public static void DisplayFileInvalid()
        {
            Console.WriteLine("File path is invalid!");
        }

        public static void DisplayFileInvalidFormat()
        {
            Console.WriteLine("File format is invalid!");
        }
    }
}
