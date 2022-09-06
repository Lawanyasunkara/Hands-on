using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class_Library;
namespace _5_Sep_Handson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BookCategory bcat = new BookCategory();
            //Console.WriteLine("Book Category id : {0}, Book Category Name : {1}, BookCategory Description : {2}", bcat.CategoryID, bcat.CategoryName,bcat.Description);

            //BookCategory bcat2 = new BookCategory(1, "Pride and prejudice" ,"Classics type");
            //Console.WriteLine("Book Category id : {0}, Book Category Name : {1}, BookCategory Description : {2}", bcat2.CategoryID, bcat2.CategoryName, bcat2.Description);

            Book b = new Book();
            Console.WriteLine("Book  id : {0}, Book Name : {1}, Book Description : {2}", b.BookID, b.BookName, b.Price);

            Book b2 = new Book(2, "Strange Planet", 500);
            Console.WriteLine("Book  id : {0}, Book Name : {1}, Book Description : {2}", b2.BookID, b2.BookName, b2.Price);



            Console.ReadKey();
        }
    }
}