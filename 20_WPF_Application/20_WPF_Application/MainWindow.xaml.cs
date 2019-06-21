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

namespace _20_WPF_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool status = false;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Background = ((App)Application.Current).Settings.color;
            Width = ((App)Application.Current).Settings.width;
            Height = ((App)Application.Current).Settings.height;
            Top = ((App)Application.Current).Settings.top;
            Left = ((App)Application.Current).Settings.left;

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            ((App)Application.Current).Settings.color = Background;
            ((App)Application.Current).Settings.width = Width;
            ((App)Application.Current).Settings.height = Height;
            ((App)Application.Current).Settings.top = Top;
            ((App)Application.Current).Settings.left = Left;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (status)
            {
                Background = Brushes.Blue;
                status = false;
            }
            else
            {
                Background = Brushes.Red;
                status = true;
            }
        }
    }
}
