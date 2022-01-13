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
using Lib_2;

namespace pract_1
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

        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП - 34, Голота, Вариант 2. Вычислить разницу целых случайных чисел, распределенных в диапазоне от 2 до 10, пока эта разница не станет меньше некоторого числа K (K<0). Вывести на экран сгенерированные числа, значение суммы, и количество сгенерированных чисел.");
        }

        private void find(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.Parse(tbk.Text) < 0)
                {
                    var rez = Numbers.Difference(int.Parse(tbk.Text));
                    tbnumbers.Text = rez.Item1;
                    tbdifference.Text = rez.Item2;
                    tbcount.Text = rez.Item3.ToString();
                } else MessageBox.Show("Введите отрицательное число!", "Внимание!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка {ex.Data.ToString()}", "Внимание!");
            }
            
        }
    }
}
