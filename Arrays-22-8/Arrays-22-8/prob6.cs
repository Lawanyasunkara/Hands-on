using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_22_8
{
    internal class prob6
    {
        Stack<int> st = new Stack<int>();
        st.Push(10);
            st.Push(205);
            st.Push(300);
            st.Push(400);
            st.Push(500);
            Console.WriteLine($"No.of.elements in stack:" + st.Count);
            Console.WriteLine("STACK ELEMENTS");
           
            st.Push(500);
            foreach (var item in st)
            {
                Console.WriteLine(item + "\t");
            }
    Console.WriteLine($"top element:"+  st.Peek());
            st.Pop();
            st.Pop();
            Console.WriteLine($"top element:" +   st.Peek());
            Console.ReadLine();
    }
}
