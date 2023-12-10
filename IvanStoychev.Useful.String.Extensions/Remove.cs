using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace IvanStoychev.Useful.String.Extensions;

public static partial class StringExtensions
{
    /// <summary>
    /// Returns a new string in which all occurrences of the given <paramref name="removeString"/> in the current instance are replaced with <see cref="string.Empty"/>.
    /// </summary>
    /// <param name="str">The instance to remove strings from.</param>
    /// <param name="removeString">Substring to be removed.</param>
    /// <param name="comparison">Comparison rules to use.</param>
    /// <returns>
    /// A string that is equivalent to the current string except that all instances of <paramref name="removeString"/> are removed.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="removeString"/> is the empty string ("").
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="removeString"/> is <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Remove(this string str, string removeString, StringComparison comparison = StringComparison.CurrentCulture)
    {
        Validate.NotNull(removeString);
        Validate.NotEmptyString(removeString);
        Validate.EnumContainsValue<StringComparison>(comparison);

        str = str.Replace(removeString, string.Empty, comparison);

        return str;
    }

    /// <summary>
    /// Returns a new string in which all occurrences of all members of the given <paramref name="removeStrings"/> in the current instance are removed.
    /// Occurrences are removed in the same order as the IEnumerable's members, using the provided <paramref name="comparison"/> rules.
    /// </summary>
    /// <param name="str">The instance to remove strings from.</param>
    /// <param name="removeStrings">Collection of values to be removed.</param>
    /// <param name="comparison">Comparison rules to use.</param>
    /// <returns>
    /// A string that is equivalent to the current string except that all instances of all members of the given collection are removed.
    /// If none of the members are found in the current instance, the method returns it unchanged.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="removeStrings"/> is empty or any of its members are the empty string ("").
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="removeStrings"/> or any of its members are <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Remove(this string str, IEnumerable<string> removeStrings, StringComparison comparison = StringComparison.CurrentCulture)
    {
        Validate.NotNull(removeStrings);
        Validate.IEnumNotEmpty(removeStrings);
        Validate.EnumContainsValue<StringComparison>(comparison);

        foreach (var item in removeStrings)
        {
            Validate.NotNullMember(item, nameof(removeStrings));
            Validate.EmptyStringMember(item, nameof(removeStrings));
            str = str.Replace(item, string.Empty, comparison);
        }

        return str;
    }

    /// <summary>
    /// Returns a new string in which all occurrences of all members of the given <paramref name="removeChars"/> in the current instance are removed.
    /// Occurrences are removed in the same order as the IEnumerable's members, using the provided <paramref name="comparison"/> rules.
    /// </summary>
    /// <param name="str">The instance to remove strings from.</param>
    /// <param name="removeChars">Collection of values to be removed.</param>
    /// <param name="comparison">Comparison rules to use.</param>
    /// <returns>
    /// A string that is equivalent to the current string except that all instances of all members of the given collection are removed.
    /// If none of the members are found in the current instance, the method returns it unchanged.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="removeChars"/> is empty.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="removeChars"/> is <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Remove(this string str, IEnumerable<char> removeChars, StringComparison comparison = StringComparison.CurrentCulture)
    {
        Validate.NotNull(removeChars);
        Validate.IEnumNotEmpty(removeChars);
        Validate.EnumContainsValue<StringComparison>(comparison);

        foreach (var item in removeChars)
            str = str.Replace(item.ToString(), string.Empty, comparison);

        return str;
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
        => Regex.Replace(originalString, @"[\d-]", string.Empty);

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
        => Regex.Replace(originalString, "[^0-9A-Za-z]+", string.Empty);

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
        => Regex.Replace(originalString, "[A-Za-z]", string.Empty);
}
