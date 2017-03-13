using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sporting_goods_App
{
    class Shop
    {
        public List<Product> Products { get; set; }

        public string Address { get; set; }

        public Shop( List<Product>products, string address)
        {
            Products = products;
            Address = address;
        }
    }
}
