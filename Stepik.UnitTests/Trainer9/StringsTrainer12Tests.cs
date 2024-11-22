using Stepik.Trainer9;

namespace Stepik.UnitTests.Trainer9;

public class StringsTrainer12Tests
{
    private readonly StringsTrainer12 _sut = new();
    
    [Fact]
    public void WhenSearchIsExistsInMessage_ShouldReturnTrue()
    {
        // arrange
        const string search = "одежду";
        const string message = "Учитесь выбирать свои мысли, как выбираете в шкафу одежду каждый день.";
        const bool expected = true;
        
        // act
        var result = _sut.IsSearchContainsInMessage(search, message);

        // assert
        result.Should().Be(expected);
    }
    
    [Fact]
    public void WhenSearchIsNotExistsInMessage_ShouldReturnFalse()
    {
        // arrange
        const string search = "приставку";
        const string message = "Учитесь выбирать свои мысли, как выбираете в шкафу одежду каждый день.";
        const bool expected = false;
        
        // act
        var result = _sut.IsSearchContainsInMessage(search, message);

        // assert
        result.Should().Be(expected);
    }
}