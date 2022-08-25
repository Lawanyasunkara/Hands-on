using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Reflection;

namespace prob2
{
    public class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file name to be created: ");
            string name = Console.ReadLine();

            string path = "C:\\Users\\Lavanya\\source\\repos\\25-8";

            string fname = String.Concat(path, name);
            //File.Create(fname);
            //string s = "hi";
            //File.WriteAllText(fname, s);
            //Console.WriteLine("---file copy---");
            //File.Copy(fname, "hi raj.txt");
            //Console.WriteLine("----file moved---");
            //File.Move(fname, "movedfile.txt");
            //Console.WriteLine("---file deleted---");
            //File.Delete(path);
            FileInfo fileInfo = new FileInfo(fname);
            Console.WriteLine(fileInfo.FullName + "  Full Name");
            Console.WriteLine(fileInfo.DirectoryName + " DirectoryName");
            Console.WriteLine(fileInfo.CreationTime);
            Directory.CreateDirectory("MyDir");
            Console.ReadLine();

        }

    }
}