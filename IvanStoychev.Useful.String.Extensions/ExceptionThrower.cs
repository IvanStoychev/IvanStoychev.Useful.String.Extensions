using System;
using System.Runtime.CompilerServices;

namespace IvanStoychev.Useful.String.Extensions
{
    /// <summary>
    /// Handles formatting and throwing of exceptions.
    /// </summary>
    static class ExceptionThrower
    {
        /// <summary>
        /// Maximum amount of characters to display in an exception to the user.
        /// </summary>
        const int MAX_LENGTH = 10;

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value "<paramref name="substring"/>" of
        /// parameter "<paramref name="parameterName"/>" is not found in the original string. If the value of <paramref name="substring"/> is longer
        /// than 10 characters the value displayed in the exception message will be truncated to 10.
        /// </summary>
        /// <param name="substring">Substring not located in the originalString.</param>
        /// <param name="parameterName">Name of the parameter in the original method whose argument is <paramref name="substring"/>.</param>
        internal static void Throw_Substring_ArgumentOutOfRangeException(string substring, string parameterName)
        {
            if (substring.Length > MAX_LENGTH) substring = substring[..MAX_LENGTH] + "...";
            throw new ArgumentOutOfRangeException(parameterName, $"The string given for '{parameterName}' (\"{substring}\") was not found in the original instance.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value of <paramref name="endString"/> was
        /// not found after <paramref name="startString"/> in the original instance. If the value of either <paramref name="startString"/> or <paramref name="endString"/>
        /// is longer than 10 characters the value displayed in the exception message will be truncated to 10.
        /// </summary>
        /// <param name="startString">Substring that marks the start of a string which does not contain <paramref name="endString"/>.</param>
        /// <param name="endString">String the user requested but that is not present in a subset of the string the original method was called on.</param>
        internal static void Throw_Endstring_ArgumentOutOfRangeException(string startString, string endString,
                                                                         [CallerArgumentExpression("startString")] string startStringParameterName = null,
                                                                         [CallerArgumentExpression("endString")] string endStringParameterName = null)
        {
            if (endString.Length > MAX_LENGTH) endString = endString[..MAX_LENGTH] + "...";
            if (startString.Length > MAX_LENGTH) startString = startString[..MAX_LENGTH] + "...";

            throw new ArgumentOutOfRangeException(endStringParameterName, $"The string given for '{endStringParameterName}' (\"{endString}\") was not found after the given '{startStringParameterName}' (\"{startString}\") in the original instance.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentNullException"/> that informs the user the argument of <paramref name="parameterName"/> was null.
        /// </summary>
        /// <param name="parameterName">Name of the parameter in the original calling method.</param>
            internal static void ThrowArgumentNullException(string parameterName)
            => throw new ArgumentNullException(parameterName, $"The argument given for '{parameterName}' was null.");

        /// <summary>
        /// Throws an <see cref="ArgumentNullException"/> that informs the user the member of <paramref name="parameterName"/> was null.
        /// </summary>
        /// <param name="parameterName">Name of the parameter in the original calling method.</param>
        internal static void ThrowArgumentNullMemberException(string parameterName)
            => throw new ArgumentNullException(parameterName, $"A member of the collection argument given for '{parameterName}' was null.");

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value "<paramref name="length"/>" of
        /// parameter "<paramref name="parameterName"/>" is a negative number.
        /// </summary>
        /// <param name="length">Integer, less than zero, the user provided for an operation that requires a positive number.</param>
        /// <param name="parameterName">Name of the parameter in the original method whose argument is <paramref name="length"/>.</param>
        internal static void Throw_Length_ArgumentOutOfRangeException(int length, string parameterName)
            => throw new ArgumentOutOfRangeException(parameterName, $"The value given for '{parameterName}' (\"{length}\") is less than zero.");

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value "<paramref name="length"/>" of
        /// parameter "<paramref name="parameterName"/>" is bigger then the available string by <paramref name="lengthDiff"/>.
        /// </summary>
        /// <param name="length">Amount of characters the user wanted selected from the available string.</param>
        /// <param name="parameterName">Name of the parameter in the original method whose argument is <paramref name="length"/>.</param>
        /// <param name="lengthDiff">The difference between the available length for selection and the length requested by the user.</param>
        internal static void Throw_Length_ArgumentOutOfRangeException(int length, int lengthDiff, [CallerArgumentExpression("length")] string parameterName = null)
            => throw new ArgumentOutOfRangeException(parameterName, $"The value given for '{parameterName}' (\"{length}\") is longer than the remaining string by {Math.Abs(lengthDiff)}.");

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value "<paramref name="amount"/>" of
        /// parameter "<paramref name="parameterName"/>" is bigger then the whole string by <paramref name="lengthDiff"/>.
        /// </summary>
        /// <param name="amount">Amount of characters the user wanted removed from the available string.</param>
        /// <param name="parameterName">Name of the parameter in the original method whose argument is <paramref name="amount"/>.</param>
        /// <param name="lengthDiff">The difference between the string length and the amount of characters requested by the user.</param>
        internal static void Throw_Amount_ArgumentOutOfRangeException(int amount, int lengthDiff, [CallerArgumentExpression("amount")] string parameterName = null)
            => throw new ArgumentOutOfRangeException(parameterName, $"The value given for '{parameterName}' (\"{amount}\") is longer than the entire string by {Math.Abs(lengthDiff)}.");
    }
}
