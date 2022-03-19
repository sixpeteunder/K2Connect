namespace K2Connect.Test;

using K2Connect;
using Xunit;

public class K2Test
{
    [Fact]
    public void Given_When_Then()
    {
        var options = new K2Options(string.Empty, string.Empty, string.Empty, string.Empty);
        var k2 = new K2(options);

        Assert.NotNull(k2);
    }
}
