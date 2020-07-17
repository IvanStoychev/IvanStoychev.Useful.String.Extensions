using System;

namespace IvanStoychev.StringExtensions
{
    /// <summary>
    /// Contains methods that select substrings and charaters from strings.
    /// </summary>
    public static class Selector
    {
        /// <summary>
        /// Retrieves a substring from this instance that is located between the first
        /// instances of given start and end string.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted.</param>
        /// <param name="endString">The string which marks the end of the substring.</param>
        /// <param name="stringInclusionOptions">A StringInclusionOptions enum, indicating whether startString and/or endString should be included in the result.</param>
        /// <returns>
        /// A string representing the part of the original string, located between the startString and endString.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when either "startString" or "endString" are not found in the original string.
        /// </exception>
        public static string Substring(this string str, string startString, string endString, StringInclusionOptions stringInclusionOptions)
        {
            tryArgumentOutOfRangeException(str, startString, nameof(startString));
            tryArgumentOutOfRangeException(str, endString, nameof(endString));

            int startStringIndex = str.IndexOf(startString);
            int endStringIndex = str.IndexOf(endString);

            tryArgumentException(nameof(startString), startStringIndex, nameof(endString), endStringIndex);

            switch (stringInclusionOptions)
            {
                case StringInclusionOptions.IncludeNone:
                    startStringIndex += startString.Length;
                    break;
                case StringInclusionOptions.IncludeStart:
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
        /// Retrieves the substring starting from the first instance of
        /// the given string to the end of this instance.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring.</param>
        /// <param name="inclusive">A boolean indicating whether the substring should include the given startString.</param>
        /// <returns>A string representing the part of the original string, located from startString to the end of the original instance.</returns>
        public static string Substring(this string str, string startString, bool inclusive)
        {
            tryArgumentOutOfRangeException(str, startString, nameof(startString));

            int startStringIndex = str.IndexOf(startString) + startString.Length * Convert.ToInt32(!inclusive);

            return str.Substring(startStringIndex);
        }

        /// <summary>
        /// Retrieves a substring from this instance. The substring starts at the first
        /// occurrence of the given startString and has the specified length.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring.</param>
        /// <param name="length">The number of characters to return.</param>
        /// <param name="inclusive">A boolean indicating whether the substring should include the given startString.</param>
        /// <returns>
        /// A string that is equivalent to the substring of length "length" that begins at
        /// the first instance of "startString" in this string instance.
        /// </returns>
        public static string Substring(this string str, string startString, int length, bool inclusive)
        {
            tryArgumentOutOfRangeException(str, startString, nameof(startString));

            int startStringIndex = str.IndexOf(startString) + startString.Length * Convert.ToInt32(!inclusive);

            return str.Substring(startStringIndex, length);
        }

        /// <summary>
        /// Gets the index of "substring" in "originalString" and throws an <see cref="ArgumentOutOfRangeException"/>
        /// with a specific, descriptive message, if the index is -1.
        /// </summary>
        /// <param name="originalString">The instance which to check for "substring".</param>
        /// <param name="substring">The string to search in "originalString".</param>
        /// <param name="argumentName">
        /// The name of the argument in the original method that is supposed to cause the exception.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the index of the first occurrence of "substring" in "originalString" is -1.
        /// </exception>
        static void tryArgumentOutOfRangeException(string originalString, string substring, string argumentName)
        {
            if (originalString.IndexOf(substring) == -1)
                throw new ArgumentOutOfRangeException($"{argumentName}", $"The string given for '{argumentName}' was not found in the original string.");
        }

        /// <summary>
        /// Compares "startStringIndex" and "endStringIndex" and throws an <see cref="ArgumentException"/>
        /// with a specific, descriptive message if "endStringIndex" is less than "startStringIndex".
        /// </summary>
        /// <param name="startStringParameterName">The name of the "startString" parameter in the calling method.</param>
        /// <param name="startStringIndex">The index which marks the start of the substring to be extracted in the calling method.</param>
        /// <param name="endStringParameterName">The name of the "endString" parameter in the calling method.</param>
        /// <param name="endStringIndex">The index which marks the end of the substring to be extracted in the calling method.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when "endStringIndex" is less than "startStringIndex".
        /// </exception>
        static void tryArgumentException(string startStringParameterName, int startStringIndex, string endStringParameterName, int endStringIndex)
        {
            if (endStringIndex < startStringIndex)
                throw new ArgumentException($"The string given for '{endStringParameterName}' (\"{endStringIndex}\") occurs before the string given for '{startStringParameterName}' (\"{startStringIndex}\") in the original string." +
                    Environment.NewLine + $"The argument provided for '{endStringParameterName}' must exist in the original string and occur after the argument provided for '{startStringParameterName}'.");
        }
    }
}
