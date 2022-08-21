using System;

namespace maxima
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int maxNum;
            Console.WriteLine("Number 1: " );
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number 2: " );
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                maxNum = num1;
            }
            else
            {
                maxNum = num2;
            }
            Console.WriteLine("Maximum number is: " + maxNum);
            Console.ReadKey();
        }
    }
}