using StrykerDemos.MyLib._03_Palindrome;

namespace StrykerDemos.MyLib.Tests._03_Palindrome;

public class PalindromeCheckerTests
{
    [Fact]
    public void IsPalindrome_works() 
        => PalindromeChecker.IsPalindrome("noon").Should().BeTrue();
}