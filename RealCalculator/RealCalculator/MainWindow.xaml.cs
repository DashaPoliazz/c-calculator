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

namespace RealCalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TextBoxValue1.Text = "10";
            TextBoxValue2.Text = "2";
            TextBoxResult.Text = "Result";

            ButtonPlus.Click += ButtonPlus_Click;
            ButtonMinus.Click += ButtonMinus_Click;
            ButtonMultiply.Click += ButtonMultiply_Click;
            ButtonDivide.Click += ButtonDivide_Click;
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            decimal value1 = Convert.ToDecimal(TextBoxValue1.Text);
            decimal value2 = Convert.ToDecimal(TextBoxValue2.Text);

            decimal valueOut = value1 / value2;

            TextBoxSymbol.Text = "/";
            TextBoxResult.Text = valueOut.ToString();
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            decimal value1 = Convert.ToDecimal(TextBoxValue1.Text);
            decimal value2 = Convert.ToDecimal(TextBoxValue2.Text);

            decimal valueOut = value1 * value2;

            TextBoxSymbol.Text = "*";
            TextBoxResult.Text = valueOut.ToString();
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            decimal value1 = Convert.ToDecimal(TextBoxValue1.Text);
            decimal value2 = Convert.ToDecimal(TextBoxValue2.Text);

            decimal valueOut = value1 - value2;

            TextBoxSymbol.Text = "-";
            TextBoxResult.Text = valueOut.ToString();
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            decimal value1 = Convert.ToDecimal(TextBoxValue1.Text);
            decimal value2 = Convert.ToDecimal(TextBoxValue2.Text);

            decimal valueOut = value1 + value2;

            TextBoxSymbol.Text = "+";
            TextBoxResult.Text = valueOut.ToString();

        }
    }
}
