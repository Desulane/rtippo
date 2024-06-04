using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Memory
{
    public partial class InputWindow : Window
    {
        private Game game;
        private ItemManager itemManager;
        private int currentPlayerNumber;
        private Dictionary<int, int> playerResults;

        public InputWindow(Game game)
        {
            InitializeComponent();

            this.game = game;
            playerResults = new Dictionary<int, int>();

            itemManager = new ItemManager();
            currentPlayerNumber = 1;

            Title = $"Игрок №{currentPlayerNumber}";
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            HashSet<string> countedImagePaths = new HashSet<string>();
            string inputText = InputTextBox.Text;
            inputText = inputText.Trim().ToLower().Replace("ё", "е");
            string[] enteredItems = inputText.Split(new[] { System.Environment.NewLine }, System.StringSplitOptions.RemoveEmptyEntries);

            int score = 0;
            foreach (string enteredItem in enteredItems)
            {
                foreach (Item item in game.Items)
                {
                    List<string> validItemNames = itemManager.GetItemNames(item.ItemImage);
                    if (validItemNames.Contains(enteredItem) && !countedImagePaths.Contains(item.ItemImage))
                    {
                        score++;
                        countedImagePaths.Add(item.ItemImage);
                        game.Players[currentPlayerNumber - 1].Sheet.Answers.Add(new Answer(score, item.ItemName));
                        break;
                    }
                }
            }

            playerResults[currentPlayerNumber] = score;

            if (currentPlayerNumber == game.PlayerCount)
            {
                ResultWindow resultWindow = new ResultWindow(playerResults);
                resultWindow.Show();
                Close();
            }
            else
            {
                InputTextBox.Clear();
                countedImagePaths.Clear();
                currentPlayerNumber++;
                Title = $"Игрок №{currentPlayerNumber}";
            }
        }
    }
}
