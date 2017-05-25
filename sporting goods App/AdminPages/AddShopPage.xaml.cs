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
    /// Логика взаимодействия для AddShopPage.xaml
    /// </summary>
    public partial class AddShopPage : Page
    {
        Repository _repository;
        public AddShopPage(Repository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void btnShopAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Необходимо ввести название магазина");
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Необходимо ввести адрес магазина");
                txtAddress.Focus();
                return;
            }
            try
            {
                Shop newShop = new Shop(txtAddress.Text, txtName.Text);
                _repository.AddShop(newShop);
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
