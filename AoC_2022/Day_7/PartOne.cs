namespace AdventOfCode.DaySeven
{
    public class PartOne
    {
        internal static long getSize(Directory cwd)
        {
            return cwd.files.Sum();
        }

        internal static int PopulateSizes(Directory directory, ref List<int> directoriesSizes)
        {
            if (directory.files.Any())
                directory.totalSize += directory.files.Sum();
            if (directory.subDirectories.Any())
                foreach (var subDir in directory.subDirectories)
                    directory.totalSize += PopulateSizes(subDir, ref directoriesSizes);

            directoriesSizes.Add(directory.totalSize);

            return directory.totalSize;
        }

        public static int GetAnswer(string fileName)
        {
            int maxSize = 100000;

            var rootDir = new Directory();
            var directoriesSizes = new List<int>();

            var cwd = rootDir;

            var lines = File.ReadLines(fileName).Skip(1).ToList();

            // Perform terminal actions
            foreach (string line in lines)
            {
                // Do nothing for ls commands
                if (line.Equals("$ ls"))
                {
                }
                // Go to parent dir
                else if (line.Equals("$ cd .."))
                {
                    cwd = cwd.parent;
                }
                // Go to subdir
                else if (line.StartsWith("$ cd"))
                {
                    var dirName = line.Split(' ')[2].ToString();
                    cwd = cwd.subDirectories.Single(x => x.name.Equals(dirName));
                }
                // Add dir to list of subdirectories
                else if (line.StartsWith("dir"))
                {
                    var dirName = line.Split(' ')[1].ToString();
                    cwd.subDirectories.Add(new Directory()
                    {
                        name = dirName,
                        parent = cwd
                    });
                }
                // Add file (size) to list of files
                else
                {
                    var fileSize = int.Parse(line.Split(' ')[0]);
                    cwd.files.Add(fileSize);
                }
            }

            // Recursively check total size of directories
            PopulateSizes(rootDir, ref directoriesSizes);                       

            // Answer is the sum of all the directory sizes, where size below maxSize
            return directoriesSizes.Where(size => size <= maxSize).Sum();
        }
    }
}