using System;
using System.IO;
using AoC2021.Common;

namespace AoC2021.Day1
{
    internal static class Main
    {
        public static void Solve(int dayNumber = 1)
        {
            Console.WriteLine($"Day 1:");
            const string filename = "day1";

            Console.WriteLine(Directory.GetCurrentDirectory());

            var textFile = $"../../../../../resources/{filename}.txt";
            //var textFile = $"../../../../../resources/{filename}_example.txt";

            if (File.Exists(textFile))
            {
                var lines = File.ReadAllLines(textFile);
                var integers = SharedMethods.ParseStringArrayToInt(lines);

                /*foreach (var integer in integers)
                {
                    Console.WriteLine(integer);
                }*/

                Console.WriteLine("Task 1:");
                Solver.Task1(integers);

                Console.WriteLine("Task 2:");
                Solver.Task2(integers);
            }
            else
            {
                Console.WriteLine($"Fant IKKE filen: '{textFile}'");
            }
        }
    }
}