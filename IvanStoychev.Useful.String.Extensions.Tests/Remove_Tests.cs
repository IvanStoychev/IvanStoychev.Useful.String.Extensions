using System;
using System.Collections.Generic;
using System.Globalization;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Remove_Tests
{
    #region Remove(this string str, string removeString, StringComparison stringComparison = StringComparison.CurrentCulture)

    #region Pass

    [Theory]
    #region Data
    [InlineData("Case encyclopædia Archæology", "Case", " encyclopædia Archæology")]
    [InlineData("Case encyclopædia Archæology", "encyclopædia ", "Case Archæology")]
    [InlineData("Case encyclopædia Archæology", " Archæology", "Case encyclopædia")]
    #endregion Data
    public void Remove_String_DefaultComparison_Pass(string testString, string removeString, string expectedString)
    {
        string actualString = testString.Remove(removeString);

        Assert.Equal(expectedString, actualString);
    }

    [Theory]
    #region Data
    [InlineData("Case encyclopædia Archæology", "Case", StringComparison.Ordinal, " encyclopædia Archæology")]
    [InlineData("Case encyclopædia Archæology", "Encyclopædia ", StringComparison.OrdinalIgnoreCase, "Case Archæology")]
    [InlineData("Case encyclopædia Archæology", " Archæology", StringComparison.InvariantCulture, "Case encyclopædia")]
    [InlineData("Case encyclopædia Archæology", " archæology", StringComparison.InvariantCultureIgnoreCase, "Case encyclopædia")]
    #endregion Data
    public void Remove_String_SetComparison_Pass(string testString, string removeString, StringComparison stringComparison, string expectedString)
    {
        string actualString = testString.Remove(removeString, stringComparison);

        Assert.Equal(expectedString, actualString);
    }

    #endregion Pass

    #region Fail

    [Theory]
    #region Data
    [InlineData("Case encyclopædia Archæology", "dummy")]
    [InlineData("Case encyclopædia Archæology", "empty")]
    [InlineData("Case encyclopædia Archæology", "miss")]
    #endregion Data
    public void Remove_String_DefaultComparison_Fail(string testString, string removeString)
    {
        string actualString = testString.Remove(removeString);

        Assert.Equal(testString, actualString);
    }

    [Theory]
    #region Data
    [InlineData("Case encyclopædia Archæology", "case", StringComparison.Ordinal)]
    [InlineData("Case encyclopædia Archæology", "encyclopaedia ", StringComparison.OrdinalIgnoreCase)]
    [InlineData("Case encyclopædia Archæology", "archæology", StringComparison.InvariantCulture)]
    [InlineData("Case encyclopædia Archæology", "archaeology", StringComparison.InvariantCultureIgnoreCase)]
    #endregion Data
    public void Remove_String_SetComparison_Fail(string testString, string removeString, StringComparison stringComparison)
    {
        string actualString = testString.Remove(removeString, stringComparison);

        Assert.Equal(testString, actualString);
    }

    #endregion Fail

    #endregion Remove(this string str, IEnumerable<string> removeStrings, StringComparison stringComparison = StringComparison.CurrentCulture)

    #region Remove(this string str, string removeString, bool ignoreCase, CultureInfo? culture)

    [Theory]
    #region Data
    [InlineData("Case encyclopædia Archæology",     "case",             true,       " encyclopædia Archæology")]
    [InlineData("Case encyclopædia Archæology",     "eNcyclopædia ",    true,       "Case Archæology")]
    [InlineData("Case encyclopædia Archæology",     " archæoLogy",      true,       "Case encyclopædia")]
    [InlineData("Case encyclopædia Archæology",     "Case",             false,      " encyclopædia Archæology")]
    [InlineData("Case encyclopædia Archæology",     "encyclopædia ",    false,      "Case Archæology")]
    [InlineData("Case encyclopædia Archæology",     " Archæology",      false,      "Case encyclopædia")]
    #endregion Data
    public void Remove_String_CultureInfo(string testString, string removeString, bool ignoreCase, string expectedString)
    {
        string actualString = testString.Remove(removeString, ignoreCase, CultureInfo.InvariantCulture);

        Assert.Equal(expectedString, actualString);
    }


    #endregion Remove(this string str, string removeString, bool ignoreCase, CultureInfo? culture)

    #region Remove(this string str, IEnumerable<string> removeStrings, StringComparison stringComparison = StringComparison.CurrentCulture)

    [Theory, MemberData(nameof(Data_Remove_IEnumString_DefaultComparison_Pass))]
    public void Remove_IEnumString_DefaultComparison_Pass(string testString, IEnumerable<string> removeStrings, string expectedString)
    {
        string actualString = testString.Remove(removeStrings);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Remove_IEnumString_SetComparison_Pass))]
    public void Remove_IEnumString_SetComparison_Pass(string testString, IEnumerable<string> removeStrings, StringComparison stringComparison, string expectedString)
    {
        string actualString = testString.Remove(removeStrings, stringComparison);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Remove_IEnumString_DefaultComparison_Fail))]
    public void Remove_IEnumString_DefaultComparison_Fail(string testString, IEnumerable<string> removeStrings)
    {
        string actualString = testString.Remove(removeStrings);

        Assert.Equal(testString, actualString);
    }

    [Theory, MemberData(nameof(Data_Remove_IEnumString_SetComparison_Fail))]
    public void Remove_IEnumString_SetComparison_Fail(string testString, IEnumerable<string> removeStrings, StringComparison stringComparison)
    {
        string actualString = testString.Remove(removeStrings, stringComparison);

        Assert.Equal(testString, actualString);
    }

    #endregion Remove(this string str, IEnumerable<string> removeStrings, StringComparison stringComparison = StringComparison.CurrentCulture)

    #region Remove(this string str, IEnumerable<string> removeStrings, bool ignoreCase, CultureInfo? culture)

    [Theory, MemberData(nameof(Data_Remove_IEnumString_CultureInfo))]
    public void Remove_IEnumString_CultureInfo(string testString, IEnumerable<string> removeStrings, bool ignoreCase, string expectedString)
    {
        string actualString = testString.Remove(removeStrings, ignoreCase, CultureInfo.InvariantCulture);

        Assert.Equal(expectedString, actualString);
    }

    #endregion Remove(this string str, IEnumerable<string> removeStrings, bool ignoreCase, CultureInfo? culture)

    #region Remove(this string str, IEnumerable<char> removeChars, StringComparison comparison = StringComparison.CurrentCulture)


    [Theory, MemberData(nameof(Data_Remove_IEnumChar_DefaultComparison_Pass))]
    public void Remove_IEnumChar_DefaultComparison_Pass(string testString, IEnumerable<char> removeChars, string expectedString)
    {
        string actualString = testString.Remove(removeChars);

        Assert.Equal(expectedString, actualString);
    }


    [Theory, MemberData(nameof(Data_Remove_IEnumChar_SetComparison_Pass))]
    public void Remove_IEnumChar_SetComparison_Pass(string testString, IEnumerable<char> removeChars, StringComparison stringComparison, string expectedString)
    {
        string actualString = testString.Remove(removeChars, stringComparison);

        Assert.Equal(expectedString, actualString);
    }


    [Theory, MemberData(nameof(Data_Remove_IEnumChar_DefaultComparison_Fail))]
    public void Remove_IEnumChar_DefaultComparison_Fail(string testString, IEnumerable<char> removeChars)
    {
        string actualString = testString.Remove(removeChars);

        Assert.Equal(testString, actualString);
    }


    [Theory, MemberData(nameof(Data_Remove_IEnumChar_SetComparison_Fail))]
    public void Remove_IEnumChar_SetComparison_Fail(string testString, IEnumerable<char> removeChars, StringComparison stringComparison)
    {
        string actualString = testString.Remove(removeChars, stringComparison);

        Assert.Equal(testString, actualString);
    }


    #endregion Remove(this string str, IEnumerable<char> removeChars, StringComparison comparison = StringComparison.CurrentCulture)

    #region Remove(this string str, IEnumerable<char> removeStrings, bool ignoreCase, CultureInfo? culture)

    [Theory, MemberData(nameof(Data_Remove_IEnumChar_CultureInfo))]
    public void Remove_IEnumChar_CultureInfo(string testString, IEnumerable<char> removeChars, bool ignoreCase, string expectedString)
    {
        string actualString = testString.Remove(removeChars, ignoreCase, CultureInfo.InvariantCulture);

        Assert.Equal(expectedString, actualString);
    }

    #endregion Remove(this string str, IEnumerable<char> removeStrings, bool ignoreCase, CultureInfo? culture)

    #region Data
    [Theory]
    [InlineData(@"rMhj5(VirYg<rS7lWuGZ", @"5(<7")]
    [InlineData(@"gNa/*+Kd($@k+$%8Fj/I", @"/*+($@+$%8/")]
    [InlineData(@"bJcnmhy7<9-h%]wk[dTc", @"7<9-%][")]
    #endregion Data
	public void RemoveLetters(string testString, string expectedString)
    {
        string actual = testString.RemoveLetters();

        Assert.Equal(expectedString, actual);
    }

    #region Data
	[Theory]
    [InlineData("b2HGLTxiVJz0cxWacceZ", "bHGLTxiVJzcxWacceZ")]
    [InlineData("S1Rsf3jsE2IPKhIML5kN", "SRsfjsEIPKhIMLkN")]
    [InlineData("xqyao0g2EwQmweZUqy6l", "xqyaogEwQmweZUqyl")]
	#endregion Data
	public void RemoveNumbers(string testString, string expectedString)
    {
        string actual = testString.RemoveNumbers();

        Assert.Equal(expectedString, actual);
    }

    #region Data
	[Theory]
    [InlineData(@"5riD+p-AvsnZImA@i[(r", @"5riDpAvsnZImAir")]
    [InlineData(@"qnxON$cEX\=i?]3s3MyB", @"qnxONcEXi3s3MyB")]
    [InlineData(@"^{b,H:b{ft^3TU<PZJGd", @"bHbft3TUPZJGd")]
    #endregion Data
	public void RemoveSpecialCharacters(string testString, string expectedString)
    {
        string actual = testString.RemoveSpecialCharacters();

        Assert.Equal(expectedString, actual);
    }

    #region Test Data

    public static IEnumerable<object[]> Data_Remove_IEnumString_DefaultComparison_Pass
        => new[]
            {
                new object[]
                { "I would have gotten the promotion, but my attendance wasn’t good enough.", new string[] { "gotten", "attendance", "would", "enough" }, "I  have  the promotion, but my  wasn’t good ." },
                ["This is the last random sentence I will be writing and I am going to stop mid-sent", new List<string>() { "random ", "writing ", " sentence" }, "This is the last I will be and I am going to stop mid-sent"],
                ["Oh, how I'd love to go!", new HashSet<string>() { "how I", ",", "go!" }, "Oh 'd love to "],
                ["Rock music approaches at high velocity.", new Queue<string>(new string[] { "Rock ", "music", " approaches", "velocity" }), " at high ."]
            };

    public static IEnumerable<object[]> Data_Remove_IEnumString_SetComparison_Pass
        => new[]
            {
                new object[]
                { "Case encyclopædia Archæology", new string[] { "case", "encyclopædia", "ARCHÆOLOGY" }, GlobalVariables.InvariantCulture, "Case  Archæology" },
                ["Case encyclopædia Archæology", new List<string>() { "Case", "encyclopaedia", "ARCHÆOLOGY" }, GlobalVariables.InvariantCulture, " encyclopædia Archæology"],
                ["Case encyclopædia Archæology", new HashSet<string>() { "case", "encyclopaedia", "Archæology" }, GlobalVariables.InvariantCulture, "Case encyclopædia "],
                ["Case encyclopædia Archæology", new Queue<string>(new string[] { "Case", "encyclopædia", "Archæology" }), GlobalVariables.InvariantCulture, "  "],

                ["Case encyclopædia Archæology", new string[] { "case", "encyclopaedia", "ARCHAEOLOGY" }, GlobalVariables.InvariantCultureIgnoreCase, " encyclopædia Archæology"],
                ["Case encyclopædia Archæology", new List<string>() { "kase", "encyclopaedia", "ARCHÆOLOGY" }, GlobalVariables.InvariantCultureIgnoreCase, "Case encyclopædia "],
                ["Case encyclopædia Archæology", new HashSet<string>() { "kase", "ENCYCLOPÆDIA", "ARCHAEOLOGY" }, GlobalVariables.InvariantCultureIgnoreCase, "Case  Archæology"],
                ["Case encyclopædia Archæology", new Queue<string>(new string[] { "case", "ENCYCLOPÆDIA", "ARCHÆOLOGY" }), GlobalVariables.InvariantCultureIgnoreCase, "  "],

                ["Case encyclopædia Archæology", new string[] { "Case", "encyclopaedia", "ARCHÆOLOGY" }, GlobalVariables.Ordinal, " encyclopædia Archæology"],
                ["Case encyclopædia Archæology", new List<string>() { "case", "encyclopædia", "ARCHÆOLOGY" }, GlobalVariables.Ordinal, "Case  Archæology"],
                ["Case encyclopædia Archæology", new HashSet<string>() { "case", "encyclopaedia", "Archæology" }, GlobalVariables.Ordinal, "Case encyclopædia "],
                ["Case encyclopædia Archæology", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), GlobalVariables.Ordinal, "Case  "],

                ["Case encyclopædia Archæology", new string[] { "case", "encyclopaedia", "ARCHÆOLOGY" }, GlobalVariables.OrdinalIgnoreCase, " encyclopædia "],
                ["Case encyclopædia Archæology", new List<string>() { "case", "encyclopaedia", "ARCHÆOLOGY" }, GlobalVariables.OrdinalIgnoreCase, " encyclopædia "],
                ["Case encyclopædia Archæology", new HashSet<string>() { "case", "encyclopaedia", "ARCHÆOLOGY" }, GlobalVariables.OrdinalIgnoreCase, " encyclopædia "],
                ["Case encyclopædia Archæology", new Queue<string>(new string[] { "case", "encyclopaedia", "ARCHÆOLOGY" }), GlobalVariables.OrdinalIgnoreCase, " encyclopædia "]
            };

    public static IEnumerable<object[]> Data_Remove_IEnumString_CultureInfo
        => new[]
            {
                new object[]
                { "Case encyclopædia Archæology", new[] { "case", "encyclopædia", "ARCHÆOLOGY" }, false, "Case  Archæology" },
                ["Case encyclopædia Archæology", new List<string>() { "Case", "encyclopaedia", "ARCHÆOLOGY" }, false, " encyclopædia Archæology"],
                ["Case encyclopædia Archæology", new HashSet<string>() { "case", "encyclopaedia", "Archæology" }, false, "Case encyclopædia "],
                ["Case encyclopædia Archæology", new Queue<string>(new[] { "Case", "encyclopædia", "Archæology" }), false, "  "],

                ["Case encyclopædia Archæology", new string[] { "case", "encyclopaedia", "ARCHAEOLOGY" }, true, " encyclopædia Archæology"],
                ["Case encyclopædia Archæology", new List<string>() { "kase", "encyclopaedia", "ARCHÆOLOGY" }, true, "Case encyclopædia "],
                ["Case encyclopædia Archæology", new HashSet<string>() { "kase", "ENCYCLOPÆDIA", "ARCHAEOLOGY" }, true, "Case  Archæology"],
                ["Case encyclopædia Archæology", new Queue<string>(new[] { "case", "ENCYCLOPÆDIA", "ARCHÆOLOGY" }), true, "  "],
            };

    public static IEnumerable<object[]> Data_Remove_IEnumString_DefaultComparison_Fail
        => new[]
            {
                new object[]
                { "I would have gotten the promotion, but my attendance wasn’t good enough.", new string[] { "dummy", "dummy", "dummy", "dummy" } },
                ["This is the last random sentence I will be writing and I am going to stop mid-sent", new List<string>() { "dummy ", "dummy ", "dummy" }],
                ["Oh, how I'd love to go!", new HashSet<string>() { "dummy", "dummy", "dummy" }],
                ["Rock music approaches at high velocity.", new Queue<string>(new string[] { "dummy", "dummy", "dummy", "dummy" })]
            };

    public static IEnumerable<object[]> Data_Remove_IEnumString_SetComparison_Fail
        => new[]
            {
                new object[]
                { "Case encyclopædia Archæology", new string[] { "dummy", "dummy", "dummy" }, GlobalVariables.InvariantCulture },
                ["Case encyclopædia Archæology", new List<string>() { "dummy", "dummy", "dummy" }, GlobalVariables.InvariantCulture],
                ["Case encyclopædia Archæology", new HashSet<string>() { "dummy", "dummy", "dummy" }, GlobalVariables.InvariantCulture],
                ["Case encyclopædia Archæology", new Queue<string>(new string[] { "dummy", "dummy", "dummy" }), GlobalVariables.InvariantCulture],

                ["Case encyclopædia Archæology", new string[] { "dummy", "dummy", "dummy" }, GlobalVariables.InvariantCultureIgnoreCase],
                ["Case encyclopædia Archæology", new List<string>() { "dummy", "dummy", "dummy" }, GlobalVariables.InvariantCultureIgnoreCase],
                ["Case encyclopædia Archæology", new HashSet<string>() { "dummy", "dummy", "dummy" }, GlobalVariables.InvariantCultureIgnoreCase],
                ["Case encyclopædia Archæology", new Queue<string>(new string[] { "dummy", "dummy", "dummy" }), GlobalVariables.InvariantCultureIgnoreCase],

                ["Case encyclopædia Archæology", new string[] { "dummy", "dummy", "dummy" }, GlobalVariables.Ordinal],
                ["Case encyclopædia Archæology", new List<string>() { "dummy", "dummy", "dummy" }, GlobalVariables.Ordinal],
                ["Case encyclopædia Archæology", new HashSet<string>() { "dummy", "dummy", "dummy" }, GlobalVariables.Ordinal],
                ["Case encyclopædia Archæology", new Queue<string>(new string[] { "dummy", "dummy", "dummy" }), GlobalVariables.Ordinal],

                ["Case encyclopædia Archæology", new string[] { "dummy", "dummy", "dummy" }, GlobalVariables.OrdinalIgnoreCase],
                ["Case encyclopædia Archæology", new List<string>() { "dummy", "dummy", "dummy" }, GlobalVariables.OrdinalIgnoreCase],
                ["Case encyclopædia Archæology", new HashSet<string>() { "dummy", "dummy", "dummy" }, GlobalVariables.OrdinalIgnoreCase],
                ["Case encyclopædia Archæology", new Queue<string>(new string[] { "dummy", "dummy", "dummy" }), GlobalVariables.OrdinalIgnoreCase]
            };

    public static IEnumerable<object[]> Data_Remove_IEnumChar_DefaultComparison_Pass
        => new[]
            {
                new object[]
                { "Case encyclopædia Archæology", new[] { 's', 'e', 'o' }, "Ca ncyclpædia Archælgy" },
                ["Case encyclopædia Archæology", new List<char>() { 's', 'e', 'o' }, "Ca ncyclpædia Archælgy"],
                ["Case encyclopædia Archæology", new HashSet<char>() { 's', 'e', 'o' }, "Ca ncyclpædia Archælgy"],
                ["Case encyclopædia Archæology", new Queue<char>(new[] { 's', 'e', 'o' }), "Ca ncyclpædia Archælgy"]
            };

    public static IEnumerable<object[]> Data_Remove_IEnumChar_SetComparison_Pass
        => new[]
            {
                new object[]
                { "Case encyclopædia Archæology", new[] { 's', 'e', 'o' }, GlobalVariables.InvariantCulture, "Ca ncyclpædia Archælgy" },
                ["Case encyclopædia Archæology", new List<char>() { 's', 'e', 'o' }, GlobalVariables.InvariantCulture, "Ca ncyclpædia Archælgy"],
                ["Case encyclopædia Archæology", new HashSet<char>() { 's', 'e', 'o' }, GlobalVariables.InvariantCulture, "Ca ncyclpædia Archælgy"],
                ["Case encyclopædia Archæology", new Queue<char>(new[] { 's', 'e', 'o' }), GlobalVariables.InvariantCulture, "Ca ncyclpædia Archælgy"],

                ["Case encyclopædia Archæology", new[] { 's', 'e', 'o' }, GlobalVariables.InvariantCultureIgnoreCase, "Ca ncyclpædia Archælgy"],
                ["Case encyclopædia Archæology", new List<char>() { 's', 'e', 'o' }, GlobalVariables.InvariantCultureIgnoreCase, "Ca ncyclpædia Archælgy"],
                ["Case encyclopædia Archæology", new HashSet<char>() { 's', 'e', 'o' }, GlobalVariables.InvariantCultureIgnoreCase, "Ca ncyclpædia Archælgy"],
                ["Case encyclopædia Archæology", new Queue<char>(new[] { 's', 'e', 'o' }), GlobalVariables.InvariantCultureIgnoreCase, "Ca ncyclpædia Archælgy"],

                ["Case encyclopædia Archæology", new[] { 's', 'e', 'o' }, GlobalVariables.Ordinal, "Ca ncyclpædia Archælgy"],
                ["Case encyclopædia Archæology", new List<char>() { 's', 'e', 'o' }, GlobalVariables.Ordinal, "Ca ncyclpædia Archælgy"],
                ["Case encyclopædia Archæology", new HashSet<char>() { 's', 'e', 'o' }, GlobalVariables.Ordinal, "Ca ncyclpædia Archælgy"],
                ["Case encyclopædia Archæology", new Queue<char>(new[] { 's', 'e', 'o' }), GlobalVariables.Ordinal, "Ca ncyclpædia Archælgy"],

                ["Case encyclopædia Archæology", new[] { 's', 'e', 'o' }, GlobalVariables.OrdinalIgnoreCase, "Ca ncyclpædia Archælgy"],
                ["Case encyclopædia Archæology", new List<char>() { 's', 'e', 'o' }, GlobalVariables.OrdinalIgnoreCase, "Ca ncyclpædia Archælgy"],
                ["Case encyclopædia Archæology", new HashSet<char>() { 's', 'e', 'o' }, GlobalVariables.OrdinalIgnoreCase, "Ca ncyclpædia Archælgy"],
                ["Case encyclopædia Archæology", new Queue<char>(new[] { 's', 'e', 'o' }), GlobalVariables.OrdinalIgnoreCase, "Ca ncyclpædia Archælgy"]
            };

    public static IEnumerable<object[]> Data_Remove_IEnumChar_CultureInfo
        => new[]
            {
                new object[]
                { "Case encyclopædia Archæology",               new[] { 'S', 'e', 'o' },                    true,   "Ca ncyclpædia Archælgy" },
                ["Case encyclopædia Archæology",                new List<char>() { 's', 'E', 'o' },         true,   "Ca ncyclpædia Archælgy"],
                ["Case encyclopædia Archæology",                new HashSet<char>() { 's', 'e', 'O' },      true,   "Ca ncyclpædia Archælgy"],
                ["Case encyclopædia Archæology",                new Queue<char>(new[] { 'S', 'E', 'O' }),   true,   "Ca ncyclpædia Archælgy"],
                ["Case encyclopædia Archæology",                new[] { 's', 'e', 'o' },                    false,  "Ca ncyclpædia Archælgy"],
                ["Case encyclopædia Archæology",                new List<char>() { 's', 'e', 'o' },         false,  "Ca ncyclpædia Archælgy"],
                ["Case encyclopædia Archæology",                new HashSet<char>() { 's', 'e', 'o' },      false,  "Ca ncyclpædia Archælgy"],
                ["Case encyclopædia Archæology",                new Queue<char>(new[] { 's', 'e', 'o' }),   false,  "Ca ncyclpædia Archælgy"]
            };

    public static IEnumerable<object[]> Data_Remove_IEnumChar_DefaultComparison_Fail
        => new[]
            {
                new object[]
                { "Case encyclopædia Archæology", new[] { 'z', 'z', 'z', 'z' } },
                ["Case encyclopædia Archæology", new List<char>() { 'z', 'z', 'z' }],
                ["Case encyclopædia Archæology", new HashSet<char>() { 'z', 'z', 'z' }],
                ["Case encyclopædia Archæology", new Queue<char>(new[] { 'z', 'z', 'z', 'z' })]
            };

    public static IEnumerable<object[]> Data_Remove_IEnumChar_SetComparison_Fail
        => new[]
            {
                new object[]
                { "Case encyclopædia Archæology", new[] { 'z', 'z', 'z' }, GlobalVariables.InvariantCulture },
                ["Case encyclopædia Archæology", new List<char>() { 'z', 'z', 'z' }, GlobalVariables.InvariantCulture],
                ["Case encyclopædia Archæology", new HashSet<char>() { 'z', 'z', 'z' }, GlobalVariables.InvariantCulture],
                ["Case encyclopædia Archæology", new Queue<char>(new[] { 'z', 'z', 'z' }), GlobalVariables.InvariantCulture],

                ["Case encyclopædia Archæology", new[] { 'z', 'z', 'z' }, GlobalVariables.InvariantCultureIgnoreCase],
                ["Case encyclopædia Archæology", new List<char>() { 'z', 'z', 'z' }, GlobalVariables.InvariantCultureIgnoreCase],
                ["Case encyclopædia Archæology", new HashSet<char>() { 'z', 'z', 'z' }, GlobalVariables.InvariantCultureIgnoreCase],
                ["Case encyclopædia Archæology", new Queue<char>(new[] { 'z', 'z', 'z' }), GlobalVariables.InvariantCultureIgnoreCase],

                ["Case encyclopædia Archæology", new[] { 'z', 'z', 'z' }, GlobalVariables.Ordinal],
                ["Case encyclopædia Archæology", new List<char>() { 'z', 'z', 'z' }, GlobalVariables.Ordinal],
                ["Case encyclopædia Archæology", new HashSet<char>() { 'z', 'z', 'z' }, GlobalVariables.Ordinal],
                ["Case encyclopædia Archæology", new Queue<char>(new[] { 'z', 'z', 'z' }), GlobalVariables.Ordinal],

                ["Case encyclopædia Archæology", new[] { 'z', 'z', 'z' }, GlobalVariables.OrdinalIgnoreCase],
                ["Case encyclopædia Archæology", new List<char>() { 'z', 'z', 'z' }, GlobalVariables.OrdinalIgnoreCase],
                ["Case encyclopædia Archæology", new HashSet<char>() { 'z', 'z', 'z' }, GlobalVariables.OrdinalIgnoreCase],
                ["Case encyclopædia Archæology", new Queue<char>(new[] { 'z', 'z', 'z' }), GlobalVariables.OrdinalIgnoreCase]
            };
    
    #endregion Test Data
}
