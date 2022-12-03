namespace AdventOfCode.DayThree
{
    public class PartOne
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

            var lines = File.ReadLines(fileName);

            // Loop over lines
            foreach(ReadOnlySpan<char> line in lines)
            {
                var checkedChars = new List<char>();
                int length = line.Length;
                
                // Slice into two compartments
                var firstCompartment = line[..(length / 2)];
                var secondCompartment = line[(length / 2)..];               

                foreach (char c in firstCompartment)
                {
                    // Only check each item type once
                    if (!checkedChars.Contains(c))
                    {
                        // Get common item type
                        if (secondCompartment.Contains(c))
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