using System.Windows;

namespace WpfTasks
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenTask1_Click(object sender, RoutedEventArgs e)
        {
            Task1Window task1 = new Task1Window();
            task1.Show();
        }

        private void OpenTask2_Click(object sender, RoutedEventArgs e)
        {
            Task2Window task2 = new Task2Window();
            task2.Show();
        }

        private void OpenTask3_Click(object sender, RoutedEventArgs e)
        {
            Task3Window task3 = new Task3Window();
            task3.Show();
        }

        private void OpenTask4_Click(object sender, RoutedEventArgs e)
        {
            Task4Window task4 = new Task4Window();
            task4.Show();
        }
    }
}
