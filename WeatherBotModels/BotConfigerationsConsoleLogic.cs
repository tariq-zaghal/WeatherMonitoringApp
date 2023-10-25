using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringApp.WeatherBotModels;

namespace WeatherMonitoringApp
{
    public class BotConfigerationsConsoleLogic
    {
        public static BotConfigerationsProvider GetBotConfigerationsProvider()
        {
            string configFileContent = FileContentProcessor.ConvertFileToString(BotConfigerationsFileLocation.BotConfigerationsFileAddress);
            BotConfigerationsProvider botConfigerationsProvider = BotConfigerationsProvider.ProvideWeatherBots(configFileContent);

            return botConfigerationsProvider;
        }
    }
}
