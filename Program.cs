using System;
using System.IO;
using WeatherMonitoringApp.ConsoleLoggingModels;
using WeatherMonitoringApp.WeatherBotModels;
using WeatherMonitoringApp.WeatherDataFileModels;

namespace WeatherMonitoringApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainConsoleLogger.DisplayEnterFilePathMessage();
            string filePath = ReadInputDataFilePath();

            if (!VerifyFile.FileExits(filePath)) 
            {
                FileValidationLogger.DisplayFileInvalid();
                return;
            }

            IWeatherDataFile? weatherDataFile = WeatherDataFileConsoleLogic.GetWeatherDataFile(filePath);

            if (weatherDataFile == null)
            {
                FileValidationLogger.DisplayFileInvalidFormat();
                return;
            }

            IWeatherData? weatherData = weatherDataFile.ConvertToWeatherData();

            BotConfigerationsProvider botConfigerationsProvider = BotConfigerationsConsoleLogic.GetBotConfigerationsProvider();

            List<string> notificationsList = WeatherNotifierConsoleLogic.CreateWeatherNotifications(botConfigerationsProvider, weatherData);

            WeatherNotifierConsoleLogic.DisplayNotificationsToConsole(notificationsList);
        }

        private static string ReadInputDataFilePath()
        {
            return Console.ReadLine();
        }
    }
}