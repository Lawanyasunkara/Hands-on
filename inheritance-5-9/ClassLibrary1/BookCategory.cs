using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class BookCategory
    {
        private int _catid;

        public int CategoryID
        {
            get { return _catid; }
            set { _catid = value; }
        }
        private string _catname;

        public string CategoryName
        {
            get { return _catname; }
            set { _catname = value; }
        }

        private string desc;

        public string Description
        {
            get { return desc; }
            set { desc = value; }
        }
        //default constructor
        public BookCategory()
        {
            CategoryName = "Novel";
        }

        //parameterized constructor
        public BookCategory(int Catid, string CatName, string Desc)
        {
            this.CategoryID = Catid;
            this.CategoryName = CatName;
            this.Description = Desc;

        }



    }


}