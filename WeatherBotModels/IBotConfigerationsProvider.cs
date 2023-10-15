namespace WeatherMonitoringApp.WeatherBotModels
{
    public interface IBotConfigerationsProvider
    {
        public RainBot RainBot { get; set; }
        public SnowBot SnowBot { get; set; }
        public SunBot SunBot { get; set; }
    }
}
