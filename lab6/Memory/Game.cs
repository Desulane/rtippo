using System.Collections.Generic;

namespace Memory
{
    public class Game
    {
        public int GameNumber { get; set; }
        public int PlayerCount { get; set; }
        public List<Item> Items { get; set; }
        public List<Player> Players { get; set; }
        public Game(int gameNumber, int playerCount, List<Item> items)
        {
            GameNumber = gameNumber;
            PlayerCount = playerCount;
            Items = items;
            Players = new List<Player>();
        }
    }
}
