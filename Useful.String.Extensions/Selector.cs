using System;
using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

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
            tryArgumentOutOfRangeException(str, startString, nameof(startString));

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
            tryArgumentOutOfRangeException(str, startString, nameof(startString));

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
            tryArgumentOutOfRangeException(str, startString, nameof(startString));

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
            tryArgumentOutOfRangeException(str, endString, nameof(endString));

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
            tryArgumentOutOfRangeException(str, endString, nameof(endString));

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
            tryArgumentOutOfRangeException(str, endString, nameof(endString));

            int startIndex = str.IndexOf(endString) - length;
            int finalLength = length + endString.Length * Convert.ToInt32(!inclusive);

            return str.Substring(startIndex, finalLength);
        }

        /// <summary>
        /// Retrieves a substring from this instance that is located between the specified occurrences of the
        /// given start and end strings.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted.</param>
        /// <param name="endString">The string which marks the end of the substring.</param>
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
            tryArgumentOutOfRangeException(str, startString, nameof(startString));
            tryArgumentOutOfRangeException(str, endString, nameof(endString));
            tryArgumentException(str, startString, endString, nameof(startString), nameof(endString));

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
        /// Retrieves a substring from this instance that is located between the specified occurrences of the
        /// given start and end strings.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted.</param>
        /// <param name="startStringOccurrence">
        /// Which occurrence of "startString" to use to mark the start the substring. Use zero to specify the last occurrence.
        /// An exception will be thrown if the given number is larger than the total occurrences of "startString" in this instance.
        /// </param>
        /// <param name="endString">The string which marks the end of the substring.</param>
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
            tryArgumentOutOfRangeException(str, startString, nameof(startString));
            tryArgumentOutOfRangeException(str, endString, nameof(endString));
            tryArgumentOutOfRangeException(startStringOccurrence, nameof(startStringOccurrence), 0, int.MaxValue);
            tryArgumentOutOfRangeException(endStringOccurrence, nameof(endStringOccurrence), 0, int.MaxValue);
            tryArgumentException(str, startString, endString, nameof(startString), nameof(endString));

            int startStringIndex = 0, endStringIndex = 0;

            if (startStringOccurrence == 0)
                startStringIndex = str.LastIndexOf(startString);
            else if (startStringOccurrence == 1)
                startStringIndex = str.IndexOf(startString);
            else
            {
                CheckOccurrenceNumber(str, startString, nameof(startStringOccurrence), startStringOccurrence);
            }

            if (endStringOccurrence == 0)
                endStringIndex = str.LastIndexOf(endString);
            else if (endStringOccurrence == 1)
                endStringIndex = str.IndexOf(endString);
            else
            {
                CheckOccurrenceNumber(str, endString, nameof(endStringOccurrence), endStringOccurrence);
            }

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
                        
            // Checks if the given occurrence of the substring isn't larger than
            // the total amount of times it occurs in the original string.
            void CheckOccurrenceNumber(string original, string substring, string argumentName, int targetOccurrence)
            {
                string exMessage = "";
                int totalOccurrences = OccurrencesNumber(original, substring);
                if (totalOccurrences < targetOccurrence)
                    throw new ArgumentOutOfRangeException(argumentName, $"The substring '{substring}' does not occur {targetOccurrence} times in '{original}'. It only occurs {totalOccurrences} times.");
            }
        }

        /// <summary>
        /// Returns the number of times the given "substring" occurs in this instance. Case sensetive.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="substring">The string </param>
        /// <returns>The amount of times "substring" can be found in this string.</returns>
        public static int GetOccurrencesNumber(this string str, string substring)
        {
            string[] array = str.Split(substring);
            return array.Length - 1;
        }

        /// <summary>
        /// Returns the number of times the given "substring" occurs in this instance.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="substring">The string </param>
        /// <param name="caseSensetive">Boolean indicating whether the string comparison should be case sensetive.</param>
        /// <returns>The amount of times "substring" can be found in this string.</returns>
        public static int GetOccurrencesNumber(this string str, string substring, bool caseSensetive)
        {
            int occurrences = 0;

            if (caseSensetive)
            {
                occurrences = str.GetOccurrencesNumber(substring);
            }
            else
            {
                string[] array = Regex.Split(str, substring, RegexOptions.IgnoreCase);
                occurrences = array.Length - 1;
            }

            return occurrences;
        }

        /// <summary>
        /// Gets the index of "substring" in "originalString" and throws an <see cref="ArgumentOutOfRangeException"/>
        /// with a specific, descriptive message, if the index is -1.
        /// </summary>
        /// <param name="originalString">The instance which to check for "substring".</param>
        /// <param name="substring">The string to search in "originalString".</param>
        /// <param name="parameterName">The name of the parameter in the original method that is checked for the exception.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when "substring" does not exist within the "originalString" instance.
        /// </exception>
        static void tryArgumentOutOfRangeException(string originalString, string substring, string parameterName)
        {
            if (originalString.IndexOf(substring) == -1)
                throw new ArgumentOutOfRangeException(parameterName, $"The string given for '{parameterName}' was not found in the original string.");
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
                throw new ArgumentOutOfRangeException(parameterName, $"The number given for '{parameterName}' (\"{parameter}\") is less than the minimum allowed value of \"{minValue}\".");

            if (parameter > maxValue)
                throw new ArgumentOutOfRangeException(parameterName, $"The number given for '{parameterName}' (\"{parameter}\") is greater than the maximum allowed value of \"{maxValue}\".");
        }

        /// <summary>
        /// Gets the index of "startString" and "endString" in "originalString" and throws an <see cref="ArgumentException"/>
        /// with a specific, descriptive message, if the index of "endString" is less than that of "startString".
        /// </summary>
        /// <param name="originalString">The instance which to check.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted from "originalString".</param>
        /// <param name="endString">The string which marks the end of the substring to be extracted from "originalString".</param>
        /// <param name="startStringArgumentName">The name of the "startString" argument in the original method.</param>
        /// <param name="endStringArgumentName">The name of the "endString" argument in the original method.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when "endString" occurs before "startString" in the "originalString" instance.
        /// </exception>
        static void tryArgumentException(string originalString, string startString, string endString, string startStringArgumentName, string endStringArgumentName)
        {
            int startStringIndex = originalString.IndexOf(startString);
            int endStringIndex = originalString.IndexOf(endString);

            if (endStringIndex < startStringIndex)
                throw new ArgumentException($"The string given for '{endStringArgumentName}' (\"{endString}\") occurs before the string given for '{startStringArgumentName}' (\"{startString}\") in the original string. " +
                    $"The argument provided for '{endStringArgumentName}' must exist in the original string and occur after the argument provided for '{startStringArgumentName}'.");
        }
    }
}
