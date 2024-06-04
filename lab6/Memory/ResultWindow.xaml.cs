using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Memory
{
    public partial class ResultWindow : Window
    {
        public ResultWindow(Dictionary<int, int> playerResults)
        {
            InitializeComponent();

            var sortedResults = playerResults.OrderByDescending(pair => pair.Value);

            ResultsDataGrid.ItemsSource = sortedResults;
        }

        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
