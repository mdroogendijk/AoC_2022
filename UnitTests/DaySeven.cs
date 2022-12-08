namespace UnitTests
{
    public class DaySeven
    {
        [Fact]
        public void TestPartOne()
        {
            // Arrange
            int expected = 95437;

            // Act
            int actual = AdventOfCode.DaySeven.PartOne.GetAnswer("Day_7/Input/sample.txt");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPartTwo()
        {
            // Arrange
            int expected = 24933642;

            // Act
            int actual = AdventOfCode.DaySeven.PartTwo.GetAnswer("Day_7/Input/sample.txt");

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}