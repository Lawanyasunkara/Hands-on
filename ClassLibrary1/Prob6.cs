using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ClassLibrary1
{
    public class Prob6
    {
        public static void Makefile()
        {
            //Program 6
            string path = @"C:\Users\Lavanya\source\repos\MyApp\Demo.txt";
            File.Create(path);
        }
    }
}
