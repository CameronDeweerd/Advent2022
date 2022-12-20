using Advent2022.Solver;
namespace Advent2022.Solver.Day
{
    public class Day5Solver : ISolver
    {
        public (string, string) Solve(string[] puzzleInput)
        {

            (List<List<int>> Instructions, List<List<char>> puzzleData) = InputParser(puzzleInput);
            string part1Sol = Part1(Instructions, puzzleData);
            (Instructions, puzzleData) = InputParser(puzzleInput);
            string part2Sol = Part2(Instructions, puzzleData);

            return (part1Sol, part2Sol);
        }

        public static string Part1(List<List<int>> Instructions, List<List<char>> puzzleData)
        {

            foreach (List<int> instruction in Instructions)
            {
                (int qty, int start, int end) = (instruction[0],instruction[1],instruction[2]);
                puzzleData[end].AddRange(puzzleData[start].TakeLast(qty).Reverse());
                puzzleData[start].RemoveRange(puzzleData[start].Count-qty, qty);
            }

            string output = "";
            foreach (List<char> pile in puzzleData)
            {
                if (pile.Any())
                {
                    output = String.Concat(output, pile[pile.Count-1]);
                }
            }
            return output;
        }

        public static string Part2(List<List<int>> Instructions, List<List<char>> puzzleData)
        {

            foreach (List<int> instruction in Instructions)
            {
                (int qty, int start, int end) = (instruction[0], instruction[1], instruction[2]);
                puzzleData[end].AddRange(puzzleData[start].TakeLast(qty));
                puzzleData[start].RemoveRange(puzzleData[start].Count - qty, qty);
            }

            string output = "";
            foreach (List<char> pile in puzzleData)
            {
                if (pile.Any())
                {
                    output = String.Concat(output, pile[pile.Count - 1]);
                }
            }
            return output;
        }


        public static (List<List<int>>, List<List<char>>) InputParser(string[] puzzleInput)
        {

            List<List<char>> piles = new();
            List<List<int>> instructions = new();
            int splitIndex = 0;
            foreach (string s in puzzleInput)
            {
                if (s == "")
                {
                    break;
                }
                splitIndex++;
            }

            
            string[] instructionText = puzzleInput[(splitIndex+1)..^0];

            foreach (string instruction in instructionText)
            {
                string[] line = instruction.Split(' ');
                instructions.Add(new List<int> {Int32.Parse(line[1]), Int32.Parse(line[3])-1, Int32.Parse(line[5])-1});
            }

            List<string> pileText = new List<string>(puzzleInput[0..(splitIndex - 1)]);
            pileText.Reverse();
            int columnCount = (pileText[0].Length + 1) / 4;
            for (int i = 0; i < columnCount; i++)
            {
                piles.Add(new List<char>());
            }

            
            foreach (string pileLine in pileText)
            {
                for (int i = 1; i < pileText[0].Length + 1; i+=4)
                {
                    if (pileLine[i] != ' ')
                    {
                        piles[(i-1)/4].Add(pileLine[i]);
                    }
                }


            }

            return (instructions, piles);

        }

    }
}