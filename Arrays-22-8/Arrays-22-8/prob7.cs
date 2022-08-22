using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Program7
{
    public static void Main(string[] args)
    {
        Queue q = new Queue();

        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);

        Console.Write("Original queue: ");
        foreach (int i in q)
        {
            Console.Write(i + " ");
        }

        q.Dequeue();
        q.Dequeue();
        Console.WriteLine();

        Console.Write("Queue after Dequeue() operation: ");

        foreach (int i in q)
        {

            Console.Write(i + " ");
        }
        foreach (int i in q)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine("peek element is: {0}", q.Peek());
    }
}