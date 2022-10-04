using _02_DependencyInjection.WPF.Services;
using System;
using System.Collections.Generic;
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

namespace _02_DependencyInjection.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IFileManager _fileManager;

        public MainWindow(IFileManager fileManager)
        {
            InitializeComponent();
            _fileManager = fileManager;
            tb_FilePath.Text = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\file.txt";
        }

        private async void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            await _fileManager.SaveAsync(tb_FilePath.Text, tb_Text.Text);
            tb_Text.Text = "";
        }
    }
}
