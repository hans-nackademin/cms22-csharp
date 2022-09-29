using _01_Communication.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
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

namespace _01_Communication.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string url = "https://localhost:7028/api/contacts";

        public MainWindow()
        {
            InitializeComponent();

        }

        private async void btnSend_Click(object sender, RoutedEventArgs e)
        {
            var contact = new ContactPerson(tbFirstName.Text, tbLastName.Text, tbStreetName.Text, tbPostalCode.Text, tbCity.Text);

            using var http = new HttpClient();
            await http.PostAsJsonAsync(url, contact);

            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbStreetName.Text = "";
            tbPostalCode.Text = "";
            tbCity.Text = "";
        }
    }
}
