using Demo.MyLib;

namespace Demo.Tests;

public class SomeServiceTests
{
    [Theory]
    [InlineData(5, "child")]
    [InlineData(20, "adult")]
    public void DoMagicWorks(int i, string expected) 
        => SomeService.DoMagic(i).Should().Be(expected);
}