using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class prob11
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Mydict = new Dictionary<int, string>();
            Mydict.Add(1, "hii");
            Mydict.Add(2, "visual");
            Mydict.Add(3, "code");

            foreach (KeyValuePair<int, string> elem in Mydict)
            {
                Console.WriteLine("{0} and {1}", elem.Key, elem.Value);

            }
            SortedDictionary<int, string> Mydict1 = new SortedDictionary<int, string>()
            {
                 {1, "hii"}, {5, "visual"},{2, "code"},


             };
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}