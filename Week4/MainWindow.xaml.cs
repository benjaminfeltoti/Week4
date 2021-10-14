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

namespace Week4
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

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            if (tgglBttn.IsChecked == true)
            {
                tltpHome.Visibility = Visibility.Collapsed;
                tltpContacts.Visibility = Visibility.Collapsed;
                tltpMessages.Visibility = Visibility.Collapsed;
                tltpMaps.Visibility = Visibility.Collapsed;
                tltpSettings.Visibility = Visibility.Collapsed;
                tltpSignOut.Visibility = Visibility.Collapsed;
            }
            else
            {
                tltpHome.Visibility = Visibility.Visible;
                tltpContacts.Visibility = Visibility.Visible;
                tltpMessages.Visibility = Visibility.Visible;
                tltpMaps.Visibility = Visibility.Visible;
                tltpSettings.Visibility = Visibility.Visible;
                tltpSignOut.Visibility = Visibility.Visible;
            }
        }

        private void tgglBttn_Unchecked(object sender, RoutedEventArgs e) 
        {
            imgBackGround.Opacity = 1;
        }

        private void tgglBttn_Checked(object sender, RoutedEventArgs e)
        {
            imgBackGround.Opacity = 0.3;
        }

        private void bckgrnd_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tgglBttn.IsChecked = false;
        }

        private void closeBttn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
