using System;

namespace Useful.String.Extensions
{
    /// <summary>
    /// Contains methods that select substrings and charaters from strings.
    /// </summary>
    public static class Selector
    {
        /// <summary>
        /// Retrieves the substring starting from the first instance of
        /// the given string to the end of this instance.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring.</param>
        /// <returns>
        /// A string representing the part of the original string, located from
        /// "startString" to the end of the original instance.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "startString" does not exist within this instance.
        /// </exception>
        public static string Substring(this string str, string startString)
        {
            tryExeption(str, startString, nameof(startString));

            return str.Substring(startString, false);
        }

        /// <summary>
        /// Retrieves the substring starting from the first instance of
        /// the given string to the end of this instance.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring.</param>
        /// <param name="inclusive">A boolean indicating whether the substring should include the given "startString".</param>
        /// <returns>
        /// A string representing the part of the original string, located from "startString"
        /// to the end of the original instance.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "startString" does not exist within this instance.
        /// </exception>
        public static string Substring(this string str, string startString, bool inclusive)
        {
            tryExeption(str, startString, nameof(startString));

            int startStringIndex = str.IndexOf(startString) + startString.Length * Convert.ToInt32(!inclusive);

            return str.Substring(startStringIndex);
        }

        /// <summary>
        /// Retrieves a substring from this instance. The substring starts at the first
        /// occurrence of the given "startString" and has the specified length.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring.</param>
        /// <param name="length">The number of characters to return.</param>
        /// <param name="inclusive">A boolean indicating whether the substring should include the given "startString".</param>
        /// <returns>
        /// A string that is equivalent to the substring of length "length" that begins at
        /// the first instance of "startString" in this string instance.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "startString" plus length indicates a position not within this instance
        /// or length is less than zero or "startString" does not exist within this instance.
        /// </exception>
        public static string Substring(this string str, string startString, int length, bool inclusive)
        {
            tryExeption(str, startString, nameof(startString));

            int startIndex = str.IndexOf(startString) + startString.Length * Convert.ToInt32(!inclusive);

            return str.Substring(startIndex, length);
        }

        /// <summary>
        /// Retrieves the substring starting from the start of this instance
        /// to the first instance of the given string.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="endString">The string which marks the end of the substring.</param>
        /// <returns>
        /// A string representing the part of the original string located from the start
        /// of the original instance to the first occurrence of "endString".
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "endString" does not exist within this instance.
        /// </exception>
        public static string SubstringEnd(this string str, string endString)
        {
            tryExeption(str, endString, nameof(endString));

            return str.SubstringEnd(endString, false);
        }

        /// <summary>
        /// Retrieves the substring starting from the start of this instance
        /// to the first instance of the given string.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="endString">The string which marks the end of the substring.</param>
        /// <param name="inclusive">A boolean indicating whether the substring should include the given "endString".</param>
        /// <returns>
        /// A string representing the part of the original string located from the start
        /// of the original instance to the first occurrence of "endString".
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "endString" does not exist within this instance.
        /// </exception>
        public static string SubstringEnd(this string str, string endString, bool inclusive)
        {
            tryExeption(str, endString, nameof(endString));

            int length = str.IndexOf(endString) + endString.Length * Convert.ToInt32(!inclusive);

            return str.Substring(0, length);
        }

        /// <summary>
        /// Retrieves a substring of length "length" that ends at
        /// the first instance of "endString" in this string instance.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="endString">The string which marks the end of the substring.</param>
        /// <param name="length">The length of the substring to return.</param>
        /// <param name="inclusive">A boolean indicating whether the substring should include the given "endString".</param>
        /// <returns>
        /// A string that is equivalent to the substring of length "length" that ends at
        /// the first instance of "endString" in this string instance.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "endString" plus length indicates a position not within this instance
        /// or length is less than zero or "endString" does not exist within this instance.
        /// </exception>
        public static string SubstringEnd(this string str, string endString, int length, bool inclusive)
        {
            tryExeption(str, endString, nameof(endString));

            int startIndex = str.IndexOf(endString) - length;
            int finalLength = length + endString.Length * Convert.ToInt32(!inclusive);

            return str.Substring(startIndex, finalLength);
        }

        /// <summary>
        /// Retrieves a substring from this instance that is located between the first
        /// instances of given start and end string.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted.</param>
        /// <param name="endString">The string which marks the end of the substring.</param>
        /// <param name="stringInclusionOptions">
        /// A StringInclusionOptions enum, indicating whether "startString" and/or
        /// "endString" should be included in the result.
        /// </param>
        /// <returns>
        /// A string representing the part of the original string, located between
        /// the "startString" and "endString".
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "startString" or "endString" do not exist within this instance.
        /// </exception>
        public static string Substring(this string str, string startString, string endString, StringInclusionOptions stringInclusionOptions)
        {
            tryExeption(str, startString, nameof(startString));
            tryExeption(str, endString, nameof(endString));

            int startStringIndex = str.IndexOf(startString);
            int endStringIndex = str.IndexOf(endString);

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
        /// Gets the index of "substring" in "originalString" and throws an <see cref="ArgumentOutOfRangeException"/>
        /// with a specific, descriptive message, if the index is -1.
        /// </summary>
        /// <param name="originalString">The instance which to check for "substring".</param>
        /// <param name="substring">The string to search in "originalString".</param>
        /// <param name="argumentName">The name of the argument in the original method that is supposed to cause the exception.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "substring" does not exist within this instance.
        /// </exception>
        static void tryExeption(string originalString, string substring, string argumentName)
        {
            if (originalString.IndexOf(substring) == -1)
                throw new ArgumentOutOfRangeException($"{argumentName}", $"The string given for '{argumentName}' was not found in the original string.");
        }
    }
}
