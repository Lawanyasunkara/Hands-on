﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static delegates.Class1;
using static delegates.Class1;

namespace HandsonSep8
{
    internal class Program
    {
        static void Main(string[] args)
        {
        samde:
            Console.WriteLine("Enter the username");
            string p = Console.ReadLine();
            Console.WriteLine("Enter the password");
            string u = Console.ReadLine();
            var data = Tuple.Create<string, string>(p, u);
            Predicate<Tuple<string, string>> ps = (data1) => {
                if (data1.Item1 == "Lavanya" && data1.Item2 == "123456L#")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            if (ps(data))
            {
                List<Employee> m = new List<Employee>();
            earn:
                Console.WriteLine(" 1.Add\n 2.Delete\n 3.Edit");
                int y = Convert.ToInt32(Console.ReadLine());

                Dept CS = new Dept();




                switch(y)
                {
                    case 1:

                        Console.WriteLine("Enter deptno");
                    CS.DeptNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("DeptName");
                    CS.DeptName = Console.ReadLine();
                    Console.WriteLine("Location of department");
                    CS.Location = Console.ReadLine();
                start:
                    numb s1 = new numb(CS.Adding);
                    CS = s1(CS);
                    foreach (Employee e in CS.prod)
                    {
                        if (!m.Contains(e))
                            m.Add(e);

                    }
                    Console.WriteLine("Enter Yes to add Next item");
                    string mk = Console.ReadLine();
                    if (mk == "Yes")
                    {
                        goto start;
                    }
                    break;
                    case 2:
                        Employee mp = new Employee();
                    Console.WriteLine("Enter employee id to remove");
                    int mkt = Convert.ToInt32(Console.ReadLine());
                    m = mp.Delete(mkt, m);
                    mp.Display(m);
                    break;
                    case 3:
                        Console.WriteLine("Enter employee id to edit");
                    int ktm = Convert.ToInt32(Console.ReadLine());
                    Employee mpt = new Employee();
                    m = mpt.Edit(ktm, m);
                    mpt.Display(m);

                    break;
                }

                Employee mt = new Employee();
                Console.WriteLine("Display all Employee names");
                numb1 ns = new numb1(mt.Display);
                ns(m);
                numb1 ns1 = new numb1(mt.Displaybymgr);
                ns1(m);
                Console.WriteLine("Enter Yes to restart");
                string pass = Console.ReadLine();
                if (pass == "Yes")
                {
                    goto earn;
                }
            }
            else
            {
                Console.WriteLine("Try again");
                goto samde;
            }
            Console.ReadLine();
        }
    }
}