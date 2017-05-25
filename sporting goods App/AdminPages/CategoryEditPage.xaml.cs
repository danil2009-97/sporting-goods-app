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
    /// Логика взаимодействия для CategoryEditPage.xaml
    /// </summary>
    public partial class CategoryEditPage : Page
    {
        private Repository _repository;
        private Category _category;

        public CategoryEditPage(Repository repository, Category category)
        {
            InitializeComponent();

            _repository = repository;
            _category = category;
           
            textBoxName.Text = _category.Name;
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Необходимо ввести название категории");
                textBoxName.Focus();
                return;
            }
            _repository.EditCategory(_category, textBoxName.Text);
            NavigationService.GoBack();
        }
    }
}
