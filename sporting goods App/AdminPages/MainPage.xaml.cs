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
        Repository _repository;
        Shop _shop;

        public MainPage(Repository repository, Shop shop)
        {
            InitializeComponent();
            _repository = repository;
            _shop = shop;
            categoryList.ItemsSource = _shop.Categories;
            _repository.CategoryAdded += c => categoryList.Items.Refresh();
            _repository.ProductAdded += p => categoryList.SelectedIndex = -1;
        }

        private void btnCategoryAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CategoryPage(_repository, _shop));
        }

        private void btnCategoryRemove_Click(object sender, RoutedEventArgs e)
        {
            if (categoryList.SelectedIndex != -1)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить эту категорию?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                    return;

                _repository.RemoveCategory(categoryList.SelectedItem as Category, _shop);
                categoryList.Items.Refresh();
            }
        }

        private void btnProductAdd_Click(object sender, RoutedEventArgs e)
        {
            if (_shop.Categories.Count < 1)
            {
                MessageBox.Show("Для добавления продукта должна быть хотя бы одна категория!");
                return;
            }
            NavigationService.Navigate(new ProductPage(_repository, _shop));
        }

        private void btnProductRemove_Click(object sender, RoutedEventArgs e)
        {
            if (productList.SelectedIndex != -1)
            {
                if (MessageBox.Show("Вы уверены,что хотите удалить этот продукт?", "Удаление продукта", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                    return;

                Category selected = categoryList.SelectedItem as Category;
                _repository.RemoveProduct(productList.SelectedItem as Product, selected);
                productList.Items.Refresh();
            }
        }

        private void categoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnCategoryRemove.IsEnabled = categoryList.SelectedIndex != -1;
            btnCategoryEdit.IsEnabled = categoryList.SelectedIndex != -1;

            if (categoryList.SelectedIndex != -1)
                productList.ItemsSource = (categoryList.SelectedItem as Category).Products;
            else
                productList.ItemsSource = null;
        }

       

        private void btnCategoryEdit_Click(object sender, RoutedEventArgs e)
        {
            if (categoryList.SelectedIndex != -1)
            {
                Category selected = categoryList.SelectedItem as Category;
                if (selected != null)
                    NavigationService.Navigate(new CategoryEditPage(_repository, selected));
            }
        }

        private void txtCategoryFound_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = txtCategoryFound.Text;
            if (text == "")
                categoryList.ItemsSource = _shop.Categories;
            else
                categoryList.ItemsSource = _repository.FindCategories(_shop, text);
        }

        private void txtProductFound_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(categoryList.SelectedIndex != -1)
            {
                string text = txtProductFound.Text;

                Category selected = categoryList.SelectedItem as Category;

                if (text == "")
                    productList.ItemsSource = selected.Products;
                else
                    productList.ItemsSource = _repository.FindProducts(selected, text);
            }
            
        }

        private void productList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnProductRemove.IsEnabled = productList.SelectedIndex != -1;
            btnProductEdit.IsEnabled = productList.SelectedIndex != -1;
        }

        private void productList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (productList.SelectedIndex != -1)
            {
                Product selected = productList.SelectedItem as Product;
                NavigationService.Navigate(new GuestProductPage(selected));
            }
        }

        private void btnProductEdit_Click(object sender, RoutedEventArgs e)
        {
            if (productList.SelectedIndex != -1)
            {
                Product selected = productList.SelectedItem as Product;
                if (selected != null)
                    NavigationService.Navigate(new EditProductPage(_repository, selected, _shop));
            }
        }

        
    }
}
