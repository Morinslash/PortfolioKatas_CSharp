namespace FizzBuzz.Kata;

public static class FizzBuzzEngine
{
    private static List<INumberHandler> Handlers = new()
    {
        new FizzBuzzHandler(),
        new BuzzHandler(),
        new FizzHandler()
    };
    public static string Generate(int[] input)
    {
        return string.Join(',', input
            .Select(Convert)
            .ToList());
    }

    private static string Convert(int number)
    {
        foreach (var handler in Handlers)
        {
            if (handler.Handle(number, out var result))
            {
                return result;
            }
        }

        return number.ToString();
    }
}