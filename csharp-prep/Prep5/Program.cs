using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResult(name,squared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the program!");
        
    }
    static string PromptUserName()
    {
        Console.Write($"What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write($"What is your favorite Number?");
        string userNumber = Console.ReadLine();
        int number= int.Parse(userNumber);
        return number;
    }
    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }   
    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name} , {squared}");
    }
}