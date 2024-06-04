using System.Windows;

namespace Memory
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CreateGame_Click(object sender, RoutedEventArgs e)
        {
            CreateGameWindow createGameWindow = new CreateGameWindow();
            createGameWindow.Show();
            Close();
        }

        private void ExitGame_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
