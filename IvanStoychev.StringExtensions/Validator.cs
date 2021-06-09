using System;
using System.Data.SqlTypes;

namespace IvanStoychev.StringExtensions
{
    /// <summary>
    /// Performs checks, ensuring program execution proceeds smoothly.
    /// </summary>
    static class Validator
    {
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
                ExceptionThrower.Throw_Substring_ArgumentOutOfRangeException(substring, parameterName);
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
                ExceptionThrower.Throw_Substring_ArgumentOutOfRangeException(substring, parameterName);
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

            string substringStartStringOnwards = originalString.Substring(startStringIndex + startString.Length);
            endStringIndex = substringStartStringOnwards.IndexOf(endString, stringComparison);

            if (endStringIndex == -1)
                ExceptionThrower.Throw_Endstring_ArgumentOutOfRangeException(startString, endString);
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

            string substringStartStringOnwards = originalString.Substring(startStringIndex + startString.Length);
            endStringIndex = substringStartStringOnwards.LastIndexOf(endString, stringComparison);

            if (endStringIndex == -1)
                ExceptionThrower.Throw_Endstring_ArgumentOutOfRangeException(startString, endString);
        }
    }
}
