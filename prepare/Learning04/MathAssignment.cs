using System;

public class MathAssignment : Assignment
{
    private string _bookSection;
    private string _problem;

    public MathAssignment(string bookSection, string problem) : base(name, topic)
    {
        _bookSection = bookSection;
        _problem = problem;   
    }

    public string GetHomeworkList()
    {
        return $"section {_bookSection} {_problem};
    }



    
}

