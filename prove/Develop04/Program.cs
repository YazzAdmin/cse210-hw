using System;

class Program
{
    static void Main(string[] args)
    Journal journal = new Journal(); string choice = "0";

    
    do { Console.WriteLine("Please select one of the following choices: "); 
    }
    Console.WriteLinej("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load"); 
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");
    Console.Write("What would you like to do? ");
    
    choice = Console.ReadLine();
    if (choice == "1")
    {
        journal.AddEntry(); 
    }
    if (choice == "2")
{
    { journal.Display(); }
}
    if (choice == "3")
    {
        journal.LoadFile();
    }
    if (choice == "4")
    {
       journalournal.SaveFile();
    }
    while(choice != "5");
}