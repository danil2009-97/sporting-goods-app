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
    /// Логика взаимодействия для GuestProductPage.xaml
    /// </summary>
    public partial class GuestProductPage : Page
    {
        public GuestProductPage(Product product)
        {
            InitializeComponent();
            labelName.Content = product.Name;
            labelDescription.Content = product.Description;
        }
    }
}
