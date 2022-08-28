using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program4
{
    public static void Main(string[] args)
    {
        LinkedList<string> mylist = new LinkedList<string>();
        mylist.AddFirst("jack");
        mylist.AddLast("veena");
        mylist.AddAfter(mylist.First, "jill");
        mylist.AddBefore(mylist.Last, "jim");
        mylist.AddBefore(mylist.Last.Previous, "pari");
        mylist.AddAfter(mylist.First.Next, "hari");
        LinkedListNode<string> foundnode = mylist.Find("jim");
        foundnode.Value = "don";

        foreach (var item in mylist)
        {
            Console.WriteLine(item);

        }
        Console.ReadKey();
    }

}