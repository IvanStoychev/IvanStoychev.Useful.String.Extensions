using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Text.RegularExpressions;

namespace IvanStoychev.Useful.String.Extensions;

public static partial class StringExtensions
{
    /// <summary>
    /// Returns a new string in which all occurrences of all members of <paramref name="oldStrings"/>
    /// in the current instance are replaced with the given <paramref name="newChar"/>, using the provided comparison type.
    /// </summary>
    /// <param name="str">String to operate on.</param>
    /// <param name="oldStrings">Collection of strings to be replaced.</param>
    /// <param name="newChar">Character to replace all occurances of all members of <paramref name="oldStrings"/> with.</param>
    /// <param name="comparison">Comparison rules to use for the replacement.</param>
    /// <returns>A string with all instances of all members of <paramref name="oldStrings"/> replaced by <paramref name="newChar"/>.</returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="oldStrings"/> is empty, one of its memebers is the empty string ("")
    /// or the value given for <paramref name="comparison"/> is not a valid <see cref="StringComparison"/>.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="oldStrings"/>, one of its members or the original instance (<paramref name="str"/>) are <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Replace(this string str, IEnumerable<string> oldStrings, char newChar, StringComparison comparison = StringComparison.CurrentCulture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(oldStrings);
        Validate.IEnumNotEmpty(oldStrings);
        Validate.EnumContainsValue<StringComparison>(comparison);

        string newString = newChar.ToString();
        foreach (var item in oldStrings)
        {
            Validate.NotNullMember(item, nameof(oldStrings));
            Validate.NotEmptyString_Member(item, nameof(oldStrings));
            str = str.Replace(item, newString, comparison);
        }

        return str;
    }

    /// <summary>
    /// Returns a new string in which all occurrences of all members of <paramref name="oldStrings"/> in the current instance are
    /// replaced with the given <paramref name="newChar"/>, using the provided cultural information and case-sensitivity.
    /// </summary>
    /// <param name="str">String to operate on.</param>
    /// <param name="oldStrings">Collection of strings to be replaced.</param>
    /// <param name="newChar">Character to replace all occurances of all members of <paramref name="oldStrings"/> with.</param>
    /// <param name="ignoreCase">Whether to consider strings equal if they have different casings.</param>
    /// <param name="culture">
    /// Cultural information that determines how strings are compared.
    /// <br/>If <paramref name="culture"/> is <see langword="null"/>, the current culture is used.
    /// </param>
    /// <returns>A string with all instances of all members of <paramref name="oldStrings"/> replaced by <paramref name="newChar"/>.</returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="oldStrings"/> is empty or one of its memebers is the empty string ("").
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="oldStrings"/>, one of its members or the original instance (<paramref name="str"/>) are <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Replace(this string str, IEnumerable<string> oldStrings, char newChar, bool ignoreCase, CultureInfo? culture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(oldStrings);
        Validate.IEnumNotEmpty(oldStrings);

        string newString = newChar.ToString();
        foreach (var item in oldStrings)
        {
            Validate.NotNullMember(item, nameof(oldStrings));
            Validate.NotEmptyString_Member(item, nameof(oldStrings));
            str = str.Replace(item, newString, ignoreCase, culture);
        }

        return str;
    }

    /// <summary>
    /// Returns a new string in which all occurrences of all members of <paramref name="oldStrings"/>
    /// in the current instance are replaced with the given <paramref name="newString"/>, using the provided comparison type.
    /// </summary>
    /// <param name="str">String to operate on.</param>
    /// <param name="oldStrings">Collection of strings to be replaced.</param>
    /// <param name="newString">String to replace all occurances of all members of <paramref name="oldStrings"/> with.</param>
    /// <param name="comparison">Comparison rules to use for the replacement.</param>
    /// <returns>A string with all instances of all members of <paramref name="oldStrings"/> replaced by <paramref name="newString"/>.</returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="oldStrings"/> is empty, one of its memebers is the empty string ("")
    /// or the value given for <paramref name="comparison"/> is not a valid <see cref="StringComparison"/>.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="oldStrings"/>, one of its members or the original instance (<paramref name="str"/>) are <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Replace(this string str, IEnumerable<string> oldStrings, string? newString, StringComparison comparison = StringComparison.CurrentCulture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(oldStrings);
        Validate.IEnumNotEmpty(oldStrings);
        Validate.EnumContainsValue<StringComparison>(comparison);

        foreach (var item in oldStrings)
        {
            Validate.NotNullMember(item, nameof(oldStrings));
            Validate.NotEmptyString_Member(item, nameof(oldStrings));
            str = str.Replace(item, newString, comparison);
        }

        return str;
    }

    /// <summary>
    /// Returns a new string in which all occurrences of all members of <paramref name="oldStrings"/>
    /// in the current instance are replaced with the given <paramref name="newString"/>, using the provided cultural information and case-sensitivity.
    /// </summary>
    /// <param name="str">String to operate on.</param>
    /// <param name="oldStrings">Collection of strings to be replaced.</param>
    /// <param name="newString">String to replace all occurances of all members of <paramref name="oldStrings"/> with.</param>
    /// <param name="ignoreCase">Whether to consider strings equal if they have different casings.</param>
    /// <param name="culture">
    /// Cultural information that determines how strings are compared.
    /// <br/>If <paramref name="culture"/> is <see langword="null"/>, the current culture is used.
    /// </param>
    /// <returns>A string with all instances of all members of <paramref name="oldStrings"/> replaced by <paramref name="newString"/>.</returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="oldStrings"/> is empty or one of its memebers is the empty string ("").
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="oldStrings"/>, one of its members or the original instance (<paramref name="str"/>) are <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Replace(this string str, IEnumerable<string> oldStrings, string? newString, bool ignoreCase, CultureInfo? culture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(oldStrings);
        Validate.IEnumNotEmpty(oldStrings);

        foreach (var item in oldStrings)
        {
            Validate.NotNullMember(item, nameof(oldStrings));
            Validate.NotEmptyString_Member(item, nameof(oldStrings));
            str = str.Replace(item, newString, ignoreCase, culture);
        }

        return str;
    }

    /// <summary>
    /// Returns a new string in which all occurrences of all members of <paramref name="oldChars"/>
    /// in the current instance are replaced with the given <paramref name="newChar"/>, using the provided comparison type.
    /// </summary>
    /// <param name="str">String to operate on.</param>
    /// <param name="oldChars">Collection of characters to be replaced.</param>
    /// <param name="newChar">Character to replace all occurances of all members of <paramref name="oldChars"/> with.</param>
    /// <param name="comparison">Comparison rules to use for the replacement.</param>
    /// <returns>A string with all instances of all members of <paramref name="oldChars"/> replaced by <paramref name="newChar"/>.</returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="oldChars"/> is empty or the value given for <paramref name="comparison"/> is not a valid <see cref="StringComparison"/>.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="oldChars"/> or the original instance (<paramref name="str"/>) are <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Replace(this string str, IEnumerable<char> oldChars, char newChar, StringComparison comparison = StringComparison.CurrentCulture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(oldChars);
        Validate.IEnumNotEmpty(oldChars);
        Validate.EnumContainsValue<StringComparison>(comparison);

        string newString = newChar.ToString();
        foreach (var item in oldChars)
            str = str.Replace(item.ToString(), newString, comparison);

        return str;
    }

    /// <summary>
    /// Returns a new string in which all occurrences of all members of <paramref name="oldChars"/>
    /// in the current instance are replaced with the given <paramref name="newChar"/>, using the provided cultural information and case-sensitivity.
    /// </summary>
    /// <param name="str">String to operate on.</param>
    /// <param name="oldChars">Collection of characters to be replaced.</param>
    /// <param name="newChar">Character to replace all occurances of all members of <paramref name="oldChars"/> with.</param>
    /// <param name="ignoreCase">Whether to consider strings equal if they have different casings.</param>
    /// <param name="culture">
    /// Cultural information that determines how strings are compared.
    /// <br/>If <paramref name="culture"/> is <see langword="null"/>, the current culture is used.
    /// </param>
    /// <returns>A string with all instances of all members of <paramref name="oldChars"/> replaced by <paramref name="newChar"/>.</returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="oldChars"/> is empty.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="oldChars"/> or the original instance (<paramref name="str"/>) are <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Replace(this string str, IEnumerable<char> oldChars, char newChar, bool ignoreCase, CultureInfo? culture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(oldChars);
        Validate.IEnumNotEmpty(oldChars);

        string newString = newChar.ToString();
        foreach (var item in oldChars)
            str = str.Replace(item.ToString(), newString, ignoreCase, culture);

        return str;
    }

    /// <summary>
    /// Returns a new string in which all occurrences of all members of <paramref name="oldChars"/>
    /// in the current instance are replaced with the given <paramref name="newString"/>, using the provided comparison type.
    /// </summary>
    /// <param name="str">String to operate on.</param>
    /// <param name="oldChars">Collection of characters to be replaced.</param>
    /// <param name="newString">String to replace all occurances of all members of <paramref name="oldChars"/> with.</param>
    /// <param name="comparison">Comparison rules to use for the replacement.</param>
    /// <returns>A string with all instances of all members of <paramref name="oldChars"/> replaced by <paramref name="newString"/>.</returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="oldChars"/> is empty or the value given for <paramref name="comparison"/> is not a valid <see cref="StringComparison"/>.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="oldChars"/> or the original instance (<paramref name="str"/>) are <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Replace(this string str, IEnumerable<char> oldChars, string? newString, StringComparison comparison = StringComparison.CurrentCulture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(oldChars);
        Validate.IEnumNotEmpty(oldChars);
        Validate.EnumContainsValue<StringComparison>(comparison);

        foreach (var item in oldChars)
            str = str.Replace(item.ToString(), newString, comparison);

        return str;
    }

    /// <summary>
    /// Returns a new string in which all occurrences of all members of <paramref name="oldChars"/>
    /// in the current instance are replaced with the given <paramref name="newString"/>, using the provided cultural information and case-sensitivity.
    /// </summary>
    /// <param name="str">String to operate on.</param>
    /// <param name="oldChars">Collection of characters to be replaced.</param>
    /// <param name="newString">String to replace all occurances of all members of <paramref name="oldChars"/> with.</param>
    /// <param name="ignoreCase">Whether to consider strings equal if they have different casings.</param>
    /// <param name="culture">
    /// Cultural information that determines how strings are compared.
    /// <br/>If <paramref name="culture"/> is <see langword="null"/>, the current culture is used.
    /// </param>
    /// <returns>A string with all instances of all members of <paramref name="oldChars"/> replaced by <paramref name="newString"/>.</returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="oldChars"/> is empty.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="oldChars"/> or the original instance (<paramref name="str"/>) are <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Replace(this string str, IEnumerable<char> oldChars, string? newString, bool ignoreCase, CultureInfo? culture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(oldChars);
        Validate.IEnumNotEmpty(oldChars);

        foreach (var item in oldChars)
            str = str.Replace(item.ToString(), newString, ignoreCase, culture);

        return str;
    }

    /// <summary>
    /// Returns a new string in which all occurrences of all keys of <paramref name="replaceData"/> in the current instance are replaced
    /// with their corresponding values, using the provided comparison type.
    /// </summary>
    /// <param name="str">String to operate on.</param>
    /// <param name="replaceData">Collection of keys to replace with their values.</param>
    /// <param name="comparison">Comparison rules to use for the replacement.</param>
    /// <returns>A string with all instances of all keys of <paramref name="replaceData"/> replaced by their corresponding values.</returns>
    [Pure]
    public static string Replace(this string str, IEnumerable<KeyValuePair<string, string>> replaceData, StringComparison comparison = StringComparison.CurrentCulture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(replaceData);
        Validate.IEnumNotEmpty(replaceData);
        Validate.EnumContainsValue<StringComparison>(comparison);

        foreach (var item in replaceData)
        {
            Validate.NotEmptyString_Member(item.Key, nameof(replaceData));
            str = str.Replace(item.Key, item.Value, comparison);
        }

        return str;
    }
}
