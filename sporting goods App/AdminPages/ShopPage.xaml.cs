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
                _repository.ShopAdded += p => shopList.Items.Refresh();
        }

        private void shopList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnShopRemove.IsEnabled = shopList.SelectedIndex != -1;

            if (shopList.SelectedIndex != -1)
            {
                Shop selected = shopList.SelectedItem as Shop;
                txtName.Text = selected.Name;
                txtAddress.Text = selected.Address;
                shopBlock.Visibility = Visibility.Visible;
            }
            else
                shopBlock.Visibility = Visibility.Hidden;
        }

        private void btnShopAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddShopPage(_repository));
        }

        private void btnShopRemove_Click(object sender, RoutedEventArgs e)
        {
            if (shopList.SelectedIndex != -1)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить этот магазин?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                    return;

                _repository.RemoveShop(shopList.SelectedItem as Shop);
                shopList.Items.Refresh();
            }
        }

        private void txtShopFound_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = txtShopFound.Text;

            if (text == "")
                shopList.ItemsSource = _repository.Shops;
            else
                shopList.ItemsSource = _repository.FindShops(text);
        }


        private void shopList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (shopList.SelectedIndex != -1)
                NavigationService.Navigate(new MainPage(_repository, shopList.SelectedItem as Shop));
        }
    }
}
