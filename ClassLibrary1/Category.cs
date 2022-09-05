using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Category
    {
        private int _catid;

        public int CatId
        {
            get { return _catid; }
            set { _catid = value; }
        }

        private string _catname;

        public string CatName
        {
            get { return _catname; }
            set { _catname = value; }
        }

        private string _desc;

        public string Description
        {
            get { return _desc; }
            set { _desc = value; }
        }









        ///creating a list of products in category class
        private List<product> _prodlist;

        public List<product> ProductList
        {
            get { return _prodlist; }
            set { _prodlist = value; }
        }










    }
}