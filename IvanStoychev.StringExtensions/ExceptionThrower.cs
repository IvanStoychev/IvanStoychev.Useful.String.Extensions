using System;

namespace IvanStoychev.StringExtensions
{
    /// <summary>
    /// Handles formatting and throwing of exceptions.
    /// </summary>
    static class ExceptionThrower
    {
        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value "<paramref name="substring"/>" of
        /// parameter "<paramref name="parameterName"/>" is not found in the original string. If the value of <paramref name="substring"/> is longer
        /// than 10 characters the value displayed in the exception message will be truncated to 10.
        /// </summary>
        /// <param name="substring">The substring not located in the originalString.</param>
        /// <param name="parameterName">The name of the parameter in the original method whose argument is <paramref name="substring"/>.</param>
        internal static void Throw_Substring_ArgumentOutOfRangeException(string substring, string parameterName)
        {
            if (substring.Length > 10) substring = substring.Substring(0, 10) + "...";
            throw new ArgumentOutOfRangeException($"{parameterName}", $"The string given for '{parameterName}' (\"{substring}\") was not found in the original instance.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> that informs the user the value of <paramref name="endString"/> was
        /// not found after <paramref name="startString"/> in the original instance. If the value of either <paramref name="startString"/> or <paramref name="endString"/>
        /// is longer than 10 characters the value displayed in the exception message will be truncated to 10.
        /// </summary>
        /// <param name="startString"></param>
        /// <param name="endString"></param>
        internal static void Throw_Endstring_ArgumentOutOfRangeException(string startString, string endString)
        {
            if (endString.Length > 10) endString = endString.Substring(0, 10) + "...";
            if (startString.Length > 10) startString = startString.Substring(0, 10) + "...";

            throw new ArgumentOutOfRangeException($"endString", $"The string given for 'endString' (\"{endString}\") was not found after the given 'startString' (\"{startString}\") in the original instance.");
        }
    }
}
