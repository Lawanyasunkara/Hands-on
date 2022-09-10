using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _9_Sep_Handson
{
    class Mutex
    {
        static void Main(string[] args)
        {
            //imterprocess
            using (System.Threading.Mutex mutex = new System.Threading.Mutex(false, "ThreadingDemo"))
            {

                if (!mutex.WaitOne(1000, false))
                {
                    Console.WriteLine("already running....");
                    Console.ReadLine();
                    return;

                }
                else
                {
                    Console.WriteLine("app is running");
                    Console.ReadLine();
                }

            }

        }
    }
}