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

    [Theory, MemberData(nameof(Data_ContainsAll_IEnumString_DefaultComparison_Fail))]
    public void ContainsAll_IEnumString_DefaultComparison_Fail(string testString, IEnumerable<string> keywords)
    {
        bool actual = testString.ContainsAll(keywords);
        Assert.False(actual);
    }

    [Theory, MemberData(nameof(Data_ContainsAll_IEnumString_SetComparison_Fail))]
    public void ContainsAll_IEnumString_SetComparison_Fail(string testString, IEnumerable<string> keywords, StringComparison stringComparison)
    {
        bool actual = testString.ContainsAll(keywords, stringComparison);
        Assert.False(actual);
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

    [Theory, MemberData(nameof(Data_ContainsAll_IEnumChar_DefaultComparison_Fail))]
    public void ContainsAll_IEnumChar_DefaultComparison_Fail(string testString, IEnumerable<char> keychars)
    {
        bool actual = testString.ContainsAll(keychars);
        Assert.False(actual);
    }

    [Theory, MemberData(nameof(Data_ContainsAll_IEnumChar_SetComparison_Fail))]
    public void ContainsAll_IEnumChar_SetComparison_Fail(string testString, IEnumerable<char> keychars, StringComparison stringComparison)
    {
        bool actual = testString.ContainsAll(keychars, stringComparison);
        Assert.False(actual);
    }

    #endregion ContainsAll(this string str, IEnumerable<char> keychars, StringComparison comparison)

    #region IEnumerable test data

    const string TEST_STRING = "case encyclopædia Archæology";

    public static TheoryData<string, IEnumerable<string>> Data_ContainsAny_IEnumString_DefaultComparison_Pass
        => new()
        {
            { TEST_STRING, ["dummy", "case", "dummy", "dummy"] },
            { TEST_STRING, new List<string>() { "dummy", "encyclopædia", "dummy", "dummy" } },
            { TEST_STRING, new HashSet<string>() { "dummy", "Archæology", "dummy", "dummy" } },
            { TEST_STRING, new Queue<string>(["dummy", "case", "encyclopædia", "Archæology"]) }
        };

    public static TheoryData<string, IEnumerable<string>> Data_ContainsAny_IEnumString_DefaultComparison_Fail
        => new()
        {
            { TEST_STRING, ["dummy", "Case", "encyclopaedia", "ARCHÆOLOGY"] },
            { TEST_STRING, new List<string>() { "dummy", "Case", "encyclopaedia", "ARCHÆOLOGY" } },
            { TEST_STRING, new HashSet<string>() { "dummy", "Case", "encyclopaedia", "ARCHÆOLOGY" } },
            { TEST_STRING, new Queue<string>(["dummy", "Case", "encyclopaedia", "ARCHÆOLOGY"]) }
        };

    public static TheoryData<string, IEnumerable<string>, StringComparison> Data_ContainsAny_IEnumString_SetComparison_Pass
        => new()
        {
            { TEST_STRING, ["dummy", "case", "dummy"], GlobalVariables.InvariantCulture },
            { TEST_STRING, new List<string>() { "dummy", "encyclopædia", "dummy" }, GlobalVariables.InvariantCulture },
            { TEST_STRING, new HashSet<string>() { "dummy", "Archæology", "dummy" }, GlobalVariables.InvariantCulture },
            { TEST_STRING, new Queue<string>(["case", "encyclopædia", "Archæology"]), GlobalVariables.InvariantCulture },

            { TEST_STRING, ["dummy", "Case", "dummy"], GlobalVariables.InvariantCultureIgnoreCase },
            { TEST_STRING, new List<string>() { "dummy", "encyclopædiA", "dummy" }, GlobalVariables.InvariantCultureIgnoreCase },
            { TEST_STRING, new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, GlobalVariables.InvariantCultureIgnoreCase },
            { TEST_STRING, new Queue<string>(["Case", "encyclopædiA", "ARCHÆOLOGY"]), GlobalVariables.InvariantCultureIgnoreCase },

            { TEST_STRING, ["dummy", "case", "dummy"], GlobalVariables.Ordinal },
            { TEST_STRING, new List<string>() { "dummy", "encyclopædia", "dummy" }, GlobalVariables.Ordinal },
            { TEST_STRING, new HashSet<string>() { "dummy", "Archæology", "dummy" }, GlobalVariables.Ordinal },
            { TEST_STRING, new Queue<string>(["case", "encyclopædia", "Archæology"]), GlobalVariables.Ordinal },

            { TEST_STRING, ["dummy", "Case", "dummy"], GlobalVariables.OrdinalIgnoreCase },
            { TEST_STRING, new List<string>() { "dummy", "encyclopædiA", "dummy" }, GlobalVariables.OrdinalIgnoreCase },
            { TEST_STRING, new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, GlobalVariables.OrdinalIgnoreCase },
            { TEST_STRING, new Queue<string>(["Case", "encyclopædiA", "ARCHÆOLOGY"]), GlobalVariables.OrdinalIgnoreCase }
        };

    public static TheoryData<string, IEnumerable<string>, StringComparison> Data_ContainsAny_IEnumString_SetComparison_Fail
        => new()
        {
            { TEST_STRING, ["dummy", "Case", "dummy"], GlobalVariables.InvariantCulture },
            { TEST_STRING, new List<string>() { "dummy", "encyclopaedia", "dummy" }, GlobalVariables.InvariantCulture },
            { TEST_STRING, new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, GlobalVariables.InvariantCulture },
            { TEST_STRING, new Queue<string>(["Case", "encyclopaedia", "ARCHÆOLOGY"]), GlobalVariables.InvariantCulture },

            { TEST_STRING, ["dummy", "Kase", "dummy"], GlobalVariables.InvariantCultureIgnoreCase },
            { TEST_STRING, new List<string>() { "dummy", "encyclopaedia", "dummy" }, GlobalVariables.InvariantCultureIgnoreCase },
            { TEST_STRING, new HashSet<string>() { "dummy", "ARCHAEOLOGY", "dummy" }, GlobalVariables.InvariantCultureIgnoreCase },
            { TEST_STRING, new Queue<string>(["Kase", "encyclopaedia", "ARCHAEOLOGY"]), GlobalVariables.InvariantCultureIgnoreCase },

            { TEST_STRING, ["dummy", "Case", "dummy"], GlobalVariables.Ordinal },
            { TEST_STRING, new List<string>() { "dummy", "encyclopaedia", "dummy" }, GlobalVariables.Ordinal },
            { TEST_STRING, new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, GlobalVariables.Ordinal },
            { TEST_STRING, new Queue<string>(["Case", "encyclopaedia", "ARCHÆOLOGY"]), GlobalVariables.Ordinal },

            { TEST_STRING, ["dummy", "Kase", "dummy"], GlobalVariables.OrdinalIgnoreCase },
            { TEST_STRING, new List<string>() { "dummy", "encyclopaedia", "dummy" }, GlobalVariables.OrdinalIgnoreCase },
            { TEST_STRING, new HashSet<string>() { "dummy", "Archaeology", "dummy" }, GlobalVariables.OrdinalIgnoreCase },
            { TEST_STRING, new Queue<string>(["Kase", "encyclopaedia", "Archaeology"]), GlobalVariables.OrdinalIgnoreCase }
        };

    public static TheoryData<string, IEnumerable<char>> Data_ContainsAny_IEnumChar_DefaultComparison_Pass
        => new()
        {
            { "char", ['c', 'z', 'z', 'z'] },
            { "char", new List<char>() { 'z', 'h', 'z', 'z' } },
            { "char", new HashSet<char>() { 'z', 'z', 'a', 'z' } },
            { "char", new Queue<char>(['z', 'z', 'z', 'r']) }
        };

    public static TheoryData<string, IEnumerable<char>> Data_ContainsAny_IEnumChar_DefaultComparison_Fail
        => new()
        {
            { "char", ['C', 'z', 'z', 'z'] },
            { "char", new List<char>() { 'z', 'H', 'z', 'z' } },
            { "char", new HashSet<char>() { 'z', 'z', 'A', 'z' } },
            { "char", new Queue<char>(['z', 'z', 'z', 'R']) }
        };

    // The comments denote what is the code for the character preceding them as visually they are very similar.
    public static TheoryData<string, IEnumerable<char>, StringComparison> Data_ContainsAny_IEnumChar_SetComparison_Pass
        => new()
        {
            { "i" /* (U+0069) */, ['i' /* (U+0069) */, 'z', 'z', 'z'], GlobalVariables.InvariantCulture },
            { "i" /* (U+0069) */, new List<char>() { 'z', 'i' /* (U+0069) */, 'z', 'z' }, GlobalVariables.InvariantCulture },
            { "i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'i' /* (U+0069) */, 'z' }, GlobalVariables.InvariantCulture },
            { "i" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'i' /* (U+0069) */]), GlobalVariables.InvariantCulture },

            { "i" /* (U+0069) */, ['I' /* (U+0049) */, 'z', 'z', 'z'], GlobalVariables.InvariantCultureIgnoreCase },
            { "i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, GlobalVariables.InvariantCultureIgnoreCase },
            { "i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, GlobalVariables.InvariantCultureIgnoreCase },
            { "i" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'I' /* (U+0049) */]), GlobalVariables.InvariantCultureIgnoreCase },

            { "i" /* (U+0069) */, ['i' /* (U+0069) */, 'z', 'z', 'z'], GlobalVariables.Ordinal },
            { "i" /* (U+0069) */, new List<char>() { 'z', 'i' /* (U+0069) */, 'z', 'z' }, GlobalVariables.Ordinal },
            { "i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'i' /* (U+0069) */, 'z' }, GlobalVariables.Ordinal },
            { "i" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'i' /* (U+0069) */]), GlobalVariables.Ordinal },

            { "i" /* (U+0069) */, ['I' /* (U+0049) */, 'z', 'z', 'z'], GlobalVariables.OrdinalIgnoreCase },
            { "i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, GlobalVariables.OrdinalIgnoreCase },
            { "i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, GlobalVariables.OrdinalIgnoreCase },
            { "i" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'I' /* (U+0049) */]), GlobalVariables.OrdinalIgnoreCase }
        };

    // The comments denote what is the code for the character preceding them as visually they are very similar.
    public static TheoryData<string, IEnumerable<char>, StringComparison> Data_ContainsAny_IEnumChar_SetComparison_Fail
        => new()
        {
            { "i" /* (U+0069) */, ['ı' /* (U+0131) */, 'z', 'z', 'z'], GlobalVariables.InvariantCulture },
            { "i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, GlobalVariables.InvariantCulture },
            { "I" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, GlobalVariables.InvariantCulture },
            { "i" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'I' /* (U+0049) */]), GlobalVariables.InvariantCulture },

            { "i" /* (U+0069) */, ['ı' /* (U+0131) */, 'z', 'z', 'z'], GlobalVariables.InvariantCultureIgnoreCase },
            { "i" /* (U+0069) */, new List<char>() { 'z', 'ı' /* (U+0131) */, 'z', 'z' }, GlobalVariables.InvariantCultureIgnoreCase },
            { "i" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, GlobalVariables.InvariantCultureIgnoreCase },
            { "i" /* (U+0049) */, new Queue<char>(['z', 'z', 'z', 'ı' /* (U+0131) */]), GlobalVariables.InvariantCultureIgnoreCase },

            { "i" /* (U+0069) */, ['ı' /* (U+0131) */, 'z', 'z', 'z'], GlobalVariables.Ordinal },
            { "i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, GlobalVariables.Ordinal },
            { "I" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, GlobalVariables.Ordinal },
            { "i" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'I' /* (U+0049) */]), GlobalVariables.Ordinal },

            { "i" /* (U+0069) */, ['ı' /* (U+0131) */, 'z', 'z', 'z'], GlobalVariables.OrdinalIgnoreCase },
            { "i" /* (U+0069) */, new List<char>() { 'z', 'ı' /* (U+0131) */, 'z', 'z' }, GlobalVariables.OrdinalIgnoreCase },
            { "I" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, GlobalVariables.OrdinalIgnoreCase },
            { "I" /* (U+0049) */, new Queue<char>(['z', 'z', 'z', 'ı' /* (U+0131) */]), GlobalVariables.OrdinalIgnoreCase }
        };

    public static TheoryData<string, IEnumerable<string>> Data_ContainsAll_IEnumString_DefaultComparison_Pass
        => new()
        {
            { TEST_STRING, ["case", "encyclopædia", "Archæology"] },
            { TEST_STRING, new List<string>() { "case", "encyclopædia", "Archæology" } },
            { TEST_STRING, new HashSet<string>() { "case", "encyclopædia", "Archæology" } },
            { TEST_STRING, new Queue<string>(["case", "encyclopædia", "Archæology"]) }
        };

    public static TheoryData<string, IEnumerable<string>> Data_ContainsAll_IEnumString_DefaultComparison_Fail
        => new()
        {
            { TEST_STRING, ["case", "encyclopædia", "z"] },
            { TEST_STRING, new List<string>() { "case", "z", "Archæology" } },
            { TEST_STRING, new HashSet<string>() { "z", "encyclopædia", "Archæology" } },
            { TEST_STRING, new Queue<string>(["case", "z", "z"]) }
        };

    public static TheoryData<string, IEnumerable<string>, StringComparison> Data_ContainsAll_IEnumString_SetComparison_Pass
        => new()
        {
            { TEST_STRING, ["case", "encyclopædia", "Archæology"], GlobalVariables.InvariantCulture },
            { TEST_STRING, new List<string>() { "case", "encyclopædia", "Archæology" }, GlobalVariables.InvariantCulture },
            { TEST_STRING, new HashSet<string>() { "case", "encyclopædia", "Archæology" }, GlobalVariables.InvariantCulture },
            { TEST_STRING, new Queue<string>(["case", "encyclopædia", "Archæology"]), GlobalVariables.InvariantCulture },

            { TEST_STRING, ["caSe", "Encyclopædia", "archæology"], GlobalVariables.InvariantCultureIgnoreCase },
            { TEST_STRING, new List<string>() { "caSe", "Encyclopædia", "archæology" }, GlobalVariables.InvariantCultureIgnoreCase },
            { TEST_STRING, new HashSet<string>() { "caSe", "Encyclopædia", "archæology" }, GlobalVariables.InvariantCultureIgnoreCase },
            { TEST_STRING, new Queue<string>(["caSe", "Encyclopædia", "archæology"]), GlobalVariables.InvariantCultureIgnoreCase },

            { TEST_STRING, ["case", "encyclopædia", "Archæology"], GlobalVariables.Ordinal },
            { TEST_STRING, new List<string>() { "case", "encyclopædia", "Archæology" }, GlobalVariables.Ordinal },
            { TEST_STRING, new HashSet<string>() { "case", "encyclopædia", "Archæology" }, GlobalVariables.Ordinal },
            { TEST_STRING, new Queue<string>(["case", "encyclopædia", "Archæology"]), GlobalVariables.Ordinal },

            { TEST_STRING, ["caSe", "Encyclopædia", "archæology"], GlobalVariables.OrdinalIgnoreCase },
            { TEST_STRING, new List<string>() { "caSe", "Encyclopædia", "archæology" }, GlobalVariables.OrdinalIgnoreCase },
            { TEST_STRING, new HashSet<string>() { "caSe", "Encyclopædia", "archæology" }, GlobalVariables.OrdinalIgnoreCase },
            { TEST_STRING, new Queue<string>(["caSe", "Encyclopædia", "archæology"]), GlobalVariables.OrdinalIgnoreCase }
        };

    public static TheoryData<string, IEnumerable<string>, StringComparison> Data_ContainsAll_IEnumString_SetComparison_Fail
        => new()
        {
            { TEST_STRING, ["case", "Encyclopædia", "Archæology"], GlobalVariables.InvariantCulture },
            { TEST_STRING, new List<string>() { "Case", "encyclopædia", "Archæology" }, GlobalVariables.InvariantCulture },
            { TEST_STRING, new HashSet<string>() { "case", "encyclopædia", "archæology" }, GlobalVariables.InvariantCulture },
            { TEST_STRING, new Queue<string>(["case", "encyclopaedia", "Archaeology"]), GlobalVariables.InvariantCulture },

            { TEST_STRING, ["caSe", "encyclopaedia", "Archaeology"], GlobalVariables.InvariantCultureIgnoreCase },
            { TEST_STRING, new List<string>() { "caSe", "encyclopaedia", "Archaeology" }, GlobalVariables.InvariantCultureIgnoreCase },
            { TEST_STRING, new HashSet<string>() { "caSe", "encyclopaedia", "Archaeology" }, GlobalVariables.InvariantCultureIgnoreCase },
            { TEST_STRING, new Queue<string>(["caSe", "encyclopaedia", "Archaeology"]), GlobalVariables.InvariantCultureIgnoreCase },

            { TEST_STRING, ["case", "encyclopaedia", "Archaeology"], GlobalVariables.Ordinal },
            { TEST_STRING, new List<string>() { "case", "encyclopaedia", "Archaeology" }, GlobalVariables.Ordinal },
            { TEST_STRING, new HashSet<string>() { "case", "encyclopaedia", "Archaeology" }, GlobalVariables.Ordinal },
            { TEST_STRING, new Queue<string>(["case", "encyclopaedia", "Archaeology"]), GlobalVariables.Ordinal },

            { TEST_STRING, ["caSe", "Encyclopaedia", "archaeology"], GlobalVariables.OrdinalIgnoreCase },
            { TEST_STRING, new List<string>() { "caSe", "Encyclopaedia", "archaeology" }, GlobalVariables.OrdinalIgnoreCase },
            { TEST_STRING, new HashSet<string>() { "caSe", "Encyclopaedia", "archaeology" }, GlobalVariables.OrdinalIgnoreCase },
            { TEST_STRING, new Queue<string>(["caSe", "Encyclopaedia", "archaeology"]), GlobalVariables.OrdinalIgnoreCase }
        };

    public static TheoryData<string, IEnumerable<char>> Data_ContainsAll_IEnumChar_DefaultComparison_Pass
        =>new()
        {
            { "char", ['c', 'h', 'a', 'r'] },
            { "char", new List<char>() { 'c', 'h', 'a', 'r' } },
            { "char", new HashSet<char>() { 'c', 'h', 'a', 'r' } },
            { "char", new Queue<char>(['c', 'h', 'a', 'r']) }
        };

    public static TheoryData<string, IEnumerable<char>> Data_ContainsAll_IEnumChar_DefaultComparison_Fail
        => new()
        {
            { "char", ['c', 'h', 'a', 'z'] },
            { "char", new List<char>() { 'c', 'h', 'z', 'r' } },
            { "char", new HashSet<char>() { 'c', 'z', 'a', 'r' } },
            { "char", new Queue<char>(['z', 'h', 'a', 'r']) }
        };

    // The comments denote what is the code for the character preceding them as visually they are very similar.
    public static TheoryData<string, IEnumerable<char>, StringComparison> Data_ContainsAll_IEnumChar_SetComparison_Pass
        => new()
        {
            { "iz" /* (U+0069) */, ['i' /* (U+0069) */, 'z', 'z', 'z'], GlobalVariables.InvariantCulture },
            { "iz" /* (U+0069) */, new List<char>() { 'z', 'i' /* (U+0069) */, 'z', 'z' }, GlobalVariables.InvariantCulture },
            { "iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'i' /* (U+0069) */, 'z' }, GlobalVariables.InvariantCulture },
            { "iz" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'i' /* (U+0069) */]), GlobalVariables.InvariantCulture },

            { "iz" /* (U+0069) */, ['I' /* (U+0049) */, 'z', 'z', 'z'], GlobalVariables.InvariantCultureIgnoreCase },
            { "iz" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, GlobalVariables.InvariantCultureIgnoreCase },
            { "iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, GlobalVariables.InvariantCultureIgnoreCase },
            { "iz" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'I' /* (U+0049) */]), GlobalVariables.InvariantCultureIgnoreCase },

            { "iz" /* (U+0069) */, ['i' /* (U+0069) */, 'z', 'z', 'z'], GlobalVariables.Ordinal },
            { "iz" /* (U+0069) */, new List<char>() { 'z', 'i' /* (U+0069) */, 'z', 'z' }, GlobalVariables.Ordinal },
            { "iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'i' /* (U+0069) */, 'z' }, GlobalVariables.Ordinal },
            { "iz" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'i' /* (U+0069) */]), GlobalVariables.Ordinal },

            { "iz" /* (U+0069) */, ['I' /* (U+0049) */, 'z', 'z', 'z'], GlobalVariables.OrdinalIgnoreCase },
            { "iz" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, GlobalVariables.OrdinalIgnoreCase },
            { "iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, GlobalVariables.OrdinalIgnoreCase },
            { "iz" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'I' /* (U+0049) */]), GlobalVariables.OrdinalIgnoreCase }
        };

    // The comments denote what is the code for the character preceding them as visually they are very similar.
    public static TheoryData<string, IEnumerable<char>, StringComparison> Data_ContainsAll_IEnumChar_SetComparison_Fail
        => new()
        {
            { "iz" /* (U+0069) */, ['I' /* (U+0049) */, 'z', 'z', 'z'], GlobalVariables.InvariantCulture },
            { "iz" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, GlobalVariables.InvariantCulture },
            { "iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, GlobalVariables.InvariantCulture },
            { "iz" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'I' /* (U+0049) */]), GlobalVariables.InvariantCulture },

            { "iz" /* (U+0069) */, ['ı' /* (U+0131) */, 'z', 'z', 'z'], GlobalVariables.InvariantCultureIgnoreCase },
            { "iz" /* (U+0069) */, new List<char>() { 'z', 'ı' /* (U+0131) */, 'z', 'z' }, GlobalVariables.InvariantCultureIgnoreCase },
            { "iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, GlobalVariables.InvariantCultureIgnoreCase },
            { "iz" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'ı' /* (U+0131) */]), GlobalVariables.InvariantCultureIgnoreCase },

            { "iz" /* (U+0069) */, ['I' /* (U+0049) */, 'z', 'z', 'z'], GlobalVariables.Ordinal },
            { "iz" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, GlobalVariables.Ordinal },
            { "iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, GlobalVariables.Ordinal },
            { "iz" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'I' /* (U+0049) */]), GlobalVariables.Ordinal },

            { "iz" /* (U+0069) */, ['ı' /* (U+0131) */, 'z', 'z', 'z'], GlobalVariables.OrdinalIgnoreCase },
            { "iz" /* (U+0069) */, new List<char>() { 'z', 'ı' /* (U+0131) */, 'z', 'z' }, GlobalVariables.OrdinalIgnoreCase },
            { "iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, GlobalVariables.OrdinalIgnoreCase },
            { "iz" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'ı' /* (U+0131) */]), GlobalVariables.OrdinalIgnoreCase }
        };

    #endregion IEnumerable test data
}
