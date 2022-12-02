namespace AdventOfCode.DayTwo
{
    public class PartTwo
    {
        public static int GetAnswer(string fileName)
        {
            int answer;
            int points = 0;

            var shapePoints = new Dictionary<string, int>()
            {
                {"Rock", 1 },
                {"Paper", 2 },
                {"Scissors", 3 },
            };

            // A = Rock, B = Paper, C = Scissors            
            // Loss = 0, Draw = 3, Win = 6
            var matchPoints = new List<(string, string, int)>()
            {
                ("Rock", "A", 3 ),
                ("Rock", "B", 0 ),
                ("Rock", "C", 6 ),
                ("Paper", "A", 6 ),
                ("Paper", "B", 3 ),
                ("Paper", "C", 0 ),
                ("Scissors", "A", 0 ),
                ("Scissors", "B", 6 ),
                ("Scissors", "C", 3 ),
            };

            var lines = File.ReadLines(fileName);

            // Loop over lines
            foreach (string line in lines)
            {
                // Select which match result we go for
                var matchResultSelector = line[2..3] switch
                {
                    "X" => 0,
                    "Y" => 3,
                    "Z" => 6,
                    _ => throw new NotImplementedException()
                };
                
                // Add match result points
                points += matchResultSelector;

                // Select the shape we need to get the match result
                string shapeSelector = matchPoints
                    .Where(x => x.Item2.Equals(line[0..1]) && x.Item3.Equals(matchResultSelector))
                    .Select(x => x.Item1)
                    .Single();

                // Add points for the shape selected
                points += shapePoints[shapeSelector];
            }

            // Answer is total amount of points
            answer = points;

            return answer;
        }
    }
}