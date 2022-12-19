using Advent2022.Solver;
namespace Advent2022.Solver.Day
{
    public class Day4Solver : ISolver
    {
        public (string, string) Solve(string[] puzzleInput)
        {

            List<List<List<int>>> puzzleData = InputParser(puzzleInput);
            string part1Sol = Part1(puzzleData);
            string part2Sol = Part2(puzzleData);

            return (part1Sol, part2Sol);
        }

        public static string Part1(List<List<List<int>>> puzzleData)
        {
            int count = 0;
            foreach (List<List<int>> elfPair in puzzleData)
            {
                List<int> elf0 = elfPair[0];
                List<int> elf1 = elfPair[1];
                if (checkContains(elf0, elf1))
                {
                    count++;
                }
            }
            return count.ToString();

            static bool checkContains(List<int> firstElf, List<int> secondElf)
            {
                if (firstElf[0] >= secondElf[0] && firstElf[0] <= secondElf[1])
                {
                    if (firstElf[1] >= secondElf[0] && firstElf[1] <= secondElf[1])
                    {
                        return true;
                    }
                }
                if (secondElf[0] >= firstElf[0] && secondElf[0] <= firstElf[1])
                {
                    if (secondElf[1] >= firstElf[0] && secondElf[1] <= firstElf[1])
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public static string Part2(List<List<List<int>>> puzzleData)
        {

            int count = 0;
            foreach (List<List<int>> elfPair in puzzleData)
            {
                List<int> elf0 = elfPair[0];
                List<int> elf1 = elfPair[1];
                if (checkContains(elf0, elf1))
                {
                    count++;
                }
            }
            return count.ToString();

            static bool checkContains(List<int> firstElf, List<int> secondElf)
            {
                if (firstElf[0] >= secondElf[0] && firstElf[0] <= secondElf[1])
                {
                    return true;
                }
                if (firstElf[1] >= secondElf[0] && firstElf[1] <= secondElf[1])
                {
                    return true;
                }

                if (secondElf[0] >= firstElf[0] && secondElf[0] <= firstElf[1])
                {
                    return true;
                }
                if (secondElf[1] >= firstElf[0] && secondElf[1] <= firstElf[1])
                {
                    return true;
                }
                
                return false;
            }
        }


        public static List<List<List<int>>> InputParser(string[] puzzleInput)
        {

            List<List<List<int>>> puzzleData = new();
            foreach (string inputLine in puzzleInput)
            {
                string[] elfPair = inputLine.Split(",");
                
                puzzleData.Add(new List<List<int>> { assignmentMaker(elfPair[0]), assignmentMaker(elfPair[1]) });
            }
            return puzzleData;

            static List<int> assignmentMaker(string elf)
            {
                string[] stringPair = elf.Split("-");
                List<int> intPair = new List<int>{Int32.Parse(stringPair[0]), Int32.Parse(stringPair[1])};

                return intPair;
            }
        }

    }
}