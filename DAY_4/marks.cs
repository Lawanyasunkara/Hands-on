
using System;
class marks
{

    static void Main(string[] args)
    {

        
        int  marks1, marks2, marks3, total;

        
        float percentage;
       
        Console.WriteLine("Enter Subject-1 Marks : ");
        marks1 = Convert.ToInt32(Console.ReadLine());

        // Enter student subject 2 marks
        Console.WriteLine("Enter Subject-2 Marks : ");
        marks2 = Convert.ToInt32(Console.ReadLine());

        // Enter student subject 3 marks
        Console.WriteLine("Enter Subject-3 Marks :");
        marks3 = Convert.ToInt32(Console.ReadLine());

        
        total = marks1 + marks2 + marks3;

        
        percentage = total / 3.0f;

        
        Console.WriteLine("Final result of {0} is:");
        Console.WriteLine("Total Marks : " + total);
        Console.WriteLine("Percentage : " + percentage);

        
        if (percentage <= 35)
        {
            Console.WriteLine("Grade is F");
        }
        else if (percentage >= 35 && percentage <= 40)
        {
            Console.WriteLine("rank is third");
        }
        else if (percentage >= 46 && percentage <= 60)
        {
            Console.WriteLine("rank is second");
        }
        else if (percentage >= 60 )
        {
            Console.WriteLine("rank is first");
        }
        
    }
}
