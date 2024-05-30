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
using WpfDolgozat.Tasks;

namespace WpfDolgozat
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

        private void DragMove_Text(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            Page1 page1Content = new Page1();
            TaskHolder.Content = page1Content;
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            Page2 page2Content = new Page2();
            TaskHolder.Content = page2Content;
        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {
            Page3 page3Content = new Page3();
            TaskHolder.Content = page3Content;

        }
    }
}