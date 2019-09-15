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

namespace Module_Motor_DC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModels.DataViewModel data = new ViewModels.DataViewModel();
        public MainWindow()
        {
            InitializeComponent();
            data.Initialize();
            data.Add(0, 300, 0, 0, 0, 0);
            data.Add(1, 400, 0, 0, 0, 0);
            data.Add(2, 500, 0, 0, 0, 0);
            SpeedViewControl.DataContext = data;
            PIDViewControl.DataContext = data;
            PIDComponentViewControl.DataContext = data;
        }

        private void PortBox_DropDownOpened(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ConnectBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReadBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WriteBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
