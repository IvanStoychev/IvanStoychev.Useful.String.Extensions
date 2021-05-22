using System;
using System.Diagnostics.Contracts;

namespace IvanStoychev.StringExtensions
{
    /// <summary>
    /// Contains methods that select substrings and charaters from strings.
    /// </summary>
    public static class Selector
    {
        /// <summary>
        /// Retrieves the substring from the start of this instance to the first occurrence of the given <paramref name="endString"/>.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="endString">The string which marks the end of the substring.</param>
        /// <param name="inclusive">A boolean indicating whether the substring should include the given <paramref name="endString"/>.</param>
        /// <param name="stringComparison">The comparison rules to use when looking for the strings.</param>
        /// <returns>
        /// A string representing the part of the original string, located from the start of the original instance to the first occurrence of <paramref name="endString"/>.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="endString"/> is not found in the original instance.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="endString"/> is null.
        /// </exception>
        [Pure]
        public static string SubstringStart(this string str, string endString, bool inclusive = false, StringComparison stringComparison = StringComparison.CurrentCulture)
        {
            tryArgumentOutOfRangeException(str, endString, nameof(endString), stringComparison);

            int endStringIndex = str.IndexOf(endString, stringComparison);
            endStringIndex = OffsetIndexBySubstringLength(endStringIndex, endString, inclusive);

            return str.Substring(0, endStringIndex);
        }

        /// <summary>
        /// Retrieves the substring starting from the first occurrence of the given <paramref name="startString"/> to the end of this instance.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring.</param>
        /// <param name="inclusive">A boolean indicating whether the substring should include the given <paramref name="startString"/>.</param>
        /// <param name="stringComparison">The comparison rules to use when looking for the strings.</param>
        /// <returns>A string representing the part of the original string, located from <paramref name="startString"/> to the end of the original instance.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="startString"/> is not found in the original instance.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="startString"/> is null.
        /// </exception>
        [Pure]
        public static string Substring(this string str, string startString, bool inclusive = false, StringComparison stringComparison = StringComparison.CurrentCulture)
        {
            tryArgumentOutOfRangeException(str, startString, nameof(startString), stringComparison);

            int startStringIndex = str.IndexOf(startString, stringComparison);
            startStringIndex = OffsetIndexBySubstringLength(startStringIndex, startString, inclusive);

            return str.Substring(startStringIndex);
        }

        /// <summary>
        /// Retrieves a substring from this instance. The substring starts at the first occurrence of the given <paramref name="startString"/> and has the specified length.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring.</param>
        /// <param name="length">The number of characters to return.</param>
        /// <param name="inclusive">A boolean indicating whether the substring should include the given <paramref name="startString"/>.</param>
        /// <param name="stringComparison">The comparison rules to use when looking for the strings.</param>
        /// <returns>
        /// A string that is equivalent to the substring of length <paramref name="length"/> that begins at
        /// the first instance of <paramref name="startString"/> in this string instance.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="startString"/> is not found in the original instance or <paramref name="length"/> is less than zero or the index of <paramref name="startString"/> plus "length" indicates
        /// a position not within this instance.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="startString"/> is null.
        /// </exception>
        [Pure]
        public static string Substring(this string str, string startString, int length, bool inclusive = false, StringComparison stringComparison = StringComparison.CurrentCulture)
        {
            tryArgumentOutOfRangeException(str, startString, nameof(startString), stringComparison);

            int startStringIndex = str.IndexOf(startString, stringComparison);
            startStringIndex = OffsetIndexBySubstringLength(startStringIndex, startString, inclusive);

            return str.Substring(startStringIndex, length);
        }

        /// <summary>
        /// Locates he first occurrence of <paramref name="startString"/>, in the original instance, and returns the string situated between it and the first occurrence
        /// of <paramref name="endString"/>, located after <paramref name="startString"/>. Whether <paramref name="startString"/> and/or <paramref name="endString"/>,
        /// themselves, are returned is controlled by the <paramref name="stringInclusionOptions"/> argument.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted.</param>
        /// <param name="endString">The string which marks the end of the substring.</param>
        /// <param name="stringInclusionOptions">A StringInclusionOptions enum, indicating whether <paramref name="startString"/> and/or <paramref name="endString"/> should be included in the result.</param>
        /// <param name="stringComparison">The comparison rules to use when looking for the strings.</param>
        /// <returns>
        /// A string representing the part of the original instance, located between <paramref name="startString"/> and <paramref name="endString"/>.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="startString"/> or <paramref name="endString"/> are not found in the original instance.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="startString"/> or <paramref name="endString"/> are null.
        /// </exception>
        [Pure]
        public static string Substring(this string str, string startString, string endString, StringInclusionOptions stringInclusionOptions, StringComparison stringComparison = StringComparison.CurrentCulture)
        {
            tryArgumentOutOfRangeException(str, startString, nameof(startString), stringComparison);

            int startStringIndex = str.IndexOf(startString, stringComparison);
            string substringStartStringOnwards = str.Substring(startStringIndex + startString.Length);
            tryArgumentOutOfRangeExceptionEndString(substringStartStringOnwards, startString, endString, stringComparison);

            int endStringIndex = str.IndexOf(endString, startStringIndex + startString.Length, stringComparison);


            switch (stringInclusionOptions)
            {
                case StringInclusionOptions.IncludeNone:
                    startStringIndex += startString.Length;
                    break;
                case StringInclusionOptions.IncludeEnd:
                    startStringIndex += startString.Length;
                    endStringIndex += endString.Length;
                    break;
                case StringInclusionOptions.IncludeAll:
                    endStringIndex += endString.Length;
                    break;
            }

            int selectLength = endStringIndex - startStringIndex;

            return str.Substring(startStringIndex, selectLength);
        }

        /// <summary>
        /// Retrieves the substring starting from the last occurrence of the given string to the end of this instance.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring.</param>
        /// <param name="inclusive">A boolean indicating whether the substring should include the given <paramref name="startString"/>.</param>
        /// <param name="stringComparison">The comparison rules to use when looking for the strings.</param>
        /// <returns>A string representing the part of the original string, located from <paramref name="startString"/> to the end of the original instance.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="startString"/> is not found in the original instance.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="startString"/> is null.
        /// </exception>
        [Pure]
        public static string SubstringEnd(this string str, string startString, bool inclusive = false, StringComparison stringComparison = StringComparison.CurrentCulture)
        {
            tryArgumentOutOfRangeException(str, startString, nameof(startString), stringComparison);

            int startStringIndex = str.LastIndexOf(startString, stringComparison);
            startStringIndex = OffsetIndexBySubstringLength(startStringIndex, startString, inclusive);

            return str.Substring(startStringIndex);
        }

        /// <summary>
        /// Retrieves a substring from this instance. The substring starts at the last occurrence of the given <paramref name="startString"/> and has the specified <paramref name="length"/>.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring.</param>
        /// <param name="length">The number of characters to return.</param>
        /// <param name="inclusive">A boolean indicating whether the substring should include the given <paramref name="startString"/>.</param>
        /// <param name="stringComparison">The comparison rules to use when looking for the strings.</param>
        /// <returns>
        /// A string that is equivalent to the substring of length <paramref name="length"/> that begins at
        /// the first instance of <paramref name="startString"/> in this string instance.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="startString"/> is not found in the original instance or <paramref name="length"/> is less than zero or the index of <paramref name="startString"/> plus "length" indicates
        /// a position not within this instance.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="startString"/> is null.
        /// </exception>
        [Pure]
        public static string SubstringEnd(this string str, string startString, int length, bool inclusive = false, StringComparison stringComparison = StringComparison.CurrentCulture)
        {
            tryArgumentOutOfRangeException(str, startString, nameof(startString), stringComparison);

            int startStringIndex = str.LastIndexOf(startString, stringComparison);
            startStringIndex = OffsetIndexBySubstringLength(startStringIndex, startString, inclusive);

            return str.Substring(startStringIndex, length);
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
        static int OffsetIndexBySubstringLength(int index, string substring, bool doNotOffset) =>
            doNotOffset ? index : index += substring.Length;

        /// <summary>
        /// Gets the index of <paramref name="substring"/> in <paramref name="originalString"/> and, if the index is -1, throws an
        /// <see cref="ArgumentOutOfRangeException"/> that informs the user the value "<paramref name="substring"/>" of
        /// argument <paramref name="parameterName"/> is not found in said string. If the value of <paramref name="substring"/> is longer
        /// than 10 characters, the exception display value will be truncated to 10.
        /// </summary>
        /// <param name="originalString">The instance which to check for "substring".</param>
        /// <param name="substring">The string to search in "originalString".</param>
        /// <param name="parameterName">
        /// The name of the parameter in the original method that is supposed to cause the exception.
        /// </param>
        /// <param name="stringComparison">The comparison rules to use when looking for the strings.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// "substring" is not found in "originalString".
        /// </exception>
        static void tryArgumentOutOfRangeException(string originalString, string substring, string parameterName, StringComparison stringComparison = StringComparison.CurrentCulture)
        {
            if (originalString.IndexOf(substring, stringComparison) == -1)
            {
                if (substring.Length > 10) substring = substring.Substring(0, 10) + "...";
                throw new ArgumentOutOfRangeException($"{parameterName}", $"The string given for '{parameterName}' (\"{substring}\") was not found in the original instance.");
            }
        }

        /// <summary>
        /// Gets the index of <paramref name="endString"/> in <paramref name="substringStartStringOnwards"/> and, if the index is -1, throws an
        /// <see cref="ArgumentOutOfRangeException"/> that informs the user the value of <paramref name="endString"/> was not found after <paramref name="startString"/>
        /// in said string. If the value of either <paramref name="startString"/> or <paramref name="endString"/> is longer than 10 characters,
        /// the exception display value will be truncated to 10.
        /// </summary>
        /// <param name="substringStartStringOnwards">The part of the original instance after <paramref name="startString"/>.</param>
        /// <param name="startString">The value used for the start of the substring in the calling method.</param>
        /// <param name="endString">The string to search in <paramref name="substringStartStringOnwards"/>.</param>
        /// <param name="stringComparison">The comparison rules to use when looking for the strings.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="endString"/> is not found in <paramref name="substringStartStringOnwards"/>.
        /// </exception>
        static void tryArgumentOutOfRangeExceptionEndString(string substringStartStringOnwards, string startString, string endString, StringComparison stringComparison = StringComparison.CurrentCulture)
        {
            if (substringStartStringOnwards.IndexOf(endString, stringComparison) == -1)
            {
                if (endString.Length > 10) endString = endString.Substring(0, 10) + "...";
                if (startString.Length > 10) startString = startString.Substring(0, 10) + "...";
                throw new ArgumentOutOfRangeException($"endString", $"The string given for 'endString' (\"{endString}\") was not found after the given 'startString' (\"{startString}\") in the original instance.");
            }
        }
    }
}
