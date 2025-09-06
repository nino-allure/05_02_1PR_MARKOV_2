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

namespace TONYMONTANA
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

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TextBoxX.Text, out double xValue) && double.TryParse(TextBoxX.Text, out double yValue) && double.TryParse(TextBoxX.Text, out double zValue))
            {
                double result = ((xValue * xValue) - (7 * xValue) + 10) / ((xValue * xValue) - (8 * xValue) + 12);
                resultLabel.Content = result;
            }
            else { )
                //nice!

        }
    }
}
