namespace AdventOfCode.DayFour
{
    public class PartTwo
    {
        public static int GetAnswer(string fileName)
        {
            int assignmentPairs = 0;

            var lines = File.ReadLines(fileName);

            // Loop over lines
            foreach (string line in lines)
            {
                // Split into int array with start and end sections
                var sections = Array.ConvertAll(line.Split(new Char[] { ',', '-' }), int.Parse);

                // Check overlapping sections
                if (sections[0] >= sections[2] && sections[0] <= sections[3])
                {
                    assignmentPairs++;
                }
                else if (sections[1] >= sections[2] && sections[1] <= sections[3])
                {
                    assignmentPairs++;
                }
                else if (sections[3] >= sections[0] && sections[3] <= sections[1])
                {
                    assignmentPairs++;
                }
            }

            // Answer is the number of pairs having overlapping sections
            return assignmentPairs;
        }
    }
}