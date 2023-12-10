using System;
public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string eventType, string description, DateTime date, string time, Address address, string weatherForecast)
        : base(eventType, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }
}