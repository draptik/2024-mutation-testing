namespace StrykerDemos.MyLib._01_CaptainObvious;

public class SomeService
{
    private int BaseLine { get; }

    public SomeService(int baseLine)
    {
        BaseLine = baseLine;
    }

    public bool IsSmallerThanBaseline(int number)
    {
        return number < BaseLine;
    }
}