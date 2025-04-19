using System.Diagnostics.Contracts;
using System.Linq;
using System.Text.RegularExpressions;

namespace IvanStoychev.Useful.String.Extensions;

/// <summary>
/// Contains methods that remove all but a specified set of characters from a string.
/// </summary>
public static partial class UsefulStringExtensions
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
    [Pure]
    public static string KeepOnlyNumbers(this string originalString)
        => Regex.Replace(originalString, @"[^\d]", string.Empty);

    /// <summary>
    /// Returns a new string containing all occurrences of all special characters in the current instance.
    /// </summary>
    /// <returns>
    /// A string containing all occurrences of all special characters in the current instance.
    /// </returns>
    /// <remarks>
    /// Whitespace is considered a special character.
    /// </remarks>
    [Pure]
    public static string KeepOnlySpecialCharacters(this string originalString)
        => Regex.Replace(originalString, @"[0-9a-zA-Z]", string.Empty);

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
    [Pure]
    public static string KeepOnlyLetters(this string originalString)
        => Regex.Replace(originalString, @"[^a-zA-Z]", string.Empty);
}
