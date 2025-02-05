using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction def = new Fraction();
        Fraction one = new Fraction(5);
        Fraction two = new Fraction(3, 4);
        Fraction three = new Fraction(1, 3);

        Console.WriteLine(def.GetFractionString());
        Console.WriteLine(def.GetDecimalValue());
        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalValue());
        Console.WriteLine(two.GetFractionString());
        Console.WriteLine(two.GetDecimalValue());
        Console.WriteLine(three.GetFractionString());
        Console.WriteLine(three.GetDecimalValue());
    }
}