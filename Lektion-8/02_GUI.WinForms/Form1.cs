using System.Diagnostics;

namespace _02_GUI.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OrderAsync().ConfigureAwait(false);
        }

        private void btnBlocking_Click(object sender, EventArgs e)
        {
            OrderAsync().ConfigureAwait(false);
        }

        private async void btnNonBlocking_Click(object sender, EventArgs e)
        {
            await OrderAsync();
        }


        private async Task OrderAsync()
        {
            labelStatus.Text = "";
            await Task.Delay(4000);
            labelStatus.Text = "Din beställning är skickad.";

            await Task.Delay(2000);
            Debug.WriteLine("Din beställning är mottagen.");
            labelStatus.Text = "Din beställning är mottagen.";


            await Task.Delay(2000);
            Debug.WriteLine("Din beställning tillagas.");
            labelStatus.Text = "Din beställning tillagas.";


            await Task.Delay(5000);
            Debug.WriteLine("Din beställning är klar för leverans");
            labelStatus.Text = "Din beställning är klar för leverans";

            await Task.Delay(2000);
            labelStatus.Text = "Din mat är nu leverarad.";
        }
    }
}
