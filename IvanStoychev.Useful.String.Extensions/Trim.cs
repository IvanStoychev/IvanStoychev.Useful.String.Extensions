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
    /// Removes all leading and trailing occurrences of a specified string from the current instance, using the provided string comparison option.
    /// </summary>
    /// <param name="str">The instance to remove the string from.</param>
    /// <param name="trimString">The string to remove.</param>
    /// <param name="comparison">One of the enumeration values that determines how the start of the current instance and <paramref name="trimString"/> are compared.</param>
    /// <param name="trimWhitespace">
    /// <see langword="true"/> to remove any whitespace characters remaining at the start and end of the original instance after <paramref name="trimString"/> is removed.
    /// If <see langword="true"/>, whitespace removal will occur regardless of whether the original instance starts and/or ends with <paramref name="trimString"/>.
    /// </param>
    /// <returns>
    /// The string that remains after the occurrence of "trimString" is removed from the start and end of the current instance. If "trimString" is <see langword="null"/>,
    /// the empty string or not found at the start or end of the current instance the method returns the current instance unchanged.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="comparison"/> is not a valid <see cref="StringComparison"/>.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// The original instance (<paramref name="str"/>) is <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Trim(this string str, string trimString, StringComparison comparison = StringComparison.CurrentCulture, bool trimWhitespace = false)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.EnumContainsValue<StringComparison>(comparison);

        if (string.IsNullOrEmpty(trimString))
            return trimWhitespace ? str.Trim() : str;

        str = str.TrimStart(trimString, comparison, trimWhitespace);
        str = str.TrimEnd(trimString, comparison, trimWhitespace);

        return str;
    }

    /// <summary>
    /// Removes all leading and trailing occurrences of a specified string from the current instance, comparing using the provided cultural information and case-sensitivity.
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
    /// <exception cref="ArgumentNullException">
    /// The original instance (<paramref name="str"/>) is <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Trim(this string str, string trimString, bool ignoreCase, CultureInfo? culture, bool trimWhitespace = false)
    {
        Validate.OriginalInstanceNotNull(str);

        if (string.IsNullOrEmpty(trimString))
            return trimWhitespace ? str.Trim() : str;

        str = str.TrimStart(trimString, ignoreCase, culture, trimWhitespace);
        str = str.TrimEnd(trimString, ignoreCase, culture, trimWhitespace);

        return str;
    }

    /// <summary>
    /// Removes all leading occurrences of a specified string from the current instance, using the provided string comparison option.
    /// </summary>
    /// <param name="str">The instance to remove the string from.</param>
    /// <param name="trimString">The string to remove.</param>
    /// <param name="comparison">One of the enumeration values that determines how the start of the current instance and <paramref name="trimString"/> are compared.</param>
    /// <param name="trimWhitespace">
    /// <see langword="true"/> to remove any whitespace characters remaining at the start of the original instance after <paramref name="trimString"/> is removed.
    /// If <see langword="true"/>, whitespace removal will occur regardless of whether the original instance starts with <paramref name="trimString"/>.
    /// </param>
    /// <returns>
    /// The string that remains after the occurrence of "trimString" is removed from the start of
    /// the current instance. If "trimString" is null, the empty string or not found at the start of the
    /// current instance the method returns the current instance unchanged.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="comparison"/> is not a valid <see cref="StringComparison"/>.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// The original instance (<paramref name="str"/>) is <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string TrimStart(this string str, string trimString, StringComparison comparison = StringComparison.CurrentCulture, bool trimWhitespace = false)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.EnumContainsValue<StringComparison>(comparison);
        
        if (string.IsNullOrEmpty(trimString))
            return trimWhitespace ? str.TrimStart() : str;

        while (str.StartsWith(trimString, comparison))
            str = str.Substring(trimString.Length);

        if (trimWhitespace)
            str = str.TrimStart();

        return str;
    }

    /// <summary>
    /// Removes all leading occurrences of a specified string from the current instance, comparing using the provided cultural information and case-sensitivity.
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
    /// <exception cref="ArgumentNullException">
    /// The original instance (<paramref name="str"/>) is <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string TrimStart(this string str, string trimString, bool ignoreCase, CultureInfo? culture, bool trimWhitespace = false)
    {
        Validate.OriginalInstanceNotNull(str);

        if (string.IsNullOrEmpty(trimString))
            return trimWhitespace ? str.TrimStart() : str;

        while (str.StartsWith(trimString, ignoreCase, culture))
            str = str.Substring(trimString.Length);

        if (trimWhitespace)
            str = str.TrimStart();

        return str;
    }

    /// <summary>
    /// Removes all trailing occurrences of a specified string from the current instance, using the provided string comparison option.
    /// </summary>
    /// <param name="str">The string to remove occurrences from.</param>
    /// <param name="trimString">The string to remove.</param>
    /// <param name="comparison">One of the enumeration values that determines how the end of the current instance and <paramref name="trimString"/> are compared.</param>
    /// <param name="trimWhitespace">
    /// <see langword="true"/> to remove any whitespace characters remaining at the end of the original instance after <paramref name="trimString"/> is removed.
    /// If <see langword="true"/>, whitespace removal will occur regardless of whether the original instance ends with <paramref name="trimString"/>.
    /// </param>
    /// <returns>
    /// The string that remains after the occurrence of <paramref name="trimString"/> is removed from the end of
    /// the current instance. If <paramref name="trimString"/> is <see langword="null"/>, the empty string or not found at the end of the
    /// current instance the method returns the current instance unchanged.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="comparison"/> is not a valid <see cref="StringComparison"/>.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// The original instance (<paramref name="str"/>) is <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string TrimEnd(this string str, string trimString, StringComparison comparison = StringComparison.CurrentCulture, bool trimWhitespace = false)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.EnumContainsValue<StringComparison>(comparison);

        if (string.IsNullOrEmpty(trimString))
            return trimWhitespace ? str.TrimEnd() : str;

        while (str.EndsWith(trimString, comparison))
            str = str.Substring(0, str.Length - trimString.Length);

        if (trimWhitespace)
            str = str.TrimEnd();

        return str;
    }

    /// <summary>
    /// Removes all trailing occurrences of a specified string from the current instance, comparing using the provided cultural information and case-sensitivity.
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
    /// <exception cref="ArgumentNullException">
    /// The original instance (<paramref name="str"/>) is <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string TrimEnd(this string str, string trimString, bool ignoreCase, CultureInfo? culture, bool trimWhitespace = false)
    {
        Validate.OriginalInstanceNotNull(str);

        if (string.IsNullOrEmpty(trimString))
            return trimWhitespace ? str.TrimEnd() : str;

        while (str.EndsWith(trimString, ignoreCase, culture))
            str = str.Substring(0, str.Length - trimString.Length);

        if (trimWhitespace)
            str = str.TrimEnd();

        return str;
    }
}
