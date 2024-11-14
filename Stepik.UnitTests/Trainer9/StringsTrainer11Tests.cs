using System.Reflection.Metadata;
using FluentAssertions;
using Stepik.Trainer9;

namespace Stepik.UnitTests.Trainer9;

public class StringsTrainer11Tests
{
    private readonly StringsTrainer1 _sut = new();
    
    [Fact]
    public void WhenStringIsCorrect_ShouldReturnSlug()
    {
        // act
        const string actual = "The Hellfire Club";
        const string expected = "the-hellfire-club";
        
        // arrange
        var result = _sut.Trainer11(actual);

        // assert
        result.Should().NotBeNullOrWhiteSpace();
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("Dear Billy", "dear-billy")]
    [InlineData("The Hellfire Club", "the-hellfire-club")]
    public void WhenStringsIsCorrect_ShouldReturnSlug(string actual, string expected)
    {
        
        // arrange
        var result = _sut.Trainer11(actual);

        // assert
        result.Should().NotBeNullOrWhiteSpace();
        result.Should().Be(expected);
    }
}