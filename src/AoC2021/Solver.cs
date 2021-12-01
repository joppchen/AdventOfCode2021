using System;
using AoC2021.Common;

namespace AoC2021.Day1
{
    internal static class Solver
    {
        public static void Task1(int[] theList) //Answer: 1184
        {
            int sum = 0;
            for (int i = 1; i < theList.Length; i++)
            {
                if (theList[i] > theList[i - 1])
                {
                    sum += 1;
                }
            }

            Console.WriteLine($"Task 1: {sum}");
        }

        public static void Task2(int[] theList) //Answer: 1158
        {
            int sum = 0;
            var slideSum = new int[theList.Length - 1];
            int j = 1;
            
            for (int i = 2; i < theList.Length; i++)
            {
                slideSum[j] = theList[i - 2] + theList[i - 1] + theList[i];
                if (slideSum[j] > slideSum[j-1] && j -1 > 0)
                {
                    sum += 1;
                }
                j += 1;
            }
            
            Console.WriteLine($"Task 2: {sum}");
        }
    }
}