using StrykerDemos.MyLib._04_Palindrome;

namespace StrykerDemos.MyLib.Tests._04_Palindrome;

public class PalindromeCheckerTests
{
    [Fact]
    public void IsPalindrome_works() 
        => PalindromeChecker.IsPalindrome("noon").Should().BeTrue();
}