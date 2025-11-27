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
            { TEST_STRING, ["dummy", "case", "dummy"], StringComparison.InvariantCulture },
            { TEST_STRING, new List<string>() { "dummy", "encyclopædia", "dummy" }, StringComparison.InvariantCulture },
            { TEST_STRING, new HashSet<string>() { "dummy", "Archæology", "dummy" }, StringComparison.InvariantCulture },
            { TEST_STRING, new Queue<string>(["case", "encyclopædia", "Archæology"]), StringComparison.InvariantCulture },

            { TEST_STRING, ["dummy", "Case", "dummy"], StringComparison.InvariantCultureIgnoreCase },
            { TEST_STRING, new List<string>() { "dummy", "encyclopædiA", "dummy" }, StringComparison.InvariantCultureIgnoreCase },
            { TEST_STRING, new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, StringComparison.InvariantCultureIgnoreCase },
            { TEST_STRING, new Queue<string>(["Case", "encyclopædiA", "ARCHÆOLOGY"]), StringComparison.InvariantCultureIgnoreCase },

            { TEST_STRING, ["dummy", "case", "dummy"], StringComparison.Ordinal },
            { TEST_STRING, new List<string>() { "dummy", "encyclopædia", "dummy" }, StringComparison.Ordinal },
            { TEST_STRING, new HashSet<string>() { "dummy", "Archæology", "dummy" }, StringComparison.Ordinal },
            { TEST_STRING, new Queue<string>(["case", "encyclopædia", "Archæology"]), StringComparison.Ordinal },

            { TEST_STRING, ["dummy", "Case", "dummy"], StringComparison.OrdinalIgnoreCase },
            { TEST_STRING, new List<string>() { "dummy", "encyclopædiA", "dummy" }, StringComparison.OrdinalIgnoreCase },
            { TEST_STRING, new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, StringComparison.OrdinalIgnoreCase },
            { TEST_STRING, new Queue<string>(["Case", "encyclopædiA", "ARCHÆOLOGY"]), StringComparison.OrdinalIgnoreCase }
        };

    public static TheoryData<string, IEnumerable<string>, StringComparison> Data_ContainsAny_IEnumString_SetComparison_Fail
        => new()
        {
            { TEST_STRING, ["dummy", "Case", "dummy"], StringComparison.InvariantCulture },
            { TEST_STRING, new List<string>() { "dummy", "encyclopaedia", "dummy" }, StringComparison.InvariantCulture },
            { TEST_STRING, new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, StringComparison.InvariantCulture },
            { TEST_STRING, new Queue<string>(["Case", "encyclopaedia", "ARCHÆOLOGY"]), StringComparison.InvariantCulture },

            { TEST_STRING, ["dummy", "Kase", "dummy"], StringComparison.InvariantCultureIgnoreCase },
            { TEST_STRING, new List<string>() { "dummy", "encyclopaedia", "dummy" }, StringComparison.InvariantCultureIgnoreCase },
            { TEST_STRING, new HashSet<string>() { "dummy", "ARCHAEOLOGY", "dummy" }, StringComparison.InvariantCultureIgnoreCase },
            { TEST_STRING, new Queue<string>(["Kase", "encyclopaedia", "ARCHAEOLOGY"]), StringComparison.InvariantCultureIgnoreCase },

            { TEST_STRING, ["dummy", "Case", "dummy"], StringComparison.Ordinal },
            { TEST_STRING, new List<string>() { "dummy", "encyclopaedia", "dummy" }, StringComparison.Ordinal },
            { TEST_STRING, new HashSet<string>() { "dummy", "ARCHÆOLOGY", "dummy" }, StringComparison.Ordinal },
            { TEST_STRING, new Queue<string>(["Case", "encyclopaedia", "ARCHÆOLOGY"]), StringComparison.Ordinal },

            { TEST_STRING, ["dummy", "Kase", "dummy"], StringComparison.OrdinalIgnoreCase },
            { TEST_STRING, new List<string>() { "dummy", "encyclopaedia", "dummy" }, StringComparison.OrdinalIgnoreCase },
            { TEST_STRING, new HashSet<string>() { "dummy", "Archaeology", "dummy" }, StringComparison.OrdinalIgnoreCase },
            { TEST_STRING, new Queue<string>(["Kase", "encyclopaedia", "Archaeology"]), StringComparison.OrdinalIgnoreCase }
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
            { "i" /* (U+0069) */, ['i' /* (U+0069) */, 'z', 'z', 'z'], StringComparison.InvariantCulture },
            { "i" /* (U+0069) */, new List<char>() { 'z', 'i' /* (U+0069) */, 'z', 'z' }, StringComparison.InvariantCulture },
            { "i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'i' /* (U+0069) */, 'z' }, StringComparison.InvariantCulture },
            { "i" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'i' /* (U+0069) */]), StringComparison.InvariantCulture },

            { "i" /* (U+0069) */, ['I' /* (U+0049) */, 'z', 'z', 'z'], StringComparison.InvariantCultureIgnoreCase },
            { "i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, StringComparison.InvariantCultureIgnoreCase },
            { "i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, StringComparison.InvariantCultureIgnoreCase },
            { "i" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'I' /* (U+0049) */]), StringComparison.InvariantCultureIgnoreCase },

            { "i" /* (U+0069) */, ['i' /* (U+0069) */, 'z', 'z', 'z'], StringComparison.Ordinal },
            { "i" /* (U+0069) */, new List<char>() { 'z', 'i' /* (U+0069) */, 'z', 'z' }, StringComparison.Ordinal },
            { "i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'i' /* (U+0069) */, 'z' }, StringComparison.Ordinal },
            { "i" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'i' /* (U+0069) */]), StringComparison.Ordinal },

            { "i" /* (U+0069) */, ['I' /* (U+0049) */, 'z', 'z', 'z'], StringComparison.OrdinalIgnoreCase },
            { "i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, StringComparison.OrdinalIgnoreCase },
            { "i" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, StringComparison.OrdinalIgnoreCase },
            { "i" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'I' /* (U+0049) */]), StringComparison.OrdinalIgnoreCase }
        };

    // The comments denote what is the code for the character preceding them as visually they are very similar.
    public static TheoryData<string, IEnumerable<char>, StringComparison> Data_ContainsAny_IEnumChar_SetComparison_Fail
        => new()
        {
            { "i" /* (U+0069) */, ['ı' /* (U+0131) */, 'z', 'z', 'z'], StringComparison.InvariantCulture },
            { "i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, StringComparison.InvariantCulture },
            { "I" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, StringComparison.InvariantCulture },
            { "i" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'I' /* (U+0049) */]), StringComparison.InvariantCulture },

            { "i" /* (U+0069) */, ['ı' /* (U+0131) */, 'z', 'z', 'z'], StringComparison.InvariantCultureIgnoreCase },
            { "i" /* (U+0069) */, new List<char>() { 'z', 'ı' /* (U+0131) */, 'z', 'z' }, StringComparison.InvariantCultureIgnoreCase },
            { "i" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, StringComparison.InvariantCultureIgnoreCase },
            { "i" /* (U+0049) */, new Queue<char>(['z', 'z', 'z', 'ı' /* (U+0131) */]), StringComparison.InvariantCultureIgnoreCase },

            { "i" /* (U+0069) */, ['ı' /* (U+0131) */, 'z', 'z', 'z'], StringComparison.Ordinal },
            { "i" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, StringComparison.Ordinal },
            { "I" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, StringComparison.Ordinal },
            { "i" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'I' /* (U+0049) */]), StringComparison.Ordinal },

            { "i" /* (U+0069) */, ['ı' /* (U+0131) */, 'z', 'z', 'z'], StringComparison.OrdinalIgnoreCase },
            { "i" /* (U+0069) */, new List<char>() { 'z', 'ı' /* (U+0131) */, 'z', 'z' }, StringComparison.OrdinalIgnoreCase },
            { "I" /* (U+0049) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, StringComparison.OrdinalIgnoreCase },
            { "I" /* (U+0049) */, new Queue<char>(['z', 'z', 'z', 'ı' /* (U+0131) */]), StringComparison.OrdinalIgnoreCase }
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
            { TEST_STRING, ["case", "encyclopædia", "Archæology"], StringComparison.InvariantCulture },
            { TEST_STRING, new List<string>() { "case", "encyclopædia", "Archæology" }, StringComparison.InvariantCulture },
            { TEST_STRING, new HashSet<string>() { "case", "encyclopædia", "Archæology" }, StringComparison.InvariantCulture },
            { TEST_STRING, new Queue<string>(["case", "encyclopædia", "Archæology"]), StringComparison.InvariantCulture },

            { TEST_STRING, ["caSe", "Encyclopædia", "archæology"], StringComparison.InvariantCultureIgnoreCase },
            { TEST_STRING, new List<string>() { "caSe", "Encyclopædia", "archæology" }, StringComparison.InvariantCultureIgnoreCase },
            { TEST_STRING, new HashSet<string>() { "caSe", "Encyclopædia", "archæology" }, StringComparison.InvariantCultureIgnoreCase },
            { TEST_STRING, new Queue<string>(["caSe", "Encyclopædia", "archæology"]), StringComparison.InvariantCultureIgnoreCase },

            { TEST_STRING, ["case", "encyclopædia", "Archæology"], StringComparison.Ordinal },
            { TEST_STRING, new List<string>() { "case", "encyclopædia", "Archæology" }, StringComparison.Ordinal },
            { TEST_STRING, new HashSet<string>() { "case", "encyclopædia", "Archæology" }, StringComparison.Ordinal },
            { TEST_STRING, new Queue<string>(["case", "encyclopædia", "Archæology"]), StringComparison.Ordinal },

            { TEST_STRING, ["caSe", "Encyclopædia", "archæology"], StringComparison.OrdinalIgnoreCase },
            { TEST_STRING, new List<string>() { "caSe", "Encyclopædia", "archæology" }, StringComparison.OrdinalIgnoreCase },
            { TEST_STRING, new HashSet<string>() { "caSe", "Encyclopædia", "archæology" }, StringComparison.OrdinalIgnoreCase },
            { TEST_STRING, new Queue<string>(["caSe", "Encyclopædia", "archæology"]), StringComparison.OrdinalIgnoreCase }
        };

    public static TheoryData<string, IEnumerable<string>, StringComparison> Data_ContainsAll_IEnumString_SetComparison_Fail
        => new()
        {
            { TEST_STRING, ["case", "Encyclopædia", "Archæology"], StringComparison.InvariantCulture },
            { TEST_STRING, new List<string>() { "Case", "encyclopædia", "Archæology" }, StringComparison.InvariantCulture },
            { TEST_STRING, new HashSet<string>() { "case", "encyclopædia", "archæology" }, StringComparison.InvariantCulture },
            { TEST_STRING, new Queue<string>(["case", "encyclopaedia", "Archaeology"]), StringComparison.InvariantCulture },

            { TEST_STRING, ["caSe", "encyclopaedia", "Archaeology"], StringComparison.InvariantCultureIgnoreCase },
            { TEST_STRING, new List<string>() { "caSe", "encyclopaedia", "Archaeology" }, StringComparison.InvariantCultureIgnoreCase },
            { TEST_STRING, new HashSet<string>() { "caSe", "encyclopaedia", "Archaeology" }, StringComparison.InvariantCultureIgnoreCase },
            { TEST_STRING, new Queue<string>(["caSe", "encyclopaedia", "Archaeology"]), StringComparison.InvariantCultureIgnoreCase },

            { TEST_STRING, ["case", "encyclopaedia", "Archaeology"], StringComparison.Ordinal },
            { TEST_STRING, new List<string>() { "case", "encyclopaedia", "Archaeology" }, StringComparison.Ordinal },
            { TEST_STRING, new HashSet<string>() { "case", "encyclopaedia", "Archaeology" }, StringComparison.Ordinal },
            { TEST_STRING, new Queue<string>(["case", "encyclopaedia", "Archaeology"]), StringComparison.Ordinal },

            { TEST_STRING, ["caSe", "Encyclopaedia", "archaeology"], StringComparison.OrdinalIgnoreCase },
            { TEST_STRING, new List<string>() { "caSe", "Encyclopaedia", "archaeology" }, StringComparison.OrdinalIgnoreCase },
            { TEST_STRING, new HashSet<string>() { "caSe", "Encyclopaedia", "archaeology" }, StringComparison.OrdinalIgnoreCase },
            { TEST_STRING, new Queue<string>(["caSe", "Encyclopaedia", "archaeology"]), StringComparison.OrdinalIgnoreCase }
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
            { "iz" /* (U+0069) */, ['i' /* (U+0069) */, 'z', 'z', 'z'], StringComparison.InvariantCulture },
            { "iz" /* (U+0069) */, new List<char>() { 'z', 'i' /* (U+0069) */, 'z', 'z' }, StringComparison.InvariantCulture },
            { "iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'i' /* (U+0069) */, 'z' }, StringComparison.InvariantCulture },
            { "iz" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'i' /* (U+0069) */]), StringComparison.InvariantCulture },

            { "iz" /* (U+0069) */, ['I' /* (U+0049) */, 'z', 'z', 'z'], StringComparison.InvariantCultureIgnoreCase },
            { "iz" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, StringComparison.InvariantCultureIgnoreCase },
            { "iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, StringComparison.InvariantCultureIgnoreCase },
            { "iz" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'I' /* (U+0049) */]), StringComparison.InvariantCultureIgnoreCase },

            { "iz" /* (U+0069) */, ['i' /* (U+0069) */, 'z', 'z', 'z'], StringComparison.Ordinal },
            { "iz" /* (U+0069) */, new List<char>() { 'z', 'i' /* (U+0069) */, 'z', 'z' }, StringComparison.Ordinal },
            { "iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'i' /* (U+0069) */, 'z' }, StringComparison.Ordinal },
            { "iz" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'i' /* (U+0069) */]), StringComparison.Ordinal },

            { "iz" /* (U+0069) */, ['I' /* (U+0049) */, 'z', 'z', 'z'], StringComparison.OrdinalIgnoreCase },
            { "iz" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, StringComparison.OrdinalIgnoreCase },
            { "iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, StringComparison.OrdinalIgnoreCase },
            { "iz" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'I' /* (U+0049) */]), StringComparison.OrdinalIgnoreCase }
        };

    // The comments denote what is the code for the character preceding them as visually they are very similar.
    public static TheoryData<string, IEnumerable<char>, StringComparison> Data_ContainsAll_IEnumChar_SetComparison_Fail
        => new()
        {
            { "iz" /* (U+0069) */, ['I' /* (U+0049) */, 'z', 'z', 'z'], StringComparison.InvariantCulture },
            { "iz" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, StringComparison.InvariantCulture },
            { "iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, StringComparison.InvariantCulture },
            { "iz" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'I' /* (U+0049) */]), StringComparison.InvariantCulture },

            { "iz" /* (U+0069) */, ['ı' /* (U+0131) */, 'z', 'z', 'z'], StringComparison.InvariantCultureIgnoreCase },
            { "iz" /* (U+0069) */, new List<char>() { 'z', 'ı' /* (U+0131) */, 'z', 'z' }, StringComparison.InvariantCultureIgnoreCase },
            { "iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, StringComparison.InvariantCultureIgnoreCase },
            { "iz" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'ı' /* (U+0131) */]), StringComparison.InvariantCultureIgnoreCase },

            { "iz" /* (U+0069) */, ['I' /* (U+0049) */, 'z', 'z', 'z'], StringComparison.Ordinal },
            { "iz" /* (U+0069) */, new List<char>() { 'z', 'I' /* (U+0049) */, 'z', 'z' }, StringComparison.Ordinal },
            { "iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'I' /* (U+0049) */, 'z' }, StringComparison.Ordinal },
            { "iz" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'I' /* (U+0049) */]), StringComparison.Ordinal },

            { "iz" /* (U+0069) */, ['ı' /* (U+0131) */, 'z', 'z', 'z'], StringComparison.OrdinalIgnoreCase },
            { "iz" /* (U+0069) */, new List<char>() { 'z', 'ı' /* (U+0131) */, 'z', 'z' }, StringComparison.OrdinalIgnoreCase },
            { "iz" /* (U+0069) */, new HashSet<char>() { 'z', 'z', 'ı' /* (U+0131) */, 'z' }, StringComparison.OrdinalIgnoreCase },
            { "iz" /* (U+0069) */, new Queue<char>(['z', 'z', 'z', 'ı' /* (U+0131) */]), StringComparison.OrdinalIgnoreCase }
        };

    #endregion IEnumerable test data
}
