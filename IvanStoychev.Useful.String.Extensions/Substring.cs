using System;
using System.Diagnostics.Contracts;

namespace IvanStoychev.Useful.String.Extensions;

public static partial class StringExtensions
{
    /// <summary>
    /// Retrieves a substring from this instance. The substring starts at the first occurrence of the given <paramref name="startString"/> and has the specified <paramref name="length"/>.
    /// The retrieved substring can contain <paramref name="startString"/> in it if <paramref name="inclusive"/> is <see langword="true"/>. In both cases the length
    /// will be counted from the end of <paramref name="startString"/>.
    /// </summary>
    /// <param name="str">The instance from which to extract a substring.</param>
    /// <param name="startString">The string which marks the start of the substring.</param>
    /// <param name="length">
    /// The number of characters to return. If <paramref name="inclusive"/> is <see langword="true"/> characters will be counted from the end of <paramref name="startString"/>.
    /// </param>
    /// <param name="inclusive">A boolean indicating whether the substring should include the given <paramref name="startString"/>.</param>
    /// <param name="comparison">The comparison rules to use when looking for the strings.</param>
    /// <returns>
    /// A string that is equivalent to the substring of length <paramref name="length"/> that begins at
    /// the first instance of <paramref name="startString"/> in this string instance.
    /// <br/>If <paramref name="startString"/> is the empty string ("") the returned substring starts at index 0 of the string instance.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="comparison"/> is not a valid <see cref="StringComparison"/>.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="startString"/> or the original instance (<paramref name="str"/>) are null.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="startString"/> is not found in the original instance or the index of <paramref name="startString"/> plus <paramref name="length"/> indicates
    /// a position not within this instance.
    /// </exception>
    [Pure]
    public static string Substring(this string str, string startString, int length, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(startString);
        Validate.LengthIsPositive(length);
        Validate.EnumContainsValue<StringComparison>(comparison);
        Validate.SubstringIndex(str, startString, out int startStringIndex, comparison);

        int availableLength = str.Length - startStringIndex - startString.Length;
        Validate.LengthIsWithinBounds(availableLength, length);

        startStringIndex = AddSubstringLengthConditional(startStringIndex, startString, inclusive);
        int offsetlength = AddSubstringLengthConditional(length, startString, !inclusive);

        return str.Substring(startStringIndex, offsetlength);
    }

    /// <summary>
    /// Locates he first occurrence of <paramref name="startString"/> in the original instance and returns the string situated between it and the first occurrence
    /// of <paramref name="endString"/>, located after <paramref name="startString"/>. Whether <paramref name="startString"/> and/or <paramref name="endString"/>,
    /// themselves, are returned is controlled by the <paramref name="inclusionOptions"/> argument.
    /// </summary>
    /// <param name="str">The instance from which to extract a substring.</param>
    /// <param name="startString">The string which marks the start of the substring to be extracted.</param>
    /// <param name="endString">The string which marks the end of the substring.</param>
    /// <param name="inclusionOptions">
    /// A <see cref="StringInclusionOptions"/> enum, indicating whether <paramref name="startString"/> and/or <paramref name="endString"/> should be included in the result.
    /// </param>
    /// <param name="comparison">The comparison rules to use when looking for the strings.</param>
    /// <returns>
    /// A string representing the part of the original instance, located between <paramref name="startString"/> and <paramref name="endString"/>.
    /// <br/>If <paramref name="startString"/> is the empty string ("") the returned substring starts at index 0 of the string instance.
    /// <br/>If <paramref name="endString"/> is the empty string ("") the returned substring will end right after <paramref name="startString"/>.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="comparison"/> is not a valid <see cref="StringComparison"/>.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="startString"/>, <paramref name="endString"/> or the original instance (<paramref name="str"/>) are null.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="startString"/> was not found in the original instance or <paramref name="endString"/> was not found in the part of the original instance after <paramref name="startString"/>.
    /// </exception>
    [Pure]
    public static string Substring(this string str, string startString, string endString, StringInclusionOptions inclusionOptions = StringInclusionOptions.IncludeNone, StringComparison comparison = StringComparison.CurrentCulture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(startString);
        Validate.NotNull(endString);
        Validate.EnumContainsValue<StringComparison>(comparison);
        Validate.EnumContainsValue<StringInclusionOptions>(inclusionOptions);
        Validate.EndStringIndex(str, startString, endString, out int startStringIndex, out int endStringIndex, comparison);

        // This logic is because of how the "endStringIndex" is being calculated.
        switch (inclusionOptions)
        {
            case StringInclusionOptions.IncludeNone:
                startStringIndex += startString.Length;
                break;
            case StringInclusionOptions.IncludeStart:
                endStringIndex += startString.Length;
                break;
            case StringInclusionOptions.IncludeEnd:
                startStringIndex += startString.Length;
                endStringIndex += endString.Length;
                break;
            case StringInclusionOptions.IncludeAll:
                endStringIndex += endString.Length + startString.Length;
                break;
        }

        int selectLength = endStringIndex;

        return str.Substring(startStringIndex, selectLength);
    }

    /// <summary>
    /// Locates he first occurrence of <paramref name="startString"/> in the original instance and returns the string situated between it and the last occurrence
    /// of <paramref name="endString"/>, located after <paramref name="startString"/>. Whether <paramref name="startString"/> and/or <paramref name="endString"/>,
    /// themselves, are returned is controlled by the <paramref name="inclusionOptions"/> argument.
    /// </summary>
    /// <param name="str">The instance from which to extract a substring.</param>
    /// <param name="startString">The string which marks the start of the substring to be extracted.</param>
    /// <param name="endString">The string which marks the end of the substring.</param>
    /// <param name="inclusionOptions">
    /// A <see cref="StringInclusionOptions"/> enum, indicating whether <paramref name="startString"/> and/or <paramref name="endString"/> should be included in the result.
    /// </param>
    /// <param name="comparison">The comparison rules to use when looking for the strings.</param>
    /// <returns>
    /// A string representing the part of the original instance, located between <paramref name="startString"/> and <paramref name="endString"/>.
    /// <br/>If <paramref name="startString"/> is the empty string ("") the returned substring starts at index 0 of the string instance.
    /// <br/>If <paramref name="endString"/> is the empty string ("") the method returns what remains of the instance after <paramref name="startString"/>.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="comparison"/> is not a valid <see cref="StringComparison"/>.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="startString"/>, <paramref name="endString"/> or the original instance (<paramref name="str"/>) are null.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="startString"/> was not found in the original instance or <paramref name="endString"/> was not found in the part of the original instance after <paramref name="startString"/>.
    /// </exception>
    [Pure]
    public static string SubstringLast(this string str, string startString, string endString, StringInclusionOptions inclusionOptions = StringInclusionOptions.IncludeNone, StringComparison comparison = StringComparison.CurrentCulture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(startString);
        Validate.NotNull(endString);
        Validate.EnumContainsValue<StringComparison>(comparison);
        Validate.EnumContainsValue<StringInclusionOptions>(inclusionOptions);
        Validate.EndStringLastIndex(str, startString, endString, out int startStringIndex, out int endStringIndex, comparison);

        // This logic is because of how the "endStringIndex" is being calculated.
        switch (inclusionOptions)
        {
            case StringInclusionOptions.IncludeNone:
                startStringIndex += startString.Length;
                break;
            case StringInclusionOptions.IncludeStart:
                endStringIndex += startString.Length;
                break;
            case StringInclusionOptions.IncludeEnd:
                startStringIndex += startString.Length;
                endStringIndex += endString.Length;
                break;
            case StringInclusionOptions.IncludeAll:
                endStringIndex += endString.Length + startString.Length;
                break;
        }

        int selectLength = endStringIndex;

        return str.Substring(startStringIndex, selectLength);
    }

    /// <summary>
    /// Retrieves the substring from the start of this instance to the first occurrence of the given <paramref name="endString"/>.
    /// </summary>
    /// <param name="str">The instance from which to extract a substring.</param>
    /// <param name="endString">The string which marks the end of the substring.</param>
    /// <param name="inclusive">A boolean indicating whether the substring should include the given <paramref name="endString"/>.</param>
    /// <param name="comparison">The comparison rules to use when looking for the strings.</param>
    /// <returns>
    /// A string representing the part of the original string, located from the start of the original instance to the first occurrence of <paramref name="endString"/>.
    /// <br/>If <paramref name="endString"/> is the empty string ("") the method also returns the empty string ("").
    /// </returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="comparison"/> is not a valid <see cref="StringComparison"/>.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="endString"/> or the original instance (<paramref name="str"/>) are null.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="endString"/> is not found in the original instance.
    /// </exception>
    [Pure]
    public static string SubstringStart(this string str, string endString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(endString);
        Validate.EnumContainsValue<StringComparison>(comparison);
        Validate.SubstringIndex(str, endString, out int endStringIndex, comparison);

        endStringIndex = AddSubstringLengthConditional(endStringIndex, endString, !inclusive);

        return str.Substring(0, endStringIndex);
    }

    /// <summary>
    /// Retrieves the substring from the start of this instance to the last occurrence of the given <paramref name="endString"/>.
    /// </summary>
    /// <param name="str">The instance from which to extract a substring.</param>
    /// <param name="endString">The string which marks the end of the substring.</param>
    /// <param name="inclusive">A boolean indicating whether the substring should include the given <paramref name="endString"/>.</param>
    /// <param name="comparison">The comparison rules to use when looking for the strings.</param>
    /// <returns>
    /// Substring starting from the first occurrence of <paramref name="endString"/> to the end of the original string.
    /// <br/>If <paramref name="endString"/> is the empty string ("") the method returns the original instance, unchanged.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="comparison"/> is not a valid <see cref="StringComparison"/>.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="endString"/> or the original instance (<paramref name="str"/>) are null.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="endString"/> is not found in the original instance.
    /// </exception>
    [Pure]
    public static string SubstringStartLast(this string str, string endString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(endString);
        Validate.EnumContainsValue<StringComparison>(comparison);
        Validate.SubstringLastIndex(str, endString, out int endStringIndex, comparison);

        endStringIndex = AddSubstringLengthConditional(endStringIndex, endString, !inclusive);

        return str.Substring(0, endStringIndex);
    }

    /// <summary>
    /// Retrieves the substring starting from the first occurrence of the given <paramref name="startString"/> to the end of this instance.
    /// </summary>
    /// <param name="str">The instance from which to extract a substring.</param>
    /// <param name="startString">The string which marks the start of the substring.</param>
    /// <param name="inclusive">A boolean indicating whether the substring should include the given <paramref name="startString"/>.</param>
    /// <param name="comparison">The comparison rules to use when looking for the strings.</param>
    /// <returns>
    /// A string representing the part of the original string, located from <paramref name="startString"/> to the end of the original instance.
    /// <br/>If <paramref name="startString"/> is the empty string ("") the returned substring starts at index 0 of the string instance.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="comparison"/> is not a valid <see cref="StringComparison"/>.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="startString"/> or the original instance (<paramref name="str"/>) are null.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="startString"/> is not found in the original instance.
    /// </exception>
    [Pure]
    public static string SubstringEnd(this string str, string startString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(startString);
        Validate.EnumContainsValue<StringComparison>(comparison);
        Validate.SubstringIndex(str, startString, out int startStringIndex, comparison);

        startStringIndex = AddSubstringLengthConditional(startStringIndex, startString, inclusive);

        return str.Substring(startStringIndex);
    }

    /// <summary>
    /// Retrieves the substring starting from the last occurrence of <paramref name="startString"/> to the end of this instance.
    /// </summary>
    /// <param name="str">The instance from which to extract a substring.</param>
    /// <param name="startString">The string which marks the start of the substring.</param>
    /// <param name="inclusive">A boolean indicating whether the substring should include the given <paramref name="startString"/>.</param>
    /// <param name="comparison">The comparison rules to use when looking for the strings.</param>
    /// <returns>
    /// Substring of the original string, starting from the last occurrence of <paramref name="startString"/> to the end of the original string.
    /// <br/>If <paramref name="startString"/> is the empty string ("") the method returns the original instance, unchanged.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="comparison"/> is not a valid <see cref="StringComparison"/>.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="startString"/> or the original instance (<paramref name="str"/>) are null.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="startString"/> is not found in the original instance.
    /// </exception>
    [Pure]
    public static string SubstringEndLast(this string str, string startString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(startString);
        Validate.EnumContainsValue<StringComparison>(comparison);
        Validate.SubstringLastIndex(str, startString, out int startStringIndex, comparison);

        startStringIndex = AddSubstringLengthConditional(startStringIndex, startString, inclusive);

        return str.Substring(startStringIndex);
    }

    /// <summary>
    /// Retrieves a substring from this instance. The substring starts at the last occurrence of the given <paramref name="startString"/> and has the specified
    /// <paramref name="length"/>. The retrieved substring can contain <paramref name="startString"/> in it if <paramref name="inclusive"/> is <see langword="true"/>.
    /// In that case the length will be counted from the end of <paramref name="startString"/>.
    /// </summary>
    /// <param name="str">The instance from which to extract a substring.</param>
    /// <param name="startString">The string which marks the start of the substring.</param>
    /// <param name="length">The number of characters to return.</param>
    /// <param name="inclusive">A boolean indicating whether the substring should include the given <paramref name="startString"/>.</param>
    /// <param name="comparison">The comparison rules to use when looking for the strings.</param>
    /// <returns>
    /// A substring of length "<paramref name="length"/>" that begins at the last occurrence of <paramref name="startString"/> in this instance.
    /// <br/>If <paramref name="startString"/> is the empty string ("") the returned substring starts at the last index of the string instance and
    /// any <paramref name="length"/> greater than 0 will cause an exception.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="comparison"/> is not a valid <see cref="StringComparison"/>.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="startString"/> or the original instance (<paramref name="str"/>) are null.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="startString"/> is not found in the original instance or <paramref name="length"/> is less than zero or the index of <paramref name="startString"/> plus "length" indicates
    /// a position not within this instance.
    /// </exception>
    [Pure]
    public static string SubstringEndLast(this string str, string startString, int length, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)
    {
        Validate.OriginalInstanceNotNull(str);
        Validate.NotNull(startString);
        Validate.LengthIsPositive(length);
        Validate.EnumContainsValue<StringComparison>(comparison);
        Validate.SubstringLastIndex(str, startString, out int startStringIndex, comparison);

        int availableLength = str.Length - startStringIndex - startString.Length;
        Validate.LengthIsWithinBounds(availableLength, length);

        startStringIndex = AddSubstringLengthConditional(startStringIndex, startString, inclusive);
        int offsetlength = AddSubstringLengthConditional(length, startString, !inclusive);

        return str.Substring(startStringIndex, offsetlength);
    }

    /// <summary>
    /// Adds the length of <paramref name="substring"/> to the given <paramref name="index"/> if <paramref name="doNotOffset"/> is <see langword="false"/>.
    /// </summary>
    /// <remarks>
    /// When <paramref name="index"/> is the index at which <paramref name="substring"/> starts in another string, offsetting <paramref name="index"/>
    /// by <paramref name="substring"/>'s length will actually omit <paramref name="substring"/> in any result which selects everything from the offsetted index onward.
    /// <br/><paramref name="doNotOffset"/>'s parameter name and function were chosen so that the "inclusive" boolean arguments of the various "Substring" methods
    /// can be passed to this method as they are.
    /// </remarks>
    /// <param name="index">Integer, signifying the start of <paramref name="substring"/> in a parent string.</param>
    /// <param name="substring">String that starts at the given <paramref name="index"/> in a parent string.</param>
    /// <param name="doNotOffset">Whether the length of <paramref name="substring"/> should NOT be added to <paramref name="index"/>.</param>
    /// <returns>Integer, signifying the index in a string where the part, significant to the user, starts.</returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="substring"/> is null.
    /// </exception>
    static int AddSubstringLengthConditional(int index, string substring, bool doNotOffset)
        => doNotOffset ? index : index += substring.Length;
}
