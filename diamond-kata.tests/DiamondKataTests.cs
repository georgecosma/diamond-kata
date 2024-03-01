namespace diamond_kata.tests;

public class DiamondKataTests
{
    [Fact]
    public void GenerateDiamond_FirstLetter_ShouldBeA()
    {
        // arrange
        var expectedFirstLetter = 'A';

        // act
        var actualFirstLetter = 'A'; // to replace with actual GenerateDiamond call

        // assert
        Assert.Equal(expectedFirstLetter, actualFirstLetter);
    }
}