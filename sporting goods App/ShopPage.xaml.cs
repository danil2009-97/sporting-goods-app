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
    /// Логика взаимодействия для ShopPage.xaml
    /// </summary>
    public partial class ShopPage : Page
    {
        Repository _repository = new Repository();
        public ShopPage()
        {
            InitializeComponent();
            shopList.ItemsSource = _repository.Shops;
            _repository.CategoryAdded += c => shopList.Items.Refresh();
        }

        private void shopList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnShopAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddShopPage(_repository));
        }

        private void btnShopRemove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtShopFound_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnCatalog_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage(_repository));
        }

        private void addressList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
