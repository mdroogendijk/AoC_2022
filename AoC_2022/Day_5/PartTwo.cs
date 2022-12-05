namespace AdventOfCode.DayFive
{
    public class PartTwo
    {
        public static string GetAnswer(string fileName)
        {
            string topCrates = string.Empty;

            var lines = File.ReadLines(fileName).ToList();

            // Split input file on blank line
            var seperator = lines.FindIndex(x => string.IsNullOrWhiteSpace(x));

            // Select lines containing movement actions
            var movementActions = lines.Skip(seperator + 1).ToList();

            // Find the total number of stacks
            var stacksCount = char.GetNumericValue(lines.ElementAt(seperator - 1).Max());

            var stacks = new List<List<char>>();

            for (int i = 0; i < (stacksCount); i++)
            {
                var stack = new List<char>();

                // Get the position of (the letter inside) the first crate (horizontal, vertical)
                ValueTuple<int, int> cratePosition = ((i * 4) + 1, seperator - 2);

                // Every stack has at least one crate
                var crate = true;

                // Stop iteration if no crates are found at position
                while (crate && cratePosition.Item2 >= 0)
                {
                    // If crate exists
                    if (!Char.IsWhiteSpace(lines[cratePosition.Item2].ElementAt(cratePosition.Item1)))
                    {
                        // Add crate to stack
                        stack.Add(lines[cratePosition.Item2][cratePosition.Item1]);

                        // Get the next crate
                        cratePosition.Item2 -= 1;
                    }
                    else
                    {
                        crate = false;
                    }
                }

                // Add stack to the stacks list
                stacks.Add(stack);
            }

            // Loop over movement actions
            foreach (string movement in movementActions)
            {
                // Split into string array
                var movementDetails = movement.Split(' ');

                // Count of crates to move
                int moveCount = int.Parse(movementDetails[1]);

                // Source stack (reduce 1 to account for index 0)
                int sourceStack = int.Parse(movementDetails[3]) - 1;

                // Target stack (reduce 1 to account for index 0)
                int targetStack = int.Parse(movementDetails[5]) - 1;

                // Get crates
                var items = stacks[sourceStack].TakeLast(moveCount).ToList();

                // Delete from source stack, add to target stack
                stacks[sourceStack].RemoveRange(stacks[sourceStack].Count - moveCount, moveCount);
                stacks[targetStack].AddRange(items);                
            }

            foreach (var stack in stacks)
            {
                topCrates += stack.Last();
            }

            // Answer is the number of pairs having fully overlapping sections
            return topCrates;
        }
    }
}