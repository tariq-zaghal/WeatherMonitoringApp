using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringApp.WeatherBotModels;
using WeatherMonitoringApp.WeatherDataModels;

namespace WeatherMonitoringApp.WeatherNotifierModels
{
    public class WeatherNotifier
    {

        private List<WeatherBot> _weatherBots;

        public WeatherNotifier(BotConfigerationsProvider providedWeatherBots)
        {
            _weatherBots = new List<WeatherBot> { providedWeatherBots.SnowBot, providedWeatherBots.SunBot, providedWeatherBots.RainBot };
        }

        public List<string?> NotifyBots(IWeatherData weatherData)
        {
            List<string?> NotificationFromBots = new List<string?>();

            foreach (var bot in _weatherBots)
            {
                NotificationFromBots.Add(bot.GetInfo(weatherData));
            }

            return NotificationFromBots;
        }
    }
}
