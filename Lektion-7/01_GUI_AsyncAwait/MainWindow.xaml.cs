using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace _01_GUI_AsyncAwait
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBlockingCode_Click(object sender, RoutedEventArgs e)
        {
            tblockStatus.Text = "";
            tblockStatus.Text += "Downloading...\n";
            Thread.Sleep(5000);
            tblockStatus.Text += "Installing...\n";
            Thread.Sleep(5000);
            tblockStatus.Text += "Installation completed";
        }

        private async void btnNonBlockingCode_Click(object sender, RoutedEventArgs e)
        {
            tblockStatus.Text = "";
            tblockStatus.Text += "Downloading...\n";
            await Task.Delay(5000);
            tblockStatus.Text += "Installing...\n";
            await Task.Delay(5000);
            tblockStatus.Text += "Installation completed";
            
        }
    }
}
