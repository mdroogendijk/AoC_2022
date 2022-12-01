namespace UnitTests
{
    public class DayOne
    {
        [Fact]
        public void TestPartOne()
        {
            // Arrange
            int expected = 24000;

            // Act
            int actual = AdventOfCode.DayOne.PartOne.GetAnswer("Day_1/Input/sample.txt");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPartTwo()
        {
            // Arrange
            int expected = 45000;

            // Act
            int actual = AdventOfCode.DayOne.PartTwo.GetAnswer("Day_1/Input/sample.txt");

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}