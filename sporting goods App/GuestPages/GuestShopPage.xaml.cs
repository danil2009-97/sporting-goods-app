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
    /// Логика взаимодействия для GuestShopPage.xaml
    /// </summary>
    public partial class GuestShopPage : Page
    {
        Repository _repository = new Repository();
        
        public GuestShopPage()
        {
            InitializeComponent();
            shopList.ItemsSource = _repository.Shops;
           
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
                NavigationService.Navigate(new GuestMainPage(_repository, shopList.SelectedItem as Shop));
        }
    }
}
