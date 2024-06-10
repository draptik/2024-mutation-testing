namespace StrykerDemos.MyLib.Tests;

public class FizzBuzzerTests
{
    [Fact]
    public void When_given_3_return_Fizz()
    {
        var actual = FizzBuzzer.FizzBuzz(3);
        const string expected = "Fizz";
        Assert.Equal(expected, actual);
    }
}