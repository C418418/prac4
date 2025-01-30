using System.Windows;

namespace WpfTasks
{
    public partial class Task2Window : Window
    {
        public Task2Window()
        {
            InitializeComponent();
            for (int i = 10; i <= 20; i++)
            {
                ResultListBox.Items.Add($"{i}^2 = {i * i}");
            }
        }
    }
}
