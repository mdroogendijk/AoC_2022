namespace UnitTests
{
    public class DayTwo
    {
        [Fact]
        public void TestPartOne()
        {
            // Arrange
            int expected = 15;

            // Act
            int actual = AdventOfCode.DayTwo.PartOne.GetAnswer("Day_2/Input/sample.txt");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPartTwo()
        {
            // Arrange
            int expected = 12;

            // Act
            int actual = AdventOfCode.DayTwo.PartTwo.GetAnswer("Day_2/Input/sample.txt");

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}