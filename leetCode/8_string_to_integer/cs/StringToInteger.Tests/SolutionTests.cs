using Xunit;

namespace StringToInteger.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void MyAtoi_Parses_Positive_Integer()
        {
            // arrange
            var solution = new Solution();

            // act
            var parsedInteger = solution.MyAtoi("42");
            var parsedIntegerWithPositiveSign = solution.MyAtoi("+42");

            // assert
            Assert.Equal(42, parsedInteger);
            Assert.Equal(42, parsedIntegerWithPositiveSign);
        }

        [Fact]
        public void MyAtoi_Parses_Negative_Integer()
        {
            // arrange
            var solution = new Solution();

            // act
            var parsedInteger = solution.MyAtoi("-42");

            // assert
            Assert.Equal(-42, parsedInteger);
        }

        [Fact]
        public void MyAtoi_Parses_Values_Higher_Than_Miaximum_Positive_Integer_Defaulting_To_Max_Int_Value()
        {
            // arrange
            var solution = new Solution();

            // act
            var parsedInteger = solution.MyAtoi("91283472332");

            // assert
            Assert.Equal(2147483647, parsedInteger);
        }

        [Fact]
        public void MyAtoi_Parses_Values_Lower_Than_Minimum_Negative_Integer_Defaulting_To_Min_Int_Value()
        {
            // arrange
            var solution = new Solution();

            // act
            var parsedInteger = solution.MyAtoi("-91283472332");

            // assert
            Assert.Equal(-2147483648, parsedInteger);
        }

        [Fact]
        public void MyAtoi_Returns_Zero_If_String_Does_Not_Start_With_Valid_Number()
        {
            // arrange
            var solution = new Solution();

            // act
            var parsedInteger = solution.MyAtoi("words and 987");

            // assert
            Assert.Equal(0, parsedInteger);
        }

        [Fact]
        public void MyAtoi_Returns_Leading_Number_If_String_Continues_Past_Beginning_Numeric_Value()
        {
            // arrange
            var solution = new Solution();

            // act
            var parsedInteger = solution.MyAtoi("4193 with words");

            // assert
            Assert.Equal(4193, parsedInteger);
        }

        [Fact]
        public void MyAtoi_Returns_Returns_Zero_For_Just_Hyphen()
        {
            // arrange
            var solution = new Solution();

            // act
            var parsedInteger = solution.MyAtoi("-");

            // assert
            Assert.Equal(0, parsedInteger);
        }

        [Fact]
        public void MyAtoi_Returns_Returns_Zero_For_Just_Plus()
        {
            // arrange
            var solution = new Solution();

            // act
            var parsedInteger = solution.MyAtoi("+");

            // assert
            Assert.Equal(0, parsedInteger);
        }

        [Fact]
        public void MyAtoi_Returns_Returns_Zero_Multiple_Signs()
        {
            // arrange
            var solution = new Solution();

            // act
            var parsedInteger = solution.MyAtoi("+-1");
            var parsedInteger1 = solution.MyAtoi("-+1");
            var parsedInteger2 = solution.MyAtoi("--1");
            var parsedInteger3 = solution.MyAtoi("++1");

            // assert
            Assert.Equal(0, parsedInteger);
            Assert.Equal(0, parsedInteger1);
            Assert.Equal(0, parsedInteger2);
            Assert.Equal(0, parsedInteger3);
        }

        [Fact]
        public void MyAtoi_Returns_Returns_Zero_For_Empty_String()
        {
            // arrange
            var solution = new Solution();

            // act
            var parsedInteger = solution.MyAtoi(string.Empty);

            // assert
            Assert.Equal(0, parsedInteger);
        }

        [Fact]
        public void MyAtoi_Returns_Returns_Zero_With_Space_Between_Sign_And_Number()
        {
            // arrange
            var solution = new Solution();

            // act
            var parsedInteger = solution.MyAtoi("- 1");
            var parsedInteger1 = solution.MyAtoi("+ 1");

            // assert
            Assert.Equal(0, parsedInteger);
            Assert.Equal(0, parsedInteger1);
        }
    }
}
