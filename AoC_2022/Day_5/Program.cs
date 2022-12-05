namespace AdventOfCode.DayFive
{
    public class Program
    {
        public static List<string> Main()
        {
            var resultSet = new List<string>();

            // Part selector
            bool inputPartOne = true;
            bool inputPartTwo = true;

            if (inputPartOne)
            {
                string answerPartOne = PartOne.GetAnswer("Day_5/Input/input.txt");
                resultSet.Add($"The answer for the input file in Part 1 = {answerPartOne}");
            }

            if (inputPartTwo)
            {
                string answerPartTwo = PartTwo.GetAnswer("Day_5/Input/input.txt");
                resultSet.Add($"The answer for the input file in Part 2 = {answerPartTwo}");
            }

            return resultSet;
        }
    }
}