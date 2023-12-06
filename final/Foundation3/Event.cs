using System;

public class Event
{
    protected string _eventType;
    protected string _description;
    protected DateTime _date;
    protected string _time;
    protected Address _address;

    public Event(string eventType, string description, DateTime date, string time, Address address)
    {
        _eventType = eventType;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {_eventType}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {_eventType}\nDate: {_date.ToShortDateString()}";
    }
}