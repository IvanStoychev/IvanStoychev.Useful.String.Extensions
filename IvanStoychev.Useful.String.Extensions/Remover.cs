using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Text.RegularExpressions;

namespace IvanStoychev.Useful.String.Extensions;

/// <summary>
/// Contains methods that remove substrings.
/// </summary>
public static class Remover
{
    /// <summary>
    /// Returns a new string in which all occurrences of the given <paramref name="removeString"/> in the current instance are replaced with <see cref="string.Empty"/>.
    /// </summary>
    /// <param name="str">The instance to remove strings from.</param>
    /// <param name="removeString">Substring to be removed.</param>
    /// <param name="stringComparison">Comparison rules to use.</param>
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
    public static string Remove(this string str, string removeString, StringComparison stringComparison = StringComparison.CurrentCulture)
    {
        Validate.EmptyString(removeString);
        Validate.NullArgument(removeString);

        str = str.Replace(removeString, string.Empty, stringComparison);

        return str;
    }

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
    /// Removes the leading and trailing occurrences of a specified string from the current instance, using the provided string comparison option.
    /// </summary>
    /// <param name="str">The instance to remove the string from.</param>
    /// <param name="trimString">The string to remove.</param>
    /// <param name="stringComparison">One of the enumeration values that determines how the start of the current instance and <paramref name="trimString"/> are compared.</param>
    /// <param name="trimWhitespace">
    /// <see langword="true"/> to remove any whitespace characters remaining at the start and end of the original instance after <paramref name="trimString"/> is removed.
    /// If <see langword="true"/>, whitespace removal will occur regardless of whether the original instance starts and/or ends with <paramref name="trimString"/>.
    /// </param>
    /// <returns>
    /// The string that remains after the occurrence of "trimString" is removed from the start and end of the current instance. If "trimString" is <see langword="null"/>,
    /// the empty string or not found at the start or end of the current instance the method returns the current instance unchanged.
    /// </returns>
    [Pure]
    public static string Trim(this string str, string trimString, StringComparison stringComparison = StringComparison.CurrentCulture, bool trimWhitespace = false)
    {
        if (string.IsNullOrEmpty(trimString))
            return str;

        int startIndex = 0;
        int tailLength = 0;

        if (str.StartsWith(trimString, stringComparison))
            startIndex = trimString.Length;

        if (str.EndsWith(trimString, stringComparison))
            tailLength = trimString.Length;

        int length = str.Length - startIndex - tailLength;
        str = str.Substring(startIndex, length);

        if (trimWhitespace)
            str = str.Trim();

        return str;
    }

    /// <summary>
    /// Removes the leading and trailing occurrences of a specified string from the current instance, comparing using the provided cultural information and case-sensitivity.
    /// </summary>
    /// <param name="str">The string to remove occurrences from.</param>
    /// <param name="trimString">The string to remove.</param>
    /// <param name="ignoreCase"><see langword="true"/> to ignore casing when trimming, <see langword="false"/> otherwise.</param>
    /// <param name="culture">
    /// Cultural information that determines how the start and end of this instance and <paramref name="trimString"/> are compared.
    /// If culture is <see langword="null"/>, the current culture is used.
    /// </param>
    /// <param name="trimWhitespace">
    /// <see langword="true"/> to remove any whitespace characters remaining at the start and end of the original instance after <paramref name="trimString"/> is removed.
    /// If <see langword="true"/>, whitespace removal will occur regardless of whether the original instance starts and/or ends with <paramref name="trimString"/>.
    /// </param>
    /// <returns>
    /// The string that remains after the occurrence of <paramref name="trimString"/> is removed from the start and end of the current instance.
    /// If <paramref name="trimString"/> is <see langword="null"/>, the empty string or not found at the start of the current instance the method returns
    /// the current instance unchanged.
    /// </returns>
    [Pure]
    public static string Trim(this string str, string trimString, bool ignoreCase, CultureInfo? culture, bool trimWhitespace = false)
    {
        if (string.IsNullOrEmpty(trimString))
            return str;

        int startIndex = 0;
        int tailLength = 0;

        if (str.StartsWith(trimString, ignoreCase, culture))
            startIndex = trimString.Length;

        if (str.EndsWith(trimString, ignoreCase, culture))
            tailLength = trimString.Length;

        int length = str.Length - startIndex - tailLength;
        str = str.Substring(startIndex, length);

        if (trimWhitespace)
            str = str.Trim();

        return str;
    }

    /// <summary>
    /// Removes the leading occurrence of a specified string from the current instance, using the provided string comparison option.
    /// </summary>
    /// <param name="str">The instance to remove the string from.</param>
    /// <param name="trimString">The string to remove.</param>
    /// <param name="stringComparison">One of the enumeration values that determines how the start of the current instance and <paramref name="trimString"/> are compared.</param>
    /// <param name="trimWhitespace">
    /// <see langword="true"/> to remove any whitespace characters remaining at the start of the original instance after <paramref name="trimString"/> is removed.
    /// If <see langword="true"/>, whitespace removal will occur regardless of whether the original instance starts with <paramref name="trimString"/>.
    /// </param>
    /// <returns>
    /// The string that remains after the occurrence of "trimString" is removed from the start of
    /// the current instance. If "trimString" is null, the empty string or not found at the start of the
    /// current instance the method returns the current instance unchanged.
    /// </returns>
    [Pure]
    public static string TrimStart(this string str, string trimString, StringComparison stringComparison = StringComparison.CurrentCulture, bool trimWhitespace = false)
    {
        if (string.IsNullOrEmpty(trimString))
            return str;

        if (str.StartsWith(trimString, stringComparison))
            str = str.Substring(trimString.Length);

        if (trimWhitespace)
            str = str.TrimStart();

        return str;
    }

    /// <summary>
    /// Removes the leading occurrence of a specified string from the current instance, comparing using the provided cultural information and case-sensitivity.
    /// </summary>
    /// <param name="str">The string to remove occurrences from.</param>
    /// <param name="trimString">The string to remove.</param>
    /// <param name="ignoreCase"><see langword="true"/> to ignore casing when trimming, <see langword="false"/> otherwise.</param>
    /// <param name="culture">
    /// Cultural information that determines how the start of this instance and <paramref name="trimString"/> are compared.
    /// If culture is null, the current culture is used.
    /// </param>
    /// <param name="trimWhitespace">
    /// <see langword="true"/> to remove any whitespace characters remaining at the start of the original instance after <paramref name="trimString"/> is removed.
    /// If <see langword="true"/>, whitespace removal will occur regardless of whether the original instance starts with <paramref name="trimString"/>.
    /// </param>
    /// <returns>
    /// The string that remains after the occurrence of <paramref name="trimString"/> is removed from the start of
    /// the current instance. If <paramref name="trimString"/> is <see langword="null"/>, the empty string or not found at the start of the
    /// current instance the method returns the current instance unchanged.
    /// </returns>
    [Pure]
    public static string TrimStart(this string str, string trimString, bool ignoreCase, CultureInfo? culture, bool trimWhitespace = false)
    {
        if (string.IsNullOrEmpty(trimString))
            return str;

        if (str.StartsWith(trimString, ignoreCase, culture))
            str = str.Substring(trimString.Length);

        if (trimWhitespace)
            str = str.TrimStart();

        return str;
    }

    /// <summary>
    /// Removes the trailing occurrence of a specified string from the current instance, using the provided string comparison option.
    /// </summary>
    /// <param name="str">The string to remove occurrences from.</param>
    /// <param name="trimString">The string to remove.</param>
    /// <param name="stringComparison">One of the enumeration values that determines how the end of the current instance and <paramref name="trimString"/> are compared.</param>
    /// <param name="trimWhitespace">
    /// <see langword="true"/> to remove any whitespace characters remaining at the end of the original instance after <paramref name="trimString"/> is removed.
    /// If <see langword="true"/>, whitespace removal will occur regardless of whether the original instance ends with <paramref name="trimString"/>.
    /// </param>
    /// <returns>
    /// The string that remains after the occurrence of <paramref name="trimString"/> is removed from the end of
    /// the current instance. If <paramref name="trimString"/> is <see langword="null"/>, the empty string or not found at the end of the
    /// current instance the method returns the current instance unchanged.
    /// </returns>
    [Pure]
    public static string TrimEnd(this string str, string trimString, StringComparison stringComparison = StringComparison.CurrentCulture, bool trimWhitespace = false)
    {
        if (string.IsNullOrEmpty(trimString))
            return str;

        if (str.EndsWith(trimString, stringComparison))
            str = str.Substring(0, str.Length - trimString.Length);

        if (trimWhitespace)
            str = str.TrimEnd();

        return str;
    }

    /// <summary>
    /// Removes the trailing occurrence of a specified string from the current instance, comparing using the provided cultural information and case-sensitivity.
    /// </summary>
    /// <param name="str">The string to remove occurrences from.</param>
    /// <param name="trimString">The string to remove.</param>
    /// <param name="ignoreCase"><see langword="true"/> to ignore casing when trimming, <see langword="false"/> otherwise.</param>
    /// <param name="culture">
    /// Cultural information that determines how the end of this instance and <paramref name="trimString"/> are compared.
    /// If culture is null, the current culture is used.
    /// </param>
    /// <param name="trimWhitespace">
    /// <see langword="true"/> to remove any whitespace characters remaining at the end of the original instance after <paramref name="trimString"/> is removed.
    /// If <see langword="true"/>, whitespace removal will occur regardless of whether the original instance ends with <paramref name="trimString"/>.
    /// </param>
    /// <returns>
    /// The string that remains after the occurrence of <paramref name="trimString"/> is removed from the end of
    /// the current instance. If <paramref name="trimString"/> is <see langword="null"/>, the empty string or not found at the end of the
    /// current instance the method returns the current instance unchanged.
    /// </returns>
    [Pure]
    public static string TrimEnd(this string str, string trimString, bool ignoreCase, CultureInfo? culture, bool trimWhitespace = false)
    {
        if (string.IsNullOrEmpty(trimString))
            return str;

        if (str.EndsWith(trimString, ignoreCase, culture))
            str = str.Substring(0, str.Length - trimString.Length);

        if (trimWhitespace)
            str = str.TrimEnd();

        return str;
    }
}
