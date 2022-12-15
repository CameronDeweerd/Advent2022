
namespace Advent2022.Solver
{
    public interface ISolver
    {
        /// <summary>
        /// Solves the puzzle
        /// </summary>
        /// <param name="puzzleInput">the array of strings that represent the puzzle input</param>
        /// <returns>data string, part1 solution string, part 2 solution string</returns>
        public (string, string) Solve(string[] puzzleInput);
    }
}