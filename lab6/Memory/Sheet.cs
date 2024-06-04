using System.Collections.Generic;

namespace Memory
{
    public class Sheet
    {
        public int SheetNumber { get; set; }
        public List<Answer> Answers { get; set; }

        public Sheet(int sheetNumber)
        {
            SheetNumber = sheetNumber;
            Answers = new List<Answer>();
        }
    }
}
