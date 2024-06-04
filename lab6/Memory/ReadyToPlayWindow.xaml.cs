using System.Windows;

namespace Memory
{
    public partial class ReadyToPlayWindow : Window
    {
        private Game game;

        public ReadyToPlayWindow(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            if (game.Items != null && game.Items.Count > 0)
            {
                GameWindow gameWindow = new GameWindow(game);
                gameWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Список предметов пустой. Невозможно начать игру.");
            }
        }
    }
}
