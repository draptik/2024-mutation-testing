namespace Demo.MyLib;

public static class SomeService
{
    public static string DoMagic(int i)
        => i < 18 ? "child" : "adult";
}