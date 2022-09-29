using _00_Repetition.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _00_Repetition
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ActivityItem> activities;

        public MainWindow()
        {
            InitializeComponent();
            activities = new ObservableCollection<ActivityItem>();

            if (activities.Count > 0)
                lvItems.ItemsSource = activities.OrderByDescending(x => x.Created);
            else
                lvItems.ItemsSource = activities;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
                AddToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var obj = (Button)sender;
            var activity = (ActivityItem)obj.DataContext;
            activities.Remove(activity);
            lvItems.ItemsSource = activities.OrderByDescending(x => x.Created);
        }

        private void btnComplete_Click(object sender, RoutedEventArgs e)
        {
            var obj = (Button)sender;
            var activity = (ActivityItem)obj.DataContext;
            activity.IsCompleted = true;

            activities.Remove(activity);
            activities.Add(activity);
            lvItems.ItemsSource = activities.OrderByDescending(x => x.Created);
        }


        private void AddToList()
        {
            if (!string.IsNullOrEmpty(tbActivity.Text))
            {
                activities.Add(new ActivityItem { Text = tbActivity.Text });
                tbActivity.Text = "";
                lvItems.ItemsSource = activities.OrderByDescending(x => x.Created);
            }
        }

        private void tbActivity_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
                AddToList();
        }
    }
}
