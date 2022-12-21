using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace ShippingCompany.Page.Profile
{
    /// <summary>
    /// Логика взаимодействия для UserProfile.xaml
    /// </summary>
    public partial class UserProfile 
    {
        public UserProfile(string name)
        {
            InitializeComponent();
            TxbUser.Text = name;
        }
    }
}
