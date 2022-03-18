using System;
using System.Runtime.CompilerServices;

namespace IvanStoychev.Useful.String.Extensions;

/// <summary>
/// Performs checks, ensuring program execution proceeds smoothly.
/// </summary>
static class Validator
{
    /// <summary>
    /// Checks if the value of <paramref name="lengthDiff"/> is negative. And if it is, throws an <see cref="ArgumentOutOfRangeException"/>.
    /// </summary>
    /// <param name="amount">Number of characters the user wishes to remove from a string.</param>
    /// <param name="lengthDiff">Number of characters left in the string after <paramref name="amount"/> have been removed.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="lengthDiff"/> is a negative number.</exception>
    internal static void CheckAmountStringLength(int amount, int lengthDiff)
    {
        if (lengthDiff < 0)
            ExceptionThrower.Throw_ArgumentOutOfRangeException_Amount(amount, lengthDiff);
    }

    /// <summary>
    /// Checks if the value of <paramref name="lengthDiff"/> is negative. And if it is, throws an <see cref="ArgumentOutOfRangeException"/>.
    /// </summary>
    /// <param name="amount">Number of characters the user wishes to remove from a string.</param>
    /// <param name="lengthDiff">Number of characters left in the string after <paramref name="amount"/> have been removed.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="lengthDiff"/> is a negative number.</exception>
    internal static void CheckDoubleAmountStringLength(int amount, int lengthDiff)
    {
        if (lengthDiff < 0)
            ExceptionThrower.Throw_ArgumentOutOfRangeException_DoubleAmount(amount, lengthDiff);
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
    internal static void CheckEmptyStringMember(string collectionMember, string collectionParameterName, [CallerMemberName] string callingMethodName = null)
    {
        if (collectionMember == "")
            ExceptionThrower.Throw_ArgumentException(collectionParameterName, callingMethodName);
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
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="endString"/> is not found in the part of <paramref name="originalString"/> from <paramref name="startString"/> onward.
    /// </exception>
    internal static void CheckEndStringIndex(string originalString, string startString, string endString, out int startStringIndex, out int endStringIndex, StringComparison stringComparison = StringComparison.CurrentCulture)
    {
        CheckSubstringIndex(originalString, startString, nameof(startString), out startStringIndex, stringComparison);

        string substringStartStringOnwards = originalString[(startStringIndex + startString.Length)..];
        endStringIndex = substringStartStringOnwards.IndexOf(endString, stringComparison);

        if (endStringIndex == -1)
            ExceptionThrower.Throw_ArgumentOutOfRangeException_Endstring(startString, endString);
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
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="endString"/> is not found in the part of <paramref name="originalString"/> from <paramref name="startString"/> onward.
    /// </exception>
    internal static void CheckEndStringLastIndex(string originalString, string startString, string endString, out int startStringIndex, out int endStringIndex, StringComparison stringComparison = StringComparison.CurrentCulture)
    {
        CheckSubstringIndex(originalString, startString, nameof(startString), out startStringIndex, stringComparison);

        string substringStartStringOnwards = originalString[(startStringIndex + startString.Length)..];
        endStringIndex = substringStartStringOnwards.LastIndexOf(endString, stringComparison);

        if (endStringIndex == -1)
            ExceptionThrower.Throw_ArgumentOutOfRangeException_Endstring(startString, endString);
    }
    
    /// <summary>
    /// Checks if the value given for <paramref name="length"/> isn't a negative number. And if it is, throws an <see cref="ArgumentOutOfRangeException"/>.
    /// </summary>
    /// <param name="length">Integer to be verified that it isn't less than zero.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="length"/> is a negative number.</exception>
    internal static void CheckLengthIsPositive(int length)
    {
        if (length < 0)
            ExceptionThrower.Throw_ArgumentOutOfRangeException_Length(length, nameof(length));
    }

    /// <summary>
    /// Checks if the value given for <paramref name="length"/> isn't bigger than the given <paramref name="stringLength"/>.
    /// And if it is, throws an <see cref="ArgumentOutOfRangeException"/>.
    /// </summary>
    /// <param name="stringLength">The amount of available characters from which the user wishes to select <paramref name="length"/> amount.</param>
    /// <param name="length">Amount of characters the user wishes to select from a string with length "<paramref name="stringLength"/>".</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="length"/> is bigger than <paramref name="stringLength"/>.</exception>
    internal static void CheckLengthIsWithinBounds(int stringLength, int length)
    {
        int lengthDiff = stringLength - length;
        if (lengthDiff < 0)
            ExceptionThrower.Throw_ArgumentOutOfRangeException_Length(length, lengthDiff);
    }

    /// <summary>
    /// Checks if the given <paramref name="argument"/> of parameter "<paramref name="parameterName"/>" is null.
    /// And if it is, throws an <see cref="ArgumentNullException"/>.
    /// </summary>
    /// <param name="argument">Value passed as the argument for a method's parameter.</param>
    /// <param name="parameterName">Name of the parameter in the original method.</param>
    /// <param name="callingMethodName">Name of the method that does this validation.</param>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="argument"/> is null.
    /// </exception>
    internal static void CheckNullArgument(object argument, [CallerArgumentExpression("argument")] string parameterName = null, [CallerMemberName] string callingMethodName = null)
    {
        if (argument is null)
            ExceptionThrower.Throw_ArgumentNullException(parameterName, callingMethodName);
    }

    /// <summary>
    /// Checks if the given <paramref name="collectionMember"/> is null. And if it is, throws an <see cref="ArgumentNullException"/>.
    /// </summary>
    /// <param name="collectionMember">Member of a collection to evaluate.</param>
    /// <param name="collectionParameterName">Name of the parameter, whose argument is the collection, in the original method.</param>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="collectionMember"/> is null.
    /// </exception>
    internal static void CheckNullMember(object collectionMember, string collectionParameterName)
    {
        if (collectionMember is null)
            ExceptionThrower.Throw_ArgumentNullMemberException(collectionParameterName);
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
    /// <param name="parameterName">The name of the parameter in the original method, the argument of which is <paramref name="substring"/>.</param>
    /// <param name="substringIndex">
    /// Contains the index of <paramref name="substring"/> in <paramref name="originalString"/>. If it is not found the index is "-1".
    /// <br/>This parameter is passed uninitialized.
    /// </param>
    /// <param name="stringComparison">The comparison rules to use when looking for <paramref name="substring"/>.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="substring"/> is not found in <paramref name="originalString"/>.
    /// </exception>
    internal static void CheckSubstringIndex(string originalString, string substring, string parameterName, out int substringIndex, StringComparison stringComparison = StringComparison.CurrentCulture)
    {
        substringIndex = originalString.IndexOf(substring, stringComparison);

        if (substringIndex == -1)
            ExceptionThrower.Throw_ArgumentOutOfRangeException_Substring(substring, parameterName);
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
    /// <param name="parameterName">The name of the parameter in the original method, the argument of which is <paramref name="substring"/>.</param>
    /// <param name="substringIndex">
    /// Contains the index of <paramref name="substring"/> in <paramref name="originalString"/>. If it is not found the index is "-1".
    /// <br/>This parameter is passed uninitialized.
    /// </param>
    /// <param name="stringComparison">The comparison rules to use when looking for <paramref name="substring"/>.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="substring"/> is not found in <paramref name="originalString"/>.
    /// </exception>
    internal static void CheckSubstringLastIndex(string originalString, string substring, string parameterName, out int substringIndex, StringComparison stringComparison = StringComparison.CurrentCulture)
    {
        substringIndex = originalString.LastIndexOf(substring, stringComparison);

        if (substringIndex == -1)
            ExceptionThrower.Throw_ArgumentOutOfRangeException_Substring(substring, parameterName);
    }
}
