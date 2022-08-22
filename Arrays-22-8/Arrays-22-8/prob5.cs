using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class prob5
    {
        static void Main(string[] args)
        {
            int[][] stu_array = new int[3][];

            stu_array[0] = new int[] { 10, 20, 30 };
            stu_array[1] = new int[] { 5, 6, 7 };
            stu_array[2] = new int[] { 2, 3, 1, 4 };
            foreach (int[] array in stu_array)

            {
                foreach (int value in array)
                {

                    Console.Write("student in each class stu_array{0}\t", value);
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();



        }
    }
}