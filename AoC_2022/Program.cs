namespace AdventOfCode
{
    public class Program
    {
        public static void Main()
        {
            // Day selector
            int day = 6;

            // Solutions to run for selected day
            var resultSet = day switch
            {
                1 => DayOne.Program.Main(),
                2 => DayTwo.Program.Main(),
                3 => DayThree.Program.Main(),
                4 => DayFour.Program.Main(),
                5 => DayFive.Program.Main(),
                6 => DaySix.Program.Main(),
                _ => new List<string>()
            };

            Console.WriteLine($"The results of day {day}:");

            // Write results
            if (resultSet.Any())
            {
                foreach (string result in resultSet) Console.WriteLine(result);
            }
        }
    }
}