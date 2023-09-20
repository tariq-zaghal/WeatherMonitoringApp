using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp.WeatherBotModels
{
    public class BotConfigerationsProvider
    {
        public RainBot RainBot { get; set; }
        public SunBot SunBot { get; set; }
        public SnowBot SnowBot { get; set; }

        public static BotConfigerationsProvider provide(string fileContent)
        {
            return JsonConvert.DeserializeObject<BotConfigerationsProvider>(fileContent);
        }
    }
}
