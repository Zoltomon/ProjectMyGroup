using Newtonsoft.Json;
using ShippingCompany.ClassHelper;
using ShippingCompany.Page.AddPage;
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

namespace ShippingCompany.Page.DataView
{
    /// <summary>
    /// Логика взаимодействия для DataViewCruise.xaml
    /// </summary>
    public partial class DataViewCruise
    {
        public DataViewCruise()
        {
            InitializeComponent();
            GetCruise();
        }

        public async void GetCruise()
        {
            try
            {
                string url = $"http://spacebaikals.ru/Zolto/dataCruise";
                HttpClient client = new HttpClient();

                var response = await client.GetAsync(url);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var _clients = JsonConvert.DeserializeObject<List<ClassCruise>>(responseContent);
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

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.GoBack();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCreateCruise_Click_1(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.Navigate(new AddCruise());
        }
    }
}
