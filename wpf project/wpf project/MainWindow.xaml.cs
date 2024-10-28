using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_project
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

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            //btnStart.Opacity = .5;
            btnStart.Visibility = Visibility.Hidden;
            MessageBox.Show("Witaj swiecie");
            btnStart.Visibility = Visibility.Visible;
            //btnStart.Opacity = 1;
        }

        private void btnTime_MouseEnter(object sender, MouseEventArgs e)
        {
            DateTime data = DateTime.Now;
            btnTime.Content = data.ToString("T");
        }

        private void btnTime_MouseLeave(object sender, MouseEventArgs e)
        {
            btnTime.Content = "Czas";
        }


        private void btnYes_MouseEnter(object sender, MouseEventArgs e)
        {
            var tmpMargin = btnYes.Margin;
            btnYes.Margin = btnNo.Margin;
            btnNo.Margin = tmpMargin;
        }
    }
}