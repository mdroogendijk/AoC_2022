namespace AdventOfCode.DaySeven
{
	public class Directory
	{
		public string name;
		public Directory? parent;
		public List<Directory> subDirectories;
		public List<int> files;
		public int totalSize;

		public Directory()
		{
			name = "/";
			parent = null;
			subDirectories = new List<Directory>();
			files = new List<int>();
		}
	}
}
