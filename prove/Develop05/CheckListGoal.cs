using System;
public class CheckListGoal: Goal
{
    
    protected int _totalCompleted;
    protected int _numberCompleted;
    protected int _bonus;


    public CheckListGoal(int totalCompleted, int numberCompleted,int bonus,string name, string description,int points):base(name, description, points)
    {
        _totalCompleted = totalCompleted;
        _numberCompleted = numberCompleted;
        _bonus= bonus;
    }

    public int GettotalCompleted()
    {
        return _totalCompleted;
    }

     public int GetnumberCompleted()
    {
        return _numberCompleted;
    }

    public int Getbonus()
    {
        return _bonus;
    }
    public override void RecordEvent()
    {

    }


    public override bool IsComplete()
    {
    return _isComplete;
    }

   public void setbonus(int bonus)
    {
        _bonus = bonus;
    }

 public void settotalCompleted(int totalCompleted)
    {
        _totalCompleted = totalCompleted;
    }

public void setnumberCompleted(int numberCompleted)
    {
        _numberCompleted = numberCompleted;
    }


    // virtual GetGoalsSaved()
    // {

    // }
}











