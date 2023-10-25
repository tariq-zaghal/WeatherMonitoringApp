using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp.WeatherBotModels
{
    public class BotConfigerationsProvider : IBotConfigerationsProvider
    {
        public RainBot RainBot { get; set; }
        public SunBot SunBot { get; set; }
        public SnowBot SnowBot { get; set; }

        public static BotConfigerationsProvider ProvideWeatherBots(string fileContent)
        {
            return JsonConvert.DeserializeObject<BotConfigerationsProvider>(fileContent);
        }
    }
}
