using System;
using System.IO;
using AoC2021.Common;

namespace AoC2021.Day1
{
    internal static class Main
    {
        public static void Solve(int dayNumber)
        {
            Console.WriteLine($"Day 1:");
            const string filename = "day1";

            //Console.WriteLine(Directory.GetCurrentDirectory());

            var textFile = $"../../../../../resources/{filename}.txt";
            //var textFile = $"../../../../../resources/{filename}_example.txt";

            if (File.Exists(textFile))
            {
                var lines = File.ReadAllLines(textFile);
                var integers = SharedMethods.ParseStringArrayToInt(lines);

                Console.WriteLine("TASK 1");
                var watch = System.Diagnostics.Stopwatch.StartNew();
                var result = Solver.Task1(integers);
                watch.Stop();
                Console.WriteLine($"Task 1: {result}. Elapsed time [ms]: {watch.ElapsedMilliseconds}");

                watch = System.Diagnostics.Stopwatch.StartNew();
                result = Solver.Task1Einaram(integers);
                watch.Stop();
                Console.WriteLine($"Einaram's Linq solution: {result}. Elapsed time [ms]: {watch.ElapsedMilliseconds}");

                watch = System.Diagnostics.Stopwatch.StartNew();
                result = Solver.Task1Linq(integers);
                watch.Stop();
                Console.WriteLine($"Task 1 w/Linq: {result}. Elapsed time [ms]: {watch.ElapsedMilliseconds}");


                Console.WriteLine("");
                Console.WriteLine("TASK 2");

                watch = System.Diagnostics.Stopwatch.StartNew();
                result = Solver.Task2(integers);
                watch.Stop();
                Console.WriteLine($"Task 2: {result}. Elapsed time [ms]: {watch.ElapsedMilliseconds}");

                watch = System.Diagnostics.Stopwatch.StartNew();
                result = Solver.Task2Einaram(integers);
                watch.Stop();
                Console.WriteLine($"Einaram's Linq solution: {result}. Elapsed time [ms]: {watch.ElapsedMilliseconds}");

                watch = System.Diagnostics.Stopwatch.StartNew();
                result = Solver.Task2Linq(integers);
                watch.Stop();
                Console.WriteLine($"Task 2 Take 2: {result}. Elapsed time [ms]: {watch.ElapsedMilliseconds}");
            }
            else
            {
                Console.WriteLine($"File not found: '{textFile}'");
            }
        }
    }
}