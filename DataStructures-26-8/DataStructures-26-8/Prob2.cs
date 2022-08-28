using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonAug26
{
    internal class Prob2
    {
        public struct Student
        {

            // Declare three variables
            // id, name and age
            public int Id;
            public string Name;
            public int Age;

            // Set the employee details
            public void SetStudent(int id, string name, int age)
            {
                Id = id;
                Name = name;
                Age = age;
            }

            // Display employee details
            public void DisplayStudent()
            {
                Console.WriteLine("Employee:");
                Console.WriteLine("\tId    : " + Id);
                Console.WriteLine("\tName   : " + Name);
                Console.WriteLine("\tAge   : " + Age);
                Console.WriteLine("\n");
            }

        }
    }
}