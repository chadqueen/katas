using System;

namespace DivideTwoIntegers
{
    public class Solution
    {
        /// <summary>
        /// Given two integers dividend and divisor, divide two integers without using multiplication, division and mod operator.
        /// Return the quotient after dividing dividend by divisor.
        /// The integer division should truncate toward zero.
        /// </summary>
        /// <param name="dividend">input dividend.</param>
        /// <param name="divisor">input divisor. assumed to never be zero.</param>
        /// <returns>quotient result. Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. For overflow, default to 2^31 - 1</returns>
        public int Divide(int dividend, int divisor)
        {
            var quotient = 0;
            var oppositeSigns = !((dividend > 0 && divisor > 0) || (dividend < 0 && divisor < 0));
            var negativeDividend = dividend > 0 ? dividend - dividend - dividend : dividend;
            var negativeDivisor = divisor > 0 ? divisor - divisor - divisor : divisor;

            if (negativeDividend - negativeDivisor < negativeDivisor)
            {
                var nextCommonDenominatorQuotient = 0;
                var divisorScaleCount = 64;
                var divisorScale = 0;

                try
                {
                    checked
                    {
                        divisorScale = negativeDivisor + negativeDivisor + negativeDivisor + negativeDivisor +
                                       negativeDivisor + negativeDivisor + negativeDivisor + negativeDivisor +
                                       negativeDivisor + negativeDivisor + negativeDivisor + negativeDivisor +
                                       negativeDivisor + negativeDivisor + negativeDivisor + negativeDivisor +
                                       negativeDivisor + negativeDivisor + negativeDivisor + negativeDivisor +
                                       negativeDivisor + negativeDivisor + negativeDivisor + negativeDivisor +
                                       negativeDivisor + negativeDivisor + negativeDivisor + negativeDivisor +
                                       negativeDivisor + negativeDivisor + negativeDivisor + negativeDivisor +
                                       negativeDivisor + negativeDivisor + negativeDivisor + negativeDivisor +
                                       negativeDivisor + negativeDivisor + negativeDivisor + negativeDivisor +
                                       negativeDivisor + negativeDivisor + negativeDivisor + negativeDivisor +
                                       negativeDivisor + negativeDivisor + negativeDivisor + negativeDivisor +
                                       negativeDivisor + negativeDivisor + negativeDivisor + negativeDivisor +
                                       negativeDivisor + negativeDivisor + negativeDivisor + negativeDivisor +
                                       negativeDivisor + negativeDivisor + negativeDivisor + negativeDivisor +
                                       negativeDivisor + negativeDivisor + negativeDivisor + negativeDivisor;
                        nextCommonDenominatorQuotient = Divide(negativeDividend, divisorScale);
                    }
                }
                catch
                {
                }
                
                var quotientMultiplier = 0;
                var remainder = negativeDividend;
                if (nextCommonDenominatorQuotient > 0)
                {
                    while (quotientMultiplier++ < nextCommonDenominatorQuotient)
                    {
                        try
                        {
                            checked
                            {
                                quotient += divisorScaleCount;
                            }
                        }
                        catch (Exception)
                        {
                            return oppositeSigns ? int.MinValue : int.MaxValue;
                        }
                        
                        remainder -= divisorScale;
                    }
                }

                if (remainder > negativeDivisor)
                {
                    return oppositeSigns ? quotient - quotient - quotient : quotient;
                }

                negativeDividend = remainder;
            }

            var currentSum = negativeDivisor;
            while (negativeDividend < currentSum)
            {
                try
                {
                    checked
                    {
                        quotient++;
                    }
                }
                catch (Exception e)
                {
                    return oppositeSigns ? int.MinValue : int.MaxValue;
                }

                try
                {
                    checked
                    {
                        currentSum += negativeDivisor;
                    }
                }
                catch
                {
                    return oppositeSigns ? quotient - quotient - quotient : quotient;
                }
            }

            if (currentSum == negativeDividend)
            {
                try
                {
                    checked
                    {
                        quotient++;
                    }
                }
                catch (Exception e)
                {
                    return oppositeSigns ? int.MinValue : int.MaxValue;
                }
            }

            return oppositeSigns ? quotient - quotient - quotient : quotient;
        }
    }
}
