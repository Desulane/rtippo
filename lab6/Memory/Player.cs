namespace Memory
{
    public class Player
    {
        public int PlayerNumber { get; set; }
        public Sheet Sheet { get; set; }

        public Player(int playerNumber)
        {
            PlayerNumber = playerNumber;
            Sheet = new Sheet(playerNumber);
        }
    }
}
