namespace OOP_Calculator.Extensions
{
    public static class StringExt
    {
        public static string RemoveLastChar(this string value)
        {
            return value.Remove(value.Length - 1);
        }

        public static bool IsFloat(this string value)
        {
            return value.Contains('.');
        }

        public static bool HasValue(this string value)
        {
            return !string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value);
        }
    }
}
