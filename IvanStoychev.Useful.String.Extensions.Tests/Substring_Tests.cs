using System;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Substring_Tests
{
    #region Substring(this string str, string startString, int length, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    [Theory]
    [InlineData("I started sweating.",                          "ed sweat")]
    [InlineData("Now I have to start all over again.",          " all ove")]
    [InlineData("He didn't start taking his job seriously.",    " taking ")]
    public void Substring_String_Int_DefaultInclude_DefaultComparison(string testString, string expected)
    {
        string result = testString.Substring("start", 8);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start 1234567890 terminus.",     "12345",    StringComparison.CurrentCulture)]
    [InlineData("Begin start start 12345 terminus.",    "start",    StringComparison.CurrentCulture)]
    [InlineData("Begin START 1234567890 terminus.",     "12345",    StringComparison.CurrentCultureIgnoreCase)]
    [InlineData("Begin START start 12345 terminus.",    "start",    StringComparison.CurrentCultureIgnoreCase)]
    [InlineData("Begin start 1234567890 terminus.",     "12345",    StringComparison.InvariantCulture)]
    [InlineData("Begin start start 12345 terminus.",    "start",    StringComparison.InvariantCulture)]
    [InlineData("Begin START 1234567890 terminus.",     "12345",    StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START start 12345 terminus.",    "start",    StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start 1234567890 terminus.",     "12345",    StringComparison.Ordinal)]
    [InlineData("Begin start start 12345 terminus.",    "start",    StringComparison.Ordinal)]
    [InlineData("Begin START 1234567890 terminus.",     "12345",    StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START start 12345 terminus.",    "start",    StringComparison.OrdinalIgnoreCase)]

    #endregion Data
    public void Substring_String_Int_DefaultInclude_SetComparison(string testString, string expected, StringComparison comparison)
    {
        string result = testString.Substring("start ", 5, comparison: comparison);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start 1234567890 terminus.",     "start 12345",      true)]
    [InlineData("Begin start start 12345 terminus.",    "start start",      true)]
    [InlineData("Begin start 1234567890 terminus.",     "12345",            false)]
    [InlineData("Begin start start 12345 terminus.",    "start",            false)]

    #endregion Data
    public void Substring_String_Int_SetInclude_DefaultComparison(string testString, string expected, bool include)
    {
        string result = testString.Substring("start ", 5, include);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start 1234567890 terminus.",     "start 12345",  true,       StringComparison.CurrentCulture)]
    [InlineData("Begin start start 12345 terminus.",    "start start",  true,       StringComparison.CurrentCulture)]
    [InlineData("Begin start 1234567890 terminus.",     "12345",        false,      StringComparison.CurrentCulture)]
    [InlineData("Begin start start 12345 terminus.",    "start",        false,      StringComparison.CurrentCulture)]
    [InlineData("Begin START 1234567890 terminus.",     "START 12345",  true,       StringComparison.CurrentCultureIgnoreCase)]
    [InlineData("Begin START start 12345 terminus.",    "START start",  true,       StringComparison.CurrentCultureIgnoreCase)]
    [InlineData("Begin START 1234567890 terminus.",     "12345",        false,      StringComparison.CurrentCultureIgnoreCase)]
    [InlineData("Begin START start 12345 terminus.",    "start",        false,      StringComparison.CurrentCultureIgnoreCase)]
    [InlineData("Begin start 1234567890 terminus.",     "start 12345",  true,       StringComparison.InvariantCulture)]
    [InlineData("Begin start start 12345 terminus.",    "start start",  true,       StringComparison.InvariantCulture)]
    [InlineData("Begin start 1234567890 terminus.",     "12345",        false,      StringComparison.InvariantCulture)]
    [InlineData("Begin start start 12345 terminus.",    "start",        false,      StringComparison.InvariantCulture)]
    [InlineData("Begin START 1234567890 terminus.",     "START 12345",  true,       StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START start 12345 terminus.",    "START start",  true,       StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START 1234567890 terminus.",     "12345",        false,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START start 12345 terminus.",    "start",        false,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start 1234567890 terminus.",     "start 12345",  true,       StringComparison.Ordinal)]
    [InlineData("Begin start start 12345 terminus.",    "start start",  true,       StringComparison.Ordinal)]
    [InlineData("Begin start 1234567890 terminus.",     "12345",        false,      StringComparison.Ordinal)]
    [InlineData("Begin start start 12345 terminus.",    "start",        false,      StringComparison.Ordinal)]
    [InlineData("Begin START 1234567890 terminus.",     "START 12345",  true,       StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START start 12345 terminus.",    "START start",  true,       StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START 1234567890 terminus.",     "12345",        false,      StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START start 12345 terminus.",    "start",        false,      StringComparison.OrdinalIgnoreCase)]

    #endregion Data
    public void Substring_String_Int_SetInclude_SetComparison(string testString, string expected, bool include, StringComparison comparison)
    {
        string result = testString.Substring("start ", 5, include, comparison);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("I started sweating.",                          "I sta")]
    [InlineData("Now I have to start all over again.",          "Now I")]
    [InlineData("He didn't start taking his job seriously.",    "He di")]
    public void Substring_String_Int_DefaultInclude_DefaultComparison_EmptyString(string testString, string expected)
    {
        string result = testString.Substring("", 5);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start 1234567890 terminus.",     "Begin",    StringComparison.CurrentCulture)]
    [InlineData("Begin start start 12345 terminus.",    "Begin",    StringComparison.CurrentCulture)]
    [InlineData("Begin START 1234567890 terminus.",     "Begin",    StringComparison.CurrentCultureIgnoreCase)]
    [InlineData("Begin START start 12345 terminus.",    "Begin",    StringComparison.CurrentCultureIgnoreCase)]
    [InlineData("Begin start 1234567890 terminus.",     "Begin",    StringComparison.InvariantCulture)]
    [InlineData("Begin start start 12345 terminus.",    "Begin",    StringComparison.InvariantCulture)]
    [InlineData("Begin START 1234567890 terminus.",     "Begin",    StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START start 12345 terminus.",    "Begin",    StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start 1234567890 terminus.",     "Begin",    StringComparison.Ordinal)]
    [InlineData("Begin start start 12345 terminus.",    "Begin",    StringComparison.Ordinal)]
    [InlineData("Begin START 1234567890 terminus.",     "Begin",    StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START start 12345 terminus.",    "Begin",    StringComparison.OrdinalIgnoreCase)]

    #endregion Data
    public void Substring_String_Int_DefaultInclude_SetComparison_EmptyString(string testString, string expected, StringComparison comparison)
    {
        string result = testString.Substring("", 5, comparison: comparison);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start 1234567890 terminus.",     "Begin",    true)]
    [InlineData("Begin start start 12345 terminus.",    "Begin",    true)]
    [InlineData("Begin start 1234567890 terminus.",     "Begin",    false)]
    [InlineData("Begin start start 12345 terminus.",    "Begin",    false)]

    #endregion Data
    public void Substring_String_Int_SetInclude_DefaultComparison_EmptyString(string testString, string expected, bool include)
    {
        string result = testString.Substring("", 5, include);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start 1234567890 terminus.",     "Begin",        true,       StringComparison.CurrentCulture)]
    [InlineData("Begin start start 12345 terminus.",    "Begin",        true,       StringComparison.CurrentCulture)]
    [InlineData("Begin start 1234567890 terminus.",     "Begin",        false,      StringComparison.CurrentCulture)]
    [InlineData("Begin start start 12345 terminus.",    "Begin",        false,      StringComparison.CurrentCulture)]
    [InlineData("Begin START 1234567890 terminus.",     "Begin",        true,       StringComparison.CurrentCultureIgnoreCase)]
    [InlineData("Begin START start 12345 terminus.",    "Begin",        true,       StringComparison.CurrentCultureIgnoreCase)]
    [InlineData("Begin START 1234567890 terminus.",     "Begin",        false,      StringComparison.CurrentCultureIgnoreCase)]
    [InlineData("Begin START start 12345 terminus.",    "Begin",        false,      StringComparison.CurrentCultureIgnoreCase)]
    [InlineData("Begin start 1234567890 terminus.",     "Begin",        true,       StringComparison.InvariantCulture)]
    [InlineData("Begin start start 12345 terminus.",    "Begin",        true,       StringComparison.InvariantCulture)]
    [InlineData("Begin start 1234567890 terminus.",     "Begin",        false,      StringComparison.InvariantCulture)]
    [InlineData("Begin start start 12345 terminus.",    "Begin",        false,      StringComparison.InvariantCulture)]
    [InlineData("Begin START 1234567890 terminus.",     "Begin",        true,       StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START start 12345 terminus.",    "Begin",        true,       StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START 1234567890 terminus.",     "Begin",        false,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START start 12345 terminus.",    "Begin",        false,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start 1234567890 terminus.",     "Begin",        true,       StringComparison.Ordinal)]
    [InlineData("Begin start start 12345 terminus.",    "Begin",        true,       StringComparison.Ordinal)]
    [InlineData("Begin start 1234567890 terminus.",     "Begin",        false,      StringComparison.Ordinal)]
    [InlineData("Begin start start 12345 terminus.",    "Begin",        false,      StringComparison.Ordinal)]
    [InlineData("Begin START 1234567890 terminus.",     "Begin",        true,       StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START start 12345 terminus.",    "Begin",        true,       StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START 1234567890 terminus.",     "Begin",        false,      StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START start 12345 terminus.",    "Begin",        false,      StringComparison.OrdinalIgnoreCase)]

    #endregion Data
    public void Substring_String_Int_SetInclude_SetComparison_EmptyString(string testString, string expected, bool include, StringComparison comparison)
    {
        string result = testString.Substring("", 5, include, comparison);

        Assert.Equal(expected, result);
    }


    #endregion Substring(this string str, string startString, int length, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    #region Substring(this string str, string startString, string endString, StringInclusionOptions inclusionOptions = StringInclusionOptions.IncludeNone, StringComparison comparison = StringComparison.CurrentCulture)

    [Theory]
    [InlineData("I started starting sweating sweat.", "ed starting ")]
    [InlineData("Now I have to start starting to sweat all over sweaty again.", " starting to ")]
    [InlineData("He started to was told that he'd be fired in a sweat if he didn't start sweating on his job.", "ed to was told that he'd be fired in a ")]
    public void Substring_String_String_DefaultInclusion_DefaultComparison(string testString, string expected)
    {
        string result = testString.Substring("start", "sweat");

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                       " start middle ",           StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler ",    StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       " start middle ",           StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  " filler start filler ",    StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       " start middle ",           StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler ",    StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       " start middle ",           StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  " filler start filler ",    StringComparison.OrdinalIgnoreCase)]
    
    #endregion Data
    public void Substring_String_String_DefaultInclusion_SetComparison(string testString, string expected, StringComparison comparison)
    {
        string result = testString.Substring("start", "end", comparison: comparison);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                       " start middle ",                   StringInclusionOptions.IncludeNone)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler ",            StringInclusionOptions.IncludeNone)]
    
    [InlineData("Begin start start middle end end terminus.",                       "start start middle end",           StringInclusionOptions.IncludeAll)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start filler start filler end",    StringInclusionOptions.IncludeAll)]
    
    [InlineData("Begin start start middle end end terminus.",                       "start start middle ",              StringInclusionOptions.IncludeStart)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start filler start filler ",       StringInclusionOptions.IncludeStart)]
    
    [InlineData("Begin start start middle end end terminus.",                       " start middle end",                StringInclusionOptions.IncludeEnd)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler end",         StringInclusionOptions.IncludeEnd)]
    
    #endregion Data
    public void Substring_String_String_SetInclusion_DefaultComparison(string testString, string expected, StringInclusionOptions inclusionOptions)
    {
        string result = testString.Substring("start", "end", inclusionOptions);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                       " start middle ",                   StringInclusionOptions.IncludeNone,  StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler ",            StringInclusionOptions.IncludeNone,  StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       " start middle ",                   StringInclusionOptions.IncludeNone,  StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  " filler start filler ",            StringInclusionOptions.IncludeNone,  StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       " start middle ",                   StringInclusionOptions.IncludeNone,  StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler ",            StringInclusionOptions.IncludeNone,  StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       " start middle ",                   StringInclusionOptions.IncludeNone,  StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  " filler start filler ",            StringInclusionOptions.IncludeNone,  StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       "start start middle end",           StringInclusionOptions.IncludeAll,   StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start filler start filler end",    StringInclusionOptions.IncludeAll,   StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "START start middle END",           StringInclusionOptions.IncludeAll,   StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "START filler start filler END",    StringInclusionOptions.IncludeAll,   StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "start start middle end",           StringInclusionOptions.IncludeAll,   StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start filler start filler end",    StringInclusionOptions.IncludeAll,   StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "START start middle END",           StringInclusionOptions.IncludeAll,   StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "START filler start filler END",    StringInclusionOptions.IncludeAll,   StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       "start start middle ",              StringInclusionOptions.IncludeStart, StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start filler start filler ",       StringInclusionOptions.IncludeStart, StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "START start middle ",              StringInclusionOptions.IncludeStart, StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "START filler start filler ",       StringInclusionOptions.IncludeStart, StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "start start middle ",              StringInclusionOptions.IncludeStart, StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start filler start filler ",       StringInclusionOptions.IncludeStart, StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "START start middle ",              StringInclusionOptions.IncludeStart, StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "START filler start filler ",       StringInclusionOptions.IncludeStart, StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       " start middle end",                StringInclusionOptions.IncludeEnd,   StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler end",         StringInclusionOptions.IncludeEnd,   StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       " start middle END",                StringInclusionOptions.IncludeEnd,   StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  " filler start filler END",         StringInclusionOptions.IncludeEnd,   StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       " start middle end",                StringInclusionOptions.IncludeEnd,   StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler end",         StringInclusionOptions.IncludeEnd,   StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       " start middle END",                StringInclusionOptions.IncludeEnd,   StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  " filler start filler END",         StringInclusionOptions.IncludeEnd,   StringComparison.OrdinalIgnoreCase)]
    
    #endregion Data
    public void Substring_String_String_SetInclusion_SetComparison(string testString, string expected, StringInclusionOptions inclusionOptions, StringComparison comparison)
    {
        string result = testString.Substring("start", "end", inclusionOptions, comparison);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Substring_String_String_DefaultInclusion_DefaultComparison_EmptyStartString()
    {
        string testString = "start mid end";
        string expected = "start mid ";

        string result = testString.Substring("", "end");

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle ",           StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler ",    StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "Begin START start middle ",           StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "Begin START filler start filler ",    StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle ",           StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler ",    StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "Begin START start middle ",           StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "Begin START filler start filler ",    StringComparison.OrdinalIgnoreCase)]
    
    #endregion Data
    public void Substring_String_String_DefaultInclusion_SetComparison_EmptyStartString(string testString, string expected, StringComparison comparison)
    {
        string result = testString.Substring("", "end", comparison: comparison);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle ",                StringInclusionOptions.IncludeNone)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler ",         StringInclusionOptions.IncludeNone)]
    
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end",             StringInclusionOptions.IncludeAll)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end",      StringInclusionOptions.IncludeAll)]
    
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle ",                StringInclusionOptions.IncludeStart)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler ",         StringInclusionOptions.IncludeStart)]
    
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end",             StringInclusionOptions.IncludeEnd)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end",      StringInclusionOptions.IncludeEnd)]
    
    #endregion Data
    public void Substring_String_String_SetInclusion_DefaultComparison_EmptyStartString(string testString, string expected, StringInclusionOptions inclusionOptions)
    {
        string result = testString.Substring("", "end", inclusionOptions);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle ",                StringInclusionOptions.IncludeNone,  StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler ",         StringInclusionOptions.IncludeNone,  StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "Begin START start middle ",                StringInclusionOptions.IncludeNone,  StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "Begin START filler start filler ",         StringInclusionOptions.IncludeNone,  StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle ",                StringInclusionOptions.IncludeNone,  StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler ",         StringInclusionOptions.IncludeNone,  StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "Begin START start middle ",                StringInclusionOptions.IncludeNone,  StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "Begin START filler start filler ",         StringInclusionOptions.IncludeNone,  StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end",             StringInclusionOptions.IncludeAll,   StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end",      StringInclusionOptions.IncludeAll,   StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "Begin START start middle END",             StringInclusionOptions.IncludeAll,   StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "Begin START filler start filler END",      StringInclusionOptions.IncludeAll,   StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end",             StringInclusionOptions.IncludeAll,   StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end",      StringInclusionOptions.IncludeAll,   StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "Begin START start middle END",             StringInclusionOptions.IncludeAll,   StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "Begin START filler start filler END",      StringInclusionOptions.IncludeAll,   StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle ",                StringInclusionOptions.IncludeStart, StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler ",         StringInclusionOptions.IncludeStart, StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "Begin START start middle ",                StringInclusionOptions.IncludeStart, StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "Begin START filler start filler ",         StringInclusionOptions.IncludeStart, StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle ",                StringInclusionOptions.IncludeStart, StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler ",         StringInclusionOptions.IncludeStart, StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "Begin START start middle ",                StringInclusionOptions.IncludeStart, StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "Begin START filler start filler ",         StringInclusionOptions.IncludeStart, StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end",             StringInclusionOptions.IncludeEnd,   StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end",      StringInclusionOptions.IncludeEnd,   StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "Begin START start middle END",             StringInclusionOptions.IncludeEnd,   StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "Begin START filler start filler END",      StringInclusionOptions.IncludeEnd,   StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end",             StringInclusionOptions.IncludeEnd,   StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end",      StringInclusionOptions.IncludeEnd,   StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "Begin START start middle END",             StringInclusionOptions.IncludeEnd,   StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "Begin START filler start filler END",      StringInclusionOptions.IncludeEnd,   StringComparison.OrdinalIgnoreCase)]
    
    #endregion Data
    public void Substring_String_String_SetInclusion_SetComparison_EmptyStartString(string testString, string expected, StringInclusionOptions inclusionOptions, StringComparison comparison)
    {
        string result = testString.Substring("", "end", inclusionOptions, comparison);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Substring_String_String_DefaultInclusion_DefaultComparison_EmptyEndString()
    {
        string testString = "start mid end";
        string expected = "";

        string result = testString.Substring("start", "");

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                           "",     StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",      "",     StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                           "",     StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",      "",     StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                           "",     StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",      "",     StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                           "",     StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",      "",     StringComparison.OrdinalIgnoreCase)]
    
    #endregion Data
    public void Substring_String_String_DefaultInclusion_SetComparison_EmptyEndString(string testString, string expected, StringComparison comparison)
    {
        string result = testString.Substring("start", "", comparison: comparison);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                       "",         StringInclusionOptions.IncludeNone)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "",         StringInclusionOptions.IncludeNone)]
    
    [InlineData("Begin start start middle end end terminus.",                       "start",    StringInclusionOptions.IncludeAll)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start",    StringInclusionOptions.IncludeAll)]
    
    [InlineData("Begin start start middle end end terminus.",                       "start",    StringInclusionOptions.IncludeStart)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start",    StringInclusionOptions.IncludeStart)]
    
    [InlineData("Begin start start middle end end terminus.",                       "",         StringInclusionOptions.IncludeEnd)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "",         StringInclusionOptions.IncludeEnd)]
    
    #endregion Data
    public void Substring_String_String_SetInclusion_DefaultComparison_EmptyEndString(string testString, string expected, StringInclusionOptions inclusionOptions)
    {
        string result = testString.Substring("start", "", inclusionOptions);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                       "",         StringInclusionOptions.IncludeNone,     StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "",         StringInclusionOptions.IncludeNone,     StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "",         StringInclusionOptions.IncludeNone,     StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "",         StringInclusionOptions.IncludeNone,     StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "",         StringInclusionOptions.IncludeNone,     StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "",         StringInclusionOptions.IncludeNone,     StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "",         StringInclusionOptions.IncludeNone,     StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "",         StringInclusionOptions.IncludeNone,     StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       "start",    StringInclusionOptions.IncludeAll,      StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start",    StringInclusionOptions.IncludeAll,      StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "START",    StringInclusionOptions.IncludeAll,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "START",    StringInclusionOptions.IncludeAll,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "start",    StringInclusionOptions.IncludeAll,      StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start",    StringInclusionOptions.IncludeAll,      StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "START",    StringInclusionOptions.IncludeAll,      StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "START",    StringInclusionOptions.IncludeAll,      StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       "start",    StringInclusionOptions.IncludeStart,    StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start",    StringInclusionOptions.IncludeStart,    StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "START",    StringInclusionOptions.IncludeStart,    StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "START",    StringInclusionOptions.IncludeStart,    StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "start",    StringInclusionOptions.IncludeStart,    StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start",    StringInclusionOptions.IncludeStart,    StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "START",    StringInclusionOptions.IncludeStart,    StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "START",    StringInclusionOptions.IncludeStart,    StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       "",         StringInclusionOptions.IncludeEnd,      StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "",         StringInclusionOptions.IncludeEnd,      StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "",         StringInclusionOptions.IncludeEnd,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "",         StringInclusionOptions.IncludeEnd,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "",         StringInclusionOptions.IncludeEnd,      StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "",         StringInclusionOptions.IncludeEnd,      StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "",         StringInclusionOptions.IncludeEnd,      StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "",         StringInclusionOptions.IncludeEnd,      StringComparison.OrdinalIgnoreCase)]
    
    #endregion Data
    public void Substring_String_String_SetInclusion_SetComparison_EmptyEndString(string testString, string expected, StringInclusionOptions inclusionOptions, StringComparison comparison)
    {
        string result = testString.Substring("start", "", inclusionOptions, comparison);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Substring_String_String_DefaultInclusion_DefaultComparison_AllStringsEmpty()
    {
        string testString = "start mid end";
        string expected = "";

        string result = testString.Substring("", "");

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                           "",     StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",      "",     StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                           "",     StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",      "",     StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                           "",     StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",      "",     StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                           "",     StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",      "",     StringComparison.OrdinalIgnoreCase)]
    
    #endregion Data
    public void Substring_String_String_DefaultInclusion_SetComparison_AllStringsEmpty(string testString, string expected, StringComparison comparison)
    {
        string result = testString.Substring("", "", comparison: comparison);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                       "",         StringInclusionOptions.IncludeNone)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "",         StringInclusionOptions.IncludeNone)]
    
    [InlineData("Begin start start middle end end terminus.",                       "",         StringInclusionOptions.IncludeAll)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "",         StringInclusionOptions.IncludeAll)]
    
    [InlineData("Begin start start middle end end terminus.",                       "",         StringInclusionOptions.IncludeStart)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "",         StringInclusionOptions.IncludeStart)]
    
    [InlineData("Begin start start middle end end terminus.",                       "",         StringInclusionOptions.IncludeEnd)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "",         StringInclusionOptions.IncludeEnd)]
    
    #endregion Data
    public void Substring_String_String_SetInclusion_DefaultComparison_AllStringsEmpty(string testString, string expected, StringInclusionOptions inclusionOptions)
    {
        string result = testString.Substring("", "", inclusionOptions);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                       "",         StringInclusionOptions.IncludeNone,     StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "",         StringInclusionOptions.IncludeNone,     StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "",         StringInclusionOptions.IncludeNone,     StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "",         StringInclusionOptions.IncludeNone,     StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "",         StringInclusionOptions.IncludeNone,     StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "",         StringInclusionOptions.IncludeNone,     StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "",         StringInclusionOptions.IncludeNone,     StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "",         StringInclusionOptions.IncludeNone,     StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       "",         StringInclusionOptions.IncludeAll,      StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "",         StringInclusionOptions.IncludeAll,      StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "",         StringInclusionOptions.IncludeAll,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "",         StringInclusionOptions.IncludeAll,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "",         StringInclusionOptions.IncludeAll,      StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "",         StringInclusionOptions.IncludeAll,      StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "",         StringInclusionOptions.IncludeAll,      StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "",         StringInclusionOptions.IncludeAll,      StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       "",         StringInclusionOptions.IncludeStart,    StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "",         StringInclusionOptions.IncludeStart,    StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "",         StringInclusionOptions.IncludeStart,    StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "",         StringInclusionOptions.IncludeStart,    StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "",         StringInclusionOptions.IncludeStart,    StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "",         StringInclusionOptions.IncludeStart,    StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "",         StringInclusionOptions.IncludeStart,    StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "",         StringInclusionOptions.IncludeStart,    StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       "",         StringInclusionOptions.IncludeEnd,      StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "",         StringInclusionOptions.IncludeEnd,      StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "",         StringInclusionOptions.IncludeEnd,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "",         StringInclusionOptions.IncludeEnd,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "",         StringInclusionOptions.IncludeEnd,      StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "",         StringInclusionOptions.IncludeEnd,      StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "",         StringInclusionOptions.IncludeEnd,      StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "",         StringInclusionOptions.IncludeEnd,      StringComparison.OrdinalIgnoreCase)]
    
    #endregion Data
    public void Substring_String_String_SetInclusion_SetComparison_AllStringsEmpty(string testString, string expected, StringInclusionOptions inclusionOptions, StringComparison comparison)
    {
        string result = testString.Substring("", "", inclusionOptions, comparison);

        Assert.Equal(expected, result);
    }


    #endregion Substring(this string str, string startString, string endString, StringInclusionOptions inclusionOptions = StringInclusionOptions.IncludeNone, StringComparison comparison = StringComparison.CurrentCulture)

    #region Substring(this string str, string startString, string endString, StringInclusionOptions inclusionOptions = StringInclusionOptions.IncludeNone, StringComparison comparison = StringComparison.CurrentCulture)

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                           " start middle end ")]
    [InlineData("Begin start filler start filler end filler end filler terminus.",      " filler start filler end filler ")]
    public void SubstringLast_String_String_DefaultInclusion_DefaultComparison(string testString, string expected)
    {
        string result = testString.SubstringLast("start", "end");

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                       " start middle end ",                   StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler end filler ",     StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle end END terminus.",                       " start middle end ",                   StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler end filler END filler terminus.",  " filler start filler end filler ",     StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       " start middle end ",                   StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler end filler ",     StringComparison.Ordinal)]
    [InlineData("Begin START start middle end END terminus.",                       " start middle end ",                   StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler end filler END filler terminus.",  " filler start filler end filler ",     StringComparison.OrdinalIgnoreCase)]
    
    #endregion Data
    public void SubstringLast_String_String_DefaultInclusion_SetComparison(string testString, string expected, StringComparison comparison)
    {
        string result = testString.SubstringLast("start", "end", comparison: comparison);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                       " start middle end ",                           StringInclusionOptions.IncludeNone)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler end filler ",             StringInclusionOptions.IncludeNone)]
    
    [InlineData("Begin start start middle end end terminus.",                       "start start middle end end",                   StringInclusionOptions.IncludeAll)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start filler start filler end filler end",     StringInclusionOptions.IncludeAll)]
    
    [InlineData("Begin start start middle end end terminus.",                       "start start middle end ",                      StringInclusionOptions.IncludeStart)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start filler start filler end filler ",        StringInclusionOptions.IncludeStart)]
    
    [InlineData("Begin start start middle end end terminus.",                       " start middle end end",                        StringInclusionOptions.IncludeEnd)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler end filler end",          StringInclusionOptions.IncludeEnd)]
    
    #endregion Data
    public void SubstringLast_String_String_SetInclusion_DefaultComparison(string testString, string expected, StringInclusionOptions inclusionOptions)
    {
        string result = testString.SubstringLast("start", "end", inclusionOptions);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                       " start middle end ",                           StringInclusionOptions.IncludeNone,  StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler end filler ",             StringInclusionOptions.IncludeNone,  StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle end END terminus.",                       " start middle end ",                           StringInclusionOptions.IncludeNone,  StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler end filler END filler terminus.",  " filler start filler end filler ",             StringInclusionOptions.IncludeNone,  StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       " start middle end ",                           StringInclusionOptions.IncludeNone,  StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler end filler ",             StringInclusionOptions.IncludeNone,  StringComparison.Ordinal)]
    [InlineData("Begin START start middle end END terminus.",                       " start middle end ",                           StringInclusionOptions.IncludeNone,  StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler end filler END filler terminus.",  " filler start filler end filler ",             StringInclusionOptions.IncludeNone,  StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       "start start middle end end",                   StringInclusionOptions.IncludeAll,   StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start filler start filler end filler end",     StringInclusionOptions.IncludeAll,   StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle end END terminus.",                       "START start middle end END",                   StringInclusionOptions.IncludeAll,   StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler end filler END filler terminus.",  "START filler start filler end filler END",     StringInclusionOptions.IncludeAll,   StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "start start middle end end",                   StringInclusionOptions.IncludeAll,   StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start filler start filler end filler end",     StringInclusionOptions.IncludeAll,   StringComparison.Ordinal)]
    [InlineData("Begin START start middle end END terminus.",                       "START start middle end END",                   StringInclusionOptions.IncludeAll,   StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler end filler END filler terminus.",  "START filler start filler end filler END",     StringInclusionOptions.IncludeAll,   StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       "start start middle end ",                      StringInclusionOptions.IncludeStart, StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start filler start filler end filler ",        StringInclusionOptions.IncludeStart, StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle end END terminus.",                       "START start middle end ",                      StringInclusionOptions.IncludeStart, StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler end filler END filler terminus.",  "START filler start filler end filler ",        StringInclusionOptions.IncludeStart, StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "start start middle end ",                      StringInclusionOptions.IncludeStart, StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start filler start filler end filler ",        StringInclusionOptions.IncludeStart, StringComparison.Ordinal)]
    [InlineData("Begin START start middle end END terminus.",                       "START start middle end ",                      StringInclusionOptions.IncludeStart, StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler end filler END filler terminus.",  "START filler start filler end filler ",        StringInclusionOptions.IncludeStart, StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       " start middle end end",                        StringInclusionOptions.IncludeEnd,   StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler end filler end",          StringInclusionOptions.IncludeEnd,   StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle end END terminus.",                       " start middle end END",                        StringInclusionOptions.IncludeEnd,   StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler end filler END filler terminus.",  " filler start filler end filler END",          StringInclusionOptions.IncludeEnd,   StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       " start middle end end",                        StringInclusionOptions.IncludeEnd,   StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler end filler end",          StringInclusionOptions.IncludeEnd,   StringComparison.Ordinal)]
    [InlineData("Begin START start middle end END terminus.",                       " start middle end END",                        StringInclusionOptions.IncludeEnd,   StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler end filler END filler terminus.",  " filler start filler end filler END",          StringInclusionOptions.IncludeEnd,   StringComparison.OrdinalIgnoreCase)]
    
    #endregion Data
    public void SubstringLast_String_String_SetInclusion_SetComparison(string testString, string expected, StringInclusionOptions inclusionOptions, StringComparison comparison)
    {
        string result = testString.SubstringLast("start", "end", inclusionOptions, comparison);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void SubstringLast_String_String_DefaultInclusion_DefaultComparison_EmptyStartString()
    {
        string testString = "start mid end end";
        string expected = "start mid end ";

        string result = testString.SubstringLast("", "end");

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end ",                    StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end filler ",      StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle end END terminus.",                       "Begin START start middle end ",                    StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler end filler END filler terminus.",  "Begin START filler start filler end filler ",      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end ",                    StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end filler ",      StringComparison.Ordinal)]
    [InlineData("Begin START start middle end END terminus.",                       "Begin START start middle end ",                    StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler end filler END filler terminus.",  "Begin START filler start filler end filler ",      StringComparison.OrdinalIgnoreCase)]
    
    #endregion Data
    public void SubstringLast_String_String_DefaultInclusion_SetComparison_EmptyStartString(string testString, string expected, StringComparison comparison)
    {
        string result = testString.SubstringLast("", "end", comparison: comparison);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end ",                        StringInclusionOptions.IncludeNone)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end filler ",          StringInclusionOptions.IncludeNone)]
    
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end end",                     StringInclusionOptions.IncludeAll)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end filler end",       StringInclusionOptions.IncludeAll)]
    
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end ",                        StringInclusionOptions.IncludeStart)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end filler ",          StringInclusionOptions.IncludeStart)]
    
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end end",                     StringInclusionOptions.IncludeEnd)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end filler end",       StringInclusionOptions.IncludeEnd)]
    
    #endregion Data
    public void SubstringLast_String_String_SetInclusion_DefaultComparison_EmptyStartString(string testString, string expected, StringInclusionOptions inclusionOptions)
    {
        string result = testString.SubstringLast("", "end", inclusionOptions);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end ",                        StringInclusionOptions.IncludeNone,  StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end filler ",          StringInclusionOptions.IncludeNone,  StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "Begin START start middle END ",                        StringInclusionOptions.IncludeNone,  StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "Begin START filler start filler END filler ",          StringInclusionOptions.IncludeNone,  StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end ",                        StringInclusionOptions.IncludeNone,  StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end filler ",          StringInclusionOptions.IncludeNone,  StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "Begin START start middle END ",                        StringInclusionOptions.IncludeNone,  StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "Begin START filler start filler END filler ",          StringInclusionOptions.IncludeNone,  StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end end",                     StringInclusionOptions.IncludeAll,   StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end filler end",       StringInclusionOptions.IncludeAll,   StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "Begin START start middle END end",                     StringInclusionOptions.IncludeAll,   StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "Begin START filler start filler END filler end",       StringInclusionOptions.IncludeAll,   StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end end",                     StringInclusionOptions.IncludeAll,   StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end filler end",       StringInclusionOptions.IncludeAll,   StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "Begin START start middle END end",                     StringInclusionOptions.IncludeAll,   StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "Begin START filler start filler END filler end",       StringInclusionOptions.IncludeAll,   StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end ",                        StringInclusionOptions.IncludeStart, StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end filler ",          StringInclusionOptions.IncludeStart, StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "Begin START start middle END ",                        StringInclusionOptions.IncludeStart, StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "Begin START filler start filler END filler ",          StringInclusionOptions.IncludeStart, StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end ",                        StringInclusionOptions.IncludeStart, StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end filler ",          StringInclusionOptions.IncludeStart, StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "Begin START start middle END ",                        StringInclusionOptions.IncludeStart, StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "Begin START filler start filler END filler ",          StringInclusionOptions.IncludeStart, StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end end",                     StringInclusionOptions.IncludeEnd,   StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end filler end",       StringInclusionOptions.IncludeEnd,   StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "Begin START start middle END end",                     StringInclusionOptions.IncludeEnd,   StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "Begin START filler start filler END filler end",       StringInclusionOptions.IncludeEnd,   StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "Begin start start middle end end",                     StringInclusionOptions.IncludeEnd,   StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "Begin start filler start filler end filler end",       StringInclusionOptions.IncludeEnd,   StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "Begin START start middle END end",                     StringInclusionOptions.IncludeEnd,   StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "Begin START filler start filler END filler end",       StringInclusionOptions.IncludeEnd,   StringComparison.OrdinalIgnoreCase)]
    
    #endregion Data
    public void SubstringLast_String_String_SetInclusion_SetComparison_EmptyStartString(string testString, string expected, StringInclusionOptions inclusionOptions, StringComparison comparison)
    {
        string result = testString.SubstringLast("", "end", inclusionOptions, comparison);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void SubstringLast_String_String_DefaultInclusion_DefaultComparison_EmptyEndString()
    {
        string testString = "start mid end";
        string expected = " mid end";

        string result = testString.SubstringLast("start", "");

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                           " start middle end end terminus.",                          StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",      " filler start filler end filler end filler terminus.",     StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                           " start middle END end terminus.",                          StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",      " filler start filler END filler end filler terminus.",     StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                           " start middle end end terminus.",                          StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",      " filler start filler end filler end filler terminus.",     StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                           " start middle END end terminus.",                          StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",      " filler start filler END filler end filler terminus.",     StringComparison.OrdinalIgnoreCase)]
    
    #endregion Data
    public void SubstringLast_String_String_DefaultInclusion_SetComparison_EmptyEndString(string testString, string expected, StringComparison comparison)
    {
        string result = testString.SubstringLast("start", "", comparison: comparison);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                           " start middle end end terminus.",                              StringInclusionOptions.IncludeNone)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",      " filler start filler end filler end filler terminus.",         StringInclusionOptions.IncludeNone)]
    [InlineData("Begin start start middle end end terminus.",                           "start start middle end end terminus.",                         StringInclusionOptions.IncludeAll)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",      "start filler start filler end filler end filler terminus.",    StringInclusionOptions.IncludeAll)]
    [InlineData("Begin start start middle end end terminus.",                           "start start middle end end terminus.",                         StringInclusionOptions.IncludeStart)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",      "start filler start filler end filler end filler terminus.",    StringInclusionOptions.IncludeStart)]
    [InlineData("Begin start start middle end end terminus.",                           " start middle end end terminus.",                              StringInclusionOptions.IncludeEnd)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",      " filler start filler end filler end filler terminus.",         StringInclusionOptions.IncludeEnd)]
    
    #endregion Data
    public void SubstringLast_String_String_SetInclusion_DefaultComparison_EmptyEndString(string testString, string expected, StringInclusionOptions inclusionOptions)
    {
        string result = testString.SubstringLast("start", "", inclusionOptions);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                       " start middle end end terminus.",                                  StringInclusionOptions.IncludeNone,     StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler end filler end filler terminus.",             StringInclusionOptions.IncludeNone,     StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       " start middle END end terminus.",                                  StringInclusionOptions.IncludeNone,     StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  " filler start filler END filler end filler terminus.",             StringInclusionOptions.IncludeNone,     StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       " start middle end end terminus.",                                  StringInclusionOptions.IncludeNone,     StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler end filler end filler terminus.",             StringInclusionOptions.IncludeNone,     StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       " start middle END end terminus.",                                  StringInclusionOptions.IncludeNone,     StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  " filler start filler END filler end filler terminus.",             StringInclusionOptions.IncludeNone,     StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       "start start middle end end terminus.",                             StringInclusionOptions.IncludeAll,      StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start filler start filler end filler end filler terminus.",        StringInclusionOptions.IncludeAll,      StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "START start middle END end terminus.",                             StringInclusionOptions.IncludeAll,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "START filler start filler END filler end filler terminus.",        StringInclusionOptions.IncludeAll,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "start start middle end end terminus.",                             StringInclusionOptions.IncludeAll,      StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start filler start filler end filler end filler terminus.",        StringInclusionOptions.IncludeAll,      StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "START start middle END end terminus.",                             StringInclusionOptions.IncludeAll,      StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "START filler start filler END filler end filler terminus.",        StringInclusionOptions.IncludeAll,      StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       "start start middle end end terminus.",                             StringInclusionOptions.IncludeStart,    StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start filler start filler end filler end filler terminus.",        StringInclusionOptions.IncludeStart,    StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       "START start middle END end terminus.",                             StringInclusionOptions.IncludeStart,    StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "START filler start filler END filler end filler terminus.",        StringInclusionOptions.IncludeStart,    StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       "start start middle end end terminus.",                             StringInclusionOptions.IncludeStart,    StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  "start filler start filler end filler end filler terminus.",        StringInclusionOptions.IncludeStart,    StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       "START start middle END end terminus.",                             StringInclusionOptions.IncludeStart,    StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  "START filler start filler END filler end filler terminus.",        StringInclusionOptions.IncludeStart,    StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       " start middle end end terminus.",                                  StringInclusionOptions.IncludeEnd,      StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler end filler end filler terminus.",             StringInclusionOptions.IncludeEnd,      StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       " start middle END end terminus.",                                  StringInclusionOptions.IncludeEnd,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  " filler start filler END filler end filler terminus.",             StringInclusionOptions.IncludeEnd,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       " start middle end end terminus.",                                  StringInclusionOptions.IncludeEnd,      StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  " filler start filler end filler end filler terminus.",             StringInclusionOptions.IncludeEnd,      StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       " start middle END end terminus.",                                  StringInclusionOptions.IncludeEnd,      StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  " filler start filler END filler end filler terminus.",             StringInclusionOptions.IncludeEnd,      StringComparison.OrdinalIgnoreCase)]
    
    #endregion Data
    public void SubstringLast_String_String_SetInclusion_SetComparison_EmptyEndString(string testString, string expected, StringInclusionOptions inclusionOptions, StringComparison comparison)
    {
        string result = testString.SubstringLast("start", "", inclusionOptions, comparison);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void SubstringLast_String_String_DefaultInclusion_DefaultComparison_AllStringsEmpty()
    {
        string testString = "start mid end";
        string expected = testString;

        string result = testString.SubstringLast("", "");

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                           StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",      StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                           StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                           StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",      StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                           StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",      StringComparison.OrdinalIgnoreCase)]
    
    #endregion Data
    public void SubstringLast_String_String_DefaultInclusion_SetComparison_AllStringsEmpty(string testString, StringComparison comparison)
    {
        string expected = testString;
        string result = testString.SubstringLast("", "", comparison: comparison);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                       StringInclusionOptions.IncludeNone)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  StringInclusionOptions.IncludeNone)]
    [InlineData("Begin start start middle end end terminus.",                       StringInclusionOptions.IncludeAll)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  StringInclusionOptions.IncludeAll)]
    [InlineData("Begin start start middle end end terminus.",                       StringInclusionOptions.IncludeStart)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  StringInclusionOptions.IncludeStart)]
    [InlineData("Begin start start middle end end terminus.",                       StringInclusionOptions.IncludeEnd)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  StringInclusionOptions.IncludeEnd)]
    
    #endregion Data
    public void SubstringLast_String_String_SetInclusion_DefaultComparison_AllStringsEmpty(string testString, StringInclusionOptions inclusionOptions)
    {
        string expected = testString;
        string result = testString.SubstringLast("", "", inclusionOptions);

        Assert.Equal(expected, result);
    }

    #region Data

    [Theory]
    [InlineData("Begin start start middle end end terminus.",                       StringInclusionOptions.IncludeNone,     StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  StringInclusionOptions.IncludeNone,     StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       StringInclusionOptions.IncludeNone,     StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  StringInclusionOptions.IncludeNone,     StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       StringInclusionOptions.IncludeNone,     StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  StringInclusionOptions.IncludeNone,     StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       StringInclusionOptions.IncludeNone,     StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  StringInclusionOptions.IncludeNone,     StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       StringInclusionOptions.IncludeAll,      StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  StringInclusionOptions.IncludeAll,      StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       StringInclusionOptions.IncludeAll,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  StringInclusionOptions.IncludeAll,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       StringInclusionOptions.IncludeAll,      StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  StringInclusionOptions.IncludeAll,      StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       StringInclusionOptions.IncludeAll,      StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  StringInclusionOptions.IncludeAll,      StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       StringInclusionOptions.IncludeStart,    StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  StringInclusionOptions.IncludeStart,    StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       StringInclusionOptions.IncludeStart,    StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  StringInclusionOptions.IncludeStart,    StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       StringInclusionOptions.IncludeStart,    StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  StringInclusionOptions.IncludeStart,    StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       StringInclusionOptions.IncludeStart,    StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  StringInclusionOptions.IncludeStart,    StringComparison.OrdinalIgnoreCase)]
    
    [InlineData("Begin start start middle end end terminus.",                       StringInclusionOptions.IncludeEnd,      StringComparison.InvariantCulture)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  StringInclusionOptions.IncludeEnd,      StringComparison.InvariantCulture)]
    [InlineData("Begin START start middle END end terminus.",                       StringInclusionOptions.IncludeEnd,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  StringInclusionOptions.IncludeEnd,      StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin start start middle end end terminus.",                       StringInclusionOptions.IncludeEnd,      StringComparison.Ordinal)]
    [InlineData("Begin start filler start filler end filler end filler terminus.",  StringInclusionOptions.IncludeEnd,      StringComparison.Ordinal)]
    [InlineData("Begin START start middle END end terminus.",                       StringInclusionOptions.IncludeEnd,      StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin START filler start filler END filler end filler terminus.",  StringInclusionOptions.IncludeEnd,      StringComparison.OrdinalIgnoreCase)]
    
    #endregion Data
    public void SubstringLast_String_String_SetInclusion_SetComparison_AllStringsEmpty(string testString, StringInclusionOptions inclusionOptions, StringComparison comparison)
    {
        string expected = testString;
        string result = testString.SubstringLast("", "", inclusionOptions, comparison);

        Assert.Equal(expected, result);
    }


    #endregion Substring(this string str, string startString, string endString, StringInclusionOptions inclusionOptions = StringInclusionOptions.IncludeNone, StringComparison comparison = StringComparison.CurrentCulture)

    #region SubstringStart(this string str, string endString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    [Theory]
    [InlineData("His true character is starting to start show through.", "His true character is ")]
    [InlineData("Export of the product will start start soon.", "Export of the product will ")]
    [InlineData("I'm starting to start lose my patience.", "I'm ")]
    public void SubstringStart_String_DefaultInclusion_DefaultComparison(string testString, string expected)
    {
        string result = testString.SubstringStart("start");

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", "Begin ", StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", "Begin ", StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", "Begin ", StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", "Begin ", StringComparison.OrdinalIgnoreCase)]
    public void SubstringStart_String_DefaultInclusion_SetComparison(string testString, string expected, StringComparison stringComparison)
    {
        string result = testString.SubstringStart("mid", comparison: stringComparison);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", "Begin mid", true)]
    [InlineData("Begin mid and mid terminus.", "Begin ",    false)]
    public void SubstringStart_String_SetInclusion_DefaultComparison(string testString, string expected, bool include)
    {
        string result = testString.SubstringStart("mid", include);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", "Begin mid", true,  StringComparison.InvariantCulture)]
    [InlineData("Begin mid and mid terminus.", "Begin ",    false, StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", "Begin MID", true,  StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", "Begin ",    false, StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", "Begin mid", true,  StringComparison.Ordinal)]
    [InlineData("Begin mid and mid terminus.", "Begin ",    false, StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", "Begin MID", true,  StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", "Begin ",    false, StringComparison.OrdinalIgnoreCase)]
    public void SubstringStart_String_SetInclusion_SetComparison(string testString, string expected, bool include, StringComparison stringComparison)
    {
        string result = testString.SubstringStart("mid", include, stringComparison);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("His true character is starting to show through.")]
    [InlineData("Export of the product will start soon.")]
    [InlineData("I'm starting to lose my patience.")]
    public void SubstringStart_String_DefaultInclusion_DefaultComparison_EmptyString(string testString)
    {
        string expected = "";
        string result = testString.SubstringStart("");

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", StringComparison.OrdinalIgnoreCase)]
    public void SubstringStart_String_DefaultInclusion_SetComparison_EmptyString(string testString, StringComparison stringComparison)
    {
        string expected = "";
        string result = testString.SubstringStart("", comparison: stringComparison);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", true)]
    [InlineData("Begin mid and mid terminus.", false)]
    public void SubstringStart_String_SetInclusion_DefaultComparison_EmptyString(string testString, bool include)
    {
        string expected = "";
        string result = testString.SubstringStart("", include);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", true,  StringComparison.InvariantCulture)]
    [InlineData("Begin mid and mid terminus.", false, StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", true,  StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", false, StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", true,  StringComparison.Ordinal)]
    [InlineData("Begin mid and mid terminus.", false, StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", true,  StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", false, StringComparison.OrdinalIgnoreCase)]
    public void SubstringStart_String_SetInclusion_SetComparison_EmptyString(string testString, bool include, StringComparison stringComparison)
    {
        string expected = "";
        string result = testString.SubstringStart("", include, stringComparison);

        Assert.Equal(expected, result);
    }

    #endregion SubstringStart(this string str, string endString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    #region SubstringStartLast(this string str, string endString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    [Theory]
    [InlineData("His true character is starting to start show through.", "His true character is starting to ")]
    [InlineData("Export of the product will start start soon.", "Export of the product will start ")]
    [InlineData("I'm starting to start lose my patience.", "I'm starting to ")]
    public void SubstringStartLast_String_DefaultInclusion_DefaultComparison(string testString, string expected)
    {
        string result = testString.SubstringStartLast("start");

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", "Begin mid and ", StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", "Begin MID and ", StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", "Begin mid and ", StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", "Begin MID and ", StringComparison.OrdinalIgnoreCase)]
    public void SubstringStartLast_String_DefaultInclusion_SetComparison(string testString, string expected, StringComparison stringComparison)
    {
        string result = testString.SubstringStartLast("mid", comparison: stringComparison);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", "Begin mid and mid", true)]
    [InlineData("Begin mid and mid terminus.", "Begin mid and ", false)]
    public void SubstringStartLast_String_SetInclusion_DefaultComparison(string testString, string expected, bool include)
    {
        string result = testString.SubstringStartLast("mid", include);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", "Begin mid and mid", true,  StringComparison.InvariantCulture)]
    [InlineData("Begin mid and mid terminus.", "Begin mid and ",    false, StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", "Begin MID and MID", true,  StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", "Begin MID and ",    false, StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", "Begin mid and mid", true,  StringComparison.Ordinal)]
    [InlineData("Begin mid and mid terminus.", "Begin mid and ",    false, StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", "Begin MID and MID", true,  StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", "Begin MID and ",    false, StringComparison.OrdinalIgnoreCase)]
    public void SubstringStartLast_String_SetInclusion_SetComparison(string testString, string expected, bool include, StringComparison stringComparison)
    {
        string result = testString.SubstringStartLast("mid", include, stringComparison);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("His true character is starting to show through.")]
    [InlineData("Export of the product will start soon.")]
    [InlineData("I'm starting to lose my patience.")]
    public void SubstringStartLast_String_DefaultInclusion_DefaultComparison_EmptyString(string testString)
    {
        string expected = testString;
        string result = testString.SubstringStartLast("");

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", StringComparison.OrdinalIgnoreCase)]
    public void SubstringStartLast_String_DefaultInclusion_SetComparison_EmptyString(string testString, StringComparison stringComparison)
    {
        string expected = testString;
        string result = testString.SubstringStartLast("", comparison: stringComparison);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", true)]
    [InlineData("Begin mid and mid terminus.", false)]
    public void SubstringStartLast_String_SetInclusion_DefaultComparison_EmptyString(string testString, bool include)
    {
        string expected = testString;
        string result = testString.SubstringStartLast("", include);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", true,  StringComparison.InvariantCulture)]
    [InlineData("Begin mid and mid terminus.", false, StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", true,  StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", false, StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", true,  StringComparison.Ordinal)]
    [InlineData("Begin mid and mid terminus.", false, StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", true,  StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", false, StringComparison.OrdinalIgnoreCase)]
    public void SubstringStartLast_String_SetInclusion_SetComparison_EmptyString(string testString, bool include, StringComparison stringComparison)
    {
        string expected = testString;
        string result = testString.SubstringStartLast("", include, stringComparison);

        Assert.Equal(expected, result);
    }

    #endregion SubstringStartLast(this string str, string endString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    #region SubstringEnd(this string str, string startString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    [Theory]
    [InlineData("His true character is starting to start show through.", "ing to start show through.")]
    [InlineData("Export of the product will start start soon.", " start soon.")]
    [InlineData("I'm starting to start lose my patience.", "ing to start lose my patience.")]
    public void SubstringEnd_String_DefaultInclusion_DefaultComparison(string testString, string expected)
    {
        string result = testString.SubstringEnd("start");

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", " and mid terminus.", StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", " and MID terminus.", StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", " and mid terminus.", StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", " and MID terminus.", StringComparison.OrdinalIgnoreCase)]
    public void SubstringEnd_String_DefaultInclusion_SetComparison(string testString, string expected, StringComparison stringComparison)
    {
        string result = testString.SubstringEnd("mid", comparison: stringComparison);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", "mid and mid terminus.", true)]
    [InlineData("Begin mid and mid terminus.", " and mid terminus.", false)]
    public void SubstringEnd_String_SetInclusion_DefaultComparison(string testString, string expected, bool include)
    {
        string result = testString.SubstringEnd("mid", include);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", "mid and mid terminus.", true,  StringComparison.InvariantCulture)]
    [InlineData("Begin mid and mid terminus.", " and mid terminus.",    false, StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", "MID and MID terminus.", true,  StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", " and MID terminus.",    false, StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", "mid and mid terminus.", true,  StringComparison.Ordinal)]
    [InlineData("Begin mid and mid terminus.", " and mid terminus.",    false, StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", "MID and MID terminus.", true,  StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", " and MID terminus.",    false, StringComparison.OrdinalIgnoreCase)]
    public void SubstringEnd_String_SetInclusion_SetComparison(string testString, string expected, bool include, StringComparison stringComparison)
    {
        string result = testString.SubstringEnd("mid", include, stringComparison);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("His true character is starting to show through.")]
    [InlineData("Export of the product will start soon.")]
    [InlineData("I'm starting to lose my patience.")]
    public void SubstringEnd_String_DefaultInclusion_DefaultComparison_EmptyString(string testString)
    {
        string expected = testString;
        string result = testString.SubstringEnd("");

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", StringComparison.OrdinalIgnoreCase)]
    public void SubstringEnd_String_DefaultInclusion_SetComparison_EmptyString(string testString, StringComparison stringComparison)
    {
        string expected = testString;
        string result = testString.SubstringEnd("", comparison: stringComparison);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", true)]
    [InlineData("Begin mid and mid terminus.", false)]
    public void SubstringEnd_String_SetInclusion_DefaultComparison_EmptyString(string testString, bool include)
    {
        string expected = testString;
        string result = testString.SubstringEnd("", include);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", true, StringComparison.InvariantCulture)]
    [InlineData("Begin mid and mid terminus.", false, StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", true, StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", false, StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", true, StringComparison.Ordinal)]
    [InlineData("Begin mid and mid terminus.", false, StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", true, StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", false, StringComparison.OrdinalIgnoreCase)]
    public void SubstringEnd_String_SetInclusion_SetComparison_EmptyString(string testString, bool include, StringComparison stringComparison)
    {
        string expected = testString;
        string result = testString.SubstringEnd("", include, stringComparison);

        Assert.Equal(expected, result);
    }

    #endregion SubstringEnd(this string str, string startString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    #region SubstringEndLast(this string str, string startString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    [Theory]
    [InlineData("His true character is starting to start show through.", " show through.")]
    [InlineData("Export of the product will start start soon.", " soon.")]
    [InlineData("I'm starting to start lose my patience.", " lose my patience.")]
    public void SubstringEndLast_String_DefaultInclusion_DefaultComparison(string testString, string expected)
    {
        string result = testString.SubstringEndLast("start");

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", " terminus.", StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", " terminus.", StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", " terminus.", StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", " terminus.", StringComparison.OrdinalIgnoreCase)]
    public void SubstringEndLast_String_DefaultInclusion_SetComparison(string testString, string expected, StringComparison stringComparison)
    {
        string result = testString.SubstringEndLast("mid", comparison: stringComparison);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", "mid terminus.", true)]
    [InlineData("Begin mid and mid terminus.", " terminus.",    false)]
    public void SubstringEndLast_String_SetInclusion_DefaultComparison(string testString, string expected, bool include)
    {
        string result = testString.SubstringEndLast("mid", include);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", "mid terminus.", true,  StringComparison.InvariantCulture)]
    [InlineData("Begin mid and mid terminus.", " terminus.",    false, StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", "MID terminus.", true,  StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", " terminus.",    false, StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", "mid terminus.", true,  StringComparison.Ordinal)]
    [InlineData("Begin mid and mid terminus.", " terminus.",    false, StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", "MID terminus.", true,  StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", " terminus.",    false, StringComparison.OrdinalIgnoreCase)]
    public void SubstringEndLast_String_SetInclusion_SetComparison(string testString, string expected, bool include, StringComparison stringComparison)
    {
        string result = testString.SubstringEndLast("mid", include, stringComparison);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("His true character is starting to show through.")]
    [InlineData("Export of the product will start soon.")]
    [InlineData("I'm starting to lose my patience.")]
    public void SubstringEndLast_String_DefaultInclusion_DefaultComparison_EmptyString(string testString)
    {
        string expected = "";
        string result = testString.SubstringEndLast("");

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", StringComparison.OrdinalIgnoreCase)]
    public void SubstringEndLast_String_DefaultInclusion_SetComparison_EmptyString(string testString, StringComparison stringComparison)
    {
        string expected = "";
        string result = testString.SubstringEndLast("", comparison: stringComparison);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", true)]
    [InlineData("Begin mid and mid terminus.", false)]
    public void SubstringEndLast_String_SetInclusion_DefaultComparison_EmptyString(string testString, bool include)
    {
        string expected = "";
        string result = testString.SubstringEndLast("", include);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", true,  StringComparison.InvariantCulture)]
    [InlineData("Begin mid and mid terminus.", false, StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", true,  StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", false, StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", true,  StringComparison.Ordinal)]
    [InlineData("Begin mid and mid terminus.", false, StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", true,  StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", false, StringComparison.OrdinalIgnoreCase)]
    public void SubstringEndLast_String_SetInclusion_SetComparison_EmptyString(string testString, bool include, StringComparison stringComparison)
    {
        string expected = "";
        string result = testString.SubstringEndLast("", include, stringComparison);

        Assert.Equal(expected, result);
    }

    #endregion SubstringEndLast(this string str, string startString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    #region SubstringEndLast(this string str, string startString, int length, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    [Theory]
    [InlineData("His true character is starting to start show through.", " show ")]
    [InlineData("Export of the product will start start soon.", " soon.")]
    [InlineData("I'm starting to start lose my patience.", " lose ")]
    public void SubstringEndLast_String_Int_DefaultInclusion_DefaultComparison(string testString, string expected)
    {
        string result = testString.SubstringEndLast("start", 6);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", " terminus.", StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", " terminus.", StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", " terminus.", StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", " terminus.", StringComparison.OrdinalIgnoreCase)]
    public void SubstringEndLast_String_Int_DefaultInclusion_SetComparison(string testString, string expected, StringComparison stringComparison)
    {
        string result = testString.SubstringEndLast("mid", 10, comparison: stringComparison);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", "mid terminus.", true)]
    [InlineData("Begin mid and mid terminus.", " terminus.",    false)]
    public void SubstringEndLast_String_Int_SetInclusion_DefaultComparison(string testString, string expected, bool include)
    {
        string result = testString.SubstringEndLast("mid", 10, include);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", "mid terminus.", true,  StringComparison.InvariantCulture)]
    [InlineData("Begin mid and mid terminus.", " terminus.",    false, StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", "MID terminus.", true,  StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", " terminus.",    false, StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", "mid terminus.", true,  StringComparison.Ordinal)]
    [InlineData("Begin mid and mid terminus.", " terminus.",    false, StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", "MID terminus.", true,  StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", " terminus.",    false, StringComparison.OrdinalIgnoreCase)]
    public void SubstringEndLast_String_Int_SetInclusion_SetComparison(string testString, string expected, bool include, StringComparison stringComparison)
    {
        string result = testString.SubstringEndLast("mid", 10, include, stringComparison);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("His true character is starting to show through.")]
    [InlineData("Export of the product will start soon.")]
    [InlineData("I'm starting to lose my patience.")]
    public void SubstringEndLast_String_Int_DefaultInclusion_DefaultComparison_EmptyString(string testString)
    {
        string expected = "";
        string result = testString.SubstringEndLast("", 0);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", StringComparison.OrdinalIgnoreCase)]
    public void SubstringEndLast_String_Int_DefaultInclusion_SetComparison_EmptyString(string testString, StringComparison stringComparison)
    {
        string expected = "";
        string result = testString.SubstringEndLast("", 0, comparison: stringComparison);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", true)]
    [InlineData("Begin mid and mid terminus.", false)]
    public void SubstringEndLast_String_Int_SetInclusion_DefaultComparison_EmptyString(string testString, bool include)
    {
        string expected = "";
        string result = testString.SubstringEndLast("", 0, include);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Begin mid and mid terminus.", true,  StringComparison.InvariantCulture)]
    [InlineData("Begin mid and mid terminus.", false, StringComparison.InvariantCulture)]
    [InlineData("Begin MID and MID terminus.", true,  StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", false, StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Begin mid and mid terminus.", true,  StringComparison.Ordinal)]
    [InlineData("Begin mid and mid terminus.", false, StringComparison.Ordinal)]
    [InlineData("Begin MID and MID terminus.", true,  StringComparison.OrdinalIgnoreCase)]
    [InlineData("Begin MID and MID terminus.", false, StringComparison.OrdinalIgnoreCase)]
    public void SubstringEndLast_String_Int_SetInclusion_SetComparison_EmptyString(string testString, bool include, StringComparison stringComparison)
    {
        string expected = "";
        string result = testString.SubstringEndLast("", 0, include, stringComparison);

        Assert.Equal(expected, result);
    }

    #endregion SubstringEndLast(this string str, string startString, int length, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)
}
