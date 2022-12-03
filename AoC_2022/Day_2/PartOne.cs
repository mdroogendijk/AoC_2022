namespace AdventOfCode.DayTwo
{
    public class PartOne
    {
        public static int GetAnswer(string fileName)
        {
            int answer;
            int points = 0;

            // X = Rock, Y = Paper, Z = Scissors
            var shapePoints = new Dictionary<string, int>()
            {
                {"X", 1 },
                {"Y", 2 },
                {"Z", 3 },
            };

            // A = Rock, B = Paper, C = Scissors            
            // Loss = 0, Draw = 3, Win = 6
            var matchPoints = new List<(string, string, int)>()
            {
                ("X", "A", 3 ),
                ("X", "B", 0 ),
                ("X", "C", 6 ),
                ("Y", "A", 6 ),
                ("Y", "B", 3 ),
                ("Y", "C", 0 ),
                ("Z", "A", 0 ),
                ("Z", "B", 6 ),
                ("Z", "C", 3 ),
            };

            var lines = File.ReadLines(fileName);

            // Loop over lines
            foreach(string line in lines)
            {
                // Add points for the shape selected
                points += shapePoints[line[2..3]];

                // Add points for the match result
                points += matchPoints
                    .Where(x => x.Item1.Equals(line[2..3]) && x.Item2.Equals(line[0..1]))
                    .Select(x => x.Item3)
                    .Single();
            }

            // Answer is total amount of points
            answer = points;

            return answer;
        }
    }
}