namespace AdventOfCode.DayOne
{
    public class PartOne
    {
        public static int GetAnswer(string fileName)
        {
            int answer;
            int calories = 0;
            var totalCalories = new List<int>();

            var lines = File.ReadLines(fileName);
            int linesCount = lines.Count();

            // Loop over lines
            for(int count = 0; count < linesCount; count++)
            {
                string line = lines.ElementAt(count);

                // Add calories
                if (!string.IsNullOrWhiteSpace(line))
                {
                    calories += int.Parse(line);
                }
                // Write to list, start new count
                else
                {
                    totalCalories.Add(calories);
                    calories = 0;
                }

                // Last line in file
                if ((count + 1) == linesCount)
                {
                    totalCalories.Add(calories);
                }
            }

            // Select highest value from the list
            answer = totalCalories.Max();

            return answer;
        }
    }
}