using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson23
{
    internal class ps5
    {
        static void Main(string[] args)
        {
            employees[] arr = new employees[4];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter EmpNo");
                arr[i].EmpNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Empname");
                arr[i].Ename = Console.ReadLine();
                Console.WriteLine("Enter salary");
                arr[i].Salary = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter DeptNo");
                arr[i].Dno = Convert.ToInt32(Console.ReadLine());


            }
            Console.WriteLine("Enter the details");
            for (int i = 0; i < 4; i++)
            {
                arr[i].display();
            }
            Console.ReadLine();



        }
    }
    struct employees
    {
        public int EmpNo;
        public string Ename;
        public float Salary;
        public int deptno;
        public int empno
        {
            set
            {
                EmpNo = value;
            }
            get
            {
                return EmpNo;
            }
        }
        public string ename
        {
            set
            {
                Ename = value;
            }
            get
            {
                return Ename;
            }
        }
        public float salary
        {
            set
            {
                Salary = value;
            }
            get
            {
                return Salary;
            }
        }
        public int Dno
        {
            set
            {
                deptno = value;
            }
            get
            {
                return deptno;
            }
        }



        public void display()
        {
            Console.WriteLine("{0} {1} {2} {3}\n", EmpNo, Ename, Salary, deptno);
        }
    }
}