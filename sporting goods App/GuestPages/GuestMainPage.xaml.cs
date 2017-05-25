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
    /// Логика взаимодействия для GuestMainPage.xaml
    /// </summary>
    public partial class GuestMainPage : Page
    {
        Repository _repository;
        Shop _shop;

        public GuestMainPage(Repository repository, Shop shop)
        {
            _repository = repository;
            _shop = shop;

            InitializeComponent();
            CategoryList.ItemsSource = _shop.Categories;
        }

        bool _categoryEntered = false;

        private void txtGuestCategoryFound_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!_categoryEntered)
            {
                _categoryEntered = true;
                txtGuestCategoryFound.Text = "";
                txtGuestCategoryFound.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void txtGuestCategoryFound_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGuestCategoryFound.Text))
                _categoryEntered = true;
            else
            {
                _categoryEntered = false;
                txtGuestCategoryFound.Text = "Введите категорию";
                txtGuestCategoryFound.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        bool _productEntered = false;

        private void txtGuestProductFound_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!_productEntered)
            {
                _productEntered = true;
                txtGuestProductFound.Text = "";
                txtGuestProductFound.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void txtGuestProductFound_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGuestProductFound.Text))
                _productEntered = true;
            else
            {
                _productEntered = false;
                txtGuestProductFound.Text = "Введите продукт";
                txtGuestProductFound.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void CategoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CategoryList.SelectedIndex != -1)
                ProductList.ItemsSource = (CategoryList.SelectedItem as Category).Products;
            else
                ProductList.ItemsSource = null;
        }


        private void ProductList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (ProductList.SelectedIndex != -1)
            {
                Product selected = ProductList.SelectedItem as Product;
                NavigationService.Navigate(new GuestProductPage(selected));
            }
        }

        private void txtGuestCategoryFound_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CategoryList == null)
                return;

            string input = txtGuestCategoryFound.Text;

            if (!_categoryEntered)
                CategoryList.ItemsSource = _shop.Categories;
            else
                CategoryList.ItemsSource = _repository.FindCategories(_shop, input);
        }

        private void txtGuestProductFound_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CategoryList == null)
                return;

            if (CategoryList.SelectedIndex != -1)
            {
                string text = txtGuestProductFound.Text;

                Category selected = CategoryList.SelectedItem as Category;

                if (!_productEntered)
                    ProductList.ItemsSource = selected.Products;
                else
                    ProductList.ItemsSource = _repository.FindProducts(selected, text);
            }
        }

    }
}
