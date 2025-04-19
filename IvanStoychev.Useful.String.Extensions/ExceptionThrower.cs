using System;

namespace IvanStoychev.Useful.String.Extensions;

/// <summary>
/// Handles formatting and throwing of exceptions.
/// </summary>
static class ExceptionThrower
{
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
    internal static void Throw_ArgumentNullMemberException(string parameterName, string callingMethodName)
        => throw new ArgumentNullException(parameterName, $"A member of the collection argument given for parameter \"{parameterName}\" of method \"{callingMethodName}\" was null.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value passed for parameter <paramref name="endStringParameterName"/> was
    /// not found after the value passed for parameter <paramref name="startStringParameterName"/> for the original string instance in <paramref name="callingMethodName"/>.
    /// </summary>
    /// <param name="startStringParameterName">Name of the parameter in the original method whose argument is supposed to denote the beginning of a substring.</param>
    /// <param name="endStringParameterName">Name of the parameter in the original method whose argument is supposed to denote the ending of a substring.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The original string instance does not contain the value passed for <paramref name="endStringParameterName"/>
    /// after the value passed for <paramref name="startStringParameterName"/>.
    /// </exception>
    internal static void Throw_ArgumentOutOfRangeException_Endstring(string startStringParameterName, string endStringParameterName, string callingMethodName)
        => throw new ArgumentOutOfRangeException(endStringParameterName, $"The string given for parameter \"{endStringParameterName}\" of method \"{callingMethodName}\" was not found after the argument given for parameter \"{startStringParameterName}\" in the original instance.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value passed for parameter "<paramref name="parameterName"/>" is a negative number.
    /// </summary>
    /// <param name="parameterName">Name of the parameter in the original method whose argument is a negative number.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Value passed for <paramref name="parameterName"/> is a negative number.
    /// </exception>
    internal static void Throw_ArgumentOutOfRangeException_Length(string parameterName, string callingMethodName)
        => throw new ArgumentOutOfRangeException(parameterName, $"The value given for parameter \"{parameterName}\" of method \"{callingMethodName}\" is less than zero.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value passed for parameter "<paramref name="parameterName"/>"
    /// is bigger then the available string by <paramref name="lengthDiff"/>.
    /// </summary>
    /// <param name="parameterName">Name of the parameter in the original method whose argument is causing the exception.</param>
    /// <param name="lengthDiff">The absolute difference between the available length for selection and the length requested by the user.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Value of <paramref name="parameterName"/> is too big by <paramref name="lengthDiff"/>.
    /// </exception>
    internal static void Throw_ArgumentOutOfRangeException_Length(int lengthDiff, string parameterName, string callingMethodName)
        => throw new ArgumentOutOfRangeException(parameterName, $"The value given for parameter \"{parameterName}\" of method \"{callingMethodName}\" is longer than the remaining string by {lengthDiff}.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value passed for parameter "<paramref name="parameterName"/>"
    /// is not found in the original string.
    /// </summary>
    /// <param name="parameterName">Name of the parameter in the original method whose argument is causing the exception.</param>
    /// <param name="callingMethodName">Name of the method that throws this exception.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Value of <paramref name="parameterName"/> is not found in the original string.
    /// </exception>
    internal static void Throw_ArgumentOutOfRangeException_Substring(string parameterName, string callingMethodName)
        => throw new ArgumentOutOfRangeException(parameterName, $"The string given for parameter \"{parameterName}\" of method \"{callingMethodName}\" was not found in the original instance.");
}
