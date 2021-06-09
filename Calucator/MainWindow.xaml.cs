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
using System.Windows.Automation;

namespace Calucator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        
        }



        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            Calc calc = new Calc(Convert.ToDouble(tbx_a_param.Text), Convert.ToDouble(tbx_b_param.Text));
            result.Text = calc.AddNumber().ToString();
        }

        private void btn_devide_Click(object sender, RoutedEventArgs e)
        {
            Calc calc = new Calc(Convert.ToDouble(tbx_a_param.Text), Convert.ToDouble(tbx_b_param.Text));
            result.Text = calc.DevideNumber().ToString();
        }

        private void btn_suspension_Click(object sender, RoutedEventArgs e)
        {
            Calc calc = new Calc(Convert.ToDouble(tbx_a_param.Text), Convert.ToDouble(tbx_b_param.Text));
            result.Text = calc.SuspensionNumber().ToString();
        }

        private void btn_multiple_Click(object sender, RoutedEventArgs e)
        {
            Calc calc = new Calc(Convert.ToDouble(tbx_a_param.Text), Convert.ToDouble(tbx_b_param.Text));
            result.Text = calc.MultpileNumber().ToString();
        }

        





    }
}
