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
            var actualFirstLetter = DiamondKata.GenerateDiamond('A').Replace("_", "")[0];

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

        [Fact]
        public void GenerateDiamond_WhenCharacterB_ReturnExpectedDiamondShape()
        {
            // Arrange
            var expectedDiamondShape = "_A_\r\nB_B\r\n_A_\r\n";

            // Act
            var generateDiamondResult = DiamondKata.GenerateDiamond('B');

            // Assert
            Assert.Equal(expectedDiamondShape, generateDiamondResult);
        }

        [Fact]
        public void GenerateDiamond_WhenCharacterB_LastLetter_ShouldBeA()
        {
            // Arrange
            var expectedLastLetter = 'A';

            // Act
            var generateDiamondResult = DiamondKata.GenerateDiamond('B');
            var cleanedResult = generateDiamondResult.Replace("_", "").Replace("\r\n", "");
            var actualLastLetter = cleanedResult[cleanedResult.Length - 1];

            // Assert
            Assert.Equal(expectedLastLetter, actualLastLetter);
        }

        [Fact]
        public void GenerateDiamond_WhenCharacterC_ReturnExpectedDiamondShape()
        {
            // Arrange
             var expectedDiamondShape = "__A__\r\n_B_B_\r\nC___C\r\n_B_B_\r\n__A__\r\n";

            // Act
            var generateDiamondResult = DiamondKata.GenerateDiamond('C');

            // Assert
            Assert.Equal(expectedDiamondShape, generateDiamondResult);
        }
    }
}