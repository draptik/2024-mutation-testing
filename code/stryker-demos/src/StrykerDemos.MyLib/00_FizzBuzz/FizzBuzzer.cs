namespace StrykerDemos.MyLib._00_FizzBuzz;

public static class FizzBuzzer
{
    public static string FizzBuzz(int number)
    {
        if (number % 5 == 0 && number % 3 == 0)
        {
            return "FizzBuzz";
        }

        if (number % 3 == 0)
        {
            return "Fizz";
        }

        if (number % 5 == 0)
        {
            return "Buzz";
        }

        return number.ToString();
    }

    public static IEnumerable<string> FizzBuzzNumbers(int maxNumber)
    {
        List<int> numbers = [..Enumerable.Range(1, maxNumber)];
        return numbers.Select(FizzBuzz);
    }
}