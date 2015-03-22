namespace StringBuilderSubstringProblem
{
    using System;
    using System.Text;

    public static class ExtensionMethods
    {
        public static StringBuilder Substring(this StringBuilder strBuilder, int startIndex)
        {
            string text = strBuilder.ToString();
            text = text.Substring(startIndex);
            strBuilder.Clear();
            strBuilder.Append(text);

            return strBuilder;
        }

        public static StringBuilder Substring(this StringBuilder strBuilder, int startIndex, int length)
        {
            string text = strBuilder.ToString();
            text = text.Substring(startIndex, length);
            strBuilder.Clear();
            strBuilder.Append(text);

            return strBuilder;
        }
    }
}
