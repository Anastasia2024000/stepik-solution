using Stepik.Trainer9;

namespace Stepik.UnitTests.Trainer9;

public class StringsTrainer13Tests
{
    private readonly StringsTrainer13 _sut = new();

    [Fact]
    public void WhenSymolsIsExistsInString_ShouldReturnExpectedString()
    {
        // arrange
        const string search = "Ривенделл";
        const string expected = "р:*,и:*,в:*,е:**,н:*,д:*,л:**";

        // act
        var result = _sut.FindRepeatingOfSymbols(search);

        // assert
        result.Should().Be(expected);
    }

}