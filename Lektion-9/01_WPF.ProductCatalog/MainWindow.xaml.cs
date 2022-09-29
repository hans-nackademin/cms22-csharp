using _01_WPF.ProductCatalog.Models;
using _01_WPF.ProductCatalog.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _01_WPF.ProductCatalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Product> _products = new ObservableCollection<Product>();
        private FileManager _fileManager = new FileManager();
        private string _filePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\wpf.json";

        public MainWindow()
        {
            InitializeComponent();

            UpdateProductCatalog();
        }

        private void UpdateProductCatalog()
        {
            try
            {
                var list = 

                _products = JsonConvert.DeserializeObject<ObservableCollection<Product>>(_fileManager.Read(_filePath));
                lvProducts.ItemsSource = _products.OrderByDescending(x => x.Created);
            }
            catch { }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var product = new Product();
            product.Name = tbProductName.Text;
            product.Price = decimal.Parse(tbProductPrice.Text);

            _products.Add(product);
            _fileManager.Save(_filePath, JsonConvert.SerializeObject(_products));

            tbProductName.Text = "";
            tbProductPrice.Text = "";

            UpdateProductCatalog();
        }
    }
}
