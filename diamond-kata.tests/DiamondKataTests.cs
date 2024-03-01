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
    }
}