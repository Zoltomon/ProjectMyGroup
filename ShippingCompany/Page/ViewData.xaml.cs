using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using Newtonsoft.Json;
using ShippingCompany.ClassHelper;

namespace ShippingCompany.Page
{
    /// <summary>
    /// Логика взаимодействия для ViewData.xaml
    /// </summary>
    public partial class ViewData 
    {
        public ViewData()
        {
            InitializeComponent();
        }

        public async void GetUsers()
        {
            try
            {
                string url = $"http://spacebaikals.ru/Zolto/users";
                HttpClient client = new HttpClient();

                var response = await client.GetAsync(url);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var _clients = JsonConvert.DeserializeObject<List<UserClass>>(responseContent);
                    GridList.ItemsSource = _clients.ToList();
                }
                else
                {
                    MessageBox.Show("Данные обработать нельзя!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public async void GetUser()
        {
            try
            {
                SignIn signIn = new SignIn();
                string url = $"http://spacebaikals.ru/Zolto/page/user/{signIn.IdUser}";
                HttpClient client = new HttpClient();

                var response = await client.GetAsync(url);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var _client = JsonConvert.DeserializeObject<ViewPersonalInfo>(responseContent);
                   
                }
                else
                {
                    MessageBox.Show("Данные обработать нельзя!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}
