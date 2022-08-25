using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filesdemo
{
    internal class Prob3
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\Users\Lavanya\source\repos\25-8");
            DirectoryInfo di = new DirectoryInfo("results");

            DirectoryInfo dis = di.CreateSubdirectory("results17-18");


            DirectoryInfo dis1 = di.CreateSubdirectory("results18-19");
            DirectoryInfo dis2 = di.CreateSubdirectory("results20-21");

            Console.WriteLine(" directory created");
            Console.WriteLine("subdirectories created");

            string[] fnames = Directory.GetDirectories(@"C:\Users\Lavanya\source\repos\25-8");
            Console.WriteLine(fnames[0]);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    string k = Console.ReadLine();
                    string v = string.Concat(fnames[i], k);
                    File.Create(@v);

                }
            }
            for (int i = 0; i < 3; i++)
            {
                DirectoryInfo pa = new DirectoryInfo(fnames[i]);
                for (int j = 0; j < 12; j++)
                {
                    var p = (Months)j;
                    string r = p.ToString();
                    pa.CreateSubdirectory(r);
                    Console.ReadLine();

                }
            }
        }
        enum Months
        {
            Jan = 1,
            Feb,
            Mar,
            Apr,
            May,
            June,
            July,
            Aug,
            Sep,
            Oct,
            Nov,
            Dec
        }








    }
}