using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sporting_goods_App
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        Repository _repository;
        Shop _shop;
        public ProductPage(Repository repository, Shop shop)
        {
            InitializeComponent();
            _repository = repository;
            _shop = shop;
            categoryComboBox.ItemsSource = _shop.Categories;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (categoryComboBox.SelectedItem is Category && categoryComboBox.SelectedItem != null)
            {
                Product newProduct = new Product(textBoxName.Text, textBoxDescription.Text);
                _repository.AddProduct(newProduct, categoryComboBox.SelectedItem as Category);
                NavigationService.GoBack();
            }
        }
    }
}
