using System;
using System.Formats.Asn1;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Try and guess the magic number");
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);

        int guess;

    do
    {
        Console.WriteLine("guess the magic number:");
        guess = int.Parse(Console.ReadLine());

        if (guess > magicNum)
        {
Console.WriteLine("lower");
        }
        else if (guess < magicNum)
        {
Console.WriteLine("higher");
        }

    }
    while (guess != magicNum);


Console.WriteLine("Congrats, you guessed the number!");
    }
}