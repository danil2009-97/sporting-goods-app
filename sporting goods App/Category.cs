using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sporting_goods_App
{
    class Category
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Category(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
