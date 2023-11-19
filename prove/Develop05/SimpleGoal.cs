using System;

public class SimpleGoal: Goal
{
    
    public SimpleGoal(string name, string description,int points,bool isComplete):base(name, description, points)
    {
        _isComplete = isComplete;
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

    

}

