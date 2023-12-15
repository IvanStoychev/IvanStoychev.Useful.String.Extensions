using System;
using System.Collections.Generic;
using System.Globalization;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Remove_Tests
{
    #region public static string Remove(this string str, string removeString, StringComparison stringComparison = StringComparison.CurrentCulture)

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

    #endregion public static string Remove(this string str, IEnumerable<string> removeStrings, StringComparison stringComparison = StringComparison.CurrentCulture)

    #region public static string Remove(this string str, IEnumerable<string> removeStrings, StringComparison stringComparison = StringComparison.CurrentCulture)

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

    #endregion public static string Remove(this string str, IEnumerable<string> removeStrings, StringComparison stringComparison = StringComparison.CurrentCulture)

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

    public static IEnumerable<object[]> Data_Remove_IEnumString_DefaultComparison_Pass => new[]
            {
                new object[] { "I would have gotten the promotion, but my attendance wasn’t good enough.", new string[] { "gotten", "attendance", "would", "enough" }, "I  have  the promotion, but my  wasn’t good ." },
                ["This is the last random sentence I will be writing and I am going to stop mid-sent", new List<string>() { "random ", "writing ", " sentence" }, "This is the last I will be and I am going to stop mid-sent"],
                ["Oh, how I'd love to go!", new HashSet<string>() { "how I", ",", "go!" }, "Oh 'd love to "],
                ["Rock music approaches at high velocity.", new Queue<string>(new string[] { "Rock ", "music", " approaches", "velocity" }), " at high ."]
            };

    public static IEnumerable<object[]> Data_Remove_IEnumString_SetComparison_Pass => new[]
            {
                new object[] { "Case encyclopædia Archæology", new string[] { "case", "encyclopædia", "ARCHÆOLOGY" }, GlobalVariables.InvariantCulture, "Case  Archæology" },
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

    public static IEnumerable<object[]> Data_Remove_IEnumString_DefaultComparison_Fail => new[]
            {
                new object[] { "I would have gotten the promotion, but my attendance wasn’t good enough.", new string[] { "dummy", "dummy", "dummy", "dummy" } },
                ["This is the last random sentence I will be writing and I am going to stop mid-sent", new List<string>() { "dummy ", "dummy ", "dummy" }],
                ["Oh, how I'd love to go!", new HashSet<string>() { "dummy", "dummy", "dummy" }],
                ["Rock music approaches at high velocity.", new Queue<string>(new string[] { "dummy", "dummy", "dummy", "dummy" })]
            };

    public static IEnumerable<object[]> Data_Remove_IEnumString_SetComparison_Fail => new[]
            {
                new object[] { "Case encyclopædia Archæology", new string[] { "dummy", "dummy", "dummy" }, GlobalVariables.InvariantCulture },
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
}
