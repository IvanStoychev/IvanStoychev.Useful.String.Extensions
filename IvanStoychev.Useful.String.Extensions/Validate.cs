using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace IvanStoychev.Useful.String.Extensions;

/// <summary>
/// Performs checks, ensuring program execution proceeds smoothly.
/// </summary>
static class Validate
{
    /// <summary>
    /// Checks if the given <paramref name="ienum"/> contains any members and throws an <see cref="ArgumentException"/> if it doesn't.
    /// </summary>
    /// <param name="ienum">An <see cref="IEnumerable{T}"/> to be checked if it is empty or not.</param>
    /// <param name="parameterName">Name of the parameter in the method that does this validation.</param>
    /// <param name="callingMethodName">Name of the method that does this validation.</param>
    /// <exception cref="ArgumentException">
    /// <paramref name="ienum"/> has no elements.
    /// </exception>
    internal static void IEnumNotEmpty(IEnumerable<string> ienum, [CallerArgumentExpression("ienum")] string parameterName = null, [CallerMemberName] string callingMethodName = null)
    {
        if (!ienum.Any())
            ExceptionThrower.Throw_ArgumentException_EmptyCollection(parameterName, callingMethodName);
    }

    /// <summary>
    /// Checks if the given <paramref name="collectionMember"/> is the empty string (""). And if it is, throws an <see cref="ArgumentException"/>.
    /// </summary>
    /// <param name="collectionMember">Member of a collection to evaluate.</param>
    /// <param name="collectionParameterName">Name of the parameter, whose argument is the collection, in the original method.</param>
    /// <param name="callingMethodName">Name of the method that does this validation.</param>
    /// <exception cref="ArgumentException">
    /// <paramref name="collectionMember"/> is the empty string ("").
    /// </exception>
    internal static void EmptyStringMember(string collectionMember, string collectionParameterName, [CallerMemberName] string callingMethodName = null)
    {
        if (collectionMember == "")
            ExceptionThrower.Throw_ArgumentException_EmptyString(collectionParameterName, callingMethodName);
    }

    /// <summary>
    /// Checks if <paramref name="startString"/> occurs in <paramref name="originalString"/> and if it doesn't, throws an <see cref="ArgumentOutOfRangeException"/>.
    /// If it does occur, then checks if <paramref name="endString"/> occurs in the part of <paramref name="originalString"/> that is after <paramref name="startString"/>
    /// and if it doesn't, throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value of <paramref name="endString"/> was
    /// not found after <paramref name="startString"/> in said string. If the value of either <paramref name="startString"/> or <paramref name="endString"/>
    /// is longer than 10 characters the value displayed in the exception message will be truncated to 10.
    /// <br/>In all cases the indices of the first occurrences of <paramref name="startString"/> and <paramref name="endString"/> are saved in <paramref name="startStringIndex"/>
    /// and <paramref name="endStringIndex"/>, respectively.
    /// </summary>
    /// <param name="originalString">The instance which to check  <paramref name="startString"/>.</param>
    /// <param name="startString">The value used for the start of the substring in the calling method.</param>
    /// <param name="endString">The string to search in <paramref name="originalString"/>.</param>
    /// <param name="startStringIndex">
    /// Contains the index of <paramref name="startString"/> in <paramref name="originalString"/>. If it is not found the index is "-1".
    /// <br/>This parameter is passed uninitialized.
    /// </param>
    /// <param name="endStringIndex">
    /// Contains the index of <paramref name="endString"/> in <paramref name="originalString"/>. If it is not found the index is "-1".
    /// <br/>This parameter is passed uninitialized.
    /// </param>
    /// <param name="stringComparison">The comparison rules to use when looking for the strings.</param>
    /// <param name="callingMethodName">Name of the method that does this validation.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="endString"/> is not found in the part of <paramref name="originalString"/> from <paramref name="startString"/> onward.
    /// </exception>
    internal static void EndStringIndex(string originalString, string startString, string endString, out int startStringIndex, out int endStringIndex, StringComparison stringComparison, [CallerMemberName] string callingMethodName = null)
    {
        SubstringIndex(originalString, startString, out startStringIndex, callingMethodName, stringComparison);

        string substringStartStringOnwards = originalString.Substring(startStringIndex + startString.Length);
        endStringIndex = substringStartStringOnwards.IndexOf(endString, stringComparison);

        if (endStringIndex == -1)
            ExceptionThrower.Throw_ArgumentOutOfRangeException_Endstring(startString, endString, callingMethodName);
    }

    /// <summary>
    /// Checks if <paramref name="startString"/> occurs in <paramref name="originalString"/> and if it doesn't, throws an <see cref="ArgumentOutOfRangeException"/>.
    /// If it does occur, then checks if <paramref name="endString"/> occurs in the part of <paramref name="originalString"/> that is after <paramref name="startString"/>
    /// and if it doesn't, throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value of <paramref name="endString"/> was
    /// not found after <paramref name="startString"/> in said string. If the value of either <paramref name="startString"/> or <paramref name="endString"/>
    /// is longer than 10 characters the value displayed in the exception message will be truncated to 10.
    /// <br/>In all cases the index of the first occurrence of <paramref name="startString"/> and the index of the last occurrence of <paramref name="endString"/>
    /// are saved in <paramref name="startStringIndex"/> and <paramref name="endStringIndex"/>, respectively.
    /// </summary>
    /// <param name="originalString">The instance which to check  <paramref name="startString"/>.</param>
    /// <param name="startString">The value used for the start of the substring in the calling method.</param>
    /// <param name="endString">The string to search in <paramref name="originalString"/>.</param>
    /// <param name="startStringIndex">
    /// Contains the index of <paramref name="startString"/> in <paramref name="originalString"/>. If it is not found the index is "-1".
    /// <br/>This parameter is passed uninitialized.
    /// </param>
    /// <param name="endStringIndex">
    /// Contains the index of <paramref name="endString"/> in <paramref name="originalString"/>. If it is not found the index is "-1".
    /// <br/>This parameter is passed uninitialized.
    /// </param>
    /// <param name="stringComparison">The comparison rules to use when looking for the strings.</param>
    /// <param name="callingMethodName">Name of the method that does this validation.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="endString"/> is not found in the part of <paramref name="originalString"/> from <paramref name="startString"/> onward.
    /// </exception>
    internal static void EndStringLastIndex(string originalString, string startString, string endString, out int startStringIndex, out int endStringIndex, StringComparison stringComparison, [CallerMemberName] string callingMethodName = null)
    {
        SubstringIndex(originalString, startString, out startStringIndex, callingMethodName, stringComparison);

        string substringStartStringOnwards = originalString.Substring(startStringIndex + startString.Length);
        endStringIndex = substringStartStringOnwards.LastIndexOf(endString, stringComparison);

        if (endStringIndex == -1)
            ExceptionThrower.Throw_ArgumentOutOfRangeException_Endstring(startString, endString, callingMethodName);
    }

    /// <summary>
    /// Checks if the value given for <paramref name="length"/> isn't a negative number. And if it is, throws an <see cref="ArgumentOutOfRangeException"/>.
    /// </summary>
    /// <param name="length">Integer to be verified that it isn't less than zero.</param>
    /// <param name="callingMethodName">Name of the method that does this validation.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="length"/> is a negative number.
    /// </exception>
    internal static void LengthIsPositive(int length, [CallerMemberName] string callingMethodName = null)
    {
        if (length < 0)
            ExceptionThrower.Throw_ArgumentOutOfRangeException_Length(length, callingMethodName);
    }

    /// <summary>
    /// Checks if the value given for <paramref name="length"/> isn't bigger than the given <paramref name="stringLength"/>.
    /// And if it is, throws an <see cref="ArgumentOutOfRangeException"/>.
    /// </summary>
    /// <param name="stringLength">The amount of available characters from which the user wishes to select <paramref name="length"/> amount.</param>
    /// <param name="length">Amount of characters the user wishes to select from a string with length "<paramref name="stringLength"/>".</param>
    /// <param name="callingMethodName">Name of the method that does this validation.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="length"/> is bigger than <paramref name="stringLength"/>.
    /// </exception>
    internal static void LengthIsWithinBounds(int stringLength, int length, [CallerMemberName] string callingMethodName = null)
    {
        int lengthDiff = stringLength - length;
        if (lengthDiff < 0)
            ExceptionThrower.Throw_ArgumentOutOfRangeException_Length(length, lengthDiff, callingMethodName);
    }

    /// <summary>
    /// Checks if the given <paramref name="argument"/> of parameter "<paramref name="parameterName"/>" is null.
    /// And if it is, throws an <see cref="ArgumentNullException"/>.
    /// </summary>
    /// <param name="argument">Value passed as the argument for a method's parameter.</param>
    /// <param name="parameterName">Name of the parameter in the method that does this validation.</param>
    /// <param name="callingMethodName">Name of the method that does this validation.</param>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="argument"/> is null.
    /// </exception>
    internal static void NullArgument(object argument, [CallerArgumentExpression("argument")] string parameterName = null, [CallerMemberName] string callingMethodName = null)
    {
        if (argument is null)
            ExceptionThrower.Throw_ArgumentNullException(parameterName, callingMethodName);
    }

    /// <summary>
    /// Checks if the given <paramref name="collectionMember"/> is null. And if it is, throws an <see cref="ArgumentNullException"/>.
    /// </summary>
    /// <param name="collectionMember">Member of a collection to evaluate.</param>
    /// <param name="collectionParameterName">Name of the parameter, whose argument is the collection, in the original method.</param>
    /// <param name="callingMethodName">Name of the method that does this validation.</param>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="collectionMember"/> is null.
    /// </exception>
    internal static void NullMember(object collectionMember, string collectionParameterName, [CallerMemberName] string callingMethodName = null)
    {
        if (collectionMember is null)
            ExceptionThrower.Throw_ArgumentNullMemberException(collectionParameterName, callingMethodName);
    }

    /// <summary>
    /// Checks if <paramref name="substring"/> occurs in <paramref name="originalString"/> and if it doesn't, throws an
    /// <see cref="ArgumentOutOfRangeException"/> that informs the user that the value "<paramref name="substring"/>" of
    /// argument <paramref name="parameterName"/> is not found in said string. If the value of <paramref name="substring"/> is longer
    /// than 10 characters the value displayed in the exception message will be truncated to 10.
    /// <br/>In all cases the index of the first occurrence of <paramref name="substring"/> in <paramref name="originalString"/> is saved in <paramref name="substringIndex"/>.
    /// </summary>
    /// <param name="originalString">The instance which to check for <paramref name="substring"/>.</param>
    /// <param name="substring">The string to search in <paramref name="originalString"/> for.</param>
    /// <param name="parameterName">The Name of the parameter in the method that does this validation, the argument of which is <paramref name="substring"/>.</param>
    /// <param name="substringIndex">
    /// Contains the index of <paramref name="substring"/> in <paramref name="originalString"/>. If it is not found the index is "-1".
    /// <br/>This parameter is passed uninitialized.
    /// </param>
    /// <param name="stringComparison">The comparison rules to use when looking for <paramref name="substring"/>.</param>
    /// <param name="callingMethodName">Name of the method that does this validation.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="substring"/> is not found in <paramref name="originalString"/>.
    /// </exception>
    internal static void SubstringIndex(string originalString, string substring, out int substringIndex, string callingMethodName, StringComparison stringComparison, [CallerArgumentExpression("substring")] string parameterName = null)
    {
        substringIndex = originalString.IndexOf(substring, stringComparison);

        if (substringIndex == -1)
            ExceptionThrower.Throw_ArgumentOutOfRangeException_Substring(substring, parameterName, callingMethodName);
    }

    /// <summary>
    /// Checks if <paramref name="substring"/> occurs in <paramref name="originalString"/> and if it doesn't, throws an
    /// <see cref="ArgumentOutOfRangeException"/> that informs the user that the value "<paramref name="substring"/>" of
    /// argument <paramref name="parameterName"/> is not found in said string. If the value of <paramref name="substring"/> is longer
    /// than 10 characters the value displayed in the exception message will be truncated to 10.
    /// <br/>In all cases the index of the first occurrence of <paramref name="substring"/> in <paramref name="originalString"/> is saved in <paramref name="substringIndex"/>.
    /// </summary>
    /// <param name="originalString">The instance which to check for <paramref name="substring"/>.</param>
    /// <param name="substring">The string to search in <paramref name="originalString"/> for.</param>
    /// <param name="parameterName">The Name of the parameter in the method that does this validation, the argument of which is <paramref name="substring"/>.</param>
    /// <param name="substringIndex">
    /// Contains the index of <paramref name="substring"/> in <paramref name="originalString"/>. If it is not found the index is "-1".
    /// <br/>This parameter is passed uninitialized.
    /// </param>
    /// <param name="stringComparison">The comparison rules to use when looking for <paramref name="substring"/>.</param>
    /// <param name="callingMethodName">Name of the method that does this validation.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="substring"/> is not found in <paramref name="originalString"/>.
    /// </exception>
    internal static void SubstringIndex(string originalString, string substring, out int substringIndex, StringComparison stringComparison, [CallerArgumentExpression("substring")] string parameterName = null, [CallerMemberName] string callingMethodName = null)
    {
        substringIndex = originalString.IndexOf(substring, stringComparison);

        if (substringIndex == -1)
            ExceptionThrower.Throw_ArgumentOutOfRangeException_Substring(substring, parameterName, callingMethodName);
    }

    /// <summary>
    /// Checks if <paramref name="substring"/> occurs in <paramref name="originalString"/> and if it doesn't, throws an
    /// <see cref="ArgumentOutOfRangeException"/> that informs the user that the value "<paramref name="substring"/>" of
    /// argument <paramref name="parameterName"/> is not found in said string. If the value of <paramref name="substring"/> is longer
    /// than 10 characters the value displayed in the exception message will be truncated to 10.
    /// <br/>In all cases the index of the last occurrence of <paramref name="substring"/> in <paramref name="originalString"/> is saved in <paramref name="substringIndex"/>.
    /// </summary>
    /// <param name="originalString">The instance which to check for <paramref name="substring"/>.</param>
    /// <param name="substring">The string to search in <paramref name="originalString"/> for.</param>
    /// <param name="parameterName">The Name of the parameter in the method that does this validation, the argument of which is <paramref name="substring"/>.</param>
    /// <param name="substringIndex">
    /// Contains the index of <paramref name="substring"/> in <paramref name="originalString"/>. If it is not found the index is "-1".
    /// <br/>This parameter is passed uninitialized.
    /// </param>
    /// <param name="stringComparison">The comparison rules to use when looking for <paramref name="substring"/>.</param>
    /// <param name="callingMethodName">Name of the method that does this validation.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="substring"/> is not found in <paramref name="originalString"/>.
    /// </exception>
    internal static void SubstringLastIndex(string originalString, string substring, string parameterName, out int substringIndex, StringComparison stringComparison, [CallerMemberName] string callingMethodName = null)
    {
        substringIndex = originalString.LastIndexOf(substring, stringComparison);

        if (substringIndex == -1)
            ExceptionThrower.Throw_ArgumentOutOfRangeException_Substring(substring, parameterName, callingMethodName);
    }
}
