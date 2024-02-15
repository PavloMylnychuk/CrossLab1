using System;

Console.WriteLine("Lab 1!");

static void Task1()
{
    Console.Write("s= ");
    string? input = Console.ReadLine();

    if (float.TryParse(input, out float s))
    {
        double p = 4 * Math.Sqrt(s);
        Console.WriteLine("p=" + p);
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}

Task1();