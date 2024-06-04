using System.Collections.Generic;

namespace Memory
{
    public class ItemManager
    {
        private Dictionary<string, List<string>> itemDictionary;

        public ItemManager()
        {
            itemDictionary = new Dictionary<string, List<string>>();

            AddItem("Items/1.png", new List<string> { "пуговица" });
            AddItem("Items/2.png", new List<string> { "кепка", "бейсболка" });
            AddItem("Items/3.png", new List<string> { "шлем", "армет" });
            AddItem("Items/4.png", new List<string> { "ремень", "кожаный ремень" });
            AddItem("Items/5.png", new List<string> { "андроид", "android" });
            AddItem("Items/6.png", new List<string> { "кот", "кошка" });
            AddItem("Items/7.png", new List<string> { "конь", "лошадь" });
            AddItem("Items/8.png", new List<string> { "панда" });
            AddItem("Items/9.png", new List<string> { "батарейка" });
            AddItem("Items/10.png", new List<string> { "наушники" });
            AddItem("Items/11.png", new List<string> { "калькулятор" });
            AddItem("Items/12.png", new List<string> { "граммофон" });
            AddItem("Items/13.png", new List<string> { "холодильник" });
            AddItem("Items/14.png", new List<string> { "сыр" });
            AddItem("Items/15.png", new List<string> { "кровать" });
            AddItem("Items/16.png", new List<string> { "яблоко" });
            AddItem("Items/17.png", new List<string> { "арбуз" });
            AddItem("Items/18.png", new List<string> { "чайник" });
            AddItem("Items/19.png", new List<string> { "микроволновка", "микроволновая печь" });
            AddItem("Items/20.png", new List<string> { "танк" });
            AddItem("Items/21.png", new List<string> { "топор" });
            AddItem("Items/22.png", new List<string> { "рюкзак" });
            AddItem("Items/23.png", new List<string> { "велосипед" });
            AddItem("Items/24.png", new List<string> { "очки", "оправа" });
            AddItem("Items/25.png", new List<string> { "автомобиль" });
            AddItem("Items/26.png", new List<string> { "ключ" });
            AddItem("Items/27.png", new List<string> { "вертолет" });
            AddItem("Items/28.png", new List<string> { "магнит" });
            AddItem("Items/29.png", new List<string> { "дирижабль" });
            AddItem("Items/30.png", new List<string> { "будильник" });
            AddItem("Items/31.png", new List<string> { "самолет", "биплан" });
            AddItem("Items/32.png", new List<string> { "микроскоп" });
            AddItem("Items/33.png", new List<string> { "мяч", "баскетбольный мяч" });
            AddItem("Items/34.png", new List<string> { "медаль", "золотая медаль" });
            AddItem("Items/35.png", new List<string> { "наковальня" });
            AddItem("Items/36.png", new List<string> { "скейтборд" });
            AddItem("Items/37.png", new List<string> { "бетономешалка" });
            AddItem("Items/38.png", new List<string> { "бинокль" });
            AddItem("Items/39.png", new List<string> { "зонт" });
            AddItem("Items/40.png", new List<string> { "арбалет" });
        }

        private void AddItem(string imagePath, List<string> itemNames)
        {
            itemDictionary[imagePath] = itemNames;
        }

        public List<string> GetItemNames(string imagePath)
        {
            if (itemDictionary.ContainsKey(imagePath))
            {
                return itemDictionary[imagePath];
            }
            return new List<string>();
        }
    }
}
