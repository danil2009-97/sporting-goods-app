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
    /// Логика взаимодействия для CategoryPage.xaml
    /// </summary>
    public partial class CategoryPage : Page
    {
        Repository _repository;
        public CategoryPage(Repository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            Category newCategory = new Category(textBoxName.Text);
            _repository.AddCategory(newCategory);
            NavigationService.GoBack();
        }
    }
}
