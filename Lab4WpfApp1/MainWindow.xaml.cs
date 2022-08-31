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

namespace Lab4WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Рассчитать_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resultDollar = rateDollar*sumDollar;
            result.Text = resultDollar.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resultEuro = rateEuro * sumEuro;
            result1.Text = resultEuro.ToString();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(rate2.Text);
            double sumGrivna = Convert.ToDouble(sum2.Text);
            double resultGrivna = rateGrivna * sumGrivna;
            result2.Text = resultGrivna.ToString();
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rateDrama = Convert.ToDouble(rate3.Text);
            double sumDrama = Convert.ToDouble(sum3.Text);
            double resultDrama = rateDrama * sumDrama;
            result3.Text = resultDrama.ToString();
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            double valueInch = Convert.ToDouble(value.Text);
            double resultInch = valueInch /39.37;
            result4.Text = resultInch.ToString();
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            double valueFt = Convert.ToDouble(value1.Text);
            double resultFt = valueFt / 3.281;
            result5.Text = resultFt.ToString();
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            double valueMile = Convert.ToDouble(value2.Text);
            double resultMile = valueMile * 1609.345;
            result6.Text = resultMile.ToString();
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            double valueVerst = Convert.ToDouble(value3.Text);
            double resultVerst = valueVerst * 1067;
            result7.Text = resultVerst.ToString();
        }
    }
}
