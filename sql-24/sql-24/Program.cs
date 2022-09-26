using System;
using System.Collections.Generic;
using bal_file;
using helper;

namespace _23_sep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of Products");
            List<BL_products> po = new List<BL_products>();
            Class1 cq = new Class1();
            po = cq.Get_products();
            foreach (var item in po)
            {
                Console.Write($"{item.ProductId},{item.Product_Name},{item.Ctegoryid},{item.QuantityPerunits},{item.Unitcost},{item.Unitsonorders},{item.ReorderLevel},{item.Discontinued}\n");
            }
            Console.Read();
        }
    }
}