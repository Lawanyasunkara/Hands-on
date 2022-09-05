using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Prob1
    {
        public static void Compare()
        {
            string s1;
            string s2;
            Console.Write("Enter a string: ");
            s1 = Console.ReadLine();
            Console.Write("Enter another string: ");
            s2 = Console.ReadLine();
            if (s1 == s2)
                Console.WriteLine("\"{0}\" and \"{1}\" are equal", s1, s2);
            else
                Console.WriteLine("\"{0}\" and \"{1}\" are not equal", s1, s2);

            Console.ReadLine();
        }
    }
}