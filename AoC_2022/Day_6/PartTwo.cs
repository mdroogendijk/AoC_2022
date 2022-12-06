namespace AdventOfCode.DaySix
{
    public class PartTwo
    {
        public static long GetAnswer(string fileName)
        {
            long characterCount;
            var marker = new Queue<int>();
            int markerSize = 14;

            using FileStream fs = File.OpenRead(fileName);

            while (true)
            {
                // Get character as string
                var currentByte = fs.ReadByte();

                // Construct marker to a maximum of x characters
                if (marker.Count == markerSize)
                {
                    // Use current position if x unique characters in a row are found
                    if (marker.Distinct().Count() == markerSize)
                    {
                        characterCount = fs.Position - 1;
                        break;
                    }
                    else
                    {
                        // Update FIFO-style
                        marker.Dequeue();
                        marker.Enqueue(currentByte);
                    }
                }
                else
                {
                    marker.Enqueue(currentByte);
                }
            }

            // Answer is the number of characters read until x unique characters in a row have been found
            return characterCount;
        }
    }
}