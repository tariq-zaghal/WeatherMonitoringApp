using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    public class WeatherNotifier
    {

        private  List<WeatherBot> _weatherBots;

        public WeatherNotifier()
        {
            _weatherBots = new List<WeatherBot>();
        }

        public WeatherNotifier(List <WeatherBot> weatherBot)
        {
            _weatherBots = weatherBot;
        }

        public void AddWeatherBot(WeatherBot weatherBot)
        {
            _weatherBots.Add(weatherBot);
        }

        public void RemoveWeatherBot(WeatherBot weatherBot)
        {
            _weatherBots.Remove(weatherBot);
        }

        public List<string?> NotifyBots(WeatherData weatherData)
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
