using System;
using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace IvanStoychev.Useful.String.Extensions;

public static partial class StringExtensions
{
    /// <summary>
    /// Uses a regular expression to return a new string containing all occurrences of all unicode digits (in any script) in the current instance.
    /// </summary>
    /// <returns>
    /// A string containing all occurrences of all unicode digits (in any script) in the current instance.
    /// </returns>
    /// <exception cref="RegexMatchTimeoutException">
    /// Thrown if the execution time of the replacement operation exceeds the time-out interval specified for the application domain in which the method is called.
    /// If no time-out is defined in the application domain's properties, or if the time-out value is "Regex.InfiniteMatchTimeout", no exception is thrown.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// The original instance (<paramref name="str"/>) is null.
    /// </exception>
    [Pure]
    public static string KeepOnlyNumbers(this string str)
    {
        Validate.OriginalInstanceNotNull(str);

        return Regex.Replace(str, @"[^\d]", string.Empty);
    }

    /// <summary>
    /// Returns a new string containing all occurrences of all special characters in the current instance.
    /// </summary>
    /// <returns>
    /// A string containing all occurrences of all special characters in the current instance.
    /// </returns>
    /// <remarks>
    /// Whitespace is considered a special character.
    /// </remarks>
    /// <exception cref="ArgumentNullException">
    /// The original instance (<paramref name="str"/>) is null.
    /// </exception>
    [Pure]
    public static string KeepOnlySpecialCharacters(this string str)
    {
        Validate.OriginalInstanceNotNull(str);

        return Regex.Replace(str, @"[0-9a-zA-Z]", string.Empty);
    }

    /// <summary>
    /// Uses a regular expression to return a new string containing all occurrences of all latin letters in the current instance.
    /// </summary>
    /// <returns>
    /// A string containing all occurrences of all latin letters in the current instance.
    /// </returns>
    /// <exception cref="RegexMatchTimeoutException">
    /// Thrown if the execution time of the replacement operation exceeds the time-out interval specified for the application domain in which the method is called.
    /// If no time-out is defined in the application domain's properties, or if the time-out value is "Regex.InfiniteMatchTimeout", no exception is thrown.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// The original instance (<paramref name="str"/>) is null.
    /// </exception>
    [Pure]
    public static string KeepOnlyLetters(this string str)
    {
        Validate.OriginalInstanceNotNull(str);

        return Regex.Replace(str, @"[^a-zA-Z]", string.Empty);
    }
}
