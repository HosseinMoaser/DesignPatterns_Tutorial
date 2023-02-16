namespace Factorry_Pattern.Core.Classes;

public static class Converters
{
    public static int ConvertToInt32(this string value)
    {
        if(string.IsNullOrWhiteSpace(value))
            return 0;
        return Int32.Parse(value);
    }
}
