﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace IvanStoychev.Useful.String.Extensions
{
    /// <summary>
    /// Contains methods for determining if a substring is contained in another string.
    /// </summary>
    public static class Comparer
    {
        /// <summary>
        /// Returns a boolean indicating whether any of the specified strings occur in this string.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <param name="keywords">Strings to seek.</param>
        /// <returns>
        /// <see langword="true"/> if any of the <paramref name="keywords"/> occur within this string, or if any of them are the empty string (""); otherwise, <see langword="false"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="keywords"/> collection or any of its memebers are null.
        /// </exception>
        [Pure]
        public static bool Contains(this string str, params string[] keywords)
        {
            foreach (var word in keywords)
                if (str.Contains(word))
                    return true;

            return false;
        }

        /// <summary>
        /// Returns a boolean indicating whether any of the specified strings occur in this string, using the specified comparison rules.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <param name="comparison">One of the enumeration values that specifies the rules to use in the comparison.</param>
        /// <param name="keywords">Strings to seek.</param>
        /// <returns>
        /// <see langword="true"/> if any of the <paramref name="keywords"/> occur within this string, or if any of them are the empty string (""); otherwise, <see langword="false"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="keywords"/> collection or any of its memebers are null.
        /// </exception>
        [Pure]
        public static bool Contains(this string str, StringComparison comparison, params string[] keywords)
        {
            foreach (var word in keywords)
                if (str.Contains(word, comparison))
                    return true;

            return false;
        }

        /// <summary>
        /// Returns a <see langword="bool"/> indicating whether any of the strings in <paramref name="keywords"/> occur in this string, using the specified comparison rules.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <param name="keywords">A collection of strings to seek.</param>
        /// <param name="comparison">One of the enumeration values that specifies the rules to use in the comparison.</param>
        /// <returns>
        /// <see langword="true"/> if any of the <paramref name="keywords"/> members occur within this string, or if any of them
        /// are the empty string (""); otherwise, <see langword="false"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="keywords"/> collection or any of its memebers are null.
        /// </exception>
        [Pure]
        public static bool Contains(this string str, IEnumerable<string> keywords, StringComparison comparison = StringComparison.Ordinal)
        {
            foreach (var word in keywords)
                if (str.Contains(word, comparison))
                    return true;

            return false;
        }

        /// <summary>
        /// Returns a boolean indicating whether any of the specified characters occur in this string.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <param name="keychars">Characters to seek.</param>
        /// <returns>
        /// <see langword="true"/> if any of the <paramref name="keychars"/> occur within this string; otherwise, <see langword="false"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="keychars"/> is null.
        /// </exception>
        [Pure]
        public static bool Contains(this string str, params char[] keychars)
        {
            foreach (var ch in keychars)
                if (str.Contains(ch))
                    return true;

            return false;
        }

        /// <summary>
        /// Returns a boolean indicating whether any of the specified characters occur in this string, using the specified comparison rules.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <param name="comparison">One of the enumeration values that specifies the rules to use in the comparison.</param>
        /// <param name="keychars">Characters to seek.</param>
        /// <returns>
        /// <see langword="true"/> if any of the <paramref name="keychars"/> occur within this string; otherwise, <see langword="false"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="keychars"/> is null.
        /// </exception>
        [Pure]
        public static bool Contains(this string str, StringComparison comparison, params char[] keychars)
        {
            foreach (var ch in keychars)
                if (str.Contains(ch, comparison))
                    return true;

            return false;
        }

        /// <summary>
        /// Returns a boolean indicating whether any of the characters in the given IEnumerable occur in this string.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <param name="keychars">A collection of characters to seek.</param>
        /// <returns>
        /// "true" if any of the characters occur within this string; otherwise, "false".
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// "keychars" is null.
        /// </exception>
        [Pure]
        public static bool Contains(this string str, IEnumerable<char> keychars, StringComparison comparison = StringComparison.Ordinal)
        {
            foreach (var character in keychars)
                if (str.Contains(character, comparison))
                    return true;

            return false;
        }
    }
}
