using System;   

public class WrittingAssignment : Assignment
{
    private string _title;

    public WrittingAssignment(string name, string topic, string title) : base (name, topic)
    {
        _title = title;
    }
    public string GetWrittingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}