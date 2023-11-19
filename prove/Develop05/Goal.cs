public abstract class Goal
    {
    protected string _name;
    protected string _description;
    protected int _points; 
    protected bool _isComplete;
    public Goal(string name, string description,int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    
    public abstract void RecordEvent();
    public abstract bool IsComplete();

    public string GetGoalName()
    {
        return _name;
    }
    public string GetGoaldescription()
    {
        return _description;
    }

  

    // public virtual string GetGoalsSaved()
    // {
        
    // }

    protected void SetName(string name)
    {
        _name = name;
    }
     protected void SetDescription(string description)
    {
        _description = description;
    }
    protected void SetPoints(int points)
    {
        _points = points;
    }

}