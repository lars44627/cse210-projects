using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction def = new Fraction();
        Fraction one = new Fraction(5);
        Fraction two = new Fraction(3, 4);

        def.Top = 2;
        def.Bottom = 5;
        one.Top = 7;
        one.Bottom = 9;
        two.Top = 8;
        two.Bottom = 10;

        Console.WriteLine($"Updated Default Fraction: {def.Top}/{def.Bottom}");
        Console.WriteLine($"Updated Fraction One: {one.Top}/{one.Bottom}");
        Console.WriteLine($"Updated Fraction Two: {two.Top}/{two.Bottom}");
    }
}