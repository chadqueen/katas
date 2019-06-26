using Xunit;

namespace DivideTwoIntegers.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void Divide_Calculates_Quotient_Of_Two_Positive_Numbers()
        {
            // arrange
            var solution = new Solution();

            // act
            var quotient = solution.Divide(10, 3);

            // assert
            Assert.Equal(3, quotient);
        }

        [Fact]
        public void Divide_Calculates_Quotient_Of_Two_Negative_Numbers()
        {
            // arrange
            var solution = new Solution();

            // act
            var quotient = solution.Divide(-10, -3);

            // assert
            Assert.Equal(3, quotient);
        }

        [Fact]
        public void Divide_Calculates_Quotient_Of_Two_Numbers_With_Opposite_Signs()
        {
            // arrange
            var solution = new Solution();

            // act
            var quotient1 = solution.Divide(-7, 3);
            var quotient2 = solution.Divide(7, -3);

            // assert
            Assert.Equal(-2, quotient1);
            Assert.Equal(-2, quotient2);
        }

        [Fact]
        public void Divide_Handles_Int_Min_And_Max_Dividend()
        {
            // arrange
            var solution = new Solution();

            // act
            var quotient = solution.Divide(int.MinValue, -1);
            var quotient1 = solution.Divide(int.MinValue, 1);
            var quotient2 = solution.Divide(int.MinValue, 2);
            var quotient3 = solution.Divide(int.MaxValue, 3);

            // assert
            Assert.Equal(int.MaxValue, quotient);
            Assert.Equal(int.MinValue, quotient1);
            Assert.Equal(int.MinValue / 2, quotient2);
            Assert.Equal(int.MaxValue / 3, quotient3);
        }

        [Fact]
        public void Divide_Handles_Evenly_Divisible()
        {
            // arrange
            var solution = new Solution();

            // act
            var quotient = solution.Divide(1, -1);
            var quotient1 = solution.Divide(1, 1);
            var quotient2 = solution.Divide(-1, -1);
            var quotient3 = solution.Divide(-1, 1);
            var quotient4 = solution.Divide(-10, 2);

            // assert
            Assert.Equal(-1, quotient);
            Assert.Equal(1, quotient1);
            Assert.Equal(1, quotient2);
            Assert.Equal(-1, quotient3);
            Assert.Equal(-5, quotient4);
        }
    }
}
