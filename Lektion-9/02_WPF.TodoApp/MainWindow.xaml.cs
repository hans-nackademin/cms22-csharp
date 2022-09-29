using _02_WPF.TodoApp.Services;
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
using System.Windows.Threading;

namespace _02_WPF.TodoApp
{
    enum State
    {
        Idle,
        Saving,
        Saved,
        SavedFailed,
        Removing,
        Removed,
        RemovedFailed
    }



    public partial class MainWindow : Window
    {
        private static State _state = State.Saving;


        public MainWindow()
        {
            InitializeComponent();
            StateTimer();
        }

        private void StateTimer()
        {
            DispatcherTimer timer = new()
            {
                Interval = TimeSpan.FromMilliseconds(500)
            };
            timer.Tick += StateTimer_Tick;
            timer.Start();
        }

        private void StateTimer_Tick(object sender, EventArgs e)
        {
            tblockStatusMessage.Text = TodoService.StateMessage(_state);
        }







        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
