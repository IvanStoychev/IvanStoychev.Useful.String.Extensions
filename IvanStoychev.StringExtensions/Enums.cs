namespace IvanStoychev.StringExtensions
{
    /// <summary>
    /// Provides options for determining which of the strings should be included in the final result.
    /// </summary>
    public enum StringInclusionOptions
    {
        /// <summary>
        /// Do not include neither the start nor end strings.
        /// </summary>
        IncludeNone,

        /// <summary>
        /// Include only the start string.
        /// </summary>
        IncludeStart,

        /// <summary>
        /// Include only the end string.
        /// </summary>
        IncludeEnd,

        /// <summary>
        /// Include both the start and end strings.
        /// </summary>
        IncludeAll
    }
}
