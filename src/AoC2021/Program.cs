using System;

namespace AoC2021
{
    class Program
    {
        private const int Year = 2021;

        static void Main(string[] args)
        {
            Console.WriteLine($"Hello Advent of Code {Year}!");

            //Console.WriteLine("Type in day number to solve: ");
            //var svada = Console.ReadLine();
            //var dayNumber = svada;

            Day1.Main.Solve();
        }
    }
}
