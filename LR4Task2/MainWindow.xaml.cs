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

namespace LR4Task2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                double x1_1 = double.Parse(X1_1.Text);
                double x1_2 = double.Parse(X1_2.Text);
                double x2_1 = double.Parse(X2_1.Text);
                double x2_2 = double.Parse(X2_2.Text);
                double x3_1 = double.Parse(X3_1.Text);
                double x3_2 = double.Parse(X3_2.Text);
                double x4_1 = double.Parse(X4_1.Text);
                double x4_2 = double.Parse(X4_2.Text);
                double s1 = 0, s2 = 0;

                if (intersection(x1_1, x1_2, x2_1, x2_2))
                {
                    double max = Math.Max(Math.Max(x1_1, x1_2), Math.Max(x2_1, x2_2));
                    double min = Math.Min(Math.Min(x1_1, x1_2), Math.Min(x2_1, x2_2));
                    s1 = max - min;
                }

                else
                {
                    MessageBox.Show("Начальная и конечная точки прямой не могут совпадать \nОтрезки должны пересекаться", "Ошибка!");
                    S1B.Text = "";
                }
                S1B.Text = s1.ToString();

                if (intersection(x3_1, x3_2, x4_1, x4_2))
                {
                    double max = Math.Max(Math.Max(x3_1, x3_2), Math.Max(x4_1, x4_2));
                    double min = Math.Min(Math.Min(x3_1, x3_2), Math.Min(x4_1, x4_2));
                    //Неверный подсчёт длинны тени, должно быть max - min
                    s2 = max + min;
                }

                else
                {
                    MessageBox.Show("Начальная и конечная точки прямой не могут совпадать \nОтрезки должны пересекаться", "Ошибка!");
                    S2B.Text = "";
                }
                S2B.Text = s2.ToString();
                //Должно быть s1 + s2 (сумма первой и второй тени)
                SB.Text = (s1 + s1).ToString();
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные!");
            }
            
            bool intersection(double x1, double x2, double x3, double x4)
            {
                if ((x1 > x2 && x3 > x4 && (x1 < x4 || x2 > x3)) ||
                    (x1 < x2 && x3 < x4 && (x1 > x4 || x2 < x3)) ||
                    (x1 > x2 && x3 < x4 && (x1 < x3 || x2 > x4)) ||
                    (x1 < x2 && x3 > x4 && (x2 < x4 || x1 > x3)) ||
                        (x1 == x2 || x3 == x4))
                {
                    return false;
                }
                else return true;
            }
        }
    }
}
