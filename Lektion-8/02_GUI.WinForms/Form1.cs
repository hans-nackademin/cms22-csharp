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
            labelStatus.Text = "Din best�llning �r skickad.";

            await Task.Delay(2000);
            Debug.WriteLine("Din best�llning �r mottagen.");
            labelStatus.Text = "Din best�llning �r mottagen.";


            await Task.Delay(2000);
            Debug.WriteLine("Din best�llning tillagas.");
            labelStatus.Text = "Din best�llning tillagas.";


            await Task.Delay(5000);
            Debug.WriteLine("Din best�llning �r klar f�r leverans");
            labelStatus.Text = "Din best�llning �r klar f�r leverans";

            await Task.Delay(2000);
            labelStatus.Text = "Din mat �r nu leverarad.";
        }
    }
}
