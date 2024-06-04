namespace Memory
{
    public class Item
    {
        public int ItemNumber { get; set; }
        public string ItemName { get; set; }
        public string ItemImage { get; set; }

        public Item(int itemNumber, string itemName, string itemImage)
        {
            ItemNumber = itemNumber;
            ItemName = itemName;
            ItemImage = itemImage;
        }
    }
}
