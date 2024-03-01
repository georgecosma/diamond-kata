namespace diamond_kata.tests
{
    public class DiamondKataTests
    {
        [Fact]
        public void GenerateDiamond_ShouldNotBeAnEmptyString()
        {
            // Arrange

            // Act
            var generateDiamondResult = DiamondKata.GenerateDiamond('A');

            // Assert
            Assert.NotEmpty(generateDiamondResult);
        }

        [Fact]
        public void GenerateDiamond_FirstLetter_ShouldBeA()
        {
            // Arrange
            var expectedFirstLetter = 'A';

            // Act
            var actualFirstLetter = DiamondKata.GenerateDiamond('A')[0];

            // Assert
            Assert.Equal(expectedFirstLetter, actualFirstLetter);
        }

        [Fact]
        public void GenerateDiamond_WhenCharacterB_SecondRowShouldContainB()
        {
            // Arrange
            var expectedLetter = "B";

            // Act
            var generateDiamondResult = DiamondKata.GenerateDiamond('B');
            var indexOfFirstNewLine = generateDiamondResult.IndexOf('\n');
            var secondLine = generateDiamondResult.Substring(indexOfFirstNewLine + 1);

            // Assert
            Assert.Contains(expectedLetter, secondLine);
        }
    }
}