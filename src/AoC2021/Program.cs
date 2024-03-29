﻿using System;

namespace AoC2021
{
    internal static class Program
    {
        private const int Year = 2021;

        private static void Main(string[] args)
        {
            Console.WriteLine($"Hello Advent of Code {Year}!");

            var dayNumber = 2; // Current default

            if (args.Length > 0) dayNumber = int.Parse(args[0]);
            Console.WriteLine($"Day to be calculated: Day {dayNumber}.");
            Console.WriteLine("");

            switch (dayNumber)
            {
                case 1:
                    Day1.Main.Solve(dayNumber);
                    break;
                case 2:
                    Day2.Main.Solve(dayNumber);
                    break;
                default:
                    throw new NotImplementedException($"Day {dayNumber} is not yet implemented.");
            }
        }
    }
}