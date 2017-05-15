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
        Logger _logger = new Logger();
        private const string _xmlFileName = "../../Archive/Data.xml";

        public event Action<Category> CategoryAdded;
        public event Action<Product> ProductAdded;
        public event Action<Shop> ShopAdded;

        private List<Shop> _shops = new List<Shop>();

        public List<Shop> Shops
        {
            get { return _shops; }
        }

        public Repository()
        {
            LoadData();
        }

        public Repository(List<Shop> shops)
        {
            _shops = shops;
        }

        public void AddCategory(Category category, Shop shop)
        {
            if (shop.Categories.Exists(c => c.Name == category.Name))
                throw new Exception("Такая категория уже существует!");

            shop.Categories.Add(category);
            CategoryAdded?.Invoke(category);
            _logger.Log($"Добавлена новая категория {category.Name}");
            SaveData();
        }

        public void EditCategory(Category category, string newName)
        {
            category.Name = newName;
            CategoryAdded?.Invoke(category);
            _logger.Log($"Внесены изменения в категорию {category.Name}");
            SaveData();
        }

        public void EditProduct(Product product, string newName, string newDescription)
        {
            product.Name = newName;
            product.Description = newDescription;
            ProductAdded?.Invoke(product);
            _logger.Log($"Внесены изменения в продукт {product.Name}");
            SaveData();
        }

        public void AddProduct(Product product, Category category)
        {
            if (category.Products.Exists(p => p.Name == product.Name))
                throw new Exception("Такой продукт уже существует!");

            category.Products.Add(product);
            ProductAdded?.Invoke(product);
            _logger.Log($"Добавлен новый продукт {product.Name}");
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

        public List<Category> FindCategories(Shop shop, string input)
        {
            return shop.Categories.FindAll(c => c.Name.ToLower().Contains(input.ToLower()));
        }

        public List<Product> FindProducts(Category category, string input)
        {
            return category.Products.FindAll(p => p.Name.ToLower().Contains(input.ToLower()));
        }

        public List<Shop> FindShops(string input)
        {
            return _shops.FindAll(s => s.Name.ToLower().Contains(input.ToLower()));
        }

        public void RemoveCategory(Category category, Shop shop)
        {
            shop.Categories.Remove(category);
            _logger.Log($"Удалена категория {category.Name} ");
            SaveData();
        }

        public void RemoveProduct(Product product, Category category)
        {
            category.Products.Remove(product);
            _logger.Log($"Удален продукт {product.Name}");
            SaveData();
        }

        public void RemoveShop(Shop shop)
        {
            _shops.Remove(shop);
            _logger.Log($"Удален магазин {shop.Name}");
            SaveData();
        }

        private void SaveData()
        {
            File.Delete(_xmlFileName);
            using (FileStream fs = new FileStream(_xmlFileName, FileMode.OpenOrCreate))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Shop>));
                serializer.Serialize(fs, Shops);
            }
        }

        private void LoadData()
        {
            if (File.Exists(_xmlFileName))
            {
                using (FileStream fs = new FileStream(_xmlFileName, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Shop>));
                    _shops = (List<Shop>)serializer.Deserialize(fs);
                }
            }
        }
    }
}
