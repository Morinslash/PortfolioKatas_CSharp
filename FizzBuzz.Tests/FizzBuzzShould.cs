using FizzBuzz.Kata;
using FluentAssertions;

namespace FizzBuzz.Tests;

public class FizzBuzzShould
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "1,2")]
    [InlineData(3, "1,2,Fizz")]
    [InlineData(5, "1,2,Fizz,4,Buzz")]
    [InlineData(15, "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz")]
    public void ReturnProperOutput(int numbersRange, string expected)
    {
        var input = GenerateInput(numbersRange);
        FizzBuzzEngine.Generate(input).Should().Be(expected);
    }

    private int[] GenerateInput(int range)
    {
        return Enumerable.Range(1, range).ToArray();
    }
}