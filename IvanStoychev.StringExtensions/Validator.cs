using System;

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
        /// than 10 characters then the value displayed in the exception message will be truncated to 10.
        /// </summary>
        /// <param name="originalString">The instance which to check for <paramref name="substring"/>.</param>
        /// <param name="substring">The string to search in <paramref name="originalString"/> for.</param>
        /// <param name="parameterName">
        /// The name of the parameter in the original method, the argument of which is <paramref name="substring"/>.
        /// </param>
        /// <param name="stringComparison">The comparison rules to use when looking for <paramref name="substring"/>.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="substring"/> is not found in <paramref name="originalString"/>.
        /// </exception>
        internal static void CheckSubstringIndex(string originalString, string substring, string parameterName, StringComparison stringComparison = StringComparison.CurrentCulture)
        {
            if (originalString.IndexOf(substring, stringComparison) == -1)
            {
                if (substring.Length > 10) substring = substring.Substring(0, 10) + "...";
                throw new ArgumentOutOfRangeException($"{parameterName}", $"The string given for '{parameterName}' (\"{substring}\") was not found in the original instance.");
            }
        }

        /// <summary>
        /// Checks if <paramref name="substring"/> occurs in <paramref name="originalString"/> and if it doesn't, throws an <see cref="ArgumentOutOfRangeException"/>.
        /// If it does occur, then checks if <paramref name="endString"/> occurs in the part of <paramref name="originalString"/> that is after <paramref name="startString"/>
        /// and if it doesn't, throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value of <paramref name="endString"/> was
        /// not found after <paramref name="startString"/> in said string. If the value of either <paramref name="startString"/> or <paramref name="endString"/>
        /// is longer than 10 characters the value displayed in the exception message will be truncated to 10.
        /// </summary>
        /// <param name="originalString">The instance which to check  <paramref name="startString"/>.</param>
        /// <param name="startString">The value used for the start of the substring in the calling method.</param>
        /// <param name="endString">The string to search in <paramref name="originalString"/>.</param>
        /// <param name="stringComparison">The comparison rules to use when looking for the strings.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="endString"/> is not found in the part of <paramref name="originalString"/> from <paramref name="startString"/> onward.
        /// </exception>
        internal static void CheckEndStringIndex(string originalString, string startString, string endString, StringComparison stringComparison = StringComparison.CurrentCulture)
        {
            CheckSubstringIndex(originalString, startString, nameof(startString), stringComparison);

            int startStringIndex = originalString.IndexOf(startString, stringComparison);
            string substringStartStringOnwards = originalString.Substring(startStringIndex + startString.Length);

            if (substringStartStringOnwards.IndexOf(endString, stringComparison) == -1)
            {
                if (endString.Length > 10) endString = endString.Substring(0, 10) + "...";
                if (startString.Length > 10) startString = startString.Substring(0, 10) + "...";
                throw new ArgumentOutOfRangeException($"endString", $"The string given for 'endString' (\"{endString}\") was not found after the given 'startString' (\"{startString}\") in the original instance.");
            }
        }
    }
}
