using System;

namespace TrappingRainWater
{
    public class Solution
    {
        public int Trap(int[] height)
        {
            if (height.Length == 0)
            {
                return 0;
            }

            var trappedRainCellCount = 0;
            var currentIndex = 0;

            while (currentIndex < height.Length - 1)
            {
                if (height[currentIndex] > height[currentIndex + 1])
                {
                    var closingTrapIndex = currentIndex + 1;
                    var trapBottomTotal = 0;

                    while (closingTrapIndex < height.Length && height[currentIndex] > height[closingTrapIndex])
                    {
                        trapBottomTotal += height[closingTrapIndex];
                        closingTrapIndex++;
                    }

                    if (closingTrapIndex == height.Length || height[closingTrapIndex] < height[currentIndex])
                    {
                        height[currentIndex]--;
                        continue;
                    }

                    if (closingTrapIndex - currentIndex > 1)
                    {
                        trappedRainCellCount += (Math.Min(height[currentIndex], height[closingTrapIndex]) * (closingTrapIndex - currentIndex - 1)) - trapBottomTotal;
                    }                

                    currentIndex = closingTrapIndex;
                }
                else
                {
                    currentIndex++;
                }
            }

            return trappedRainCellCount;
        }
    }
}
