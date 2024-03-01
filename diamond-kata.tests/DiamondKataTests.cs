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
            var expectedDiamondShape = "_A_\n" + "B_B\n" + "_A_";

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
            var cleanedResult = generateDiamondResult.Replace("_", "");
            var actualLastLetter = cleanedResult[cleanedResult.Length - 1];

            // Assert
            Assert.Equal(expectedLastLetter, actualLastLetter);
        }

        [Fact]
        public void GenerateDiamond_WhenCharacterC_ReturnExpectedDiamondShape()
        {
            // Arrange
             var expectedDiamondShape = "__A__\n" + "_B_B_\n" + "C_____C\n" + "_B_B_\n" + "__A__";

            // Act
            var generateDiamondResult = DiamondKata.GenerateDiamond('B');

            // Assert
            Assert.Equal(expectedDiamondShape, generateDiamondResult);
        }
    }
}