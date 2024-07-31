using System;

namespace Assignment7
{
    internal class Solution
    {
        public int solution(int[] A)
        {
            int min = int.MaxValue;
            bool foundPositive = false;

            foreach (int num in A)
            {
                if (num > 0)
                {
                    min = Math.Min(min, num);
                    foundPositive = true;
                }
            }

            return foundPositive ? min : 0;
        }
    }
}
