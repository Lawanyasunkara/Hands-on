using System;
public class problem8
{
    public static void Main()
    {
        int x;

        Console.Write("Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0}{0}{0}", x);
        Console.WriteLine("{0} {0}", x);
        Console.WriteLine("{0} {0}", x);
        Console.WriteLine("{0} {0}", x);
        Console.WriteLine("{0}{0}{0}", x);
    }
}