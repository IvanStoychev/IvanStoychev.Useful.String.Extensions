﻿using System;
using System.Runtime.CompilerServices;

namespace IvanStoychev.Useful.String.Extensions;

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
    /// Throws an <see cref="ArgumentException"/> that informs the user a member of the collection provided for parameter
    /// "<paramref name="collectionParameterName"/>" was the empty string.
    /// </summary>
    /// <param name="collectionParameterName">Name of the parameter whose argument is the collection.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    internal static void Throw_ArgumentException_EmptyString(string collectionParameterName, string callingMethodName)
        => throw new ArgumentException($"A member of the collection given for parameter \"{collectionParameterName}\" of method \"{callingMethodName}\" is the empty string (\"\").", collectionParameterName);

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> that informs the user the collection provided for parameter
    /// "<paramref name="collectionParameterName"/>" has no members.
    /// </summary>
    /// <param name="collectionParameterName">Name of the parameter whose argument is the collection.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    internal static void Throw_ArgumentException_EmptyCollection(string collectionParameterName, string callingMethodName)
        => throw new ArgumentException($"The collection argument given for parameter \"{collectionParameterName}\" of method \"{callingMethodName}\" contains no elements.", collectionParameterName);

    /// <summary>
    /// Throws an <see cref="ArgumentNullException"/> that informs the user the argument of <paramref name="parameterName"/> was null.
    /// </summary>
    /// <param name="parameterName">Name of the parameter in the original calling method.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    internal static void Throw_ArgumentNullException(string parameterName, string callingMethodName)
        => throw new ArgumentNullException(parameterName, $"The argument given for parameter \"{parameterName}\" of method \"{callingMethodName}\" was null.");

    /// <summary>
    /// Throws an <see cref="ArgumentNullException"/> that informs the user the member of <paramref name="parameterName"/> was null.
    /// </summary>
    /// <param name="parameterName">Name of the parameter in the original calling method.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    internal static void Throw_ArgumentNullMemberException(string parameterName, string callingMethodName)
        => throw new ArgumentNullException(parameterName, $"A member of the collection argument given for parameter \"{parameterName}\" of method \"{callingMethodName}\" was null.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value "<paramref name="amount"/>" of
    /// parameter "<paramref name="parameterName"/>" is bigger then the whole string by <paramref name="lengthDiff"/>.
    /// </summary>
    /// <param name="amount">Amount of characters the user wanted removed from the available string.</param>
    /// <param name="parameterName">Name of the parameter in the original method whose argument is <paramref name="amount"/>.</param>
    /// <param name="lengthDiff">The difference between the string length and the amount of characters requested by the user.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    internal static void Throw_ArgumentOutOfRangeException_Amount(int amount, int lengthDiff, string callingMethodName, [CallerArgumentExpression("amount")] string parameterName = null)
        => throw new ArgumentOutOfRangeException(parameterName, $"The value given for parameter \"{parameterName}\" (\"{amount}\") of method \"{callingMethodName}\" is longer than the entire string by {Math.Abs(lengthDiff)}.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the string he is attempting to trim by "<paramref name="amount"/>" from both ends is
    /// <paramref name="lengthDiff"/> characters too short for that.
    /// </summary>
    /// <param name="amount">Amount of characters the user wanted removed from the start and end of a string.</param>
    /// <param name="lengthDiff">The difference between the string length and the amount of characters requested by the user.</param>
    /// <param name="parameterName">Name of the parameter in the original method whose argument is <paramref name="amount"/>.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    internal static void Throw_ArgumentOutOfRangeException_DoubleAmount(int amount, int lengthDiff, string callingMethodName, [CallerArgumentExpression("amount")] string parameterName = null)
        => throw new ArgumentOutOfRangeException(parameterName, $"The string being trimmed by method \"{callingMethodName}\" is {Math.Abs(lengthDiff)} characters too short to be trimmed by {amount} from both ends.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value of <paramref name="endString"/> was
    /// not found after <paramref name="startString"/> in the original instance. If the value of either <paramref name="startString"/> or <paramref name="endString"/>
    /// is longer than 10 characters the value displayed in the exception message will be truncated to 10.
    /// </summary>
    /// <param name="startString">Substring that marks the start of a string which does not contain <paramref name="endString"/>.</param>
    /// <param name="endString">String the user requested but that is not present in a subset of the string the original method was called on.</param>
    /// <param name="startStringParameterName">Name of the parameter in the original method whose argument is <paramref name="startString"/>.</param>
    /// <param name="endStringParameterName">Name of the parameter in the original method whose argument is <paramref name="endString"/>.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    internal static void Throw_ArgumentOutOfRangeException_Endstring(string startString, string endString, string callingMethodName,
                                                                     [CallerArgumentExpression("startString")] string startStringParameterName = null,
                                                                     [CallerArgumentExpression("endString")] string endStringParameterName = null)
    {
        if (endString.Length > MAX_LENGTH)
            endString = endString[..MAX_LENGTH] + "...";

        if (startString.Length > MAX_LENGTH)
            startString = startString[..MAX_LENGTH] + "...";

        throw new ArgumentOutOfRangeException(endStringParameterName, $"The string given for \"{endStringParameterName}\" (\"{endString}\") was not found after the given \"{startStringParameterName}\" (\"{startString}\") in the original instance. Executing method \"{callingMethodName}\".");
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value "<paramref name="length"/>" of
    /// parameter "<paramref name="parameterName"/>" is a negative number.
    /// </summary>
    /// <param name="length">Integer, less than zero, the user provided for an operation that requires a positive number.</param>
    /// <param name="parameterName">Name of the parameter in the original method whose argument is <paramref name="length"/>.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    internal static void Throw_ArgumentOutOfRangeException_Length(int length, string callingMethodName, [CallerArgumentExpression("length")] string parameterName = null)
        => throw new ArgumentOutOfRangeException(parameterName, $"The value given for \"{parameterName}\" (\"{length}\") of method \"{callingMethodName}\" is less than zero.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value "<paramref name="length"/>" of
    /// parameter "<paramref name="parameterName"/>" is bigger then the available string by <paramref name="lengthDiff"/>.
    /// </summary>
    /// <param name="length">Amount of characters the user wanted selected from the available string.</param>
    /// <param name="parameterName">Name of the parameter in the original method whose argument is <paramref name="length"/>.</param>
    /// <param name="lengthDiff">The difference between the available length for selection and the length requested by the user.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    internal static void Throw_ArgumentOutOfRangeException_Length(int length, int lengthDiff, string callingMethodName, [CallerArgumentExpression("length")] string parameterName = null)
        => throw new ArgumentOutOfRangeException(parameterName, $"The value given for \"{parameterName}\" (\"{length}\") of method \"{callingMethodName}\" is longer than the remaining string by {Math.Abs(lengthDiff)}.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value "<paramref name="substring"/>" of
    /// parameter "<paramref name="parameterName"/>" is not found in the original string. If the value of <paramref name="substring"/> is longer
    /// than 10 characters the value displayed in the exception message will be truncated to 10.
    /// </summary>
    /// <param name="substring">Substring not located in the originalString.</param>
    /// <param name="parameterName">Name of the parameter in the original method whose argument is <paramref name="substring"/>.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    internal static void Throw_ArgumentOutOfRangeException_Substring(string substring, string parameterName, string callingMethodName)
    {
        if (substring.Length > MAX_LENGTH)
            substring = substring[..MAX_LENGTH] + "...";

        throw new ArgumentOutOfRangeException(parameterName, $"The string given for \"{parameterName}\" (\"{substring}\") of method \"{callingMethodName}\" was not found in the original instance.");
    }
}
