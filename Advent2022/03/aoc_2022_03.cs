using Advent2022.Solver;
namespace Advent2022.Solver.Day
{
    public class Day3Solver : ISolver
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
            int total = 0;
            foreach (List<string> part in puzzleData)
            {
                foreach(char letter in part[0])
                {
                    if (part[1].IndexOf(letter) != -1)
                    {
                        total += getRank(letter);
                        break;
                    }
                }
            }

            return total.ToString();
        }

        public static string Part2(List<List<string>> puzzleData)
        {
            int total = 0;
            int loopcount = 0;
            List<string> packGroup = new List<string>();

            foreach (List<string> part in puzzleData)
            {
                packGroup.Add(part[0] + part[1]);
                if (packGroup.Count == 3)
                {
                    loopcount++;
                    foreach (char letter in packGroup[0])
                    {
                        if (packGroup[1].IndexOf(letter) != -1)
                        {
                            if (packGroup[2].IndexOf(letter) != -1)
                            {
                                total += getRank(letter);
                                packGroup.Clear();
                                Console.WriteLine($"{ loopcount}:{letter} -> +{getRank(letter)} -> {total}");
                                break;
                            }
                        }
                    }
                }
            }

            return total.ToString();
        }

        public static int getRank(char letter)
        {
            string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return letters.IndexOf(letter) + 1;
        }


        public static List<List<string>> InputParser(string[] puzzleInput)
        {
            List<List<string>> puzzleData = new();

            foreach (string part in puzzleInput)
            {
                var first = part.Substring(0, (int)(part.Length / 2));
                var last = part.Substring((int)(part.Length / 2), (int)(part.Length / 2));
                puzzleData.Add(new List<string>{ first, last });
            }
            return puzzleData;
        }

    }
}