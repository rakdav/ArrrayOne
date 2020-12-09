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

namespace ArrrayOne
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] mas;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = int.Parse(Razmer.Text);
                mas = new int[n];
                Random rnd = new Random();
                string res = "";
                for(int i=0;i<mas.Length;i++)
                {
                    mas[i] = rnd.Next(-10,11);
                    res += mas[i] + " ";
                }
                Result.Text = "Сгенерированный массив:" +
                    Environment.NewLine + res+Environment.NewLine;
                Buttons.IsEnabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int max, min;
            max = min = mas[0];
            for(int i=0;i<mas.Length;i++)
            {
                if (mas[i] < min) min = mas[i];
                if (mas[i] > max) max = mas[i];
            }
            Result.Text += "Максимальный элемент массива:" + max + Environment.NewLine +
                        "Минимальный элемент массива:" + min + Environment.NewLine;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int S = 0;
            for(int i=0;i<mas.Length;i++)
            {
                S += mas[i];
            }
            Result.Text += "Сумма элементов массива:" +S+Environment.NewLine;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Buttons.IsEnabled = false;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = int.Parse(N.Text);
                Result.Text+="Последнее вхождение элемента " + n + " в массив:" + Array.LastIndexOf(mas,n)+Environment.NewLine;
                int k = 0;
                foreach(int i in mas)
                {
                    if (i < n) k++;
                }
                Result.Text += "Количество элементов меньших " + n + ":"+k+Environment.NewLine;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
