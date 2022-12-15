// Program.cs
using System;
using System.IO;
using Advent2022.Solver;
using Advent2022.Solver.Day;

namespace Advent2022
{
    public class PrimaryWorkflow
    {
        //private readonly ISolver daySolver;

        public static void Main()
        {
            try
            {
                //Get which AoC day to run
                Console.WriteLine("Enter Day to run: XX \n");
                string day = Console.ReadLine();

                DateTime start_time = DateTime.Now;
                ISolver daySolver = SolverSelection(day);

                string[] puzzle_input1 = TextReader(day, "input1.txt");
                string[] example_input1 = TextReader(day, "example1.txt");
                string[] example_input2 = TextReader(day, "example2.txt");

                (string exSolution1, string exSolution2) = daySolver.Solve(example_input1);

                Console.WriteLine($"Example1 Solution for Part1 of day {day}: The solution is {exSolution1}");
                Console.WriteLine($"Example1 Solution for Part1 of day {day}: The solution is {exSolution2}\n");


                (string solution1, string solution2) = daySolver.Solve(puzzle_input1);

                Console.WriteLine($"Part1 of day {day}: The solution is {solution1}");
                Console.WriteLine($"Part2 of day {day}: The solution is {solution2}");
                Console.WriteLine($"Execution took { (DateTime.Now - start_time)} to run");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n");
                Console.WriteLine(ex.ToString());
                Console.WriteLine("\n");
            }
        }


        public static string[] TextReader(string day, string? fileName = "input1.txt")
        {
            string rootPath = "C:/Users/Cameron.Deweerd/source/repos/Advent2022/Advent2022"; //should probably have a better way to get this
            string textFile = $"{rootPath}/{day}/{fileName}";

            if (File.Exists(textFile))
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(textFile);
                return lines;
            }
            else
            {
                throw new Exception($"{textFile} was not found");
            }

        }

        public static ISolver SolverSelection(string day)
        {
            ISolver daySolver;

            switch (day)
            {
                case "01":
                    daySolver = new Day1Solver(); break;
                case "02":
                    daySolver = new Day2Solver(); break;
                default:
                    throw new Exception("Invalid date entry");
            }
            return daySolver;

        }
    }
}