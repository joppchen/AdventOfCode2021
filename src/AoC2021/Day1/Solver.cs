using System.Collections.Generic;
using System.Linq;

namespace AoC2021.Day1
{
    internal static class Solver
    {
        public static int Task1(int[] theList) //Answer: 1184
        {
            return SumOfNumbersWithIncreasingValue(theList);
        }

        private static int SumOfNumbersWithIncreasingValue(IReadOnlyList<int> input)
        {
            var sum = 0;
            for (var i = 1; i < input.Count; i++)
            {
                if (input[i] > input[i - 1])
                {
                    sum += 1;
                }
            }

            return sum;
        }

        public static int Task1Einaram(int[] input)
        {
            return input.Where((x, i) => i > 0 && input[i - 1] < x).Count();
        }

        public static int Task1Linq(IList<int> input)
        {
            return input.Partition(2, 1).Where(x => x.Count == 2).Count(x => x[0] < x[1]);
        }

        public static int Task2(int[] theList) //Answer: 1158
        {
            var sum = 0;
            var slideSum = new int[theList.Length - 1];
            var j = 1;

            for (var i = 2; i < theList.Length; i++)
            {
                slideSum[j] = theList[i - 2] + theList[i - 1] + theList[i];
                if (slideSum[j] > slideSum[j - 1] && j - 1 > 0)
                {
                    sum += 1;
                }

                j += 1;
            }

            return sum;
        }

        public static int Task2Linq(IList<int> input)
        {
            return Task1Linq(input.Partition(3, 1).Where(x => x.Count == 3).Select(x => x.Sum()).ToList());
        }

        private static IEnumerable<List<T>> Partition<T>(this IList<T> source, int size, int stepSize)
        {
            return source.Select((t, i) => new List<T>(source.Skip(stepSize * i).Take(size)));
        }

        public static int Task2Einaram(int[] input)
        {
            return input.Where((x, i) => i > 1 && i < input.Count() - 1 && input.Skip(i - 2).Take(3).Sum() < input.Skip(i - 1)
                .Take(3).Sum()).ToList().Count();
        }
    }
}