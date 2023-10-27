using System;
 
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");
 
        // Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        // Console.WriteLine(assignment.GetSummary());

        // MathAssignment assignment = new MathAssignment("Samuel Bennett", "Multiplication", "7.3", "8-19" );
        // // Console.WriteLine(assignment.GetSummary());
        // // Console.WriteLine(assignment.GetHomeworkList()); ctrl K+C
        WrittingAssignment assignment = new WrittingAssignment("Mary Waters", "European History", "The Causes of World War II" );
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(assignment.GetWrittingInformation());
    }
    
}