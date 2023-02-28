namespace FizzBuzz.Kata;

public interface INumberHandler
{
    public bool Handle(int number, out string result);
}

class FizzBuzzHandler : INumberHandler
{
    public bool Handle(int number, out string result)
    {
        result = "FizzBuzz";
        return number % 3 == 0 && number % 5 == 0;
    }
}

class BuzzHandler : INumberHandler
{
    public bool Handle(int number, out string result)
    {
        result = "Buzz";
        return number % 5 == 0;
    }
}

class FizzHandler : INumberHandler
{
    public bool Handle(int number, out string result)
    {
        result = "Fizz";
        return number % 3 == 0;
    }
}