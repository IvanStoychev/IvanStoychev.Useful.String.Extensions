using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace IvanStoychev.StringExtensions
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
            tryArgumentOutOfRangeException(str, startString, nameof(startString));

            return str.Substring(startString, false);
        }

        /// <summary>
        /// Retrieves the substring starting from the first instance of
        /// the given string to the end of this instance.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring.</param>
        /// <param name="stringComparison">The <see cref="StringComparison"/> to use when searching for "startString".</param>
        /// <returns>
        /// A string representing the part of the original string, located from
        /// "startString" to the end of the original instance.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "startString" does not exist within this instance.
        /// </exception>
        public static string Substring(this string str, string startString, StringComparison stringComparison)
        {
            tryArgumentOutOfRangeException(str, startString, nameof(startString), stringComparison);

            return str.Substring(startString, false, stringComparison);
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
            tryArgumentOutOfRangeException(str, startString, nameof(startString));

            int startStringIndex = str.IndexOf(startString) + startString.Length * Convert.ToInt32(!inclusive);

            return str.Substring(startStringIndex);
        }

        /// <summary>
        /// Retrieves the substring starting from the first instance of
        /// the given string to the end of this instance.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring.</param>
        /// <param name="inclusive">A boolean indicating whether the substring should include the given "startString".</param>
        /// <param name="stringComparison">The <see cref="StringComparison"/> to use when searching for "startString".</param>
        /// <returns>
        /// A string representing the part of the original string, located from "startString"
        /// to the end of the original instance.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "startString" does not exist within this instance.
        /// </exception>
        public static string Substring(this string str, string startString, bool inclusive, StringComparison stringComparison)
        {
            tryArgumentOutOfRangeException(str, startString, nameof(startString), stringComparison);

            int startStringIndex = str.IndexOf(startString, stringComparison) + startString.Length * Convert.ToInt32(!inclusive);

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
            tryArgumentOutOfRangeException(str, startString, nameof(startString));

            int startIndex = str.IndexOf(startString) + startString.Length * Convert.ToInt32(!inclusive);

            return str.Substring(startIndex, length);
        }

        /// <summary>
        /// Retrieves a substring from this instance. The substring starts at the first
        /// occurrence of the given "startString" and has the specified length.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring.</param>
        /// <param name="length">The number of characters to return.</param>
        /// <param name="inclusive">A boolean indicating whether the substring should include the given "startString".</param>
        /// <param name="stringComparison">The <see cref="StringComparison"/> to use when searching for "startString".</param>
        /// <returns>
        /// A string that is equivalent to the substring of length "length" that begins at
        /// the first instance of "startString" in this string instance.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "startString" plus length indicates a position not within this instance
        /// or length is less than zero or "startString" does not exist within this instance.
        /// </exception>
        public static string Substring(this string str, string startString, int length, bool inclusive, StringComparison stringComparison)
        {
            tryArgumentOutOfRangeException(str, startString, nameof(startString), stringComparison);

            int startIndex = str.IndexOf(startString, stringComparison) + startString.Length * Convert.ToInt32(!inclusive);

            return str.Substring(startIndex, length);
        }

        /// <summary>
        /// Retrieves a substring from this instance that is located between the first occurrences of the
        /// given start and end strings.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted. Case sensetive.</param>
        /// <param name="endString">The string which marks the end of the substring. Case sensetive.</param>
        /// <param name="stringInclusionOptions">
        /// A StringInclusionOptions enum value, indicating whether "startString" and/or
        /// "endString" should be included in the result.
        /// </param>
        /// <returns>
        /// A string representing the part of the original string, located between
        /// the "startString" and "endString".
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "startString" or "endString" do not exist within this instance.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when "endString" occurs before "startString" in the "originalString" instance.
        /// </exception>
        public static string Substring(this string str, string startString, string endString, StringInclusionOptions stringInclusionOptions)
        {
            // Check if substrings exist in instance.
            tryArgumentOutOfRangeException(str, startString, nameof(startString));
            tryArgumentOutOfRangeException(str, endString, nameof(endString));

            // Check if "endString" doesn't occur before "startString".
            tryArgumentException(str, startString, nameof(startString), endString, nameof(endString));

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
        /// Retrieves a substring from this instance that is located between the first occurrences of the
        /// given start and end strings.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted.</param>
        /// <param name="endString">The string which marks the end of the substring.</param>
        /// <param name="stringInclusionOptions">
        /// A StringInclusionOptions enum value, indicating whether "startString" and/or
        /// "endString" should be included in the result.
        /// </param>
        /// <param name="stringComparison">
        /// The <see cref="StringComparison"/> rules to be used when searching
        /// for "startString" and "endString".
        /// </param>
        /// <returns>
        /// A string representing the part of the original string, located between
        /// the "startString" and "endString".
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "startString" or "endString" do not exist within this instance.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when "endString" occurs before "startString" in the "originalString" instance.
        /// </exception>
        public static string Substring(this string str, string startString, string endString, StringInclusionOptions stringInclusionOptions, StringComparison stringComparison)
        {
            // Check if substrings exist in instance.
            tryArgumentOutOfRangeException(str, startString, nameof(startString), stringComparison);
            tryArgumentOutOfRangeException(str, endString, nameof(endString), stringComparison);

            // Check if "endString" doesn't occur before "startString".
            tryArgumentException(str, startString, nameof(startString), endString, nameof(endString), stringComparison);

            int startStringIndex = str.IndexOf(startString, stringComparison);
            int endStringIndex = str.IndexOf(endString, stringComparison);

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
        /// Retrieves a substring from this instance that is located between the first occurrences of the
        /// given start and end strings.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted.</param>
        /// <param name="startStringComparison">The <see cref="StringComparison"/> to use when searching for "startString".</param>
        /// <param name="endString">The string which marks the end of the substring.</param>
        /// <param name="endStringComparison">The <see cref="StringComparison"/> to use when searching for "endString".</param>
        /// <param name="stringInclusionOptions">
        /// A StringInclusionOptions enum value, indicating whether "startString" and/or
        /// "endString" should be included in the result.
        /// </param>
        /// <returns>
        /// A string representing the part of the original string, located between
        /// the "startString" and "endString".
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "startString" or "endString" do not exist within this instance.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when "endString" occurs before "startString" in the "originalString" instance.
        /// </exception>
        public static string Substring(this string str, string startString, StringComparison startStringComparison, string endString, StringComparison endStringComparison, StringInclusionOptions stringInclusionOptions)
        {
            // Check if substrings exist in instance.
            tryArgumentOutOfRangeException(str, startString, nameof(startString), startStringComparison);
            tryArgumentOutOfRangeException(str, endString, nameof(endString), endStringComparison);

            // Check if "endString" doesn't occur before "startString".
            tryArgumentException(str, startString, startStringComparison, nameof(startString), endString, endStringComparison, nameof(endString));

            int startStringIndex = str.IndexOf(startString, startStringComparison);
            int endStringIndex = str.IndexOf(endString, endStringComparison);

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
            tryArgumentOutOfRangeException(str, endString, nameof(endString));

            return str.SubstringEnd(endString, false);
        }

        /// <summary>
        /// Retrieves the substring starting from the start of this instance
        /// to the first instance of the given string.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="endString">The string which marks the end of the substring.</param>
        /// <param name="stringComparison">The <see cref="StringComparison"/> to use when searching for "endString".</param>
        /// <returns>
        /// A string representing the part of the original string located from the start
        /// of the original instance to the first occurrence of "endString".
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "endString" does not exist within this instance.
        /// </exception>
        public static string SubstringEnd(this string str, string endString, StringComparison stringComparison)
        {
            tryArgumentOutOfRangeException(str, endString, nameof(endString), stringComparison);

            return str.SubstringEnd(endString, false, stringComparison);
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
            tryArgumentOutOfRangeException(str, endString, nameof(endString));

            int length = str.IndexOf(endString) + endString.Length * Convert.ToInt32(!inclusive);

            return str.Substring(0, length);
        }

        /// <summary>
        /// Retrieves the substring starting from the start of this instance
        /// to the first instance of the given string.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="endString">The string which marks the end of the substring.</param>
        /// <param name="inclusive">A boolean indicating whether the substring should include the given "endString".</param>
        /// <param name="stringComparison">The <see cref="StringComparison"/> to use when searching for "endString".</param>
        /// <returns>
        /// A string representing the part of the original string located from the start
        /// of the original instance to the first occurrence of "endString".
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "endString" does not exist within this instance.
        /// </exception>
        public static string SubstringEnd(this string str, string endString, bool inclusive, StringComparison stringComparison)
        {
            tryArgumentOutOfRangeException(str, endString, nameof(endString), stringComparison);

            int length = str.IndexOf(endString, stringComparison) + endString.Length * Convert.ToInt32(!inclusive);

            return str.Substring(0, length);
        }

        /// <summary>
        /// Retrieves a substring of the given length that ends at
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
            tryArgumentOutOfRangeException(str, endString, nameof(endString));

            int startIndex = str.IndexOf(endString) - length;
            int resultLength = length + endString.Length * Convert.ToInt32(!inclusive);

            return str.Substring(startIndex, resultLength);
        }

        /// <summary>
        /// Retrieves a substring of the given length that ends at
        /// the first instance of "endString" in this string instance.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="endString">The string which marks the end of the substring.</param>
        /// <param name="length">The length of the substring to return.</param>
        /// <param name="inclusive">A boolean indicating whether the substring should include the given "endString".</param>
        /// <param name="stringComparison">The <see cref="StringComparison"/> to use when searching for "endString".</param>
        /// <returns>
        /// A string that is equivalent to the substring of length "length" that ends at
        /// the first instance of "endString" in this string instance.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "endString" plus length indicates a position not within this instance
        /// or length is less than zero or "endString" does not exist within this instance.
        /// </exception>
        public static string SubstringEnd(this string str, string endString, int length, bool inclusive, StringComparison stringComparison)
        {
            tryArgumentOutOfRangeException(str, endString, nameof(endString), stringComparison);

            int startIndex = str.IndexOf(endString, stringComparison) - length;
            int resultLength = length + endString.Length * Convert.ToInt32(!inclusive);

            return str.Substring(startIndex, resultLength);
        }

        /// <summary>
        /// Retrieves a substring from this instance that is located between the last occurrences of the
        /// given start and end strings.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted. Case sensetive.</param>
        /// <param name="endString">The string which marks the end of the substring. Case sensetive.</param>
        /// <param name="stringInclusionOptions">
        /// A StringInclusionOptions enum value, indicating whether "startString" and/or
        /// "endString" should be included in the result.
        /// </param>
        /// <returns>
        /// A string representing the part of the original string, located between
        /// the "startString" and "endString".
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "startString" or "endString" do not exist within this instance.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when "endString" occurs before "startString" in the "originalString" instance.
        /// </exception>
        public static string SubstringEnd(this string str, string startString, string endString, StringInclusionOptions stringInclusionOptions)
        {
            // Check if substrings exist in instance.
            tryArgumentOutOfRangeException(str, startString, nameof(startString));
            tryArgumentOutOfRangeException(str, endString, nameof(endString));

            // Check if "endString" doesn't occur before "startString".
            tryArgumentExceptionEnd(str, startString, nameof(startString), endString, nameof(endString));

            int startStringIndex = str.LastIndexOf(startString);
            int endStringIndex = str.LastIndexOf(endString);

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
        /// Retrieves a substring from this instance that is located between the last occurrences of the
        /// given start and end strings.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted.</param>
        /// <param name="endString">The string which marks the end of the substring.</param>
        /// <param name="stringInclusionOptions">
        /// A StringInclusionOptions enum value, indicating whether "startString" and/or
        /// "endString" should be included in the result.
        /// </param>
        /// <param name="stringComparison">
        /// The <see cref="StringComparison"/> rules to be used when searching
        /// for "startString" and "endString".
        /// </param>
        /// <returns>
        /// A string representing the part of the original string, located between
        /// the "startString" and "endString".
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "startString" or "endString" do not exist within this instance.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when "endString" occurs before "startString" in the "originalString" instance.
        /// </exception>
        public static string SubstringEnd(this string str, string startString, string endString, StringInclusionOptions stringInclusionOptions, StringComparison stringComparison)
        {
            // Check if substrings exist in instance.
            tryArgumentOutOfRangeException(str, startString, nameof(startString), stringComparison);
            tryArgumentOutOfRangeException(str, endString, nameof(endString), stringComparison);

            // Check if "endString" doesn't occur before "startString".
            tryArgumentExceptionEnd(str, startString, nameof(startString), endString, nameof(endString), stringComparison);

            int startStringIndex = str.LastIndexOf(startString, stringComparison);
            int endStringIndex = str.LastIndexOf(endString, stringComparison);

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
        /// Retrieves a substring from this instance that is located between the last occurrences of the
        /// given start and end strings.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted.</param>
        /// <param name="startStringComparison">The <see cref="StringComparison"/> to use when searching for "startString".</param>
        /// <param name="endString">The string which marks the end of the substring.</param>
        /// <param name="endStringComparison">The <see cref="StringComparison"/> to use when searching for "endString".</param>
        /// <param name="stringInclusionOptions">
        /// A StringInclusionOptions enum value, indicating whether "startString" and/or
        /// "endString" should be included in the result.
        /// </param>
        /// <returns>
        /// A string representing the part of the original string, located between
        /// the "startString" and "endString".
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "startString" or "endString" do not exist within this instance.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when "endString" occurs before "startString" in the "originalString" instance.
        /// </exception>
        public static string SubstringEnd(this string str, string startString, StringComparison startStringComparison, string endString, StringComparison endStringComparison, StringInclusionOptions stringInclusionOptions)
        {
            // Check if substrings exist in instance.
            tryArgumentOutOfRangeException(str, startString, nameof(startString), startStringComparison);
            tryArgumentOutOfRangeException(str, endString, nameof(endString), endStringComparison);

            // Check if "endString" doesn't occur before "startString".
            tryArgumentExceptionEnd(str, startString, startStringComparison, nameof(startString), endString, endStringComparison, nameof(endString));

            int startStringIndex = str.LastIndexOf(startString, startStringComparison);
            int endStringIndex = str.LastIndexOf(endString, endStringComparison);

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
        /// Retrieves a substring from this instance that is located between the specified occurrences of the
        /// given start and end strings.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted. Case sensetive.</param>
        /// <param name="startStringOccurrence">
        /// Which occurrence of "startString" to use to mark the start the substring. Use zero to specify the last occurrence.
        /// An exception will be thrown if the given number is larger than the total occurrences of "startString" in this instance.
        /// </param>
        /// <param name="endString">The string which marks the end of the substring. Case sensetive.</param>
        /// <param name="endStringOccurrence">
        /// Which occurrence of "endString" to use to mark the end of the substring. Use zero to specify the last occurrence.
        /// An exception will be thrown if the given number is larger than the total occurrences of "endString" in this instance.
        /// </param>
        /// <param name="stringInclusionOptions">
        /// A StringInclusionOptions enum value, indicating whether "startString" and/or
        /// "endString" should be included in the result.
        /// </param>
        /// <returns>
        /// A string representing the part of the original string, located between
        /// the "startString" and "endString".
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "startString" or "endString" do not exist within this instance. 
        /// - or - 
        /// "startString" does not occur "startStringOccurrence" times or "endString" does not occur "endStringOccurrence"
        /// times in the original instance.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when "endString" occurs before "startString" in the "originalString" instance.
        /// </exception>
        public static string Substring(this string str, string startString, int startStringOccurrence, string endString, int endStringOccurrence, StringInclusionOptions stringInclusionOptions)
        {
            // Check if substrings exist in instance.
            tryArgumentOutOfRangeException(str, startString, nameof(startString));
            tryArgumentOutOfRangeException(str, endString, nameof(endString));

            // Get total number of substring occurrences in instance and check if "startStringOccurrence" and "endStringOccurrence" are in range.
            List<int> startStringIndexesList = GetAllOccurrencesList(str, startString);
            List<int> endStringIndexesList = GetAllOccurrencesList(str, endString);
            int startStringTotalOccurrences = startStringIndexesList.Count;
            int endStringTotalOccurrences = endStringIndexesList.Count;
            tryArgumentOutOfRangeException(startStringOccurrence, nameof(startStringOccurrence), 0, startStringTotalOccurrences);
            tryArgumentOutOfRangeException(endStringOccurrence, nameof(endStringOccurrence), 0, endStringTotalOccurrences);

            int startStringIndex = startStringIndexesList[startStringOccurrence];
            int endStringIndex = endStringIndexesList[endStringOccurrence];

            // Check if the index of the desired occurrence of "endString" isn't before the
            // index of the desired occurrence of "startString".
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
        /// Retrieves a substring from this instance that is located between the specified occurrences of the
        /// given start and end strings.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted. Case sensetive.</param>
        /// <param name="startStringOccurrence">
        /// Which occurrence of "startString" to use to mark the start the substring. Use zero to specify the last occurrence.
        /// An exception will be thrown if the given number is larger than the total occurrences of "startString" in this instance.
        /// </param>
        /// <param name="endString">The string which marks the end of the substring. Case sensetive.</param>
        /// <param name="endStringOccurrence">
        /// Which occurrence of "endString" to use to mark the end of the substring. Use zero to specify the last occurrence.
        /// An exception will be thrown if the given number is larger than the total occurrences of "endString" in this instance.
        /// </param>
        /// <param name="stringInclusionOptions">
        /// A StringInclusionOptions enum value, indicating whether "startString" and/or
        /// "endString" should be included in the result.
        /// </param>
        /// <param name="stringComparison">
        /// The <see cref="StringComparison"/> rules to be used when searching
        /// for "startString" and "endString".
        /// </param>
        /// <returns>
        /// A string representing the part of the original string, located between
        /// the "startString" and "endString".
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "startString" or "endString" do not exist within this instance. 
        /// - or - 
        /// "startString" does not occur "startStringOccurrence" times or "endString" does not occur "endStringOccurrence"
        /// times in the original instance.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when "endString" occurs before "startString" in the "originalString" instance.
        /// </exception>
        public static string Substring(this string str, string startString, int startStringOccurrence, string endString, int endStringOccurrence, StringInclusionOptions stringInclusionOptions, StringComparison stringComparison)
        {
            // Check if substrings exist in instance.
            tryArgumentOutOfRangeException(str, startString, nameof(startString), stringComparison);
            tryArgumentOutOfRangeException(str, endString, nameof(endString), stringComparison);

            // Get total number of substring occurrences in instance and check if "startStringOccurrence" and "endStringOccurrence" are in range.
            List<int> startStringIndexesList = GetAllOccurrencesList(str, startString, stringComparison);
            List<int> endStringIndexesList = GetAllOccurrencesList(str, endString, stringComparison);
            int startStringTotalOccurrences = startStringIndexesList.Count;
            int endStringTotalOccurrences = endStringIndexesList.Count;
            tryArgumentOutOfRangeException(startStringOccurrence, nameof(startStringOccurrence), 0, startStringTotalOccurrences);
            tryArgumentOutOfRangeException(endStringOccurrence, nameof(endStringOccurrence), 0, endStringTotalOccurrences);

            int startStringIndex = startStringIndexesList[startStringOccurrence];
            int endStringIndex = endStringIndexesList[endStringOccurrence];

            // Check if the index of the desired occurrence of "endString" isn't before the
            // index of the desired occurrence of "startString".
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
        /// Retrieves a substring from this instance that is located between the specified occurrences of the
        /// given start and end strings.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted. Case sensetive.</param>
        /// <param name="startStringComparison">The <see cref="StringComparison"/> to use when searching for "startString".</param>
        /// <param name="startStringOccurrence">
        /// Which occurrence of "startString" to use to mark the start the substring. Use zero to specify the last occurrence.
        /// An exception will be thrown if the given number is larger than the total occurrences of "startString" in this instance.
        /// </param>
        /// <param name="endString">The string which marks the end of the substring. Case sensetive.</param>
        /// <param name="endStringComparison">The <see cref="StringComparison"/> to use when searching for "endString".</param>
        /// <param name="endStringOccurrence">
        /// Which occurrence of "endString" to use to mark the end of the substring. Use zero to specify the last occurrence.
        /// An exception will be thrown if the given number is larger than the total occurrences of "endString" in this instance.
        /// </param>
        /// <param name="stringInclusionOptions">
        /// A StringInclusionOptions enum value, indicating whether "startString" and/or
        /// "endString" should be included in the result.
        /// </param>
        /// <returns>
        /// A string representing the part of the original string, located between
        /// the "startString" and "endString".
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "startString" or "endString" do not exist within this instance. 
        /// - or - 
        /// "startString" does not occur "startStringOccurrence" times or "endString" does not occur "endStringOccurrence"
        /// times in the original instance.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when "endString" occurs before "startString" in the "originalString" instance.
        /// </exception>
        public static string Substring(this string str, string startString, StringComparison startStringComparison, int startStringOccurrence, string endString, StringComparison endStringComparison, int endStringOccurrence, StringInclusionOptions stringInclusionOptions)
        {
            // Check if substrings exist in instance.
            tryArgumentOutOfRangeException(str, startString, nameof(startString), startStringComparison);
            tryArgumentOutOfRangeException(str, endString, nameof(endString), endStringComparison);

            // Get total number of substring occurrences in instance and check if "startStringOccurrence" and "endStringOccurrence" are in range.
            List<int> startStringIndexesList = GetAllOccurrencesList(str, startString, startStringComparison);
            List<int> endStringIndexesList = GetAllOccurrencesList(str, endString, endStringComparison);
            int startStringTotalOccurrences = startStringIndexesList.Count;
            int endStringTotalOccurrences = endStringIndexesList.Count;
            tryArgumentOutOfRangeException(startStringOccurrence, nameof(startStringOccurrence), 0, startStringTotalOccurrences);
            tryArgumentOutOfRangeException(endStringOccurrence, nameof(endStringOccurrence), 0, endStringTotalOccurrences);

            int startStringIndex = startStringIndexesList[startStringOccurrence];
            int endStringIndex = endStringIndexesList[endStringOccurrence];

            // Check if the index of the desired occurrence of "endString" isn't before the
            // index of the desired occurrence of "startString".
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
        /// Returns a list of the indexes of all occurrences of the given substring in the original string.
        /// </summary>
        /// <param name="originalString">The string in which to search.</param>
        /// <param name="substring">String to look for.</param>
        /// <returns>A List&lt;int&gt; of all indexes of "substring" in the original string.</returns>
        static List<int> GetAllOccurrencesList(string originalString, string substring, StringComparison stringComparison = StringComparison.CurrentCulture)
        {
            List<int> indexes = new List<int>();
            for (int index = 0; ; index += substring.Length)
            {
                index = originalString.IndexOf(substring, index, stringComparison);
                if (index == -1) break;
                indexes.Add(index);
            }

            return indexes;
        }

        /// <summary>
        /// Gets the index of "substring" in "originalString" and throws an <see cref="ArgumentOutOfRangeException"/>
        /// with a specific, descriptive message, if the index is -1.
        /// </summary>
        /// <param name="originalString">The instance which to check for "substring".</param>
        /// <param name="substring">The string to search in "originalString".</param>
        /// <param name="parameterName">The name of the parameter in the original method that is checked for the exception.</param>
        /// <param name="stringComparison">The <see cref="StringComparison"/> rules to be used when searching for "substring".</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "substring" does not exist within the "originalString" instance.
        /// </exception>
        static void tryArgumentOutOfRangeException(string originalString, string substring, string parameterName, StringComparison stringComparison = StringComparison.CurrentCulture)
        {
            if (originalString.IndexOf(substring, stringComparison) == -1)
                throw new ArgumentOutOfRangeException(parameterName, substring, $"The string given for '{parameterName}' (\"{substring}\") was not found in the original string.");
        }

        /// <summary>
        /// Checks whether the given parameter is within the min and max values and throws an <see cref="ArgumentOutOfRangeException"/>
        /// if it isn't.
        /// </summary>
        /// <param name="parameter">The parameter to check if it conforms to the given boundaries.</param>
        /// <param name="parameterName">The name of the parameter in the original method that is checked for the exception.</param>
        /// <param name="minValue">The minimum allowed value for "parameter".</param>
        /// <param name="maxValue">The maximum allowed value for "parameter".</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "parameter" is less than "minValue" or more than "maxValue".
        /// </exception>
        static void tryArgumentOutOfRangeException(int parameter, string parameterName, int minValue, int maxValue)
        {
            if (parameter < minValue)
                throw new ArgumentOutOfRangeException(parameterName, parameter, $"The number given for '{parameterName}' (\"{parameter}\") is less than the minimum allowed value of \"{minValue}\".");

            if (parameter > maxValue)
                throw new ArgumentOutOfRangeException(parameterName, parameter, $"The number given for '{parameterName}' (\"{parameter}\") is greater than its total number of occurrences (\"{maxValue}\") in the original string.");
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

        /// <summary>
        /// Gets the index of "startString" and "endString" in "originalString" and throws an <see cref="ArgumentException"/>
        /// with a specific, descriptive message, if the index of "endString" is less than that of "startString".
        /// </summary>
        /// <param name="originalString">The instance which to check.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted from "originalString".</param>
        /// <param name="endString">The string which marks the end of the substring to be extracted from "originalString".</param>
        /// <param name="startStringArgumentName">The name of the "startString" parameter in the calling method.</param>
        /// <param name="endStringArgumentName">The name of the "endString" parameter in the calling method.</param>
        /// <param name="stringComparison">The <see cref="StringComparison"/> rules to be used when searching for "startString" and "endString".</param>
        /// <exception cref="ArgumentException">
        /// Thrown when "endString" occurs before "startString" in the "originalString" instance.
        /// </exception>
        static void tryArgumentException(string originalString, string startString, string startStringArgumentName, string endString, string endStringArgumentName, StringComparison stringComparison = StringComparison.CurrentCulture)
        {
            int startStringIndex = originalString.IndexOf(startString, stringComparison);
            int endStringIndex = originalString.IndexOf(endString, stringComparison);

            if (endStringIndex < startStringIndex)
                throw new ArgumentException($"The string given for '{endStringArgumentName}' (\"{endString}\") occurs before the string given for '{startStringArgumentName}' (\"{startString}\") in the original string." +
                    Environment.NewLine + $"The argument provided for '{endStringArgumentName}' must exist in the original string and occur after the argument provided for '{startStringArgumentName}'.");
        }

        /// <summary>
        /// Gets the index of "startString" and "endString" in "originalString" and throws an <see cref="ArgumentException"/>
        /// with a specific, descriptive message, if the index of "endString" is less than that of "startString".
        /// </summary>
        /// <param name="originalString">The instance which to check.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted from "originalString".</param>
        /// <param name="startStringComparison">The <see cref="StringComparison"/> to use when searching for "startString".</param>
        /// <param name="endString">The string which marks the end of the substring to be extracted from "originalString".</param>
        /// <param name="endStringComparison">The <see cref="StringComparison"/> to use when searching for "endString".</param>
        /// <param name="startStringArgumentName">The name of the "startString" parameter in the calling method.</param>
        /// <param name="endStringArgumentName">The name of the "endString" parameter in the calling method.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when "endString" occurs before "startString" in the "originalString" instance.
        /// </exception>
        static void tryArgumentException(string originalString, string startString, StringComparison startStringComparison, string startStringArgumentName, string endString, StringComparison endStringComparison, string endStringArgumentName)
        {
            int startStringIndex = originalString.IndexOf(startString, startStringComparison);
            int endStringIndex = originalString.IndexOf(endString, endStringComparison);

            if (endStringIndex < startStringIndex)
                throw new ArgumentException($"The string given for '{endStringArgumentName}' (\"{endString}\") occurs before the string given for '{startStringArgumentName}' (\"{startString}\") in the original string." +
                    Environment.NewLine + $"The argument provided for '{endStringArgumentName}' must exist in the original string and occur after the argument provided for '{startStringArgumentName}'.");
        }

        /// <summary>
        /// Gets the index of "startString" and "endString" in "originalString" and throws an <see cref="ArgumentException"/>
        /// with a specific, descriptive message, if the index of "endString" is less than that of "startString".
        /// </summary>
        /// <param name="originalString">The instance which to check.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted from "originalString".</param>
        /// <param name="endString">The string which marks the end of the substring to be extracted from "originalString".</param>
        /// <param name="startStringArgumentName">The name of the "startString" argument in the calling method.</param>
        /// <param name="endStringArgumentName">The name of the "endString" argument in the calling method.</param>
        /// <param name="stringComparison">The <see cref="StringComparison"/> rules to be used when searching for "startString" and "endString".</param>
        /// <exception cref="ArgumentException">
        /// Thrown when "endString" occurs before "startString" in the "originalString" instance.
        /// </exception>
        static void tryArgumentExceptionEnd(string originalString, string startString, string startStringArgumentName, string endString, string endStringArgumentName, StringComparison stringComparison = StringComparison.CurrentCulture)
        {
            int startStringIndex = originalString.LastIndexOf(startString, stringComparison);
            int endStringIndex = originalString.LastIndexOf(endString, stringComparison);

            if (endStringIndex < startStringIndex)
                throw new ArgumentException($"The string given for '{endStringArgumentName}' (\"{endString}\") occurs before the string given for '{startStringArgumentName}' (\"{startString}\") in the original string." +
                    Environment.NewLine + $"The argument provided for '{endStringArgumentName}' must exist in the original string and occur after the argument provided for '{startStringArgumentName}'.");
        }

        /// <summary>
        /// Gets the index of "startString" and "endString" in "originalString" and throws an <see cref="ArgumentException"/>
        /// with a specific, descriptive message, if the index of "endString" is less than that of "startString".
        /// </summary>
        /// <param name="originalString">The instance which to check.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted from "originalString".</param>
        /// <param name="startStringComparison">The <see cref="StringComparison"/> to use when searching for "startString".</param>
        /// <param name="endString">The string which marks the end of the substring to be extracted from "originalString".</param>
        /// <param name="endStringComparison">The <see cref="StringComparison"/> to use when searching for "endString".</param>
        /// <param name="startStringArgumentName">The name of the "startString" parameter in the calling method.</param>
        /// <param name="endStringArgumentName">The name of the "endString" parameter in the calling method.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when "endString" occurs before "startString" in the "originalString" instance.
        /// </exception>
        static void tryArgumentExceptionEnd(string originalString, string startString, StringComparison startStringComparison, string startStringArgumentName, string endString, StringComparison endStringComparison, string endStringArgumentName)
        {
            int startStringIndex = originalString.LastIndexOf(startString, startStringComparison);
            int endStringIndex = originalString.LastIndexOf(endString, endStringComparison);

            if (endStringIndex < startStringIndex)
                throw new ArgumentException($"The string given for '{endStringArgumentName}' (\"{endString}\") occurs before the string given for '{startStringArgumentName}' (\"{startString}\") in the original string." +
                    Environment.NewLine + $"The argument provided for '{endStringArgumentName}' must exist in the original string and occur after the argument provided for '{startStringArgumentName}'.");
        }
    }
}
