namespace SIS.HTTP.Extensions
{
    public static class StringExtension
    {
        public static string Capitalize(this string text)
        {
            string result = char.ToUpper(text[0]) + text.Substring(1).ToLower();
            return result;
        }
    }
}