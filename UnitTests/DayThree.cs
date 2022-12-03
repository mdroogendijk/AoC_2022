namespace UnitTests
{
    public class DayThree
    {
        [Fact]
        public void TestPartOne()
        {
            // Arrange
            int expected = 157;

            // Act
            int actual = AdventOfCode.DayThree.PartOne.GetAnswer("Day_3/Input/sample.txt");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPartTwo()
        {
            // Arrange
            int expected = 70;

            // Act
            int actual = AdventOfCode.DayThree.PartTwo.GetAnswer("Day_3/Input/sample.txt");

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}