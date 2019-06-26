using Xunit;

namespace PalindromeNumber.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void IsPalindrome_Returns_False_When_Input_Is_Not_A_Palindrome()
        {
            // arrange
            var solution = new Solution();

            // act
            var isPalindrome = solution.IsPalindrome(10);
            var isPalindrome1 = solution.IsPalindrome(14);
            var isPalindrome2 = solution.IsPalindrome(123);
            var isPalindrome3 = solution.IsPalindrome(1292041);

            // assert
            Assert.False(isPalindrome);
            Assert.False(isPalindrome1);
            Assert.False(isPalindrome2);
            Assert.False(isPalindrome3);
        }

        [Fact]
        public void IsPalindrome_Returns_True_When_Input_Is_A_Palindrome()
        {

            // arrange
            var solution = new Solution();

            // act
            var isPalindrome = solution.IsPalindrome(9);
            var isPalindrome1 = solution.IsPalindrome(11);
            var isPalindrome2 = solution.IsPalindrome(121);
            var isPalindrome3 = solution.IsPalindrome(129921);

            // assert
            Assert.True(isPalindrome);
            Assert.True(isPalindrome1);
            Assert.True(isPalindrome2);
            Assert.True(isPalindrome3);
        }

        [Fact]
        public void IsPalindrome_Returns_False_For_Any_Negative_Number()
        {

            var solution = new Solution();

            // act
            var isPalindrome = solution.IsPalindrome(-9);
            var isPalindrome1 = solution.IsPalindrome(-11);
            var isPalindrome2 = solution.IsPalindrome(-121);
            var isPalindrome3 = solution.IsPalindrome(-129921);

            // assert
            Assert.False(isPalindrome);
            Assert.False(isPalindrome1);
            Assert.False(isPalindrome2);
            Assert.False(isPalindrome3);
        }
    }
}
