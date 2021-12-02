using System;
using System.Collections.Generic;
using System.IO;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFile = File.ReadAllLines("C:/Code/AdventOfCode2021/Day1/input.txt");
            var inputList = new List<string>(inputFile);
            var depthMeasurementIncreases = 0;
            var previousReading = 199;

            foreach (var input in inputList)
            {
                var currentReading = int.Parse(input);

                if (currentReading > previousReading)
                    depthMeasurementIncreases++;

                previousReading = currentReading;
            }

            Console.WriteLine($"Increases: {depthMeasurementIncreases}");
        }
    }
}
