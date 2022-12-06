namespace UnitTests
{
    public class DaySix
    {
        [Theory]
        [InlineData(1, 7)]
        [InlineData(2, 5)]
        [InlineData(3, 6)]
        [InlineData(4, 10)]
        [InlineData(5, 11)]
        public void TestPartOne(int sampleNumber, long expected)
        {
            // Arrange
            var sampleFile = $"Day_6/Input/sample{sampleNumber}.txt";

            // Act
            long actual = AdventOfCode.DaySix.PartOne.GetAnswer(sampleFile);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 19)]
        [InlineData(2, 23)]
        [InlineData(3, 23)]
        [InlineData(4, 29)]
        [InlineData(5, 26)]
        public void TestPartTwo(int sampleNumber, long expected)
        {
            // Arrange
            var sampleFile = $"Day_6/Input/sample{sampleNumber}.txt";

            // Act
            long actual = AdventOfCode.DaySix.PartTwo.GetAnswer(sampleFile);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}