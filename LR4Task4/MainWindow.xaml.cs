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

        private void Click_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double s1 = double.Parse(S1.Text);
                double s2 = double.Parse(S2.Text);
                double s3 = double.Parse(S3.Text);

                if(s1==s2 && s2==s3)
                {
                    Result.Content = "Треугольник равносторонний";
                }
                else if(s1!=s2 && s2!=s3)
                {
                    Result.Content = "Треугольник разносторонний";
                }
                else if((s1==s2 && s1!=s3 && s2!=s3) || (s1 == s3 && s1 != s2 && s3 != s2) || (s2 == s3 && s2 != s1 && s3 != s1))
                {
                    //Опечатка, должно бть написано: "Треугольник равнобедренный"
                    Result.Content = "Треугольник равносторонний";
                }
                //Прямоугольный треугольник никогда не выведиться, так как условие находится в конструкции else if,
                //и по этому проверка этого условия не произойдёт из-за условия "разносторонности треугольника"
                else if((Math.Pow(s1,2) == Math.Pow(s2, 2) + Math.Pow(s3, 2)) || 
                    (Math.Pow(s2, 2) == Math.Pow(s1, 2) + Math.Pow(s3, 2)) ||
                    (Math.Pow(s3, 2) == Math.Pow(s1, 2) + Math.Pow(s2, 2)))
                {
                    Result.Content = "Треугольник прямоугольный";
                }
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные!");
            }
        }
    }
}
