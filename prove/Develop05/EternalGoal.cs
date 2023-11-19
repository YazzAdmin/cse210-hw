using System;
using System.Reflection.Metadata.Ecma335;

public class EternalGoal: Goal
{
    public EternalGoal(string name, string description,int points):base(name, description, points)
    {
        
    }
public override void RecordEvent()
{

}
public override bool IsComplete()
{
    return false;
}



}
