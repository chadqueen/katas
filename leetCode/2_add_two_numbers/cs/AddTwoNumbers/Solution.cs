namespace AddTwoNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var currentCarry = 0;
            var value1CurrentNode = l1;
            var value2CurrentNode = l2;

            var initialNode = new ListNode(0);
            var currentNode = initialNode;

            while (value1CurrentNode != null || value2CurrentNode != null || currentCarry > 0)
            {
                var sum = currentCarry + (value1CurrentNode?.Value ?? 0) + (value2CurrentNode?.Value ?? 0);
                currentNode = currentNode.Next = new ListNode(sum % 10);
                currentCarry = sum / 10;

                value1CurrentNode = value1CurrentNode?.Next;
                value2CurrentNode = value2CurrentNode?.Next;
            }


            return initialNode.Next;
        }
    }
}
