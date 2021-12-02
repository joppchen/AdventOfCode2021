using System;
using System.IO;

namespace AoC2021.Day2
{
    internal static class Main
    {
        public static void Solve(int dayNumber)
        {
            Console.WriteLine($"Day {dayNumber}:");
            var filename = $"day{dayNumber}";

            var textFile = $"../../../../../resources/{filename}.txt";
            //var textFile = $"../../../../../resources/{filename}_example.txt";

            if (File.Exists(textFile))
            {
                var lines = File.ReadAllLines(textFile);

                Console.WriteLine("TASK 1");
                var watch = System.Diagnostics.Stopwatch.StartNew();
                var result = Solver.Task1(lines);
                watch.Stop();
                Console.WriteLine($"Task 1: {result}. Elapsed time [ms]: {watch.ElapsedMilliseconds}");


                Console.WriteLine("");
                Console.WriteLine("TASK 2");

                watch = System.Diagnostics.Stopwatch.StartNew();
                result = Solver.Task2(lines);
                watch.Stop();
                Console.WriteLine($"Task 2: {result}. Elapsed time [ms]: {watch.ElapsedMilliseconds}");
            }
            else
            {
                Console.WriteLine($"File not found: '{textFile}'");
            }
        }
    }
}