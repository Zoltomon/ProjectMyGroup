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
using ShippingCompany.ClassHelper;

namespace ShippingCompany.Page
{
    /// <summary>
    /// Логика взаимодействия для MenuAdmin.xaml
    /// </summary>
    public partial class MenuAdmin
    {
        public MenuAdmin(string login)
        {
            InitializeComponent();
            TxbLoginUser.Text = login;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.Navigate(new MenuAdd());
        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.GoBack();
        }

        private void BtnUser_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.Navigate(new ViewData());
        }
    }
}
