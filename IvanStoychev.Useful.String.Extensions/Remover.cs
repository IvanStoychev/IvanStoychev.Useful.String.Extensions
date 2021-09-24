using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace IvanStoychev.Useful.String.Extensions
{
    /// <summary>
    /// Contains methods that remove substrings.
    /// </summary>
    public static class Remover
    {
        /// <summary>
        /// Returns a new string in which all occurrences of all members of a given IEnumerable in the current instance are removed.
        /// Occurrences are removed in the same order as the IEnumerable's members. The removal is case-sensitive.
        /// </summary>
        /// <param name="str">The instance to remove strings from.</param>
        /// <param name="removeStrings">Collection of values to be removed.</param>
        /// <returns>
        /// A string that is equivalent to the current string except that all instances of all members of the given collection are removed.
        /// If none of the members are found in the current instance, the method returns it unchanged.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Thrown if any of the "removeStrings" members are the empty string.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The "removeStrings" collection or any of its members are null.
        /// </exception>
        [Pure]
        public static string Remove(this string str, IEnumerable<string> removeStrings)
        {
            return RemoveStringConsiderCase(str, removeStrings.ToArray());
        }

        /// <summary>
        /// Returns a new string in which all occurrences of all given strings in the current instance are removed.
        /// Occurrences are removed in the same order as they are given. The removal is case-sensitive.
        /// </summary>
        /// <param name="str">The instance to remove strings from.</param>
        /// <param name="removeStrings">Values to be removed.</param>
        /// <returns>
        /// A string that is equivalent to the current string except that all instances of all members of the given collection are removed.
        /// If none of the members are found in the current instance, the method returns it unchanged.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Thrown if any of the "removeStrings" parameters are the empty string.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The "removeStrings" collection or any of its members are null.
        /// </exception>
        [Pure]
        public static string Remove(this string str, params string[] removeStrings)
        {
            return RemoveStringConsiderCase(str, removeStrings);
        }

        /// <summary>
        /// Returns a new string in which all occurrences of all members of a given IEnumerable in the current instance are removed.
        /// Occurrences are removed in the same order as the IEnumerable's members, using the specified case-sensitivity.
        /// If case is ignored a regular expression is used internally.
        /// </summary>
        /// <param name="str">The instance to remove strings from.</param>
        /// <param name="ignoreCase">"true" to ignore casing when trimming, "false" otherwise.</param>
        /// <param name="removeStrings">Array of values to be removed.</param>
        /// <returns>
        /// A string that is equivalent to the current string except that all instances of all members of the given collection are removed.
        /// If none of the members are found in the current instance, the method returns it unchanged.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// A regular expression parsing error occurred.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The "removeStrings" collection or any of its members are null.
        /// </exception>
        /// <exception cref="RegexMatchTimeoutException">
        /// The execution time of the replacement operation exceeds the time-out interval specified for the application domain in which the method is called.
        /// If no time-out is defined in the application domain's properties, or if the time-out value is "Regex.InfiniteMatchTimeout", no exception is thrown.
        /// </exception>
        [Pure]
        public static string Remove(this string str, bool ignoreCase, IEnumerable<string> removeStrings)
        {
            if (ignoreCase)
                return RemoveStringIgnoreCase(str, removeStrings.ToArray());
            else
                return RemoveStringConsiderCase(str, removeStrings.ToArray());
        }

        /// <summary>
        /// Returns a new string in which all occurrences of all given strings in the current instance are removed.
        /// Occurrences are removed in the same order as they are given, using the specified case-sensitivity.
        /// If case is ignored a regular expression is used internally.
        /// </summary>
        /// <param name="str">The instance to remove strings from.</param>
        /// <param name="ignoreCase">"true" to ignore casing when trimming, "false" otherwise.</param>
        /// <param name="removeStrings">Values to be removed.</param>
        /// <returns>
        /// A string that is equivalent to the current string except that all instances of all members of the given collection are removed.
        /// If none of the members are found in the current instance, the method returns it unchanged.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// A regular expression parsing error occurred.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The "removeStrings" collection or any of its members are null.
        /// </exception>
        /// <exception cref="RegexMatchTimeoutException">
        /// The execution time of the replacement operation exceeds the time-out interval specified for the application domain in which the method is called.
        /// If no time-out is defined in the application domain's properties, or if the time-out value is "Regex.InfiniteMatchTimeout", no exception is thrown.
        /// </exception>
        [Pure]
        public static string Remove(this string str, bool ignoreCase, params string[] removeStrings)
        {
            if (ignoreCase)
                return RemoveStringIgnoreCase(str, removeStrings);
            else
                return RemoveStringConsiderCase(str, removeStrings);
        }

        /// <summary>
        /// Uses a regular expression to return a new string in which all occurrences of all unicode digits (in any script) in the current instance are removed.
        /// </summary>
        /// <param name="originalString">The instance to remove digits from.</param>
        /// <returns>
        /// A string that is equivalent to the current string except that all instances of all unicode digits (in any script) are removed.
        /// If no digits are found in the current instance, the method returns it unchanged.
        /// </returns>
        /// <exception cref="RegexMatchTimeoutException">
        /// The execution time of the replacement operation exceeds the time-out interval specified for the application domain in which the method is called.
        /// If no time-out is defined in the application domain's properties, or if the time-out value is "Regex.InfiniteMatchTimeout", no exception is thrown.
        /// </exception>
        [Pure]
        public static string RemoveNumbers(this string originalString)
        {
            return Regex.Replace(originalString, @"[\d-]", string.Empty);
        }

        /// <summary>
        /// Uses a regular expression to return a new string in which all occurrences of all special characters in the current instance are removed.
        /// </summary>
        /// <param name="originalString">The instance to remove special characters from.</param>
        /// <returns>
        /// A string that is equivalent to the current string except that all instances of all special characters are removed.
        /// If no special characters are found in the current instance, the method returns it unchanged.
        /// </returns>
        /// <exception cref="RegexMatchTimeoutException">
        /// The execution time of the replacement operation exceeds the time-out interval specified for the application domain in which the method is called.
        /// If no time-out is defined in the application domain's properties, or if the time-out value is "Regex.InfiniteMatchTimeout", no exception is thrown.
        /// </exception>
        [Pure]
        public static string RemoveSpecialCharacters(this string originalString)
        {
            return Regex.Replace(originalString, "[^0-9A-Za-z]+", string.Empty);
        }

        /// <summary>
        /// Uses a regular expression to return a new string in which all occurrences of all latin letters in the current instance are removed.
        /// </summary>
        /// <param name="originalString">The instance to remove latin letters from.</param>
        /// <returns>
        /// A string that is equivalent to the current string except that all instances of all latin letters are removed.
        /// If no latin letters are found in the current instance, the method returns it unchanged.
        /// </returns>
        /// <exception cref="RegexMatchTimeoutException">
        /// The execution time of the replacement operation exceeds the time-out interval specified for the application domain in which the method is called.
        /// If no time-out is defined in the application domain's properties, or if the time-out value is "Regex.InfiniteMatchTimeout", no exception is thrown.
        /// </exception>
        [Pure]
        public static string RemoveLetters(this string originalString)
        {
            return Regex.Replace(originalString, "[A-Za-z]", string.Empty);
        }

        /// <summary>
        /// Trims the given amount of characters from the start and end of the current instance.
        /// </summary>
        /// <param name="target">The string to trim.</param>
        /// <param name="amount">Amount of characters to remove from the start and end of the instance.</param>
        /// <returns>The string that remains after <paramref name="amount"/> of characters have been removed from the original instance's start and end.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="amount"/> is twice of more times bigger than the original instance's length.</exception>
        [Pure]
        public static string Trim(this string target, int amount)
        {
            int lengthDiff = target.Length - amount * 2;
            Validator.CheckAmountStringLength(nameof(amount), amount, lengthDiff);

            return target.Substring(amount, lengthDiff);
        }

        /// <summary>
        /// Removes the leading occurrence of a specified string from the current instance.
        /// </summary>
        /// <param name="target">The instance to remove the string from.</param>
        /// <param name="trimString">The string to remove or null.</param>
        /// <returns>
        /// The string that remains after the occurrence of "trimString" is removed from the start of
        /// the current instance. If "trimString" is null, the empty string or not found at the start of the
        /// current instance the method returns the current instance unchanged.
        /// </returns>
        [Pure]
        public static string TrimStart(this string target, string trimString)
        {
            if (string.IsNullOrEmpty(trimString))
                return target;

            if (target.StartsWith(trimString))
                target = target[trimString.Length..];

            return target;
        }

        /// <summary>
        /// Removes the leading occurrence of a specified string from the current instance, using the provided string comparison option.
        /// </summary>
        /// <param name="target">The instance to remove the string from.</param>
        /// <param name="trimString">The string to remove.</param>
        /// <param name="stringComparison">One of the enumeration values that determines how the start of the current instance and "trimString" are compared.</param>
        /// <returns>
        /// The string that remains after the occurrence of "trimString" is removed from the start of
        /// the current instance. If "trimString" is null, the empty string or not found at the start of the
        /// current instance the method returns the current instance unchanged.
        /// </returns>
        [Pure]
        public static string TrimStart(this string target, string trimString, StringComparison stringComparison)
        {
            if (string.IsNullOrEmpty(trimString))
                return target;

            if (target.StartsWith(trimString, stringComparison))
                target = target[trimString.Length..];

            return target;
        }

        /// <summary>
        /// Removes the leading occurrence of a specified string from the current instance, comparing using the provided cultural information and case-sensitivity.
        /// </summary>
        /// <param name="target">The string to remove occurrences from.</param>
        /// <param name="trimString">The string to remove.</param>
        /// <param name="ignoreCase">"true" to ignore casing when trimming, "false" otherwise.</param>
        /// <param name="culture">
        /// Cultural information that determines how the start of this instance and "trimString" are compared.
        /// If culture is null, the current culture is used.
        /// </param>
        /// <returns>
        /// The string that remains after the occurrence of "trimString" is removed from the start of
        /// the current instance. If "trimString" is null, the empty string or not found at the start of the
        /// current instance the method returns the current instance unchanged.
        /// </returns>
        [Pure]
        public static string TrimStart(this string target, string trimString, bool ignoreCase, CultureInfo culture)
        {
            if (string.IsNullOrEmpty(trimString))
                return target;

            if (target.StartsWith(trimString, ignoreCase, culture))
                target = target[trimString.Length..];

            return target;
        }

        /// <summary>
        /// Trims the given amount of characters from the start of the current instance.
        /// </summary>
        /// <param name="target">The string to trim.</param>
        /// <param name="amount">Amount of characters to remove from the start of the instance.</param>
        /// <returns>The string that remains after <paramref name="amount"/> of characters have been removed from the original instance's start.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="amount"/> is bigger than the original instance's length.</exception>
        [Pure]
        public static string TrimStart(this string target, int amount)
        {
            int lengthDiff = target.Length - amount;
            Validator.CheckAmountStringLength(nameof(amount), amount, lengthDiff);

            return target.Substring(amount);
        }

        /// <summary>
        /// Removes the trailing occurrence of a specified string from the current instance.
        /// </summary>
        /// <param name="target">The string to remove occurrences from.</param>
        /// <param name="trimString">The string to remove.</param>
        /// <returns>
        /// The string that remains after the occurrence of "trimString" is removed from the end of
        /// the current instance. If "trimString" is null, the empty string or not found at the end of the
        /// current instance the method returns the current instance unchanged.
        /// </returns>
        [Pure]
        public static string TrimEnd(this string target, string trimString)
        {
            if (string.IsNullOrEmpty(trimString))
                return target;

            if (target.EndsWith(trimString))
                target = target.Substring(0, target.Length - trimString.Length);

            return target;
        }

        /// <summary>
        /// Removes the trailing occurrence of a specified string from the current instance, using the provided string comparison option.
        /// </summary>
        /// <param name="target">The string to remove occurrences from.</param>
        /// <param name="trimString">The string to remove.</param>
        /// <param name="stringComparison">One of the enumeration values that determines how the end of the current instance and "trimString" are compared.</param>
        /// <returns>
        /// The string that remains after the occurrence of "trimString" is removed from the end of
        /// the current instance. If "trimString" is null, the empty string or not found at the end of the
        /// current instance the method returns the current instance unchanged.
        /// </returns>
        [Pure]
        public static string TrimEnd(this string target, string trimString, StringComparison stringComparison)
        {
            if (string.IsNullOrEmpty(trimString))
                return target;

            if (target.EndsWith(trimString, stringComparison))
                target = target.Substring(0, target.Length - trimString.Length);

            return target;
        }

        /// <summary>
        /// Removes the trailing occurrence of a specified string from the current instance, comparing using the provided cultural information and case-sensitivity.
        /// </summary>
        /// <param name="target">The string to remove occurrences from.</param>
        /// <param name="trimString">The string to remove.</param>
        /// <param name="ignoreCase">"true" to ignore casing when trimming, "false" otherwise.</param>
        /// <param name="culture">
        /// Cultural information that determines how the end of this instance and "trimString" are compared.
        /// If culture is null, the current culture is used.
        /// </param>
        /// <returns>
        /// The string that remains after the occurrence of "trimString" is removed from the end of
        /// the current instance. If "trimString" is null, the empty string or not found at the end of the
        /// current instance the method returns the current instance unchanged.
        /// </returns>
        [Pure]
        public static string TrimEnd(this string target, string trimString, bool ignoreCase, CultureInfo culture)
        {
            if (string.IsNullOrEmpty(trimString))
                return target;

            if (target.EndsWith(trimString, ignoreCase, culture))
                target = target.Substring(0, target.Length - trimString.Length);

            return target;
        }

        /// <summary>
        /// Trims the given amount of characters from the end of the current instance.
        /// </summary>
        /// <param name="target">The string to trim.</param>
        /// <param name="amount">Amount of characters to remove from the end of the instance.</param>
        /// <returns>The string that remains after <paramref name="amount"/> of characters have been removed from the original instance's end.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="amount"/> is bigger than the original instance's length.</exception>
        [Pure]
        public static string TrimEnd(this string target, int amount)
        {
            int lengthDiff = target.Length - amount;
            Validator.CheckAmountStringLength(nameof(amount), amount, lengthDiff);

            return target.Substring(0, lengthDiff);
        }

        /// <exception cref="ArgumentException">
        /// Thrown if any of the "toRemove" members are the empty string.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Thrown when either "value", the "toRemove" array or any of its memebers are null.
        /// </exception>
        private static string RemoveStringConsiderCase(this string value, string[] toRemove)
        {
            foreach (var item in toRemove)
                value = value.Replace(item, string.Empty);

            return value;
        }

        /// <exception cref="ArgumentException">
        /// A regular expression parsing error occurred.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Thrown when either "value", the "toRemove" array or any of its memebers are null.
        /// </exception>
        /// <exception cref="RegexMatchTimeoutException">
        /// Thrown if the execution time of the replacement operation exceeds the time-out interval specified for the application domain in which the method is called.
        /// If no time-out is defined in the application domain's properties, or if the time-out value is "Regex.InfiniteMatchTimeout", no exception is thrown.
        /// </exception>
        private static string RemoveStringIgnoreCase(this string value, string[] toRemove)
        {
            foreach (var item in toRemove)
                value = Regex.Replace(value, Regex.Escape(item), string.Empty, RegexOptions.IgnoreCase);

            return value;
        }
    }
}
