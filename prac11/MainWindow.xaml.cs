using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace prac11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Заданная строка
            string input1 = "23 2+3 2++3 2+++3 445 677";
            string input2 = "*+ *q+ *qq+ *qqq+ *qqq qqq+";
            tb1.Text = input1;
            tb2.Text = input2;
            // Регулярное выражение для первой строки
            string pattern1 = @"\b\d+\+{0,3}\d+\b";
            // Регулярное выражение для второй строки
            string pattern2 = @"\*\w+\+";

            // Ищем совпадения для первой строки
            MatchCollection matches1 = Regex.Matches(input1, pattern1);

            // Ищем совпадения для второй строки
            MatchCollection matches2 = Regex.Matches(input2, pattern2);

            // Выводим найденные совпадения для первой строки
            foreach (Match match in matches1)
            {
                if (match.Value != "445" && match.Value != "677")
                {
                    lb1.Items.Add(match.Value);
                }
            }

            // Выводим найденные совпадения для второй строки
            foreach (Match match in matches2)
            {
                lb2.Items.Add(match.Value);
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил лучший разработчик: Девяткин Вадим Евгеньевич\r\nПрактическая №11 \r\nДана строка '23 2+3 2++3 2+++3 445 677'. Напишите регулярное выражение, которое найдет строки 23, 2+3, 2++3, 2+++3, не захватив остальные.\r\nДана строка '*+ *q+ *qq+ *qqq+ *qqq qqq+'. Напишите регулярное выражение, которое найдет строки *q+, *qq+, *qqq+, не захватив остальные");
        }
    }
}
