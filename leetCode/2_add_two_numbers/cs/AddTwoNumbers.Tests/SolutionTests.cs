using Xunit;

namespace AddTwoNumbers.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void AddTwoNumbers_Adds_Nodes_Of_Two_Populated_Singly_Linked_Lists()
        {
            // arrange
            var value1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var value2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            var value3 = new ListNode(5);
            var value4 = new ListNode(5);

            var solution = new Solution();

            // act
            var sum = solution.AddTwoNumbers(value1, value2);
            var sum2 = solution.AddTwoNumbers(value3, value4);

            // assert
            Assert.Equal(7, sum.Value);
            Assert.Equal(0, sum.Next.Value);
            Assert.Equal(8, sum.Next.Next.Value);
            Assert.Null(sum.Next.Next.Next);
            Assert.Equal(0, sum2.Value);
            Assert.Equal(1, sum2.Next.Value);
            Assert.Null(sum2.Next.Next);
        }

        [Fact]
        public void AddTwoNumbers_Returns_Null_For_Two_Null_Inputs()
        {
            // arrange
            var solution = new Solution();

            // act
            var sum = solution.AddTwoNumbers(null, null);

            // assert
            Assert.Null(sum);
        }

        [Fact]
        public void AddTwoNumbers_Handles_When_One_Input_Is_Null()
        {
            // arrange
            var solution = new Solution();
            var value1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var value2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            // act
            var sum1 = solution.AddTwoNumbers(value1, null);
            var sum2 = solution.AddTwoNumbers(null, value2);

            // assert
            Assert.Equal(2, sum1.Value);
            Assert.Equal(4, sum1.Next.Value);
            Assert.Equal(3, sum1.Next.Next.Value);
            Assert.Null(sum1.Next.Next.Next);
            Assert.Equal(5, sum2.Value);
            Assert.Equal(6, sum2.Next.Value);
            Assert.Equal(4, sum2.Next.Next.Value);
            Assert.Null(sum2.Next.Next.Next);
        }
    }
}
