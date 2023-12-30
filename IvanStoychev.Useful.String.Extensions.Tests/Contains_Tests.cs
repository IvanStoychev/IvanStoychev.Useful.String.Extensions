using System;
using System.Collections.Generic;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Contains_Tests
{
    #region ContainsAny(this string str, IEnumerable<string> keywords, StringComparison comparison)


    [Theory, MemberData(nameof(Data_ContainsAny_IEnumString_DefaultComparison_Pass))]
    public void ContainsAny_IEnumString_DefaultComparison_Pass(string testString, IEnumerable<string> keywords)
    {
        bool actual = testString.ContainsAny(keywords);

        Assert.True(actual);
    }


    [Theory, MemberData(nameof(Data_ContainsAny_IEnumString_DefaultComparison_Fail))]
    public void ContainsAny_IEnumString_DefaultComparison_Fail(string testString, IEnumerable<string> keywords)
    {
        bool actual = testString.ContainsAny(keywords);

        Assert.False(actual);
    }


    [Theory, MemberData(nameof(Data_ContainsAny_IEnumString_SetComparison_Pass))]
    public void ContainsAny_IEnumString_SetComparison_Pass(string testString, IEnumerable<string> keywords, StringComparison stringComparison)
    {
        bool actual = testString.ContainsAny(keywords, stringComparison);

        Assert.True(actual);
    }


    [Theory, MemberData(nameof(Data_ContainsAny_IEnumString_SetComparison_Fail))]
    public void ContainsAny_IEnumString_SetComparison_Fail(string testString, IEnumerable<string> keywords, StringComparison stringComparison)
    {
        bool actual = testString.ContainsAny(keywords, stringComparison);

        Assert.False(actual);
    }


    #endregion ContainsAny(this string str, IEnumerable<string> keywords, StringComparison comparison)

    #region ContainsAny(this string str, IEnumerable<char> keychars, StringComparison comparison)


    [Theory, MemberData(nameof(Data_ContainsAny_IEnumChar_DefaultComparison_Pass))]
    public void ContainsAny_IEnumChar_DefaultComparison_Pass(string testString, IEnumerable<char> keychars)
    {
        bool actual = testString.ContainsAny(keychars);

        Assert.True(actual);
    }


    [Theory, MemberData(nameof(Data_ContainsAny_IEnumChar_DefaultComparison_Fail))]
    public void ContainsAny_IEnumChar_DefaultComparison_Fail(string testString, IEnumerable<char> keychars)
    {
        bool actual = testString.ContainsAny(keychars);

        Assert.False(actual);
    }


    [Theory, MemberData(nameof(Data_ContainsAny_IEnumChar_SetComparison_Pass))]
    public void ContainsAny_IEnumChar_SetComparison_Pass(string testString, IEnumerable<char> keychars, StringComparison stringComparison)
    {
        bool actual = testString.ContainsAny(keychars, stringComparison);

        Assert.True(actual);
    }


    [Theory, MemberData(nameof(Data_ContainsAny_IEnumChar_SetComparison_Fail))]
    public void ContainsAny_IEnumChar_SetComparison_Fail(string testString, IEnumerable<char> keychars, StringComparison stringComparison)
    {
        bool actual = testString.ContainsAny(keychars, stringComparison);

        Assert.False(actual);
    }


    #endregion ContainsAny(this string str, IEnumerable<char> keychars, StringComparison comparison)

    #region ContainsAll(this string str, IEnumerable<string> keywords, StringComparison comparison)


    [Theory, MemberData(nameof(Data_ContainsAll_IEnumString_DefaultComparison_Pass))]
    public void ContainsAll_IEnumString_DefaultComparison_Pass(string testString, IEnumerable<string> keywords)
    {
        bool actual = testString.ContainsAll(keywords);

        Assert.True(actual);
    }


    [Theory, MemberData(nameof(Data_ContainsAll_IEnumString_SetComparison_Pass))]
    public void ContainsAll_IEnumString_SetComparison_Pass(string testString, IEnumerable<string> keywords, StringComparison stringComparison)
    {
        bool actual = testString.ContainsAll(keywords, stringComparison);

        Assert.True(actual);
    }


    #endregion ContainsAll(this string str, IEnumerable<string> keywords, StringComparison comparison)

    #region ContainsAll(this string str, IEnumerable<char> keychars, StringComparison comparison)


    [Theory, MemberData(nameof(Data_ContainsAll_IEnumChar_DefaultComparison_Pass))]
    public void ContainsAll_IEnumChar_DefaultComparison_Pass(string testString, IEnumerable<char> keychars)
    {
        bool actual = testString.ContainsAll(keychars);

        Assert.True(actual);
    }


    [Theory, MemberData(nameof(Data_ContainsAll_IEnumChar_SetComparison_Pass))]
    public void ContainsAll_IEnumChar_SetComparison_Pass(string testString, IEnumerable<char> keychars, StringComparison stringComparison)
    {
        bool actual = testString.ContainsAll(keychars, stringComparison);

        Assert.True(actual);
    }


    #endregion ContainsAll(this string str, IEnumerable<char> keychars, StringComparison comparison)

    #region IEnumerable test data

    public static IEnumerable<object[]> Data_ContainsAny_IEnumString_DefaultComparison_Pass => new[]
            {
                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "case", "dummy", "dummy" } },
                ["case encyclopædia Archæology", new List<string>() { "dummy", "encyclopædia", "dummy", "dummy" }],
                ["case encyclopædia Archæology", new HashSet<string>() { "dummy", "Archæology", "dummy", "dummy" }],
                ["case encyclopædia Archæology", new Queue<string>(new string[] { "dummy", "case", "encyclopædia", "Archæology" })]
            };

    public static IEnumerable<object[]> Data_ContainsAny_IEnumString_DefaultComparison_Fail => new[]
            {
                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "Case", "encyclopaedia", "ARCHÆOLOGY" } },
                ["case encyclopædia Archæology", new List<string>() { "dummy", "Case", "encyclopaedia", "ARCHÆOLOGY" }],
                ["case encyclopædia Archæology", new HashSet<string>() { "dummy", "Case", "encyclopaedia", "ARCHÆOLOGY" }],
                ["case encyclopædia Archæology", new Queue<string>(new string[] { "dummy", "Case", "encyclopaedia", "ARCHÆOLOGY" })]
            };

    public static IEnumerable<object[]> Data_ContainsAny_IEnumString_SetComparison_Pass => new[]
            {
                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "case", "dummy" }, GlobalVariables.InvariantCulture},
                ["case encyclopædia Archæology", new List<string>() { "dummy", "encyclopædia", "dummy" }, GlobalVariables.InvariantCulture],
                ["case encyclopædia Archæology", new HashSet<string>() { "dummy", "Archæology", "dummy" }, GlobalVariables.InvariantCulture],
                ["case encyclopædia Archæology", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), GlobalVariables.InvariantCulture],

                ["case encyclopædia Archæology", new string[] { "dummy", "Case", "dummy" }, GlobalVariables.InvariantCultureIgnoreCase],
                ["case encyclopædia Archæology", new List<string>() { "dummy", "encyclopædiA", "dummy" }, GlobalVariables.InvariantCultureIgnoreCase],
                ["case encyclopædia Archæology", new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, GlobalVariables.InvariantCultureIgnoreCase],
                ["case encyclopædia Archæology", new Queue<string>(new string[] { "Case", "encyclopædiA", "ARCHÆOLOGY" }), GlobalVariables.InvariantCultureIgnoreCase],

                ["case encyclopædia Archæology", new string[] { "dummy", "case", "dummy" }, GlobalVariables.Ordinal],
                ["case encyclopædia Archæology", new List<string>() { "dummy", "encyclopædia", "dummy" }, GlobalVariables.Ordinal],
                ["case encyclopædia Archæology", new HashSet<string>() { "dummy", "Archæology", "dummy" }, GlobalVariables.Ordinal],
                ["case encyclopædia Archæology", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), GlobalVariables.Ordinal],

                ["case encyclopædia Archæology", new string[] { "dummy", "Case", "dummy" }, GlobalVariables.OrdinalIgnoreCase],
                ["case encyclopædia Archæology", new List<string>() { "dummy", "encyclopædiA", "dummy" }, GlobalVariables.OrdinalIgnoreCase],
                ["case encyclopædia Archæology", new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, GlobalVariables.OrdinalIgnoreCase],
                ["case encyclopædia Archæology", new Queue<string>(new string[] { "Case", "encyclopædiA", "ARCHÆOLOGY" }), GlobalVariables.OrdinalIgnoreCase]
            };

    public static IEnumerable<object[]> Data_ContainsAny_IEnumString_SetComparison_Fail => new[]
            {
                new object[] { "case encyclopædia Archæology", new string[] { "dummy", "Case", "dummy" }, GlobalVariables.InvariantCulture},
                ["case encyclopædia Archæology", new List<string>() { "dummy", "encyclopaedia", "dummy" }, GlobalVariables.InvariantCulture],
                ["case encyclopædia Archæology", new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, GlobalVariables.InvariantCulture],
                ["case encyclopædia Archæology", new Queue<string>(new string[] { "Case", "encyclopaedia", "ARCHÆOLOGY" }), GlobalVariables.InvariantCulture],

                ["case encyclopædia Archæology", new string[] { "dummy", "Kase", "dummy" }, GlobalVariables.InvariantCultureIgnoreCase],
                ["case encyclopædia Archæology", new List<string>() { "dummy", "encyclopaedia", "dummy" }, GlobalVariables.InvariantCultureIgnoreCase],
                ["case encyclopædia Archæology", new HashSet<string>() { "dummy", "ARCHAEOLOGY", "dummy" }, GlobalVariables.InvariantCultureIgnoreCase],
                ["case encyclopædia Archæology", new Queue<string>(new string[] { "Kase", "encyclopaedia", "ARCHAEOLOGY" }), GlobalVariables.InvariantCultureIgnoreCase],

                ["case encyclopædia Archæology", new string[] { "dummy", "Case", "dummy" }, GlobalVariables.Ordinal],
                ["case encyclopædia Archæology", new List<string>() { "dummy", "encyclopaedia", "dummy" }, GlobalVariables.Ordinal],
                ["case encyclopædia Archæology", new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, GlobalVariables.Ordinal],
                ["case encyclopædia Archæology", new Queue<string>(new string[] { "Case", "encyclopaedia", "ARCHÆOLOGY" }), GlobalVariables.Ordinal],

                ["case encyclopædia Archæology", new string[] { "dummy", "Kase", "dummy" }, GlobalVariables.OrdinalIgnoreCase],
                ["case encyclopædia Archæology", new List<string>() { "dummy", "encyclopaedia", "dummy" }, GlobalVariables.OrdinalIgnoreCase],
                ["case encyclopædia Archæology", new HashSet<string>() { "dummy", "Archaeology", "dummy" }, GlobalVariables.OrdinalIgnoreCase],
                ["case encyclopædia Archæology", new Queue<string>(new string[] { "Kase", "encyclopaedia", "Archaeology" }), GlobalVariables.OrdinalIgnoreCase]
            };

    public static IEnumerable<object[]> Data_ContainsAny_IEnumChar_DefaultComparison_Pass => new[]
            {
                new object[] { "char", new char[] { 'c', 'z', 'z', 'z' } },
                ["char", new List<char>() { 'z', 'h', 'z', 'z' }],
                ["char", new HashSet<char>() { 'z', 'z', 'a', 'z' }],
                ["char", new Queue<char>(new char[] { 'z', 'z', 'z', 'r' })]
            };

    public static IEnumerable<object[]> Data_ContainsAny_IEnumChar_DefaultComparison_Fail => new[]
            {
                new object[] { "char", new char[] { 'C', 'z', 'z', 'z' } },
                ["char", new List<char>() { 'z', 'H', 'z', 'z' }],
                ["char", new HashSet<char>() { 'z', 'z', 'A', 'z' }],
                ["char", new Queue<char>(new char[] { 'z', 'z', 'z', 'R' })]
            };

    // The comments denote what is the code for the character preceding them as visually they are very similar.
    public static IEnumerable<object[]> Data_ContainsAny_IEnumChar_SetComparison_Pass => new[]
            {
                new object[] { "i" /* (U+0069) */, new char[] { 'i' /* (U+0069) */, 'z', 'z', 'z' }, GlobalVariables.InvariantCulture },
                ["i" /* (U+0069) */, new List<char>() { 'z', 'i' /* (U+0069) */, 'z', 'z' }, GlobalVariables.InvariantCulture],
                ["i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'i' /* (U+0069) */, 'z' }, GlobalVariables.InvariantCulture],
                ["i" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'i' /* (U+0069) */ }), GlobalVariables.InvariantCulture],

                ["i" /* (U+0069) */, new char[] { 'I' /* (U+0049) */, 'z', 'z', 'z' }, GlobalVariables.InvariantCultureIgnoreCase],
                ["i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, GlobalVariables.InvariantCultureIgnoreCase],
                ["i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, GlobalVariables.InvariantCultureIgnoreCase],
                ["i" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'I' /* (U+0049) */ }), GlobalVariables.InvariantCultureIgnoreCase],

                ["i" /* (U+0069) */, new char[] { 'i' /* (U+0069) */, 'z', 'z', 'z' }, GlobalVariables.Ordinal],
                ["i" /* (U+0069) */, new List<char>() { 'z', 'i' /* (U+0069) */, 'z', 'z' }, GlobalVariables.Ordinal],
                ["i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'i' /* (U+0069) */, 'z' }, GlobalVariables.Ordinal],
                ["i" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'i' /* (U+0069) */ }), GlobalVariables.Ordinal],

                ["i" /* (U+0069) */, new char[] { 'I' /* (U+0049) */, 'z', 'z', 'z' }, GlobalVariables.OrdinalIgnoreCase],
                ["i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, GlobalVariables.OrdinalIgnoreCase],
                ["i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, GlobalVariables.OrdinalIgnoreCase],
                ["i" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'I' /* (U+0049) */ }), GlobalVariables.OrdinalIgnoreCase],
            };

    // The comments denote what is the code for the character preceding them as visually they are very similar.
    public static IEnumerable<object[]> Data_ContainsAny_IEnumChar_SetComparison_Fail => new[]
            {
                new object[] { "i" /* (U+0069) */, new char[] { 'ı' /* (U+0131) */, 'z', 'z', 'z' }, GlobalVariables.InvariantCulture },
                ["i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, GlobalVariables.InvariantCulture],
                ["I" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, GlobalVariables.InvariantCulture],
                ["i" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'I' /* (U+0049) */ }), GlobalVariables.InvariantCulture],

                ["i" /* (U+0069) */, new char[] { 'ı' /* (U+0131) */, 'z', 'z', 'z' }, GlobalVariables.InvariantCultureIgnoreCase],
                ["i" /* (U+0069) */, new List<char>() { 'z', 'ı' /* (U+0131) */, 'z', 'z' }, GlobalVariables.InvariantCultureIgnoreCase],
                ["i" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, GlobalVariables.InvariantCultureIgnoreCase],
                ["i" /* (U+0049) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'ı' /* (U+0131) */ }), GlobalVariables.InvariantCultureIgnoreCase],

                ["i" /* (U+0069) */, new char[] { 'ı' /* (U+0131) */, 'z', 'z', 'z' }, GlobalVariables.Ordinal],
                ["i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, GlobalVariables.Ordinal],
                ["I" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, GlobalVariables.Ordinal],
                ["i" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'I' /* (U+0049) */ }), GlobalVariables.Ordinal],

                ["i" /* (U+0069) */, new char[] { 'ı' /* (U+0131) */, 'z', 'z', 'z' }, GlobalVariables.OrdinalIgnoreCase],
                ["i" /* (U+0069) */, new List<char>() { 'z', 'ı' /* (U+0131) */, 'z', 'z' }, GlobalVariables.OrdinalIgnoreCase],
                ["I" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, GlobalVariables.OrdinalIgnoreCase],
                ["I" /* (U+0049) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'ı' /* (U+0131) */ }), GlobalVariables.OrdinalIgnoreCase],
            };

    public static IEnumerable<object[]> Data_ContainsAll_IEnumString_DefaultComparison_Pass => new[]
            {
                new object[] { "case encyclopædia Archæology", new[] { "case", "encyclopædia", "Archæology" } },
                ["case encyclopædia Archæology", new List<string>() { "case", "encyclopædia", "Archæology" }],
                ["case encyclopædia Archæology", new HashSet<string>() { "case", "encyclopædia", "Archæology" }],
                ["case encyclopædia Archæology", new Queue<string>(new[] { "case", "encyclopædia", "Archæology" })]
            };

    public static IEnumerable<object[]> Data_ContainsAll_IEnumString_SetComparison_Pass => new[]
            {
                new object[] { "case encyclopædia Archæology", new[] { "case", "encyclopædia", "Archæology" }, GlobalVariables.InvariantCulture},
                ["case encyclopædia Archæology", new List<string>() { "case", "encyclopædia", "Archæology" }, GlobalVariables.InvariantCulture],
                ["case encyclopædia Archæology", new HashSet<string>() { "case", "encyclopædia", "Archæology" }, GlobalVariables.InvariantCulture],
                ["case encyclopædia Archæology", new Queue<string>(new[] { "case", "encyclopædia", "Archæology" }), GlobalVariables.InvariantCulture],

                ["case encyclopædia Archæology", new string[] { "caSe", "Encyclopædia", "archæology" }, GlobalVariables.InvariantCultureIgnoreCase],
                ["case encyclopædia Archæology", new List<string>() { "caSe", "Encyclopædia", "archæology" }, GlobalVariables.InvariantCultureIgnoreCase],
                ["case encyclopædia Archæology", new HashSet<string>() { "caSe", "Encyclopædia", "archæology" }, GlobalVariables.InvariantCultureIgnoreCase],
                ["case encyclopædia Archæology", new Queue<string>(new[] { "caSe", "Encyclopædia", "archæology" }), GlobalVariables.InvariantCultureIgnoreCase],

                ["case encyclopædia Archæology", new string[] { "case", "encyclopædia", "Archæology" }, GlobalVariables.Ordinal],
                ["case encyclopædia Archæology", new List<string>() { "case", "encyclopædia", "Archæology" }, GlobalVariables.Ordinal],
                ["case encyclopædia Archæology", new HashSet<string>() { "case", "encyclopædia", "Archæology" }, GlobalVariables.Ordinal],
                ["case encyclopædia Archæology", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), GlobalVariables.Ordinal],

                ["case encyclopædia Archæology", new string[] { "caSe", "Encyclopædia", "archæology" }, GlobalVariables.OrdinalIgnoreCase],
                ["case encyclopædia Archæology", new List<string>() { "caSe", "Encyclopædia", "archæology" }, GlobalVariables.OrdinalIgnoreCase],
                ["case encyclopædia Archæology", new HashSet<string>() { "caSe", "Encyclopædia", "archæology" }, GlobalVariables.OrdinalIgnoreCase],
                ["case encyclopædia Archæology", new Queue<string>(new string[] { "caSe", "Encyclopædia", "archæology" }), GlobalVariables.OrdinalIgnoreCase]
            };

    public static IEnumerable<object[]> Data_ContainsAll_IEnumChar_DefaultComparison_Pass => new[]
            {
                new object[] { "char", new[] { 'c', 'h', 'a', 'r' } },
                ["char", new List<char>() { 'c', 'h', 'a', 'r' }],
                ["char", new HashSet<char>() { 'c', 'h', 'a', 'r' }],
                ["char", new Queue<char>(new[] { 'c', 'h', 'a', 'r' })]
            };

    // The comments denote what is the code for the character preceding them as visually they are very similar.
    public static IEnumerable<object[]> Data_ContainsAll_IEnumChar_SetComparison_Pass => new[]
            {
                new object[] { "iz" /* (U+0069) */, new char[] { 'i' /* (U+0069) */, 'z', 'z', 'z' }, GlobalVariables.InvariantCulture },
                ["iz" /* (U+0069) */, new List<char>() { 'z', 'i' /* (U+0069) */, 'z', 'z' }, GlobalVariables.InvariantCulture],
                ["iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'i' /* (U+0069) */, 'z' }, GlobalVariables.InvariantCulture],
                ["iz" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'i' /* (U+0069) */ }), GlobalVariables.InvariantCulture],

                ["iz" /* (U+0069) */, new char[] { 'I' /* (U+0049) */, 'z', 'z', 'z' }, GlobalVariables.InvariantCultureIgnoreCase],
                ["iz" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, GlobalVariables.InvariantCultureIgnoreCase],
                ["iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, GlobalVariables.InvariantCultureIgnoreCase],
                ["iz" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'I' /* (U+0049) */ }), GlobalVariables.InvariantCultureIgnoreCase],

                ["iz" /* (U+0069) */, new char[] { 'i' /* (U+0069) */, 'z', 'z', 'z' }, GlobalVariables.Ordinal],
                ["iz" /* (U+0069) */, new List<char>() { 'z', 'i' /* (U+0069) */, 'z', 'z' }, GlobalVariables.Ordinal],
                ["iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'i' /* (U+0069) */, 'z' }, GlobalVariables.Ordinal],
                ["iz" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'i' /* (U+0069) */ }), GlobalVariables.Ordinal],

                ["iz" /* (U+0069) */, new char[] { 'I' /* (U+0049) */, 'z', 'z', 'z' }, GlobalVariables.OrdinalIgnoreCase],
                ["iz" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, GlobalVariables.OrdinalIgnoreCase],
                ["iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, GlobalVariables.OrdinalIgnoreCase],
                ["iz" /* (U+0069) */, new Queue<char>(new char[] { 'z', 'z', 'z', 'I' /* (U+0049) */ }), GlobalVariables.OrdinalIgnoreCase],
            };

    #endregion IEnumerable test data
}
