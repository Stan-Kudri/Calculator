using System.Text.RegularExpressions;

namespace Calculator.WPF.Extension
{
    public static class ValidateStringUsRegexExtension
    {
        private readonly static Regex RegexValue = new Regex(@"^-?\d*[,.]?\d*$");

        public static bool TryIsMatchStr(this string str) => RegexValue.IsMatch(str);
    }
}
