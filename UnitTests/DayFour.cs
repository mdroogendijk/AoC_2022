namespace UnitTests
{
    public class DayFour
    {
        [Fact]
        public void TestPartOne()
        {
            // Arrange
            int expected = 2;

            // Act
            int actual = AdventOfCode.DayFour.PartOne.GetAnswer("Day_4/Input/sample.txt");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPartTwo()
        {
            // Arrange
            int expected = 4;

            // Act
            int actual = AdventOfCode.DayFour.PartTwo.GetAnswer("Day_4/Input/sample.txt");

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}