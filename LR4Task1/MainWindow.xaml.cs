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

namespace LR4Task1
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

        private void button_found_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Double.Parse(A.Text);
                double b = Double.Parse(B.Text);
                double c = Double.Parse(C.Text);
                double d = Math.Round((Math.Pow(b, 2) - 4 * a * c), 2);
                //Не добавлен обработчик случая, когда дискриминант = 0 (d>=0)
                if (d > 0)
                {
                    double x1 = Math.Round((-b + Math.Sqrt(d)) / (2 * a), 2);
                    double x2 = Math.Round((-b - Math.Sqrt(d)) / (2 * a), 2);
                    //Нарушение логики формулы формулы, в этом месте (x1 - c) должен быть "+"
                    double r1 = Math.Round((a * Math.Pow(x1, 2) + b * x1 - c), 2);
                    double r2 = Math.Round((a * Math.Pow(x2, 2) + b * x2 - c), 2);
                    X1.Content = $"Значение x1: {x1}";
                    X2.Content = $"Значение x2: {x2}";
                    D.Content = $"Значение дискриминанта: {d}";
                    Testx1.Content = $"Подстановка первого корня: {r1}";
                    //Не выводиться второй корень, вместо r1 должен быть r2
                    Testx2.Content = $"Подстановка второго корня: {r1}";
                }
                else
                {
                    X1.Content = "Корней нет";
                    X2.Content = "Корней нет";
                    D.Content = d.ToString();
                    Testx1.Content = "Корней нет";
                    Testx2.Content = "Корней нет";
                }
            }
            catch
            {
                MessageBox.Show("Введены некорректные значения переменных!");
            }
        }
    }
}
