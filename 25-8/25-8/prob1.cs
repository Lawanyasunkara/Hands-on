using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace filesdemo
{
    internal class prob1
    {
        static void Main(string[] args)

        {
            {
                do
                {

                    Console.WriteLine("1.create\n 2.add\n 3.truncate\n");
                    int x = Convert.ToInt32(Console.ReadLine());
                    string path = @"C:\Users\Lavanya\source\repos\25-8";
                    Console.WriteLine("Enter the file name");
                    string fname = Console.ReadLine();


                    fname = string.Concat(path, fname);

                    switch (x)
                    {
                        case 1:

                            FileStream f = new FileStream(fname, FileMode.Create);
                            StreamWriter s = new StreamWriter(f);

                            s.WriteLine("hi this is a new file");
                            s.Close();
                            f.Close();
                            Console.WriteLine("File created successfully...");
                            break;

                        case 2:

                            FileStream fs = new FileStream(fname, FileMode.Append);
                            StreamWriter ss = new StreamWriter(fs);
                            ss.WriteLine("this if from lav ");
                            ss.Close();
                            fs.Close();
                            Console.WriteLine(" appended  successfully...");
                            break;
                        case 3:

                            FileStream fs1 = new FileStream(fname, FileMode.Truncate);
                            StreamWriter ss1 = new StreamWriter(fs1);

                            ss1.WriteLine("hi Lavanya");
                            ss1.Close();
                            fs1.Close();
                            Console.WriteLine(" truncate  successfully...");
                            break;



                    }
                } while (true);


            }
        }


    }
}