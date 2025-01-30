using System;
using System.Windows;

namespace WpfTasks
{
    public partial class Task4Window : Window
    {
        public Task4Window()
        {
            InitializeComponent();
        }
        private void CalculateBonus_Click(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(SalaryInput.Text, out decimal salary) && int.TryParse(YearsOfServiceInput.Text, out int yearsOfService))
            {
                decimal bonusPercentage = yearsOfService switch
                {
                    < 5 => 0.10m,
                    < 10 => 0.15m,
                    < 15 => 0.25m,
                    < 20 => 0.35m,
                    < 25 => 0.45m,
                    _ => 0.50m,
                };

                decimal bonus = salary * bonusPercentage;
                ResultBonusLabel.Content = $"Премия: {bonus:C}";
            }
            else
            {
                MessageBox.Show("Введите корректные значения.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
