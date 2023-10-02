using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        int guess = -1;
        Random  randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,101);
        

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (magicNumber >    guess)
            {
                Console.WriteLine("Higher");
            }
            else if(magicNum < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed correctly!");
            }
        }
    }
}