using Advent2022.Solver;
namespace Advent2022.Solver.Day
{
    public class Day2Solver : ISolver
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
            int score = 0;
            foreach (IList<string> match in puzzleData)
            {
                string me = match[1];
                string them = match[0];
                switch (me)
                {
                    case "X":
                        score += 1;
                        switch (them)
                        {
                            case "A":
                                score += 3; break;
                            case "B":
                                score += 0; break;
                            case "C":
                                score += 6; break;
                        }
                        break;
                    case "Y":
                        score += 2;
                        switch (them)
                        {
                            case "A":
                                score += 6; break;
                            case "B":
                                score += 3; break;
                            case "C":
                                score += 0; break;
                        }
                        break;
                    case "Z":
                        score += 3;
                        switch (them)
                        {
                            case "A":
                                score += 0; break;
                            case "B":
                                score += 6; break;
                            case "C":
                                score += 3; break;
                        }
                        break;
                }

            }
            return score.ToString();
        }

        public static string Part2(List<List<string>> puzzleData)
        {
            int score = 0;
            foreach (IList<string> match in puzzleData)
            {
                string me = match[1];
                string them = match[0];
                switch (me)
                {
                    case "X":
                        score += 0;
                        switch (them)
                        {
                            case "A":
                                score += 3; break;
                            case "B":
                                score += 1; break;
                            case "C":
                                score += 2; break;
                        }
                        break;
                    case "Y":
                        score += 3;
                        switch (them)
                        {
                            case "A":
                                score += 1; break;
                            case "B":
                                score += 2; break;
                            case "C":
                                score += 3; break;
                        }
                        break;
                    case "Z":
                        score += 6;
                        switch (them)
                        {
                            case "A":
                                score += 2; break;
                            case "B":
                                score += 3; break;
                            case "C":
                                score += 1; break;
                        }
                        break;
                }

            }
            return score.ToString();
        }


        public static List<List<string>> InputParser(string[] puzzleInput)
        {

            List<List<string>> puzzleData = new();
            string[] game = { "", "" };

            foreach (string line in puzzleInput)
            {
                game = line.Split(" ");
                puzzleData.Add(new List<string>(game));
            }
            return puzzleData;
        }

    }
}