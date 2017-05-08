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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        Repository _repository = new Repository();
        public MainPage()
        {
            InitializeComponent();
            categoryList.ItemsSource = _repository.Categories;
            _repository.CategoryAdded += c => categoryList.Items.Refresh();
            _repository.ProductAdded += p => categoryList.SelectedIndex = -1;
        }

        private void btnCategoryAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CategoryPage(_repository));
        }

        private void btnCategoryRemove_Click(object sender, RoutedEventArgs e)
        {
            if(categoryList.SelectedIndex != -1)
            {
                _repository.RemoveCategory(categoryList.SelectedItem as Category);
                categoryList.Items.Refresh();
            }
        }

        private void btnProductAdd_Click(object sender, RoutedEventArgs e)
        {
            if(_repository.Categories.Count < 1)
            {
                MessageBox.Show("Для добавления продукта должна быть хотя бы одна категория!");
                return;
            }
            NavigationService.Navigate(new ProductPage(_repository));
        }

        private void btnProductRemove_Click(object sender, RoutedEventArgs e)
        {
            if(categoryList.SelectedIndex != -1)
            {
                _repository.RemoveProduct(productList.SelectedItem as Product);
                productList.ItemsSource = _repository.FindProductsOfCategory(categoryList.SelectedItem as Category);
            }
        }

        private void categoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnCategoryRemove.IsEnabled = categoryList.SelectedIndex != -1;

            if (categoryList.SelectedIndex != -1)
                productList.ItemsSource = _repository.FindProductsOfCategory(categoryList.SelectedItem as Category);
            else
                productList.ItemsSource = null;
        }

        private void productList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnProductRemove.IsEnabled = productList.SelectedIndex != -1;
        }

        private void btnCategoryEdit_Click(object sender, RoutedEventArgs e)
        {
            btnCategoryEdit.IsEnabled = categoryList.SelectedIndex != -1;
        }

        private void btnProductEdit_Click(object sender, RoutedEventArgs e)
        {
            btnProductEdit.IsEnabled = productList.SelectedIndex != -1;
        }

        private void txtCategoryFound_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = txtCategoryFound.Text;
            if (text == "")
                categoryList.ItemsSource = _repository.Categories;
            else
                categoryList.ItemsSource = _repository.FindCategories(text);
        }

        private void txtProductFound_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = txtProductFound.Text;

            if (text == "")
                productList.ItemsSource = _repository.Products;
            else
                productList.ItemsSource = _repository.FindProducts(text);
        }
    }
}
