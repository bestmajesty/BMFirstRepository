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

namespace _20160511_WPFLearning
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    button_1.Background =Brushes.Red;
        //}

        private void MainWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Really close?","Yes",MessageBoxButton.YesNo)==MessageBoxResult.No)
            {
                e.Cancel=true;
            }
        }
    }
}
