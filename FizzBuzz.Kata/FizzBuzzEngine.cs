namespace FizzBuzz.Kata;

public static class FizzBuzzEngine
{
    public static string Generate(int[] input)
    {
        return string.Join(',', input
            .Select(Convert)
            .ToList());
    }

    private static string Convert(int number)
    {
        if (number % 3 == 0 && number%5==0)
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
}