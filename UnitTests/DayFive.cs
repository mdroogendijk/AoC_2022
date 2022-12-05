namespace UnitTests
{
    public class DayFive
    {
        [Fact]
        public void TestPartOne()
        {
            // Arrange
            string expected = "CMZ";

            // Act
            string actual = AdventOfCode.DayFive.PartOne.GetAnswer("Day_5/Input/sample.txt");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPartTwo()
        {
            // Arrange
            string expected = "MCD";

            // Act
            string actual = AdventOfCode.DayFive.PartTwo.GetAnswer("Day_5/Input/sample.txt");

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}