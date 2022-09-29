using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace _02_GUI.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OrderAsync().ConfigureAwait(false);
        }

        private void btnBlockingCode_Click(object sender, RoutedEventArgs e)
        {
            OrderAsync();
        }

        private async void btnNonBlockingCode_Click(object sender, RoutedEventArgs e)
        {
            await OrderAsync();
        }

        private async Task OrderAsync()
        {
            tblockStatus.Text = "";
            await Task.Delay(4000);
            tblockStatus.Text = "Din beställning är skickad.";

            await Task.Delay(2000);
            Debug.WriteLine("Din beställning är mottagen.");
            tblockStatus.Text = "Din beställning är mottagen.";


            await Task.Delay(2000);
            Debug.WriteLine("Din beställning tillagas.");
            tblockStatus.Text = "Din beställning tillagas.";


            await Task.Delay(5000);
            Debug.WriteLine("Din beställning är klar för leverans");
            tblockStatus.Text = "Din beställning är klar för leverans";

            await Task.Delay(2000);
            tblockStatus.Text = "Din mat är nu leverarad.";
        }

    }
}
