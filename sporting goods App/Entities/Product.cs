﻿using System;
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


        public Product () { }

        public Product(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
