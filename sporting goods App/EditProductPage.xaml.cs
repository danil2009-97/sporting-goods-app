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
    /// Логика взаимодействия для EditProductPage.xaml
    /// </summary>
    public partial class EditProductPage : Page
    {
        Repository _repository;
        Product _product;
        Shop _shop;

        public EditProductPage(Repository repository, Product product, Shop shop)
        {
            InitializeComponent();
            _repository = repository;
            _product = product;
            _shop = shop;
            textBoxName.Text = _product.Name;
            textBoxDescription.Text = _product.Description;
            categoryComboBox.ItemsSource = _shop.Categories;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            _repository.EditProduct(_product, textBoxName.Text, textBoxDescription.Text);
            NavigationService.GoBack();
        }
    }
}
