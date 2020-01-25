using System;
using System.Collections.Generic;
using System.Text;

namespace Useful.String.Extensions
{
    public static class Comparer
    {
        /// <summary>
        /// Returns a value indicating whether any of the specified strings occur in this string.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <param name="keywords">The strings to seek.</param>
        /// <returns>
        /// <see cref="true"/> if any of the keywords parameters occurs within this string, or if keywords is the empty
        /// string (""); otherwise, <see cref="false"/>.
        /// </returns>
        public static bool Contains(this string str, params string[] keywords)
        {
            foreach (string word in keywords)
                if (str.Contains(word)) return true;

            return false;
        }

        /// <summary>
        /// Returns a value indicating whether any of the specified characters occur in this string.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <param name="keychars">The characters to seek.</param>
        /// <returns>
        /// <see cref="true"/> if any of the keychars parameters occurs within this string; otherwise, <see cref="false"/>.
        /// </returns>
        public static bool Contains(this string str, params char[] keychars)
        {
            foreach (char ch in keychars)
                if (str.Contains(ch)) return true;

            return false;
        }

        /// <summary>
        /// Returns a value indicating whether any of the specified strings occur in this string,
        /// using the specified comparison rules.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <param name="comparison">One of the enumeration values that specifies the rules to use in the comparison.</param>
        /// <param name="keywords">The strings to seek.</param>
        /// <returns>
        /// <see cref="true"/> if any of the keywords parameters occurs within this string, or if value is the empty
        /// string (""); otherwise, <see cref="false"/>.
        /// </returns>
        public static bool Contains(this string str, StringComparison comparison, params string[] keywords)
        {
            foreach (string word in keywords)
                if (str.Contains(word, comparison)) return true;

            return false;
        }

        /// <summary>
        /// Returns a value indicating whether any of the specified characters occur in this string,
        /// using the specified comparison rules.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <param name="comparison">One of the enumeration values that specifies the rules to use in the comparison.</param>
        /// <param name="keychars">The characters to seek.</param>
        /// <returns>
        /// <see cref="true"/> if any of the keychars parameters occurs within this string; otherwise, <see cref="false"/>.
        /// </returns>
        public static bool Contains(this string str, StringComparison comparison, params char[] keychars)
        {
            foreach (char ch in keychars)
                if (str.Contains(ch, comparison)) return true;

            return false;
        }
    }
}
