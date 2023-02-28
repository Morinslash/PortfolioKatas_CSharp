using FizzBuzz.Kata;
using FluentAssertions;

namespace FizzBuzz.Tests;

public class FizzBuzzShould
{
    [Fact]
    public void Return1AsAStringWhenArrayWithOnly1Passed()
    {
        var input = new int[]{1};
        FizzBuzzEngine.Generate(input).Should().Be("1");
    }

    [Fact]
    public void Return1And2InCommaSeparatedStringWhenArrayIsWith1And2()
    {
        var input = new int[]{1,2};
        FizzBuzzEngine.Generate(input).Should().Be("1,2");
    }

    [Fact]
    public void Return12FizzWhenArrayRangeIsFrom1To3()
    {
        var input = new int[]{1,2,3};
        FizzBuzzEngine.Generate(input).Should().Be("1,2,Fizz");
    }
}