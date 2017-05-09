using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sporting_goods_App
{
   public class Shop
    {
        private string _name;

        public string Name      
        {
            get { return _name; }
            set { _name = value; }
        }

        private List<Category> _categories;

        public List<Category> Categories
        {
            get { return _categories; }
            set { _categories = value; }
        }

        private List<Product> _products;

        public List<Product> Products
        {
            get { return _products; }
            set { _products = value; }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public Shop() { }

        public Shop( string address, string name)
        {
            Address = address;
            Name = name;
        }
    }
}
