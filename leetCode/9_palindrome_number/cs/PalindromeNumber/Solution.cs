namespace PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            var referencedInput = x;
            var reversedValue = 0;

            while (referencedInput > 0)
            {
                reversedValue = reversedValue * 10 + referencedInput % 10;
                referencedInput /= 10;
            }

            return reversedValue == x;
        }
    }
}
