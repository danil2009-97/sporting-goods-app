using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sporting_goods_App
{
    public class Product
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private Category _category;

        public Category Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public Product () { }

        public Product(string name, string description, Category category)
        {
            Name = name;
            Description = description;
            Category = category;
        }
    }
}
