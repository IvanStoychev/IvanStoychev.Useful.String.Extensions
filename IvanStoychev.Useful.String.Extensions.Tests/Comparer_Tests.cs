using System;
using System.Collections.Generic;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Comparer_Tests
{
    #region bool Contains(this string str, IEnumerable<string> keywords, StringComparison comparison)

    [Theory, MemberData(nameof(Data_Contains_IEnumString_DefaultComparison_Pass))]
    public void Contains_IEnumString_DefaultComparison_Pass(string testString, IEnumerable<string> keywords)
    {
        bool actual = testString.Contains(keywords);

        Assert.True(actual);
    }

    [Theory, MemberData(nameof(Data_Contains_IEnumString_DefaultComparison_Fail))]
    public void Contains_IEnumString_DefaultComparison_Fail(string testString, IEnumerable<string> keywords)
    {
        bool actual = testString.Contains(keywords);

        Assert.False(actual);
    }

    [Theory, MemberData(nameof(Data_Contains_IEnumString_SetComparison_Pass))]
    public void Contains_IEnumString_SetComparison_Pass(string testString, IEnumerable<string> keywords, StringComparison stringComparison)
    {
        bool actual = testString.Contains(keywords, stringComparison);

        Assert.True(actual);
    }

    [Theory, MemberData(nameof(Data_Contains_IEnumString_SetComparison_Fail))]
    public void Contains_IEnumString_SetComparison_Fail(string testString, IEnumerable<string> keywords, StringComparison stringComparison)
    {
        bool actual = testString.Contains(keywords, stringComparison);

        Assert.False(actual);
    }

    #endregion bool Contains(this string str, IEnumerable<string> keywords, StringComparison comparison)

    #region bool Contains(this string str, IEnumerable<char> keychars, StringComparison comparison)

    [Theory, MemberData(nameof(Data_Contains_IEnumChar_DefaultComparison_Pass))]
    public void Contains_IEnumChar_DefaultComparison_Pass(string testString, IEnumerable<char> keychars)
    {
        bool actual = testString.Contains(keychars);

        Assert.True(actual);
    }

    [Theory, MemberData(nameof(Data_Contains_IEnumChar_DefaultComparison_Fail))]
    public void Contains_IEnumChar_DefaultComparison_Fail(string testString, IEnumerable<char> keychars)
    {
        bool actual = testString.Contains(keychars);

        Assert.False(actual);
    }

    [Theory, MemberData(nameof(Data_Contains_IEnumChar_SetComparison_Pass))]
    public void Contains_IEnumChar_SetComparison_Pass(string testString, IEnumerable<char> keychars, StringComparison stringComparison)
    {
        bool actual = testString.Contains(keychars, stringComparison);

        Assert.True(actual);
    }

    [Theory, MemberData(nameof(Data_Contains_IEnumChar_SetComparison_Fail))]
    public void Contains_IEnumChar_SetComparison_Fail(string testString, IEnumerable<char> keychars, StringComparison stringComparison)
    {
        bool actual = testString.Contains(keychars, stringComparison);

        Assert.False(actual);
    }

    #endregion bool Contains(this string str, IEnumerable<char> keychars, StringComparison comparison)

    #region IEnumerable test data

    public static IEnumerable<object[]> Data_Contains_IEnumString_DefaultComparison_Pass
    {
        get
        {
            return new[]
            {
                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "case", "dummy", "dummy" } },
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "encyclopædia", "dummy", "dummy" } },
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "Archæology", "dummy", "dummy" } },
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "dummy", "case", "encyclopædia", "Archæology" }) }
            };
        }
    }

    public static IEnumerable<object[]> Data_Contains_IEnumString_DefaultComparison_Fail
    {
        get
        {
            return new[]
            {
                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "Case", "encyclopaedia", "ARCHÆOLOGY" } },
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "Case", "encyclopaedia", "ARCHÆOLOGY" } },
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "Case", "encyclopaedia", "ARCHÆOLOGY" } },
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "dummy", "Case", "encyclopaedia", "ARCHÆOLOGY" }) }
            };
        }
    }

    public static IEnumerable<object[]> Data_Contains_IEnumString_SetComparison_Pass
    {
        get
        {
            return new[]
            {
                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "case", "dummy" }, StringComparison.InvariantCulture},
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "encyclopædia", "dummy" }, StringComparison.InvariantCulture},
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "Archæology", "dummy" }, StringComparison.InvariantCulture},
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), StringComparison.InvariantCulture},

                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "Case", "dummy" }, StringComparison.InvariantCultureIgnoreCase},
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "encyclopædiA", "dummy" }, StringComparison.InvariantCultureIgnoreCase},
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, StringComparison.InvariantCultureIgnoreCase},
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "Case", "encyclopædiA", "ARCHÆOLOGY" }), StringComparison.InvariantCultureIgnoreCase},

                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "case", "dummy" }, StringComparison.Ordinal},
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "encyclopædia", "dummy" }, StringComparison.Ordinal},
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "Archæology", "dummy" }, StringComparison.Ordinal},
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), StringComparison.Ordinal},

                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "Case", "dummy" }, StringComparison.OrdinalIgnoreCase},
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "encyclopædiA", "dummy" }, StringComparison.OrdinalIgnoreCase},
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, StringComparison.OrdinalIgnoreCase},
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "Case", "encyclopædiA", "ARCHÆOLOGY" }), StringComparison.OrdinalIgnoreCase}
            };
        }
    }

    public static IEnumerable<object[]> Data_Contains_IEnumString_SetComparison_Fail
    {
        get
        {
            return new[]
            {
                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "Case", "dummy" }, StringComparison.InvariantCulture},
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "encyclopaedia", "dummy" }, StringComparison.InvariantCulture},
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, StringComparison.InvariantCulture},
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "Case", "encyclopaedia", "ARCHÆOLOGY" }), StringComparison.InvariantCulture},

                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "Kase", "dummy" }, StringComparison.InvariantCultureIgnoreCase},
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "encyclopaedia", "dummy" }, StringComparison.InvariantCultureIgnoreCase},
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "ARCHAEOLOGY", "dummy" }, StringComparison.InvariantCultureIgnoreCase},
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "Kase", "encyclopaedia", "ARCHAEOLOGY" }), StringComparison.InvariantCultureIgnoreCase},

                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "Case", "dummy" }, StringComparison.Ordinal},
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "encyclopaedia", "dummy" }, StringComparison.Ordinal},
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, StringComparison.Ordinal},
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "Case", "encyclopaedia", "ARCHÆOLOGY" }), StringComparison.Ordinal},

                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "Kase", "dummy" }, StringComparison.OrdinalIgnoreCase},
                new object[] { "case encyclopædia Archæology", new List<string>() { "dummy", "encyclopaedia", "dummy" }, StringComparison.OrdinalIgnoreCase},
                new object[] { "case encyclopædia Archæology", new HashSet<string>() { "dummy", "Archaeology", "dummy" }, StringComparison.OrdinalIgnoreCase},
                new object[] { "case encyclopædia Archæology", new Queue<string>(new string[] { "Kase", "encyclopaedia", "Archaeology" }), StringComparison.OrdinalIgnoreCase}
            };
        }
    }

    public static IEnumerable<object[]> Data_Contains_IEnumChar_DefaultComparison_Pass
    {
        get
        {
            return new[]
            {
                new object[] { "char", new char[] { 'c', 'z', 'z', 'z' } },
                new object[] { "char", new List<char>() { 'z', 'h', 'z', 'z' } },
                new object[] { "char", new HashSet<char>() { 'z', 'z', 'a', 'z' } },
                new object[] { "char", new Queue<char>(new char[] { 'z', 'z', 'z', 'r' }) }
            };
        }
    }

    public static IEnumerable<object[]> Data_Contains_IEnumChar_DefaultComparison_Fail
    {
        get
        {
            return new[]
            {
                new object[] { "char", new char[] { 'C', 'z', 'z', 'z' } },
                new object[] { "char", new List<char>() { 'z', 'H', 'z', 'z' } },
                new object[] { "char", new HashSet<char>() { 'z', 'z', 'A', 'z' } },
                new object[] { "char", new Queue<char>(new char[] { 'z', 'z', 'z', 'R' }) }
            };
        }
    }

    public static IEnumerable<object[]> Data_Contains_IEnumChar_SetComparison_Pass
    {
        get
        {
            return new[]
            {
                new object[] { "i" /* (U+0069) */, new char[] { 'i' /* (U+0069) */, 'z', 'z', 'z' }, StringComparison.InvariantCulture },
                new object[] { "i" /* (U+0069) */, new List<char>() { 'z', 'i' /* (U+0069) */, 'z', 'z' }, StringComparison.InvariantCulture },
                new object[] { "i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'i' /* (U+0069) */, 'z' }, StringComparison.InvariantCulture },
                new object[] { "i" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'i' /* (U+0069) */ }), StringComparison.InvariantCulture },

                new object[] { "i" /* (U+0069) */, new char[] { 'I' /* (U+0049) */, 'z', 'z', 'z' }, StringComparison.InvariantCultureIgnoreCase },
                new object[] { "i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, StringComparison.InvariantCultureIgnoreCase },
                new object[] { "i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, StringComparison.InvariantCultureIgnoreCase },
                new object[] { "i" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'I' /* (U+0049) */ }), StringComparison.InvariantCultureIgnoreCase },

                new object[] { "i" /* (U+0069) */, new char[] { 'i' /* (U+0069) */, 'z', 'z', 'z' }, StringComparison.Ordinal },
                new object[] { "i" /* (U+0069) */, new List<char>() { 'z', 'i' /* (U+0069) */, 'z', 'z' }, StringComparison.Ordinal },
                new object[] { "i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'i' /* (U+0069) */, 'z' }, StringComparison.Ordinal },
                new object[] { "i" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'i' /* (U+0069) */ }), StringComparison.Ordinal },

                new object[] { "i" /* (U+0069) */, new char[] { 'I' /* (U+0049) */, 'z', 'z', 'z' }, StringComparison.OrdinalIgnoreCase },
                new object[] { "i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, StringComparison.OrdinalIgnoreCase },
                new object[] { "i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, StringComparison.OrdinalIgnoreCase },
                new object[] { "i" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'I' /* (U+0049) */ }), StringComparison.OrdinalIgnoreCase },
            };
        }
    }

    public static IEnumerable<object[]> Data_Contains_IEnumChar_SetComparison_Fail
    {
        get
        {
            return new[]
            {
                new object[] { "i" /* (U+0069) */, new char[] { 'ı' /* (U+0131) */, 'z', 'z', 'z' }, StringComparison.InvariantCulture },
                new object[] { "i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, StringComparison.InvariantCulture },
                new object[] { "I" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, StringComparison.InvariantCulture },
                new object[] { "i" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'I' /* (U+0049) */ }), StringComparison.InvariantCulture },

                new object[] { "i" /* (U+0069) */, new char[] { 'ı' /* (U+0131) */, 'z', 'z', 'z' }, StringComparison.InvariantCultureIgnoreCase },
                new object[] { "i" /* (U+0069) */, new List<char>() { 'z', 'ı' /* (U+0131) */, 'z', 'z' }, StringComparison.InvariantCultureIgnoreCase },
                new object[] { "i" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, StringComparison.InvariantCultureIgnoreCase },
                new object[] { "i" /* (U+0049) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'ı' /* (U+0131) */ }), StringComparison.InvariantCultureIgnoreCase },

                new object[] { "i" /* (U+0069) */, new char[] { 'ı' /* (U+0131) */, 'z', 'z', 'z' }, StringComparison.Ordinal },
                new object[] { "i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, StringComparison.Ordinal },
                new object[] { "I" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, StringComparison.Ordinal },
                new object[] { "i" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'I' /* (U+0049) */ }), StringComparison.Ordinal },

                new object[] { "i" /* (U+0069) */, new char[] { 'ı' /* (U+0131) */, 'z', 'z', 'z' }, StringComparison.OrdinalIgnoreCase },
                new object[] { "i" /* (U+0069) */, new List<char>() { 'z', 'ı' /* (U+0131) */, 'z', 'z' }, StringComparison.OrdinalIgnoreCase },
                new object[] { "I" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, StringComparison.OrdinalIgnoreCase },
                new object[] { "I" /* (U+0049) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'ı' /* (U+0131) */ }), StringComparison.OrdinalIgnoreCase },
            };
        }
    }

    #endregion IEnumerable test data
}
