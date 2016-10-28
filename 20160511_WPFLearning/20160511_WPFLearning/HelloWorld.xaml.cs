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
    /// HelloWorld.xaml の相互作用ロジック
    /// </summary>
    public partial class HelloWorld : Page
    {
        public HelloWorld()
        {
            InitializeComponent();
            txbox1.Text = DateTime.Now.ToString();
        }
    }
}
