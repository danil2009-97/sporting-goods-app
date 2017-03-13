using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sporting_goods_App
{
    class Product
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Category Category { get; set; }

        public Product(string name, string description, Category category)
        {
            Name = name;
            Description = description;
            Category = category;
        }
    }
}
