using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Prob2
    {
        public  static void Copy()
        {
            //Program 2
            Console.WriteLine("Enter a string: ");
            string s1 = Console.ReadLine();
            var s = string.Copy(s1);
            Console.WriteLine("Copy of String: \n" + s);
            Console.ReadLine();
        }
    }
}
