using System;
using System.IO;

namespace prob4
{
    internal class Prob4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("C drive info");
            DriveInfo info = new DriveInfo("C");
            Console.WriteLine(info.Name);
            Console.WriteLine(info.TotalSize);
            Console.WriteLine(info.DriveType);
            Console.WriteLine(info.DriveFormat);
            Console.WriteLine("----------------------------");
            DriveInfo[] dinfo = DriveInfo.GetDrives();
            foreach (var item in dinfo)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }
}
