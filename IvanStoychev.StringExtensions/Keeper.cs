using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text.RegularExpressions;

namespace IvanStoychev.StringExtensions
{

    public static class Keeper
    {
        /// <summary>
        /// Keeps all numbers from the original string, removing letters and special characters.
        /// </summary>
        [Pure]
        public static string KeepOnlyNumbers([NotNull] this string originalString)
        {
            return Regex.Replace(originalString, @"[^\d]", "");
        }

        /// <summary>
        /// Keeps all special characters from the original string, removing letters and numbers.
        /// </summary>
        [Pure]
        public static string KeepOnlySpecialCharacters([NotNull] this string originalString)
        {
            string specialCharacters = string.Empty;

            foreach (var item in originalString.Where(x => !char.IsLetterOrDigit(x)).GroupBy(x => x))
                specialCharacters = specialCharacters + item.Key;

            return specialCharacters;
        }

        /// <summary>
        /// Keeps all alphabetical letters from the original string, removing special characters and numbers.
        /// </summary>
        [Pure]
        public static string KeepOnlyLetters([NotNull] this string originalString)
        {        
            return Regex.Replace(originalString, @"[^a-zA-Z]", string.Empty);
        }
    }
}
