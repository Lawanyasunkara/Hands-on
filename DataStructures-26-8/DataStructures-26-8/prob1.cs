using System;

public struct Student
{
    struct student
    {
        public int s_id;
        public String s_name, c_name, s_dob;
    }
    class Program
    {
        static void Main(string[] args)
        {
            student[] arr = new student[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Please enter StudentId");
                    
                arr[i].s_id = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter StudenName");
                arr[i].s_name = Console.ReadLine();
                Console.WriteLine("Enter CourseName");
                arr[i].c_name = Console.ReadLine();
                Console.WriteLine("Enter DateOfBirth");
                arr[i].s_dob = Console.ReadLine();
            }
        }
    }



}

