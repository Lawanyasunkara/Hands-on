using System;
using System.Collections.Generic;
using Prob2;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Prob
{
    public class P3
    {
        public static void Main(string[] args)
        {
            List<Products> product = new List<Products>();
            product.Add(new Products { Pid = 1, Pname = "Watch", Price = 1000 });
            product.Add(new Products { Pid = 2, Pname = "Phone", Price = 10000 });
            product.Add(new Products { Pid = 3, Pname = "Pen", Price = 20 });

            Console.WriteLine("Product Details\n");
            foreach (var item in product)
            {
                Console.WriteLine("Product ID: " + item.Pid);
                Console.WriteLine("Product Name: " + item.Pname);
                Console.WriteLine("Product Price: " + item.Price);
                Console.WriteLine("\t");
            }

            product.RemoveAt(1);
            Console.WriteLine("After Removal\n");
            foreach (var item1 in product)
            {
                Console.WriteLine("Product ID: " + item1.Pid);
                Console.WriteLine("Product Name: " + item1.Pname);
                Console.WriteLine("Product Price: " + item1.Price);
                Console.WriteLine("\t");
            }

            Console.ReadLine();
        }
    }
}