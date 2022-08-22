using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

{
    internal class prob5
    {
        static void Main(string[] args)
        {
            int[][] classroom = new int[4][];


            classroom[0] = new int[] { 1, 2, 3, 4 };
            classroom[1] = new int[] { 11, 34, 67 };
            classroom[2] = new int[] { 89, 23 };
            classroom[3] = new int[] { 0, 45, 78, 53, 99 };


            for (int n = 0; n < classroom.Length; n++)
            {


                System.Console.Write("student({0}): ", n);

                for (int k = 0; k < classroom[n].Length; k++)
                {


                    System.Console.Write("{0} ", classroom[n][k]);
                }
                System.Console.WriteLine();
            }
        }
    }
}