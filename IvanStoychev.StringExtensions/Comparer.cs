using System;
using System.Collections.Generic;
using System.Linq;

namespace IvanStoychev.StringExtensions
{
    public static class Comparer
    {
        /// <summary>
        /// Returns a boolean indicating whether any of the strings in the given IEnumerable occur in this string.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <param name="keywords">An IEnumerable of strings to seek.</param>
        /// <returns>
        /// "true" if any of the strings occur within this string, or if "keywords" is the empty
        /// string (""); otherwise, "false".
        /// </returns>
        public static bool Contains(this string str, IEnumerable<string> keywords)
        {
            return str.Contains(keywords.ToArray());
        }

        /// <summary>
        /// Returns a boolean indicating whether any of the specified strings occur in this string.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <param name="keywords">The strings to seek.</param>
        /// <returns>
        /// "true" if any of the keywords parameters occurs within this string, or if "keywords" is the empty
        /// string (""); otherwise, "false".
        /// </returns>
        public static bool Contains(this string str, params string[] keywords)
        {
            foreach (string word in keywords)
                if (str.Contains(word)) return true;

            return false;
        }

        /// <summary>
        /// Returns a boolean indicating whether any of the characters in the given IEnumerable occur in this string.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <param name="keychars">An IEnumerable of characters to seek.</param>
        /// <returns>
        /// "true" if any of the characters occur within this string; otherwise, "false".
        /// </returns>
        public static bool Contains(this string str, IEnumerable<char> keychars)
        {
            return str.Contains(keychars.ToArray());
        }

        /// <summary>
        /// Returns a boolean indicating whether any of the specified characters occur in this string.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <param name="keychars">The characters to seek.</param>
        /// <returns>
        /// "true" if any of the keychars parameters occurs within this string; otherwise, "false".
        /// </returns>
        public static bool Contains(this string str, params char[] keychars)
        {
            foreach (char ch in keychars)
                if (str.Contains(ch)) return true;

            return false;
        }

        /// <summary>
        /// Returns a boolean indicating whether any of the strings in the given IEnumerable occur in this string,
        /// using the specified comparison rules.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <param name="comparison">One of the enumeration values that specifies the rules to use in the comparison.</param>
        /// <param name="keywords">An IEnumerable of strings to seek.</param>
        /// <returns>
        /// "true" if any of the strings occur within this string, or if "keywords" is the empty
        /// string (""); otherwise, "false".
        /// </returns>
        public static bool Contains(this string str, StringComparison comparison, IEnumerable<string> keywords)
        {
            return str.Contains(comparison, keywords.ToArray());
        }

        /// <summary>
        /// Returns a boolean indicating whether any of the specified strings occur in this string,
        /// using the specified comparison rules.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <param name="comparison">One of the enumeration values that specifies the rules to use in the comparison.</param>
        /// <param name="keywords">The strings to seek.</param>
        /// <returns>
        /// "true" if any of the keywords parameters occurs within this string, or if value is the empty
        /// string (""); otherwise, "false".
        /// </returns>
        public static bool Contains(this string str, StringComparison comparison, params string[] keywords)
        {
            foreach (string word in keywords)
                if (str.Contains(word, comparison)) return true;

            return false;
        }

        /// <summary>
        /// Returns a boolean indicating whether any of the characters in the given IEnumerable occur in this string.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <param name="comparison">One of the enumeration values that specifies the rules to use in the comparison.</param>
        /// <param name="keychars">An IEnumerable of characters to seek.</param>
        /// <returns>
        /// "true" if any of the characters occur within this string; otherwise, "false".
        /// </returns>
        public static bool Contains(this string str, StringComparison comparison, IEnumerable<char> keychars)
        {
            return str.Contains(comparison, keychars.ToArray());
        }

        /// <summary>
        /// Returns a boolean indicating whether any of the specified characters occur in this string,
        /// using the specified comparison rules.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <param name="comparison">One of the enumeration values that specifies the rules to use in the comparison.</param>
        /// <param name="keychars">The characters to seek.</param>
        /// <returns>
        /// "true" if any of the keychars parameters occurs within this string; otherwise, "false".
        /// </returns>
        public static bool Contains(this string str, StringComparison comparison, params char[] keychars)
        {
            foreach (char ch in keychars)
                if (str.Contains(ch, comparison)) return true;

            return false;
        }
    }
}
