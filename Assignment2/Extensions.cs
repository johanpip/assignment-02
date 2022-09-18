namespace Assignment2;

public static class Extensions
{
    public static IEnumerable<int> Flatten(IEnumerable<int>[] xs)
    {
        return xs.SelectMany(x => x);
    }

    public static IEnumerable<int> SelectDivisibleBy7AndGreaterThan42(int[] ys)
    {
        return ys.Where(x => x > 42 && x % 7 == 0);
    }

    public static IEnumerable<int> SelectLeapYears(int[] ys)
    {
        return ys.Where(x => DateTime.IsLeapYear(x));
    }

    public static bool IsSecure(Uri uri)
    {
        return uri.Scheme == "https";
    }

    public static int WordCount(string str)
    {
        return str.Split(' ').Length;
    }

}
