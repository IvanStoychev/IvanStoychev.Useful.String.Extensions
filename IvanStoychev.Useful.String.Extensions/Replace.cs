using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace IvanStoychev.Useful.String.Extensions;

public static partial class StringExtensions
{
    /// <summary>
    /// Returns a new string in which all occurrences of all members of <paramref name="oldStrings"/>
    /// in the current instance are replaced with the given <paramref name="newString"/>, using the provided comparison type.
    /// </summary>
    /// <param name="str">String to operate on.</param>
    /// <param name="oldStrings">Collection of strings to be replaced.</param>
    /// <param name="newString">The string to replace all occurances of all members of <paramref name="oldStrings"/>.</param>
    /// <param name="comparison">Comparison rules to use for the replacement.</param>
    /// <returns>A string with all instances of all members of <paramref name="oldStrings"/> replaced by <paramref name="newString"/>.</returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="oldStrings"/> is empty, one of its memebers is the empty string ("")
    /// or the value given for <paramref name="comparison"/> is not a valid <see cref="StringComparison"/>.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="oldStrings"/>, one of its members or the original instance (<paramref name="str"/>) are null.
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
            Validate.EmptyStringMember(item, nameof(oldStrings));
            str = str.Replace(item, newString, comparison);
        }

        return str;
    }
}
