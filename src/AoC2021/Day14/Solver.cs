using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace AoC2021.Day14
{
    internal static class Solver
    {
        public static int Task1(string[] input) //Answer: 2215080
        {
            var rgxTemplate = new Regex(@"([A-Z])\w{3,}", RegexOptions.Multiline);
            var rgxRules = new Regex(@"(\w{2}\s->\s\w{1})", RegexOptions.Multiline);
            var depth = 0;
            var horizontal = 0;

            var template = input[0];
            var rules = new string[input.Length - 2];
            Array.Copy(input, 2, rules, 0, input.Length-2);

            var rgxPairs = new Regex(@"(?=(\w\w))", RegexOptions.Multiline);
            var pairs = rgxPairs.Matches(template);
            var pairsStr = pairs;
            foreach (Match pair in pairs)
            {
                Debug.WriteLine(pair.ToString());
                Console.WriteLine(pair.ToString());
            }

            //var template = rgxTemplate.Match(s).ToString();
              //  var ruleMatch = rgxRules.Match(s);
                //var rules = ruleMatch.ToString();    


                var svada = Regex.Matches("020202020", @"(?=020)");
            
            
            

            return horizontal * depth;
        }


        public static int Task2(IEnumerable<string> instructions) //Answer: 1864715580
        {
            var rgxInstruction = new Regex(@"([a-z])\w+", RegexOptions.Multiline);
            var rgxValue = new Regex(@"([0-9])\w*", RegexOptions.Multiline);
            var depth = 0;
            var horizontal = 0;
            var aim = 0;

            foreach (var line in instructions)
            {
                var instr = rgxInstruction.Match(line).ToString();
                var value = int.Parse(rgxValue.Match(line).ToString());

                switch (instr)
                {
                    case "forward":
                        horizontal += value;
                        depth += aim * value;
                        break;
                    case "down":
                        aim += value;
                        break;
                    case "up":
                        aim -= value;
                        break;
                }
            }

            return horizontal * depth;
        }
    }
}