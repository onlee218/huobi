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
using Huobi.Rest.CSharp.Demo;
using Huobi.Rest.CSharp.Demo.Model;

namespace Wpftest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        HuobiApi api = new HuobiApi("11573ab9-2b59a811-48f6d01a-a431b", "c1db909f-99d7feaa-101233a7-7a7d3");

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = api.GetAllAccount();
        }
    }
}
