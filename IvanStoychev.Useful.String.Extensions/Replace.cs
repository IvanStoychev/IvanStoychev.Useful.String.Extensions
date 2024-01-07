using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace IvanStoychev.Useful.String.Extensions;

public static partial class StringExtensions
{
    /// <summary>
    /// Returns a new string in which all occurrences of all members of <paramref name="oldStrings"/> in the current instance are replaced with the given
    /// <paramref name="newChar"/>, using the provided comparison type and converting <paramref name="newChar"/> to a <see cref="string"/>.
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
    /// <paramref name="oldStrings"/>, one of its members or the original instance are <see langword="null"/>.
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
    /// Returns a new string in which all occurrences of all members of <paramref name="oldStrings"/> in the current instance are replaced with the given
    /// <paramref name="newChar"/>, using the provided cultural information and case-sensitivity and converting <paramref name="newChar"/> to a <see cref="string"/>.
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
    /// <paramref name="oldStrings"/>, one of its members or the original instance are <see langword="null"/>.
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
    /// Returns a new string in which all occurrences of all members of <paramref name="oldStrings"/> in the current instance are replaced with the given
    /// <paramref name="newString"/>, using the provided comparison type.
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
    /// <paramref name="oldStrings"/>, one of its members or the original instance are <see langword="null"/>.
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
    /// Returns a new string in which all occurrences of all members of <paramref name="oldStrings"/> in the current instance are replaced with the given
    /// <paramref name="newString"/>, using the provided cultural information and case-sensitivity.
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
    /// <paramref name="oldStrings"/>, one of its members or the original instance are <see langword="null"/>.
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
    /// Returns a new string in which all occurrences of all members of <paramref name="oldChars"/> in the current instance are replaced with the given <paramref name="newChar"/>.
    /// </summary>
    /// <param name="str">String to operate on.</param>
    /// <param name="oldChars">Collection of characters to be replaced.</param>
    /// <param name="newChar">Character to replace all occurances of all members of <paramref name="oldChars"/> with.</param>
    /// <returns>A string with all instances of all members of <paramref name="oldChars"/> replaced by <paramref name="newChar"/>.</returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="oldChars"/> is empty.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="oldChars"/> or the original instance are <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Replace(this string str, IEnumerable<char> oldChars, char newChar)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(oldChars);
        Validate.IEnumNotEmpty(oldChars);

        foreach (var item in oldChars)
            str = str.Replace(item, newChar);

        return str;
    }

    /// <summary>
    /// Returns a new string in which all occurrences of all members of <paramref name="oldChars"/> in the current instance are replaced with the given
    /// <paramref name="newString"/>, using the provided comparison type and converting <paramref name="oldChars"/> members to <see cref="string"/>.
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
    /// <paramref name="oldChars"/> or the original instance are <see langword="null"/>.
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
    /// Returns a new string in which all occurrences of all members of <paramref name="oldChars"/> in the current instance are replaced with the given
    /// <paramref name="newString"/>, using the provided cultural information and case-sensitivity and converting <paramref name="oldChars"/> members to <see cref="string"/>.
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
    /// <paramref name="oldChars"/> or the original instance are <see langword="null"/>.
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
    /// <exception cref="ArgumentException">
    /// <paramref name="replaceData"/> contains no elements, one of its keys is the empty string ("") or the value given for <paramref name="comparison"/>
    /// is not a valid <see cref="StringComparison"/>.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="replaceData"/> or the original instance are <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Replace(this string str, IEnumerable<KeyValuePair<string, string>> replaceData, StringComparison comparison = StringComparison.CurrentCulture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(replaceData);
        Validate.IEnumNotEmpty(replaceData);
        Validate.EnumContainsValue<StringComparison>(comparison);

        foreach (var item in replaceData)
        {
            Validate.NotEmptyString_Key(item.Key, nameof(replaceData));
            str = str.Replace(item.Key, item.Value, comparison);
        }

        return str;
    }

    /// <summary>
    /// Returns a new string in which all occurrences of all keys of <paramref name="replaceData"/> in the current instance are replaced
    /// with their corresponding values, using the provided cultural information and case-sensitivity.
    /// </summary>
    /// <param name="str">String to operate on.</param>
    /// <param name="replaceData">Collection of keys to replace with their values.</param>
    /// <param name="ignoreCase">Whether to consider strings equal if they have different casings.</param>
    /// <param name="culture">
    /// Cultural information that determines how strings are compared.
    /// <br/>If <paramref name="culture"/> is <see langword="null"/>, the current culture is used.
    /// </param>
    /// <returns>A string with all instances of all keys of <paramref name="replaceData"/> replaced by their corresponding values.</returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="replaceData"/> contains no elements or one of its keys is the empty string ("").
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="replaceData"/> or the original instance are <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Replace(this string str, IEnumerable<KeyValuePair<string, string>> replaceData, bool ignoreCase, CultureInfo? culture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(replaceData);
        Validate.IEnumNotEmpty(replaceData);

        foreach (var item in replaceData)
        {
            Validate.NotEmptyString_Key(item.Key, nameof(replaceData));
            str = str.Replace(item.Key, item.Value, ignoreCase, culture);
        }

        return str;
    }

    /// <summary>
    /// Returns a new string in which all occurrences of all keys of <paramref name="replaceData"/> in the current instance are replaced
    /// with their corresponding values, using the provided comparison type and converting the values to <see cref="string"/>.
    /// </summary>
    /// <param name="str">String to operate on.</param>
    /// <param name="replaceData">Collection of keys to replace with their values.</param>
    /// <param name="comparison">Comparison rules to use for the replacement.</param>
    /// <returns>A string with all instances of all keys of <paramref name="replaceData"/> replaced by their corresponding values.</returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="replaceData"/> contains no elements, one of its keys is the empty string ("") or the value given for <paramref name="comparison"/>
    /// is not a valid <see cref="StringComparison"/>.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="replaceData"/> or the original instance are <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Replace(this string str, IEnumerable<KeyValuePair<string, char>> replaceData, StringComparison comparison = StringComparison.CurrentCulture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(replaceData);
        Validate.IEnumNotEmpty(replaceData);
        Validate.EnumContainsValue<StringComparison>(comparison);

        foreach (var item in replaceData)
        {
            Validate.NotEmptyString_Key(item.Key, nameof(replaceData));
            string value = item.Value.ToString();
            str = str.Replace(item.Key, value, comparison);
        }

        return str;
    }

    /// <summary>
    /// Returns a new string in which all occurrences of all keys of <paramref name="replaceData"/> in the current instance are replaced
    /// with their corresponding values, using the provided cultural information and case-sensitivity.
    /// </summary>
    /// <param name="str">String to operate on.</param>
    /// <param name="replaceData">Collection of keys to replace with their values.</param>
    /// <param name="ignoreCase">Whether to consider strings equal if they have different casings.</param>
    /// <param name="culture">
    /// Cultural information that determines how strings are compared.
    /// <br/>If <paramref name="culture"/> is <see langword="null"/>, the current culture is used.
    /// </param>
    /// <returns>A string with all instances of all keys of <paramref name="replaceData"/> replaced by their corresponding values.</returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="replaceData"/> contains no elements or one of its keys is the empty string ("").
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="replaceData"/> or the original instance are <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Replace(this string str, IEnumerable<KeyValuePair<string, char>> replaceData, bool ignoreCase, CultureInfo? culture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(replaceData);
        Validate.IEnumNotEmpty(replaceData);

        foreach (var item in replaceData)
        {
            Validate.NotEmptyString_Key(item.Key, nameof(replaceData));
            string value = item.Value.ToString();
            str = str.Replace(item.Key, value, ignoreCase, culture);
        }

        return str;
    }

    /// <summary>
    /// Returns a new string in which all occurrences of all keys of <paramref name="replaceData"/> in the current instance are replaced
    /// with their corresponding values, using the provided comparison type and converting the keys to <see cref="string"/>.
    /// </summary>
    /// <param name="str">String to operate on.</param>
    /// <param name="replaceData">Collection of keys to replace with their values.</param>
    /// <param name="comparison">Comparison rules to use for the replacement.</param>
    /// <returns>A string with all instances of all keys of <paramref name="replaceData"/> replaced by their corresponding values.</returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="replaceData"/> contains no elements or the value given for <paramref name="comparison"/> is not a valid <see cref="StringComparison"/>.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="replaceData"/> or the original instance are <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Replace(this string str, IEnumerable<KeyValuePair<char, string>> replaceData, StringComparison comparison = StringComparison.CurrentCulture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(replaceData);
        Validate.IEnumNotEmpty(replaceData);
        Validate.EnumContainsValue<StringComparison>(comparison);

        foreach (var item in replaceData)
        {
            string key = item.Key.ToString();
            str = str.Replace(key, item.Value, comparison);
        }

        return str;
    }

    /// <summary>
    /// Returns a new string in which all occurrences of all keys of <paramref name="replaceData"/> in the current instance are replaced
    /// with their corresponding values, using the provided cultural information and case-sensitivity.
    /// </summary>
    /// <param name="str">String to operate on.</param>
    /// <param name="replaceData">Collection of keys to replace with their values.</param>
    /// <param name="ignoreCase">Whether to consider strings equal if they have different casings.</param>
    /// <param name="culture">
    /// Cultural information that determines how strings are compared.
    /// <br/>If <paramref name="culture"/> is <see langword="null"/>, the current culture is used.
    /// </param>
    /// <returns>A string with all instances of all keys of <paramref name="replaceData"/> replaced by their corresponding values.</returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="replaceData"/> contains no elements.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="replaceData"/> or the original instance are <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Replace(this string str, IEnumerable<KeyValuePair<char, string>> replaceData, bool ignoreCase, CultureInfo? culture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(replaceData);
        Validate.IEnumNotEmpty(replaceData);

        foreach (var item in replaceData)
        {
            string key = item.Key.ToString();
            str = str.Replace(key, item.Value, ignoreCase, culture);
        }

        return str;
    }

    /// <summary>
    /// Returns a new string in which all occurrences of all keys of <paramref name="replaceData"/> in the current instance are replaced
    /// with their corresponding values.
    /// </summary>
    /// <param name="str">String to operate on.</param>
    /// <param name="replaceData">Collection of keys to replace with their values.</param>
    /// <returns>A string with all instances of all keys of <paramref name="replaceData"/> replaced by their corresponding values.</returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="replaceData"/> contains no elements.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="replaceData"/> or the original instance are <see langword="null"/>.
    /// </exception>
    [Pure]
    public static string Replace(this string str, IEnumerable<KeyValuePair<char, char>> replaceData)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(replaceData);
        Validate.IEnumNotEmpty(replaceData);

        foreach (var item in replaceData)
            str = str.Replace(item.Key, item.Value);

        return str;
    }
}
