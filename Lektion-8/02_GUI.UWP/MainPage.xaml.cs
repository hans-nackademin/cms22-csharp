using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _02_GUI.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
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
