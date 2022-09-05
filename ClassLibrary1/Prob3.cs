using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Prob3
    {
        public static void Indexof()
        {
            //Program 3
            Console.WriteLine("Enter a string: ");
            string s = Console.ReadLine();
            Console.WriteLine("Enter character to show index: ");
            char ch = Convert.ToChar(Console.ReadLine());
            int indexofch = s.IndexOf(ch);
            Console.WriteLine("Index of given character is: " + indexofch);

        }
    }
}
