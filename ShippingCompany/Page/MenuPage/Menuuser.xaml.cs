using ShippingCompany.ClassHelper;
using ShippingCompany.Page.Profile;
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

namespace ShippingCompany.Page.DataView
{
    /// <summary>
    /// Логика взаимодействия для Menuuser.xaml
    /// </summary>
    public partial class Menuuser 
    {
        public Menuuser(string nameUser)
        {
            InitializeComponent();
           TxbUser.Text = "Приветствую клиент " + nameUser + "!";
        }

        private void BtnCruise_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.Navigate(new ClientUser());
        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.GoBack();
        }

        private void BtnUserProfile_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.Navigate(new UserProfile(TxbUser.Text));
        }
    }
}
