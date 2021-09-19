using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace IvanStoychev.Useful.String.Extensions
{
    /// <summary>
    /// Contains methods that replace given substrings with a new, specified string.
    /// </summary>
    public static class Replacer
    {
        /// <summary>
        /// Uses a regular expression to return a new string in which all occurrences of all given strings in the current instance are replaced with the given "newString". Case-sensitive.
        /// </summary>
        /// <param name="newString">The string to replace all occurances of all given "oldStrings".</param>
        /// <param name="oldStrings">Strings to be replaced.</param>
        /// <returns>A string with all instances of "oldStrings" replaced by "newString".</returns>
        /// <exception cref="ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="ArgumentNullException">The current instance, "newString", or a member of "oldStrings" is null.</exception>
        /// <exception cref="RegexMatchTimeoutException">
        /// Thrown if the execution time of the replacement operation exceeds the time-out interval specified for the application domain in which the method is called.
        /// If no time-out is defined in the application domain's properties, or if the time-out value is "Regex.InfiniteMatchTimeout", no exception is thrown.
        /// </exception>
        [Pure]
        public static string Replace(this string str, string newString, params string[] oldStrings)
        {
            return ReplaceStringConsiderCase(str, oldStrings, newString);
        }

        /// <summary>
        /// Uses a regular expression to return a new string in which all occurrences of all given strings in the current instance are replaced with the given "newString",
        /// using the specified case-sensitivity.
        /// </summary>
        /// <param name="ignoreCase">"true" to ignore casing when replacing, "false" otherwise.</param>
        /// <param name="newString">The string to replace all occurances of all given "oldStrings".</param>
        /// <param name="oldStrings">Strings to be replaced.</param>
        /// <returns>A string with all instances of "oldStrings" replaced by "newString".</returns>
        /// <exception cref="ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="ArgumentNullException">The current instance, "newString", or a member of "oldStrings" is null.</exception>
        /// <exception cref="RegexMatchTimeoutException">
        /// Thrown if the execution time of the replacement operation exceeds the time-out interval specified for the application domain in which the method is called.
        /// If no time-out is defined in the application domain's properties, or if the time-out value is "Regex.InfiniteMatchTimeout", no exception is thrown.
        /// </exception>
        [Pure]
        public static string Replace(this string str, bool ignoreCase, string newString, params string[] oldStrings)
        {
            if (ignoreCase)
                return ReplaceStringIgnoreCase(str, oldStrings, newString);
            else
                return ReplaceStringConsiderCase(str, oldStrings, newString);
        }

        /// <summary>
        /// Uses a regular expression to return a new string in which all occurrences of all members of the given IEnumerable
        /// in the current instance are replaced with the given "newString". Case-sensitive.
        /// </summary>
        /// <param name="newString">The string to replace all occurances of all given "oldStrings".</param>
        /// <param name="oldStrings">Collection of strings to be replaced.</param>
        /// <returns>A string with all instances of "oldStrings" replaced by "newString".</returns>
        /// <exception cref="ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="ArgumentNullException">The current instance, "newString", or a member of "oldStrings" is null.</exception>
        /// <exception cref="RegexMatchTimeoutException">
        /// Thrown if the execution time of the replacement operation exceeds the time-out interval specified for the application domain in which the method is called.
        /// If no time-out is defined in the application domain's properties, or if the time-out value is "Regex.InfiniteMatchTimeout", no exception is thrown.
        /// </exception>
        [Pure]
        public static string Replace(this string str, IEnumerable<string> oldStrings, string newString)
        {
            return ReplaceStringConsiderCase(str, oldStrings, newString);
        }

        /// <summary>
        /// Uses a regular expression to return a new string in which all occurrences of all members of the given IEnumerable
        /// in the current instance are replaced with the given "newString", using the specified case-sensitivity.
        /// </summary>
        /// <param name="ignoreCase">"true" to ignore casing when replacing, "false" otherwise.</param>
        /// <param name="newString">The string to replace all occurances of "oldStrings".</param>
        /// <param name="oldStrings">Collection of strings to be replaced.</param>
        /// <returns>A string with all instances of "oldStrings" replaced by "newString".</returns>
        /// <exception cref="ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="ArgumentNullException">The current instance, "newString", or a member of "oldStrings" is null.</exception>
        /// <exception cref="RegexMatchTimeoutException">
        /// Thrown if the execution time of the replacement operation exceeds the time-out interval specified for the application domain in which the method is called.
        /// If no time-out is defined in the application domain's properties, or if the time-out value is "Regex.InfiniteMatchTimeout", no exception is thrown.
        /// </exception>
        [Pure]
        public static string Replace(this string str, IEnumerable<string> oldStrings, string newString, bool ignoreCase)
        {
            if (ignoreCase)
                return ReplaceStringIgnoreCase(str, oldStrings, newString);
            else
                return ReplaceStringConsiderCase(str, oldStrings, newString);
        }

        /// <exception cref="ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="ArgumentNullException">"value", "oldStrings", or "newString" are null.</exception>
        /// <exception cref="RegexMatchTimeoutException">
        /// Thrown if the execution time of the replacement operation exceeds the time-out interval specified for the application domain in which the method is called.
        /// If no time-out is defined in the application domain's properties, or if the time-out value is "Regex.InfiniteMatchTimeout", no exception is thrown.
        /// </exception>
        private static string ReplaceStringConsiderCase(this string value, IEnumerable<string> oldStrings, string newString)
        {
            foreach (var item in oldStrings)
                value = Regex.Replace(value, Regex.Escape(item), newString, RegexOptions.None);

            return value;
        }

        /// <exception cref="ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="ArgumentNullException">"value", "oldStrings", or "newString" are null.</exception>
        /// <exception cref="RegexMatchTimeoutException">
        /// Thrown if the execution time of the replacement operation exceeds the time-out interval specified for the application domain in which the method is called.
        /// If no time-out is defined in the application domain's properties, or if the time-out value is "Regex.InfiniteMatchTimeout", no exception is thrown.
        /// </exception>
        private static string ReplaceStringIgnoreCase(this string value, IEnumerable<string> oldStrings, string newString)
        {
            foreach (var item in oldStrings)
                value = Regex.Replace(value, Regex.Escape(item), newString, RegexOptions.IgnoreCase);

            return value;
        }
    }
}
