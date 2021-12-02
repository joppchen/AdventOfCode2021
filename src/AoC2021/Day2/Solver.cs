using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AoC2021.Day2
{
    internal static class Solver
    {
        public static int Task1(IEnumerable<string> instructions) //Answer: 2215080
        {
            var rgxInstruction = new Regex(@"([a-z])\w+", RegexOptions.Multiline);
            var rgxValue = new Regex(@"([0-9])\w*", RegexOptions.Multiline);
            var depth = 0;
            var horizontal = 0;

            foreach (var line in instructions)
            {
                var instr = rgxInstruction.Match(line).ToString();
                var value = int.Parse(rgxValue.Match(line).ToString());

                switch (instr)
                {
                    case "forward":
                        horizontal += value;
                        break;
                    case "down":
                        depth += value;
                        break;
                    case "up":
                        depth -= value;
                        break;
                }
            }

            return horizontal * depth;
        }


        public static int Task2(IEnumerable<string> theList) //Answer: 
        {
            throw new NotImplementedException("Task 2");
        }
    }
}