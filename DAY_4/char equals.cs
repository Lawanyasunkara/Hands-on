using System;

public class chareqals
{
    public static void Main()
    {
        char c1, c2;

        Console.WriteLine("Enter the first character : ");
        c1 = Console.ReadLine()[0];

        Console.WriteLine("Enter the second character : ");
        c2 = Console.ReadLine()[0];

        if (c1 == c2)
            Console.WriteLine("Both characters are equal");
        else
            Console.WriteLine("Characters are not equal");
    }
}