﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace IvanStoychev.Useful.String.Extensions;

/// <summary>
/// Contains methods that remove substrings.
/// </summary>
public static class Remover
{
    /// <summary>
    /// Returns a new string in which all occurrences of all members of the given <paramref name="removeStrings"/> in the current instance are removed.
    /// Occurrences are removed in the same order as the IEnumerable's members, using the provided <paramref name="stringComparison"/> rules.
    /// </summary>
    /// <param name="str">The instance to remove strings from.</param>
    /// <param name="removeStrings">Collection of values to be removed.</param>
    /// <param name="stringComparison">Comparison rules to use.</param>
    /// <returns>
    /// A string that is equivalent to the current string except that all instances of all members of the given collection are removed.
    /// If none of the members are found in the current instance, the method returns it unchanged.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Any of the <paramref name="removeStrings"/> members are the empty string ("").
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// The <paramref name="removeStrings"/> collection or any of its members are <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Remove(this string str, IEnumerable<string> removeStrings, StringComparison stringComparison = StringComparison.CurrentCulture)
    {
        Validate.NullArgument(removeStrings);
        Validate.IEnumNotEmpty(removeStrings);

        foreach (var item in removeStrings)
        {
            Validate.NullMember(item, nameof(removeStrings));
            Validate.EmptyStringMember(item, nameof(removeStrings));
            str = str.Replace(item, string.Empty, stringComparison);
        }

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

    /// <summary>
    /// Trims the given amount of characters from the start and end of the current instance.
    /// </summary>
    /// <param name="str">The string to trim.</param>
    /// <param name="amount">Amount of characters to remove from the start and end of the instance.</param>
    /// <returns>The string that remains after <paramref name="amount"/> of characters have been removed from the original instance's start and end.</returns>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="amount"/> is twice of more times bigger than the original instance's length.</exception>
    [Pure]
    public static string Trim(this string str, int amount)
    {
        int lengthDiff = str.Length - amount * 2;
        Validate.DoubleAmountStringLength(amount, lengthDiff);

        return str.Substring(amount, lengthDiff);
    }

    /// <summary>
    /// Removes the leading occurrence of a specified string from the current instance.
    /// </summary>
    /// <param name="str">The instance to remove the string from.</param>
    /// <param name="trimString">The string to remove or null.</param>
    /// <returns>
    /// The string that remains after the occurrence of "trimString" is removed from the start of
    /// the current instance. If "trimString" is null, the empty string or not found at the start of the
    /// current instance the method returns the current instance unchanged.
    /// </returns>
    [Pure]
    public static string TrimStart(this string str, string trimString)
    {
        if (string.IsNullOrEmpty(trimString))
            return str;

        if (str.StartsWith(trimString))
            str = str[trimString.Length..];

        return str;
    }

    /// <summary>
    /// Removes the leading occurrence of a specified string from the current instance, using the provided string comparison option.
    /// </summary>
    /// <param name="str">The instance to remove the string from.</param>
    /// <param name="trimString">The string to remove.</param>
    /// <param name="stringComparison">One of the enumeration values that determines how the start of the current instance and "trimString" are compared.</param>
    /// <returns>
    /// The string that remains after the occurrence of "trimString" is removed from the start of
    /// the current instance. If "trimString" is null, the empty string or not found at the start of the
    /// current instance the method returns the current instance unchanged.
    /// </returns>
    [Pure]
    public static string TrimStart(this string str, string trimString, StringComparison stringComparison)
    {
        if (string.IsNullOrEmpty(trimString))
            return str;

        if (str.StartsWith(trimString, stringComparison))
            str = str[trimString.Length..];

        return str;
    }

    /// <summary>
    /// Removes the leading occurrence of a specified string from the current instance, comparing using the provided cultural information and case-sensitivity.
    /// </summary>
    /// <param name="str">The string to remove occurrences from.</param>
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
    public static string TrimStart(this string str, string trimString, bool ignoreCase, CultureInfo culture)
    {
        if (string.IsNullOrEmpty(trimString))
            return str;

        if (str.StartsWith(trimString, ignoreCase, culture))
            str = str[trimString.Length..];

        return str;
    }

    /// <summary>
    /// Trims the given amount of characters from the start of the current instance.
    /// </summary>
    /// <param name="str">The string to trim.</param>
    /// <param name="amount">Amount of characters to remove from the start of the instance.</param>
    /// <returns>The string that remains after <paramref name="amount"/> of characters have been removed from the original instance's start.</returns>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="amount"/> is bigger than the original instance's length.</exception>
    [Pure]
    public static string TrimStart(this string str, int amount)
    {
        int lengthDiff = str.Length - amount;
        Validate.AmountStringLength(amount, lengthDiff);

        return str[amount..];
    }

    /// <summary>
    /// Removes the trailing occurrence of a specified string from the current instance.
    /// </summary>
    /// <param name="str">The string to remove occurrences from.</param>
    /// <param name="trimString">The string to remove.</param>
    /// <returns>
    /// The string that remains after the occurrence of "trimString" is removed from the end of
    /// the current instance. If "trimString" is null, the empty string or not found at the end of the
    /// current instance the method returns the current instance unchanged.
    /// </returns>
    [Pure]
    public static string TrimEnd(this string str, string trimString)
    {
        if (string.IsNullOrEmpty(trimString))
            return str;

        if (str.EndsWith(trimString))
            str = str[..^trimString.Length];

        return str;
    }

    /// <summary>
    /// Removes the trailing occurrence of a specified string from the current instance, using the provided string comparison option.
    /// </summary>
    /// <param name="str">The string to remove occurrences from.</param>
    /// <param name="trimString">The string to remove.</param>
    /// <param name="stringComparison">One of the enumeration values that determines how the end of the current instance and "trimString" are compared.</param>
    /// <returns>
    /// The string that remains after the occurrence of "trimString" is removed from the end of
    /// the current instance. If "trimString" is null, the empty string or not found at the end of the
    /// current instance the method returns the current instance unchanged.
    /// </returns>
    [Pure]
    public static string TrimEnd(this string str, string trimString, StringComparison stringComparison)
    {
        if (string.IsNullOrEmpty(trimString))
            return str;

        if (str.EndsWith(trimString, stringComparison))
            str = str[..^trimString.Length];

        return str;
    }

    /// <summary>
    /// Removes the trailing occurrence of a specified string from the current instance, comparing using the provided cultural information and case-sensitivity.
    /// </summary>
    /// <param name="str">The string to remove occurrences from.</param>
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
    public static string TrimEnd(this string str, string trimString, bool ignoreCase, CultureInfo culture)
    {
        if (string.IsNullOrEmpty(trimString))
            return str;

        if (str.EndsWith(trimString, ignoreCase, culture))
            str = str[..^trimString.Length];

        return str;
    }

    /// <summary>
    /// Trims the given amount of characters from the end of the current instance.
    /// </summary>
    /// <param name="str">The string to trim.</param>
    /// <param name="amount">Amount of characters to remove from the end of the instance.</param>
    /// <returns>The string that remains after <paramref name="amount"/> of characters have been removed from the original instance's end.</returns>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="amount"/> is bigger than the original instance's length.</exception>
    [Pure]
    public static string TrimEnd(this string str, int amount)
    {
        int lengthDiff = str.Length - amount;
        Validate.AmountStringLength(amount, lengthDiff);

        return str[..lengthDiff];
    }
}
