using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Fraction firstconstructor = new Fraction();
        Console.WriteLine(firstconstructor.getFractionString());
        Console.WriteLine(firstconstructor.getDecimalValue());

        Fraction constructor2 = new Fraction(5);
        Console.WriteLine(constructor2.getFractionString());
        Console.WriteLine(constructor2.getDecimalValue());

        Fraction thirdfraction = new Fraction(3,4);
        Console.WriteLine(thirdfraction.getFractionString());
        Console.WriteLine(thirdfraction.getDecimalValue());

        Fraction fraction4 = new Fraction(1,3);
        Console.WriteLine(fraction4.getFractionString());
        Console.WriteLine(fraction4.getDecimalValue());
    }

    
    
}