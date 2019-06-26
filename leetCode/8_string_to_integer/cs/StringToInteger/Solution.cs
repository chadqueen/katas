namespace StringToInteger
{
    public class Solution
    {
        public int MyAtoi(string str)
        {
            if (str.Length == 0)
            {
                return 0;
            }

            var stringCharacters = str.ToCharArray();

            var beginningNumberIndex = 0;
            var isNegative = false;
            var isPositive = false;
            var currentIndex = 0;
            while (currentIndex < stringCharacters.Length)
            {
                if (char.IsNumber(stringCharacters[currentIndex]))
                {
                    beginningNumberIndex = currentIndex++;
                    break;
                }

                if (stringCharacters[currentIndex] != ' ')
                {
                    if (stringCharacters[currentIndex] == '-' && !isNegative && !isPositive)
                    {
                        currentIndex++;
                        isNegative = true;
                        continue;
                    }

                    if (stringCharacters[currentIndex] == '+' && !isPositive && !isNegative)
                    {
                        currentIndex++;
                        isNegative = false;
                        isPositive = true;
                        continue;
                    }

                    return 0;
                }

                if (isPositive || isNegative)
                {
                    return 0;
                }

                currentIndex++;
            }

            if (!char.IsNumber(stringCharacters[beginningNumberIndex]))
            {
                return 0;
            }

            while (currentIndex < stringCharacters.Length && char.IsNumber(stringCharacters[currentIndex]))
            {
                currentIndex++;
            }

            int currentValue = 0;
            for (var i = beginningNumberIndex; i < currentIndex; i++)
            {
                var newSignificantDigit = stringCharacters[i] - '0';
                if (isNegative)
                {
                    try
                    {
                        currentValue = checked(currentValue * 10 - newSignificantDigit);
                    }
                    catch
                    {
                        return int.MinValue;
                    }
                }
                else
                {
                    try
                    {
                        currentValue = checked(currentValue * 10 + newSignificantDigit);
                    }
                    catch
                    {
                        return int.MaxValue;
                    }
                }                
            }

            return currentValue;
        }
    }
}
