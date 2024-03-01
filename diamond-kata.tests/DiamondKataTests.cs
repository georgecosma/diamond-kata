namespace diamond_kata.tests
{
    public class DiamondKataTests
    {
        [Fact]
        public void GenerateDiamond_FirstLetter_ShouldBeA()
        {
            // arrange
            var expectedFirstLetter = 'A';

            // act
            var actualFirstLetter = DiamondKata.GenerateDiamond('A')[0];

            // assert
            Assert.Equal(expectedFirstLetter, actualFirstLetter);
        }
    }
}