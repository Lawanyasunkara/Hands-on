using System;
using System.IO;
using System.Text;

namespace stringcomp
{
    class Test
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;
            Console.Write("Enter a string: ");
            str1 = Console.ReadLine();
            Console.Write("Enter another string: ");
            str2 = Console.ReadLine();
            if (str1 == str2)
                Console.WriteLine(" strings are equal", str1, str2);
            else
                Console.WriteLine(" strings are not equal", str1, str2);
            Console.ReadLine();
        }
    }
}
