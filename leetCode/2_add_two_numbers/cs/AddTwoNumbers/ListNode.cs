namespace AddTwoNumbers
{
    public class ListNode
    {
        public ListNode(int inputValue)
            : this(inputValue, null)
        {
        }

        public ListNode(int inputValue, ListNode nextNode)
        {
            this.Value = inputValue;
            this.Next = nextNode;
        }

        public int Value { get; set; }

        public ListNode Next { get; set; }
    }
}
