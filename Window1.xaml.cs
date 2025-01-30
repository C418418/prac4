using System;
using System.Windows;

namespace WpfTasks
{
    public partial class Task1Window : Window
    {
        public Task1Window()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(AInput.Text, out int A) && int.TryParse(BInput.Text, out int B))
            {
                if (A < B)
                {
                    int sum = 0;
                    for (int i = A + 1; i < B; i++)
                    {
                        sum += i;
                    }
                    ResultTextBlock.Text = $"Сумма чисел между {A} и {B}: {sum}\nНечетные числа: ";
                    for (int i = A + 1; i < B; i++)
                    {
                        if (i % 2 != 0)
                        {
                            ResultTextBlock.Text += $"{i} ";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка: A должно быть меньше B.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числа.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
