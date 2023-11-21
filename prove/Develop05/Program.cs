using System;
using System.IO.Enumeration;


class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int option;
        int type;
        string name;
        string description;
        int points;
        int bonus;
        int totalCompleted;
        int totalPoints = 0;
        string filename;

        do{

        Console.WriteLine($"You have {totalPoints}");
        Console.WriteLine("Menu Selection:");
        Console.WriteLine("1. Start New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");

        Console.WriteLine("Select a choice from the menu:");
    
        option = int.Parse((Console.ReadLine()));
        
            switch(option)
            {
               
            case 1:  
                
                Console.WriteLine("Goal types are: ");
                Console.WriteLine("1. SimpleGoal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                type = int.Parse((Console.ReadLine()));
                switch(type)
                {
                    case 1:
                    Console.WriteLine("What is the name of the goal you want to create?");
                    name =Console.ReadLine();
                    Console.WriteLine("What is a short description of it?");
                    description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with the goal?");
                    points = int.Parse((Console.ReadLine()));
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points, false);

                    goals.Add(simpleGoal);
                    break;
                    case 2:
                    Console.WriteLine("What is the name of the goal you want to create?");
                    name =Console.ReadLine();
                    Console.WriteLine("What is a short description of it?");
                    description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with the goal?");
                    points = int.Parse((Console.ReadLine()));
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    goals.Add(eternalGoal);
                    break;
                    case 3:
                    Console.WriteLine("What is the name of the goal you want to create?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it?");
                    description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with the goal?");
                    points = int.Parse((Console.ReadLine()));
                    Console.Write("How many times does this goal need to be accomplished for a bonus?");
                    totalCompleted = int.Parse((Console.ReadLine()));
                    Console.Write("What is the bonus for accomplishing it that many times?");
                    bonus = int.Parse((Console.ReadLine()));
                    
                    CheckListGoal checklistgoal = new CheckListGoal(totalCompleted, 0, bonus, name, description, points);
                    goals.Add(checklistgoal);
                    break; 
                }
                    break;
                    case 2:
                    int n = 1;
                    foreach (Goal g in goals)
                    {
                        string Goalname = g.GetGoalName();
                        string Description = g.GetGoaldescription();
                       
                        
                        if (g is CheckListGoal)
                        {
                            int totalcompleted = ((CheckListGoal)g).GettotalCompleted();
                            int numberCompleted = ((CheckListGoal)g).GetnumberCompleted();
                            if (g.IsComplete())
                            {
                               Console.WriteLine($"{n} . [X] {Goalname}({Description}) -- Currently completed: {numberCompleted}/ {totalcompleted} "); 
                            }
                            else
                            {
                                Console.WriteLine($"{n} . [ ] {Goalname}({Description}) -- Currently completed: {numberCompleted}/ {totalcompleted} ");
                            }

                        }
                        else 
                        {

                            if (g.IsComplete())
                            {
                               Console.WriteLine($"{n} . [X] {Goalname}({Description})");
                            }
                            else
                            {
                                Console.WriteLine($"{n} . [ ] {Goalname}({Description})");
                            } 
                        }
                        n++;
                    }
                    break ;
                    case 3: 
                    Console.WriteLine("What is the filename for the goal file?"); 
                    filename = Console.ReadLine();
                    using(StreamWriter outputFile = new StreamWriter (filename))
                    {
                        outputFile.WriteLine($"{totalPoints}");
                        foreach(Goal g in goals)
                        {
                            if (g is SimpleGoal)
                            {
                                outputFile.WriteLine($"SimpleGoal,{g.GetGoalName()},{g.GetGoaldescription()},{g.GetGoalPoints()},{g.GetIsComplete()}");
                            }
                            else if (g is EternalGoal)
                            {
                                outputFile.WriteLine($"EternalGoal,{g.GetGoalName()},{g.GetGoaldescription()},{g.GetGoalPoints()}");
                            }
                            else 
                            {
                                outputFile.WriteLine($"CheckListGoal,{g.GetGoalName()},{g.GetGoaldescription()},{g.GetGoalPoints()},{((CheckListGoal)g).Getbonus()},{((CheckListGoal)g).GettotalCompleted()},{((CheckListGoal)g).GetnumberCompleted()}");
                            }
                        }
                    
                            
                    }
                    break;
                    case 4:
                    Console.WriteLine("What is the filename for the goal file?"); 
                    filename = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(filename); 
                    int index = 0;

                    foreach (string line in lines)
                    { 
                      string[] parts = line.Split(",");  
                      if (index > 0)
                      {                      
                        if (parts[0] == "SimpleGoal")
                        {
                            SimpleGoal simpleGoal = new SimpleGoal(parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4]));
                            goals.Add(simpleGoal);
                        }
                        else if (parts[0] == "CheckListGoal")
                        {
                            CheckListGoal checkListGoal = new CheckListGoal(int.Parse (parts[5]),int.Parse (parts[6]),int.Parse(parts[4]),parts[1],parts[2],int.Parse(parts[3]));
                            goals.Add(checkListGoal);
                        } 
                        
                        else
                        {
                            EternalGoal eternalGoal = new EternalGoal(parts[1],parts[2],int.Parse(parts[3]));
                            goals.Add(eternalGoal);
                        }
                    }
                    else
                    {
                        totalPoints = int.Parse(((parts[0])));
                    }
                    index++;
    
                    }
             
                    break;
                    case 5:
                    int index2 = 1;
                    Console.WriteLine("The goals are:");
                    foreach(Goal g in goals)
                    {
                        Console.WriteLine($"{index2}. {g.GetGoalName}");
                    }
                    Console.WriteLine("Which goal did you accomplish?");
                    break;
    }
            
        } while(option!= 6);
          
    }
}