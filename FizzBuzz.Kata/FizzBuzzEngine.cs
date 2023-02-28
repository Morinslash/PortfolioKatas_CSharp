using System.Text;

namespace FizzBuzz.Kata;

public static class FizzBuzzEngine
{
    public static string Generate(int[] input)
    {
        return string.Join(',', input
            .Select(number => number % 3 == 0 ? "Fizz" : number.ToString())
            .ToList());
    }
}