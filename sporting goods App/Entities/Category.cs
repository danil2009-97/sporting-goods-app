using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sporting_goods_App
{
    public class Category
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Category () { }
        public Category(string name)
        {
            Name = name;
        }
    }
}
