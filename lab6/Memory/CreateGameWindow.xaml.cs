using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Memory
{
    public partial class CreateGameWindow : Window
    {
        public CreateGameWindow()
        {
            InitializeComponent();
        }

        private List<Item> GenerateItems()
        {
            List<Item> items = new List<Item>();
            Random random = new Random();

            List<int> randomIndexes = Enumerable.Range(1, 40).OrderBy(x => random.Next()).Take(20).ToList();

            foreach (int index in randomIndexes)
            {
                string imagePath = $"Items/{index}.png";
                items.Add(new Item(index, "ItemNamePlaceholder", imagePath));
            }

            return items;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            int playerCount = (int)PlayerCountSlider.Value;
            List<Item> items = GenerateItems();
            Game game = new Game(1, playerCount, items);

            for (int i = 1; i <= playerCount; i++)
            {
                game.Players.Add(new Player(i));
            }

            ReadyToPlayWindow readyToPlayWindow = new ReadyToPlayWindow(game);
            readyToPlayWindow.Show();
            Close();
        }

        private void ReturnToMainMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
