using System;
using System.Collections.Generic;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Contains_Tests
{
    #region bool Contains(this string str, IEnumerable<string> keywords, StringComparison comparison)

    [Theory, MemberData(nameof(Data_Contains_IEnumString_DefaultComparison_Pass))]
    public void Contains_IEnumString_DefaultComparison_Pass(string testString, IEnumerable<string> keywords)
    {
        bool actual = testString.ContainsAny(keywords);

        Assert.True(actual);
    }

    [Theory, MemberData(nameof(Data_Contains_IEnumString_DefaultComparison_Fail))]
    public void Contains_IEnumString_DefaultComparison_Fail(string testString, IEnumerable<string> keywords)
    {
        bool actual = testString.ContainsAny(keywords);

        Assert.False(actual);
    }

    [Theory, MemberData(nameof(Data_Contains_IEnumString_SetComparison_Pass))]
    public void Contains_IEnumString_SetComparison_Pass(string testString, IEnumerable<string> keywords, StringComparison stringComparison)
    {
        bool actual = testString.ContainsAny(keywords, stringComparison);

        Assert.True(actual);
    }

    [Theory, MemberData(nameof(Data_Contains_IEnumString_SetComparison_Fail))]
    public void Contains_IEnumString_SetComparison_Fail(string testString, IEnumerable<string> keywords, StringComparison stringComparison)
    {
        bool actual = testString.ContainsAny(keywords, stringComparison);

        Assert.False(actual);
    }

    #endregion bool Contains(this string str, IEnumerable<string> keywords, StringComparison comparison)

    #region bool Contains(this string str, IEnumerable<char> keychars, StringComparison comparison)

    [Theory, MemberData(nameof(Data_Contains_IEnumChar_DefaultComparison_Pass))]
    public void Contains_IEnumChar_DefaultComparison_Pass(string testString, IEnumerable<char> keychars)
    {
        bool actual = testString.ContainsAny(keychars);

        Assert.True(actual);
    }

    [Theory, MemberData(nameof(Data_Contains_IEnumChar_DefaultComparison_Fail))]
    public void Contains_IEnumChar_DefaultComparison_Fail(string testString, IEnumerable<char> keychars)
    {
        bool actual = testString.ContainsAny(keychars);

        Assert.False(actual);
    }

    [Theory, MemberData(nameof(Data_Contains_IEnumChar_SetComparison_Pass))]
    public void Contains_IEnumChar_SetComparison_Pass(string testString, IEnumerable<char> keychars, StringComparison stringComparison)
    {
        bool actual = testString.ContainsAny(keychars, stringComparison);

        Assert.True(actual);
    }

    [Theory, MemberData(nameof(Data_Contains_IEnumChar_SetComparison_Fail))]
    public void Contains_IEnumChar_SetComparison_Fail(string testString, IEnumerable<char> keychars, StringComparison stringComparison)
    {
        bool actual = testString.ContainsAny(keychars, stringComparison);

        Assert.False(actual);
    }

    #endregion bool Contains(this string str, IEnumerable<char> keychars, StringComparison comparison)

    #region IEnumerable test data

    public static IEnumerable<object[]> Data_Contains_IEnumString_DefaultComparison_Pass => new[]
            {
                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "case", "dummy", "dummy" } },
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "encyclopædia", "dummy", "dummy" } },
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "Archæology", "dummy", "dummy" } },
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "dummy", "case", "encyclopædia", "Archæology" }) }
            };

    public static IEnumerable<object[]> Data_Contains_IEnumString_DefaultComparison_Fail => new[]
            {
                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "Case", "encyclopaedia", "ARCHÆOLOGY" } },
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "Case", "encyclopaedia", "ARCHÆOLOGY" } },
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "Case", "encyclopaedia", "ARCHÆOLOGY" } },
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "dummy", "Case", "encyclopaedia", "ARCHÆOLOGY" }) }
            };

    public static IEnumerable<object[]> Data_Contains_IEnumString_SetComparison_Pass => new[]
            {
                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "case", "dummy" }, GlobalVariables.InvariantCulture},
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "encyclopædia", "dummy" }, GlobalVariables.InvariantCulture},
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "Archæology", "dummy" }, GlobalVariables.InvariantCulture},
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), GlobalVariables.InvariantCulture},

                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "Case", "dummy" }, GlobalVariables.InvariantCultureIgnoreCase},
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "encyclopædiA", "dummy" }, GlobalVariables.InvariantCultureIgnoreCase},
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, GlobalVariables.InvariantCultureIgnoreCase},
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "Case", "encyclopædiA", "ARCHÆOLOGY" }), GlobalVariables.InvariantCultureIgnoreCase},

                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "case", "dummy" }, GlobalVariables.Ordinal},
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "encyclopædia", "dummy" }, GlobalVariables.Ordinal},
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "Archæology", "dummy" }, GlobalVariables.Ordinal},
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), GlobalVariables.Ordinal},

                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "Case", "dummy" }, GlobalVariables.OrdinalIgnoreCase},
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "encyclopædiA", "dummy" }, GlobalVariables.OrdinalIgnoreCase},
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, GlobalVariables.OrdinalIgnoreCase},
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "Case", "encyclopædiA", "ARCHÆOLOGY" }), GlobalVariables.OrdinalIgnoreCase}
            };

    public static IEnumerable<object[]> Data_Contains_IEnumString_SetComparison_Fail => new[]
            {
                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "Case", "dummy" }, GlobalVariables.InvariantCulture},
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "encyclopaedia", "dummy" }, GlobalVariables.InvariantCulture},
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, GlobalVariables.InvariantCulture},
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "Case", "encyclopaedia", "ARCHÆOLOGY" }), GlobalVariables.InvariantCulture},

                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "Kase", "dummy" }, GlobalVariables.InvariantCultureIgnoreCase},
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "encyclopaedia", "dummy" }, GlobalVariables.InvariantCultureIgnoreCase},
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "ARCHAEOLOGY", "dummy" }, GlobalVariables.InvariantCultureIgnoreCase},
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "Kase", "encyclopaedia", "ARCHAEOLOGY" }), GlobalVariables.InvariantCultureIgnoreCase},

                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "Case", "dummy" }, GlobalVariables.Ordinal},
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "encyclopaedia", "dummy" }, GlobalVariables.Ordinal},
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, GlobalVariables.Ordinal},
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "Case", "encyclopaedia", "ARCHÆOLOGY" }), GlobalVariables.Ordinal},

                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "Kase", "dummy" }, GlobalVariables.OrdinalIgnoreCase},
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "encyclopaedia", "dummy" }, GlobalVariables.OrdinalIgnoreCase},
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "Archaeology", "dummy" }, GlobalVariables.OrdinalIgnoreCase},
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "Kase", "encyclopaedia", "Archaeology" }), GlobalVariables.OrdinalIgnoreCase}
            };

    public static IEnumerable<object[]> Data_Contains_IEnumChar_DefaultComparison_Pass => new[]
            {
                new object[] { "char", new char[] { 'c', 'z', 'z', 'z' } },
                new object[] { "char", new List<char>() { 'z', 'h', 'z', 'z' } },
                new object[] { "char", new HashSet<char>() { 'z', 'z', 'a', 'z' } },
                new object[] { "char", new Queue<char>(new char[] { 'z', 'z', 'z', 'r' }) }
            };

    public static IEnumerable<object[]> Data_Contains_IEnumChar_DefaultComparison_Fail => new[]
            {
                new object[] { "char", new char[] { 'C', 'z', 'z', 'z' } },
                new object[] { "char", new List<char>() { 'z', 'H', 'z', 'z' } },
                new object[] { "char", new HashSet<char>() { 'z', 'z', 'A', 'z' } },
                new object[] { "char", new Queue<char>(new char[] { 'z', 'z', 'z', 'R' }) }
            };

    // The comments denote what is the code for the character preceding them as visually they are very similar.
    public static IEnumerable<object[]> Data_Contains_IEnumChar_SetComparison_Pass => new[]
            {
                new object[] { "i" /* (U+0069) */, new char[] { 'i' /* (U+0069) */, 'z', 'z', 'z' }, GlobalVariables.InvariantCulture },
                new object[] { "i" /* (U+0069) */, new List<char>() { 'z', 'i' /* (U+0069) */, 'z', 'z' }, GlobalVariables.InvariantCulture },
                new object[] { "i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'i' /* (U+0069) */, 'z' }, GlobalVariables.InvariantCulture },
                new object[] { "i" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'i' /* (U+0069) */ }), GlobalVariables.InvariantCulture },

                new object[] { "i" /* (U+0069) */, new char[] { 'I' /* (U+0049) */, 'z', 'z', 'z' }, GlobalVariables.InvariantCultureIgnoreCase },
                new object[] { "i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, GlobalVariables.InvariantCultureIgnoreCase },
                new object[] { "i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, GlobalVariables.InvariantCultureIgnoreCase },
                new object[] { "i" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'I' /* (U+0049) */ }), GlobalVariables.InvariantCultureIgnoreCase },

                new object[] { "i" /* (U+0069) */, new char[] { 'i' /* (U+0069) */, 'z', 'z', 'z' }, GlobalVariables.Ordinal },
                new object[] { "i" /* (U+0069) */, new List<char>() { 'z', 'i' /* (U+0069) */, 'z', 'z' }, GlobalVariables.Ordinal },
                new object[] { "i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'i' /* (U+0069) */, 'z' }, GlobalVariables.Ordinal },
                new object[] { "i" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'i' /* (U+0069) */ }), GlobalVariables.Ordinal },

                new object[] { "i" /* (U+0069) */, new char[] { 'I' /* (U+0049) */, 'z', 'z', 'z' }, GlobalVariables.OrdinalIgnoreCase },
                new object[] { "i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, GlobalVariables.OrdinalIgnoreCase },
                new object[] { "i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, GlobalVariables.OrdinalIgnoreCase },
                new object[] { "i" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'I' /* (U+0049) */ }), GlobalVariables.OrdinalIgnoreCase },
            };

    // The comments denote what is the code for the character preceding them as visually they are very similar.
    public static IEnumerable<object[]> Data_Contains_IEnumChar_SetComparison_Fail => new[]
            {
                new object[] { "i" /* (U+0069) */, new char[] { 'ı' /* (U+0131) */, 'z', 'z', 'z' }, GlobalVariables.InvariantCulture },
                new object[] { "i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, GlobalVariables.InvariantCulture },
                new object[] { "I" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, GlobalVariables.InvariantCulture },
                new object[] { "i" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'I' /* (U+0049) */ }), GlobalVariables.InvariantCulture },

                new object[] { "i" /* (U+0069) */, new char[] { 'ı' /* (U+0131) */, 'z', 'z', 'z' }, GlobalVariables.InvariantCultureIgnoreCase },
                new object[] { "i" /* (U+0069) */, new List<char>() { 'z', 'ı' /* (U+0131) */, 'z', 'z' }, GlobalVariables.InvariantCultureIgnoreCase },
                new object[] { "i" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, GlobalVariables.InvariantCultureIgnoreCase },
                new object[] { "i" /* (U+0049) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'ı' /* (U+0131) */ }), GlobalVariables.InvariantCultureIgnoreCase },

                new object[] { "i" /* (U+0069) */, new char[] { 'ı' /* (U+0131) */, 'z', 'z', 'z' }, GlobalVariables.Ordinal },
                new object[] { "i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, GlobalVariables.Ordinal },
                new object[] { "I" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, GlobalVariables.Ordinal },
                new object[] { "i" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'I' /* (U+0049) */ }), GlobalVariables.Ordinal },

                new object[] { "i" /* (U+0069) */, new char[] { 'ı' /* (U+0131) */, 'z', 'z', 'z' }, GlobalVariables.OrdinalIgnoreCase },
                new object[] { "i" /* (U+0069) */, new List<char>() { 'z', 'ı' /* (U+0131) */, 'z', 'z' }, GlobalVariables.OrdinalIgnoreCase },
                new object[] { "I" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, GlobalVariables.OrdinalIgnoreCase },
                new object[] { "I" /* (U+0049) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'ı' /* (U+0131) */ }), GlobalVariables.OrdinalIgnoreCase },
            };

    #endregion IEnumerable test data
}
