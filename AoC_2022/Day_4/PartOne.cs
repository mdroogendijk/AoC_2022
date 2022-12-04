namespace AdventOfCode.DayFour
{
    public class PartOne
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

                // Check fully overlapping sections
                if (sections[0] >= sections[2] && sections[1] <= sections[3])
                {
                    assignmentPairs++;
                }
                else if (sections[2] >= sections[0] && sections[3] <= sections[1])
                {
                    assignmentPairs++;
                }
            }

            // Answer is the number of pairs having fully overlapping sections
            return assignmentPairs;
        }
    }
}