﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringApp.WeatherBotModels;

namespace WeatherMonitoringApp
{
    public class WeatherNotifier
    {

        private  List<WeatherBot> _weatherBots;

        public WeatherNotifier()
        {
            _weatherBots = new List<WeatherBot>();
        }

        public WeatherNotifier(BotConfigerationsProvider providedWeatherBots)
        {
            _weatherBots = new List<WeatherBot> { providedWeatherBots.SnowBot, providedWeatherBots.SunBot, providedWeatherBots.RainBot};
        }

        public void AddWeatherBot(WeatherBot weatherBot)
        {
            _weatherBots.Add(weatherBot);
        }

        public void RemoveWeatherBot(WeatherBot weatherBot)
        {
            _weatherBots.Remove(weatherBot);
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
