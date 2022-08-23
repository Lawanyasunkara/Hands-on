using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handling_23_8
{
    public class prob2
    {

        public static void Main()
        {
            int a, b;
            int sum;

            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            sum = addition(a, b);

            Console.WriteLine("Sum is: " + sum);
            Console.ReadLine();
        }
        public static int addition(int a, int b)
        {
            return (a + b);
        }
    }
}
