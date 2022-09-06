using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class Book
    {

        public Book(int Bookid)
        {
            _bookid = Bookid;
        }

        private int _bookid;

        public int BookID
        {
            get { return _bookid; }
            set { _bookid = value; }
        }
        private string _bname;

        public string BookName
        {
            get { return _bname; }
            set { _bname = value; }
        }

        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private string _author;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        //default constructor
        public Book()
        {
            BookName = "Fetch-22";
        }

        //parameterized constructor
        public Book(int bookid, string bname, int price)
        {
            this.BookID = bookid;
            this.BookName = bname;
            this.Price = price;


        }


        //Overloading/OverLoaded Method-->same method name with different number,  types and sequneces of parameter and in the single class
        public void InsertBook(int bookid, string bname, int price)
        {
            this.BookID = bookid;
            this.BookName = bname;
            this.Price = price;

        }


        public void InsertBook(int bookid, string bname, int price, string author)
        {
            this.BookID = bookid;
            this.BookName = bname;
            this.Price = price;
            this.Author = author;

        }
        public void InsertBook(int bookid, string bname)
        {
            this.BookID = bookid;
            this.BookName = bname;

        }
        public class Novel : Book
        {
            int NoOfPages;
            public void InsertBook(int id, string name, int price, int noofpages)
            {
                this.BookID = id;
                this.BookName = name;
                this.Price = price;
                this.NoOfPages = noofpages;
            }
        }
        }









}
