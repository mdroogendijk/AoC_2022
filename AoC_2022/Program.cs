namespace AdventOfCode
{
    public class Program
    {
        public static void Main()
        {
            // Day selector
            int day = 1;

            // Solutions to run for selected day
            var resultSet = day switch
            {
                1 => DayOne.Program.Main(),
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