using System;
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
    /// Throws an <see cref="ArgumentException"/> that informs the user <paramref name="parameterName"/> is the empty string.
    /// </summary>
    /// <param name="parameterName">Name of the parameter in the original calling method.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    /// <exception cref="ArgumentException">
    /// <paramref name="parameterName"/> is the empty string ("").
    /// </exception>
    internal static void Throw_ArgumentException_EmptyString(string parameterName, string callingMethodName)
        => throw new ArgumentException($"The argument given for parameter \"{parameterName}\" of method \"{callingMethodName}\" is the empty string (\"\").", parameterName);

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> that informs the user a member of the collection provided for parameter
    /// "<paramref name="collectionParameterName"/>" was the empty string.
    /// </summary>
    /// <param name="collectionParameterName">Name of the parameter whose argument is the collection.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    /// <exception cref="ArgumentException">
    /// A member of <paramref name="collectionParameterName"/> is the empty string ("").
    /// </exception>
    internal static void Throw_ArgumentException_EmptyStringMember(string collectionParameterName, string callingMethodName)
        => throw new ArgumentException($"A member of the collection given for parameter \"{collectionParameterName}\" of method \"{callingMethodName}\" is the empty string (\"\").", collectionParameterName);

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> that informs the user the collection provided for parameter
    /// "<paramref name="collectionParameterName"/>" has no members.
    /// </summary>
    /// <param name="collectionParameterName">Name of the parameter whose argument is the collection.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    /// <exception cref="ArgumentException">
    /// Collection <paramref name="collectionParameterName"/> is empty.
    /// </exception>
    internal static void Throw_ArgumentException_EmptyCollection(string collectionParameterName, string callingMethodName)
        => throw new ArgumentException($"The collection argument given for parameter \"{collectionParameterName}\" of method \"{callingMethodName}\" contains no elements.", collectionParameterName);

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> that informs the user that the value of <paramref name="argument"/> does not exist in enum <paramref name="enumName"/>.
    /// </summary>
    /// <param name="argument">Value not found in enum <paramref name="enumName"/>.</param>
    /// <param name="parameterName">Name of the parameter whose argument is <paramref name="argument"/>.</param>
    /// <param name="enumName">Name of the enum that does not contain <paramref name="argument"/>.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    /// <exception cref="ArgumentException">
    /// <paramref name="argument"/> does not exist in <paramref name="enumName"/>.
    /// </exception>
    internal static void Throw_ArgumentException_EnumValueInvalid(object argument, string parameterName, string enumName, string callingMethodName)
        => throw new ArgumentException($"The argument \"{argument}\" given for parameter \"{parameterName}\" of method \"{callingMethodName}\" does not exist in enum \"{enumName}\"");

    /// <summary>
    /// Throws an <see cref="ArgumentNullException"/> that informs the user the argument of <paramref name="parameterName"/> was <see langword="null"/>.
    /// </summary>
    /// <param name="parameterName">Name of the parameter in the original calling method.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="parameterName"/> is <see langword="null"/>.
    /// </exception>
    internal static void Throw_ArgumentNullException(string parameterName, string callingMethodName)
        => throw new ArgumentNullException(parameterName, $"The argument given for parameter \"{parameterName}\" of method \"{callingMethodName}\" was null.");

    /// <summary>
    /// Throws an <see cref="ArgumentNullException"/> that informs the user the member of <paramref name="parameterName"/> was <see langword="null"/>.
    /// </summary>
    /// <param name="parameterName">Name of the parameter in the original calling method.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="parameterName"/> is <see langword="null"/>.
    /// </exception>
    internal static void Throw_ArgumentNullException_CollectionMember(string parameterName, string callingMethodName)
        => throw new ArgumentNullException(parameterName, $"A member of the collection argument given for parameter \"{parameterName}\" of method \"{callingMethodName}\" was null.");

    /// <summary>
    /// Throws an <see cref="ArgumentNullException"/> that informs the user the string on which <paramref name="callingMethodName"/> was called is <see langword="null"/>.
    /// </summary>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    /// <exception cref="ArgumentNullException">
    /// The string <paramref name="callingMethodName"/> was called on is <see langword="null"/>.
    /// </exception>
    internal static void Throw_ArgumentNullException_OriginalInstance(string callingMethodName)
        => throw new ArgumentNullException("Original string instance", $"The string instance on which \"{callingMethodName}\" was called is null.");

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
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="endString"/> was not found after <paramref name="startString"/>.
    /// </exception>
    internal static void Throw_ArgumentOutOfRangeException_Endstring(string startString, string endString, string callingMethodName,
                                                                     [CallerArgumentExpression("startString")] string startStringParameterName = null,
                                                                     [CallerArgumentExpression("endString")] string endStringParameterName = null)
    {
        if (endString.Length > MAX_LENGTH)
            endString = endString.Substring(0, MAX_LENGTH) + "...";

        if (startString.Length > MAX_LENGTH)
            startString = startString.Substring(0, MAX_LENGTH) + "...";

        throw new ArgumentOutOfRangeException(endStringParameterName, $"The string given for \"{endStringParameterName}\" (\"{endString}\") was not found after the given \"{startStringParameterName}\" (\"{startString}\") in the original instance. Name of the method throwing the exception - \"{callingMethodName}\".");
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value "<paramref name="length"/>" of
    /// parameter "<paramref name="parameterName"/>" is a negative number.
    /// </summary>
    /// <param name="length">Integer, less than zero, the user provided for an operation that requires a positive number.</param>
    /// <param name="parameterName">Name of the parameter in the original method whose argument is <paramref name="length"/>.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="length"/> is a negative number.
    /// </exception>
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
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="length"/> is too big by <paramref name="lengthDiff"/>.
    /// </exception>
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
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="substring"/> is not found in the original string.
    /// </exception>
    internal static void Throw_ArgumentOutOfRangeException_Substring(string substring, string parameterName, string callingMethodName)
    {
        if (substring.Length > MAX_LENGTH)
            substring = substring.Substring(0, MAX_LENGTH) + "...";

        throw new ArgumentOutOfRangeException(parameterName, $"The string given for \"{parameterName}\" (\"{substring}\") of method \"{callingMethodName}\" was not found in the original instance.");
    }
}
