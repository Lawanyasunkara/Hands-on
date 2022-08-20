using System;
using System.Collections.Generic;

public class problem10
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nInput first integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Check if one is negative and one is positive:");
        Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
    }
}