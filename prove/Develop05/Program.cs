using System;


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
        

        do{

        
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
                    break;
                    case 4:
                    break;
                    case 5:
                    break;
            }
           
        //   Console.Clear();  
        } while(option!= 6);
          
    }
}