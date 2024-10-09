namespace Lib;

public static class StringExtensionMethods
{
    public static string ReverseString(this string str)
    {
        return string.Concat(str.Reverse());
    }

    public static int CountChar(this string str, char ch)
    {
        return str.Count(c => c == ch);
    }
}

