using Advent2022.Solver;
namespace Advent2022.Solver.Day
{
    public class Day1Solver : ISolver
    {
        public (string, string) Solve(string[] puzzleInput)
        {

            List<List<int>> puzzleData = InputParser(puzzleInput);
            string part1Sol = Part1(puzzleData);
            string part2Sol = Part2(puzzleData);

            return (part1Sol, part2Sol);
        }

        public static string Part1(List<List<int>> puzzleData)
        {
            int largest = 0;
            foreach (List<int> elf in puzzleData)
            {
                int elfWeight = 0;
                for (int i = 0; i < elf.Count; i++)
                {
                    elfWeight += elf[i];
                }
                if (elfWeight > largest) { largest = elfWeight; }
            }
            return largest.ToString();
        }

        public static string Part2(IList<List<int>> puzzleData)
        {
            {
                int[] largest = { 0, 0, 0, 0 };
                foreach (List<int> elf in puzzleData)
                {
                    int elfWeight = 0;
                    for (int i = 0; i < elf.Count; i++)
                    {
                        elfWeight += elf[i];
                    }
                    largest[0] = elfWeight;
                    Array.Sort(largest);
                    largest[0] = 0;

                }
                return largest.Sum().ToString();
            }
        }

        public static List<List<int>> InputParser(string[] puzzleInput)
        {
            
            List<List<int>> puzzleData = new();
            List<int> weightList = new();
            int weight;

            foreach (string line in puzzleInput)
            {
                if (line != "")
                {
                    weight = Int32.Parse(line);
                    weightList.Add(weight);
                }
                else
                {
                    puzzleData.Add(new List<int>(weightList));
                    weightList.Clear();
                }
            }
            puzzleData.Add(new List<int>(weightList));

            
            return puzzleData;
        }

    }
}