using Advent2022.Solver;
namespace Advent2022.Solver.Day
{
    public class Day8Solver : ISolver
    {
        public (string, string) Solve(string[] puzzleInput)
        {

            List<List<string>> puzzleData = InputParser(puzzleInput);
            string part1Sol = Part1(puzzleData);
            string part2Sol = Part2(puzzleData);

            return (part1Sol, part2Sol);
        }

        public static string Part1(List<List<string>> puzzleData)
        {

            return "";
        }

        public static string Part2(List<List<string>> puzzleData)
        {

            return "";
        }


        public static List<List<string>> InputParser(string[] puzzleInput)
        {

            List<List<string>> puzzleData = new();

            return puzzleData;
        }

    }
}