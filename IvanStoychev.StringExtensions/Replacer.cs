using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace IvanStoychev.StringExtensions
{
    public static class Replacer
    {
        /// <summary>
        /// Replaces all occurrences of the specified "oldStrings" with the provided "newString". Case sensetive.
        /// </summary>
        /// <param name="newString">The string to replace all occurances of "oldStrings".</param>
        /// <param name="oldStrings">Strings to be replaced.</param>
        /// <returns>A string with all instances of "oldStrings" replaced by "newString".</returns>
        public static string Replace(this string str, string newString, params string[] oldStrings)
        {
            return ReplaceStringConsiderCase(str, oldStrings, newString);
        }

        /// <summary>
        /// Replaces all occurrences of the specified "oldStrings" with the provided "newString". Case sensetive.
        /// </summary>
        /// <param name="ignoreCase">Whether the replacement should ignore case or not.</param>
        /// <param name="newString">The string to replace all occurances of "oldStrings".</param>
        /// <param name="oldStrings">Strings to be replaced.</param>
        /// <returns>A string with all instances of "oldStrings" replaced by "newString".</returns>
        public static string Replace(this string str, bool ignoreCase, string newString, params string[] oldStrings)
        {
            if (ignoreCase)
                return ReplaceStringIgnoreCase(str, oldStrings, newString);
            else
                return ReplaceStringConsiderCase(str, oldStrings, newString);
        }

        /// <summary>
        /// Replaces all occurrences of the specified "oldStrings" with the provided "newString". Case sensetive.
        /// </summary>
        /// <param name="newString">The string to replace all occurances of "oldStrings".</param>
        /// <param name="oldStrings">Collection of strings to be replaced.</param>
        /// <returns>A string with all instances of "oldStrings" replaced by "newString".</returns>
        public static string Replace(this string str, IEnumerable<string> oldStrings, string newString)
        {
            return ReplaceStringConsiderCase(str, oldStrings, newString);
        }

        /// <summary>
        /// Replaces all occurrences of the specified "oldStrings" with the provided "newString".
        /// </summary>
        /// <param name="ignoreCase">Whether the replacement should ignore case or not.</param>
        /// <param name="newString">The string to replace all occurances of "oldStrings".</param>
        /// <param name="oldStrings">Collection of strings to be replaced.</param>
        /// <returns>A string with all instances of "oldStrings" replaced by "newString".</returns>
        public static string Replace(this string str, IEnumerable<string> oldStrings, string newString, bool ignoreCase)
        {
            if (ignoreCase)
                return ReplaceStringIgnoreCase(str, oldStrings, newString);
            else
                return ReplaceStringConsiderCase(str, oldStrings, newString);
        }

        private static string ReplaceStringConsiderCase(this string value, IEnumerable<string> oldStrings, string newString)
        {
            foreach (var item in oldStrings)
                value = Regex.Replace(value, Regex.Escape(item), newString, RegexOptions.None);

            return value;
        }

        private static string ReplaceStringIgnoreCase(this string value, IEnumerable<string> oldStrings, string newString)
        {
            foreach (var item in oldStrings)
                value = Regex.Replace(value, Regex.Escape(item), newString, RegexOptions.IgnoreCase);

            return value;
        }
    }
}
