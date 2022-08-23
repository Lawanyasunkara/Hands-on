using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handling_23_8
{
    internal class prob8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input first number");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input second number");
            int j = Convert.ToInt32(Console.ReadLine());
            Divide(i, j);

            Console.ReadLine();
        }
        static void Divide(int p, int q)
        {
            try
            {
                int r;
                r = p / q;
                Console.WriteLine(r);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.StackTrace);

            }
            finally
            {
                Console.WriteLine("anyway message got");
            }

        }
    }
}
