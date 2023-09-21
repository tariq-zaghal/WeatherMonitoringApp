using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringApp.WeatherBotModels;

namespace WeatherMonitoringApp
{
    public class WeatherNotifierConsoleLogic
    {
        public static List<string> CreateWeatherNotifications(BotConfigerationsProvider botConfigerationsProvider, IWeatherData weatherData)
        {
            WeatherNotifier weatherNotifier = new WeatherNotifier(botConfigerationsProvider);

            List<string> notificationsList = weatherNotifier.NotifyBots(weatherData);

            return notificationsList;
        }

        public static void DisplayNotificationsToConsole(List<string> notificationsList)
        {
            notificationsList.ForEach(notification => Console.WriteLine(notification));
        }
    }
}
