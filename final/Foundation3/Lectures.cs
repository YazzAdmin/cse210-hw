public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string eventType, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(eventType, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}