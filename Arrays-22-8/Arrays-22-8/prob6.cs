using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class prob6
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            st.Push(10);
            st.Push(44);
            st.Push(30);
            st.Push(4);
            st.Push(102);
            Console.WriteLine("No.of.elements in stack:" + st.Count);
            Console.WriteLine("stack numbers");

            st.Push(50);
            foreach (var item in st)
            {
                Console.WriteLine(item + "\t");
            }
            Console.WriteLine($"top element:" + st.Peek());
            st.Pop();
            st.Pop();
            Console.WriteLine($"top element:" + st.Peek());
            Console.ReadLine();
        }
    }
}