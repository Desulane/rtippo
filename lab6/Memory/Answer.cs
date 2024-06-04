namespace Memory
{
    public class Answer
    {
        public int AnswerNumber { get; set; }
        public string ItemName { get; set; }

        public Answer(int answerNumber, string itemName)
        {
            AnswerNumber = answerNumber;
            ItemName = itemName;
        }
    }
}
