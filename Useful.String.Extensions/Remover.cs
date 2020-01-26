using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Useful.String.Extensions
{
    public static class Remover
    {
        /// <summary>
        /// Removes all instances of all of the given strings, case-sensitive.
        /// </summary>
        /// <param name="removeStrings">Array of values to be removed.</param>
        public static string Remove(this string str, IEnumerable<string> removeStrings)
        {
            return RemoveStringConsiderCase(str, removeStrings.ToArray());
        }

        /// <summary>
        /// Removes all instances of all of the given strings, case-sensitive.
        /// </summary>
        /// <param name="removeStrings">Array of values to be removed.</param>
        public static string Remove(this string str, params string[] removeStrings)
        {
            return RemoveStringConsiderCase(str, removeStrings);
        }

        /// <summary>
        /// Removes all instances of all of the given string array elements. Case-sensitivity can be specified.
        /// </summary>
        /// <param name="ignoreCase">Boolean value indicating if the case of the value to be removed should be ignored.</param>
        /// <param name="removeStrings">Array of values to be removed.</param>
        public static string Remove(this string str, bool ignoreCase, IEnumerable<string> removeStrings)
        {
            if (ignoreCase)
                return RemoveStringIgnoreCase(str, removeStrings.ToArray());
            else
                return RemoveStringConsiderCase(str, removeStrings.ToArray());
        }

        /// <summary>
        /// Removes all instances of all of the given string array elements. Case-sensitivity can be specified.
        /// </summary>
        /// <param name="ignoreCase">Boolean value indicating if the case of the value to be removed should be ignored.</param>
        /// <param name="removeStrings">Array of values to be removed.</param>
        public static string Remove(this string str, bool ignoreCase, params string[] removeStrings)
        {
            if (ignoreCase)
                return RemoveStringIgnoreCase(str, removeStrings);
            else
                return RemoveStringConsiderCase(str, removeStrings);
        }

        private static string RemoveStringConsiderCase(this string value, string[] toRemove)
        {
            foreach (var item in toRemove)
                value = value.Replace(item, string.Empty);

            return value;
        }

        private static string RemoveStringIgnoreCase(this string value, string[] toRemove)
        {
            foreach (var item in toRemove)
                value = Regex.Replace(value, Regex.Escape(item), string.Empty, RegexOptions.IgnoreCase);

            return value;
        }

        /// <summary>
        /// Removes all numbers from the original string, keeping letters and special characters.
        /// </summary>
        public static string RemoveNumbers(this string originalString)
        {
            return Regex.Replace(originalString, @"[\d-]", string.Empty);
        }

        /// <summary>
        /// Removes all special characters from the original string, keeping letters and numbers.
        /// </summary>
        public static string RemoveSpecialCharacters(this string originalString)
        {
            return Regex.Replace(originalString, "[^0-9A-Za-z]+", string.Empty);
        }

        /// <summary>
        /// Removes all letters from the original string, keeping special characters and numbers.
        /// </summary>
        public static string RemoveLetters(this string originalString)
        {
            return Regex.Replace(originalString, "[A-Za-z]", string.Empty);
        }

        /// <summary>
        /// Removes the leading occurrence of a specified string from the current string.
        /// </summary>
        /// <param name="target">The string to remove occurrences from.</param>
        /// <param name="trimString">The string to remove.</param>
        /// <returns>
        /// The string that remains after the occurrence of the trimString string is removed
        /// from the start of the current string. If no characters can be trimmed from the
        /// current instance, the method returns the current instance unchanged.
        /// </returns>
        public static string TrimStart(this string target, string trimString)
        {
            if (string.IsNullOrEmpty(trimString)) return target;

            string result = target;
            if (result.StartsWith(trimString))
                result = result.Substring(trimString.Length);

            return result;
        }

        /// <summary>
        /// Removes the leading occurrence of a specified string from the current string.
        /// </summary>
        /// <param name="target">The string to remove occurrences from.</param>
        /// <param name="trimString">The string to remove.</param>
        /// <param name="stringComparison">One of the enumeration values that determines how this string and value are compared.</param>
        /// <returns>
        /// The string that remains after the occurrence of the trimString string is removed
        /// from the start of the current string. If no characters can be trimmed from the
        /// current instance, the method returns the current instance unchanged.
        /// </returns>
        public static string TrimStart(this string target, string trimString, StringComparison stringComparison)
        {
            if (string.IsNullOrEmpty(trimString)) return target;

            string result = target;
            if (result.StartsWith(trimString, stringComparison))
                result = result.Substring(trimString.Length);

            return result;
        }

        /// <summary>
        /// Removes the leading occurrence of a specified string from the current string.
        /// </summary>
        /// <param name="target">The string to remove occurrences from.</param>
        /// <param name="trimString">The string to remove.</param>
        /// <param name="ignoreCase">"true" to ignore case during the comparison; otherwise, "false".</param>
        /// <param name="culture">
        /// Cultural information that determines how this string and "trimString" are compared.
        /// If culture is null, the current culture is used.
        /// </param>
        /// <returns>
        /// The string that remains after the occurrence of the trimString string is removed
        /// from the start of the current string. If no characters can be trimmed from the
        /// current instance, the method returns the current instance unchanged.
        /// </returns>
        public static string TrimStart(this string target, string trimString, bool ignoreCase, CultureInfo culture)
        {
            if (string.IsNullOrEmpty(trimString)) return target;

            string result = target;
            if (result.StartsWith(trimString, ignoreCase, culture))
                result = result.Substring(trimString.Length);

            return result;
        }

        /// <summary>
        /// Removes the trailing occurrence of a specified string from the current string.
        /// </summary>
        /// <param name="target">The string to remove occurrences from.</param>
        /// <param name="trimString">The string to remove.</param>
        /// <returns>
        /// The string that remains after the occurrence of the trimString string is removed
        /// from the end of the current string. If no characters can be trimmed from the
        /// current instance, the method returns the current instance unchanged.
        /// </returns>
        public static string TrimEnd(this string target, string trimString)
        {
            if (string.IsNullOrEmpty(trimString)) return target;

            string result = target;
            if (result.EndsWith(trimString))
                result = result.Substring(0, result.Length - trimString.Length);

            return result;
        }
    }
}
