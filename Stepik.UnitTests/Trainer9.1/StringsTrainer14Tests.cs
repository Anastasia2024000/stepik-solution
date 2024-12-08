using Stepik.Trainer9._1;

namespace Stepik.UnitTests.Trainer9._1;

public class StringsTrainer14Tests
{
    private readonly StringsTrainer14 _sut = new();

    [Fact]
    public void WhenMessageAndReplacingSubstringIsValid_ShouldReturnReplaceString()
    {
        // arrange
        const string replace = "бананы";
        const string message = "Я люблю яблоки.";
        const string expected = "Я люблю бананы.";

        // act
        var result = _sut.ReplaceSubstringInMessage(replace, message);

        // assert
        result.Should().Be(expected);
    }
}
