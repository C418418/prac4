using System;
using System.Windows;

namespace WpfTasks
{
    public partial class Task3Window : Window
    {
        public Task3Window()
        {
            InitializeComponent();
        }

        private void CalculateSum_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(NInput.Text, out int n))
            {
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
                ResultLabel.Content = $"Сумма от 1 до {n}: {sum}";
            }
            else
            {
                ResultLabel.Content = "Введите корректное число.";
            }
        }
    }
}
