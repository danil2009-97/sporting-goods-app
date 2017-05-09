using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace sporting_goods_App
{
    public class Repository
    {
        private const string _xmlFileName = "../../Archive/data.xml";

        public event Action<Category> CategoryAdded;
        public event Action<Product> ProductAdded;
        public event Action<Shop> ShopAdded;

        private List<Product> _products = new List<Product>();

        public List<Product> Products
        {
            get { return _products; }
        }

        private List<Category> _categories = new List<Category>();

        public List<Category> Categories
        {
            get { return _categories; }
        }
        private List<Shop> _shops = new List<Shop>();

        public List<Shop> Shops
        {
            get { return _shops; }
        }

        public Repository()
        {
            LoadData();
        }

        public Repository(List<Category> categories, List<Product> products, List<Shop> shops)
        {
            _categories = categories;
            _products = products;
            _shops = shops;
        }

        public List<Product> FindProductsOfCategory(Category category)
        {
            return Products.FindAll(p => p.Category.Name == category.Name);
        }

        public void AddCategory(Category category)
        {
            if (_categories.Exists(c => c.Name == category.Name))
                throw new Exception("Такая категория уже существует!");

            _categories.Add(category);
            CategoryAdded?.Invoke(category);
            SaveData();
        }

        public void AddProduct(Product product)
        {
            if (_products.Exists(p => p.Name == product.Name))
                throw new Exception("Такой продукт уже существует!");

            _products.Add(product);
            ProductAdded?.Invoke(product);
            SaveData();
        }

        public void AddShop(Shop shop)
        {
            if (_shops.Exists(s => s.Name == shop.Name))
                throw new Exception("Такой магазин уже существует!");
            _shops.Add(shop);
            ShopAdded?.Invoke(shop);
            SaveData();
        }

        public List<Category> FindCategories(string input)
        {
            return Categories.FindAll(c => c.Name == input);
        }

        public List<Product> FindProducts(string input)
        {
            return Products.FindAll(p => p.Name == input);
        }

        public void RemoveCategory(Category category)
        {
            _products.RemoveAll(p => p.Category.Name == category.Name);
            _categories.Remove(category);
            SaveData();
        }

        public void RemoveProduct(Product product)
        {
            _products.Remove(product);
            SaveData();
        }

        private void SaveData()
        {
            File.Delete(_xmlFileName);
            using (FileStream fs = new FileStream(_xmlFileName, FileMode.OpenOrCreate))
            {
                Data d = new Data
                {
                    Products = this.Products,
                    Categories =this.Categories
                };

                XmlSerializer serializer = new XmlSerializer(typeof(Data));
                serializer.Serialize(fs, d);
            }
        }

        private void LoadData()
        {
            if (File.Exists(_xmlFileName))
            {
                using (FileStream fs = new FileStream(_xmlFileName, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Data));
                    Data d = (Data)serializer.Deserialize(fs);
                    _products = d.Products;
                    _categories = d.Categories;
                }
            }
        }
    }
}
