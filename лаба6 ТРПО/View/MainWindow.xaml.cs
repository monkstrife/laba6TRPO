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
using лаба6_ТРПО.Model;
using лаба6_ТРПО.ViewModel;

namespace лаба6_ТРПО
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    // ((MainWindow)System.Windows.Application.Current.MainWindow).TextBlock1.Text = "Setting Text from My Program";
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new AllViewModel();
            Resources.Add("column1", "Имя");
            Resources.Add("column2", "Группа");
            Resources.Add("column3", "Факультет");
            c1.Text = (string)Resources["column1"];
            c2.Text = (string)Resources["column2"];
            c3.Text = (string)Resources["column3"];

        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Resources["WidthItem"] = ActualWidth  * 0.175;
            Resources["HeightItem"] = ActualHeight * 0.06;
        }

        private void lbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var Allitem = (ListBox)sender;
            var selItem = (BaseClass)Allitem.SelectedItem;
        }
    }
}