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
    public override void RecordEvent()
    {

    }


    public override bool IsComplete()
    {
    return _isComplete;
    }

    public void setisComplete(bool _iscomplete)
    {
    _isComplete = _iscomplete;
    }



    // virtual GetGoalsSaved()
    // {

    // }
}











