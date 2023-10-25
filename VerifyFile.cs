using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    internal class VerifyFile
    {
        public static bool FileExits(string filePath)
        {
            if (File.Exists(filePath))
                return true;

            return false;
        }
    }
}
