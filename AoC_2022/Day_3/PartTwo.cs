using System.Linq;

namespace AdventOfCode.DayThree
{
    public class PartTwo
    {
        internal static int LetterToNumber(char c)
        {
            int index = 0;

            // Setting index for A-Z = 27-52
            if (char.IsUpper(c))
            {
                c = char.ToLower(c);
                index += 26;
            }
            // Get integer position for lower case char
            index += (int)c % 32;
            return index;
        }

        public static int GetAnswer(string fileName)
        {
            int sumPriorities = 0;
            int groupSize = 3;

            var lines = File.ReadLines(fileName);

            for (int i = 0; i < lines.Count(); i += groupSize)
            {
                var checkedChars = new List<char>();
                // Form the next group
                var group = lines.Skip(i).Take(groupSize);

                foreach (char c in group.First())
                {
                    // Only check each item type once
                    if (!checkedChars.Contains(c))
                    {
                        // Check if every member has this item type
                        if (group.All(x => x.Contains(c)))
                        {
                            // Add priority to sum
                            sumPriorities += LetterToNumber(c);
                        }
                        checkedChars.Add(c);
                    }
                }                
            }

            // Answer is the sum of priorities
            return sumPriorities;
        }
    }
}