using System;
using System.Collections.Generic;
using System.Globalization;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Remover_Tests
{
    #region public static string Remove(this string str, IEnumerable<string> removeStrings, StringComparison stringComparison = StringComparison.CurrentCulture)

    [Theory, MemberData(nameof(Data_Remove_DefaultComparison_Pass))]
    public void Remove_DefaultComparison_Pass(string testString, IEnumerable<string> removeStrings, string expectedString)
    {
        string actualString = testString.Remove(removeStrings);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Remove_SetComparison_Pass))]
    public void Remove_SetComparison_Pass(string testString, IEnumerable<string> removeStrings, StringComparison stringComparison, string expectedString)
    {
        string actualString = testString.Remove(removeStrings, stringComparison);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Remove_DefaultComparison_Fail))]
    public void Remove_DefaultComparison_Fail(string testString, IEnumerable<string> removeStrings)
    {
        string actualString = testString.Remove(removeStrings);

        Assert.Equal(testString, actualString);
    }

    [Theory, MemberData(nameof(Data_Remove_SetComparison_Fail))]
    public void Remove_SetComparison_Fail(string testString, IEnumerable<string> removeStrings, StringComparison stringComparison)
    {
        string actualString = testString.Remove(removeStrings, stringComparison);

        Assert.Equal(testString, actualString);
    }

    #endregion public static string Remove(this string str, IEnumerable<string> removeStrings, StringComparison stringComparison = StringComparison.CurrentCulture)

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

    #region Trim

    #region Pass

    #region Data

    [Theory]
    [InlineData("encyclopædia Case Archæology encyclopædia", "encyclopædia", " Case Archæology ")]
    [InlineData("Case encyclopædia Archæology", "Case", " encyclopædia Archæology")]
    [InlineData("encyclopædia Case Archæology", "Archæology", "encyclopædia Case ")]

    #endregion Data
	public void Trim_DefaultComparison_DefaultWhitespaceTrim_Pass(string testString, string stringToRemove, string expectedString)
    {
        string actual = testString.Trim(stringToRemove);

        Assert.Equal(expectedString, actual);
    }

    #region Data

	[Theory]
    [InlineData("encyclopædia Case Archæology encyclopædia", "encyclopædia", StringComparison.InvariantCulture, " Case Archæology ")]
    [InlineData("Case encyclopædia Archæology", "Case", StringComparison.InvariantCulture, " encyclopædia Archæology")]
    [InlineData("encyclopædia Case Archæology", "Archæology", StringComparison.InvariantCulture, "encyclopædia Case ")]

    [InlineData("encyclopædia Case Archæology encyclopædia", "encyclopædia", StringComparison.InvariantCultureIgnoreCase, " Case Archæology ")]
    [InlineData("Case encyclopædia Archæology", "Case", StringComparison.InvariantCultureIgnoreCase, " encyclopædia Archæology")]
    [InlineData("encyclopædia Case Archæology", "Archæology", StringComparison.InvariantCultureIgnoreCase, "encyclopædia Case ")]

    [InlineData("encyclopædia Case Archæology encyclopædia", "encyclopædia", StringComparison.Ordinal, " Case Archæology ")]
    [InlineData("Case encyclopædia Archæology", "Case", StringComparison.Ordinal, " encyclopædia Archæology")]
    [InlineData("encyclopædia Case Archæology", "Archæology", StringComparison.Ordinal, "encyclopædia Case ")]

    [InlineData("encyclopædia Case Archæology encyclopædia", "encyclopædia", StringComparison.OrdinalIgnoreCase, " Case Archæology ")]
    [InlineData("Case encyclopædia Archæology", "Case", StringComparison.OrdinalIgnoreCase, " encyclopædia Archæology")]
    [InlineData("encyclopædia Case Archæology", "Archæology", StringComparison.OrdinalIgnoreCase, "encyclopædia Case ")]
    
    #endregion Data
	public void Trim_SetComparison_DefaultWhitespaceTrim_Pass(string testString, string stringToRemove, StringComparison stringComparison, string expectedString)
    {
        string actual = testString.Trim(stringToRemove, stringComparison);

        Assert.Equal(expectedString, actual);
    }

    #region Data

	[Theory]
    [InlineData("encyclopædia Case Archæology encyclopædia", "encyclopædia", StringComparison.InvariantCulture, " Case Archæology ")]
    [InlineData("Case encyclopædia Archæology", "Case", StringComparison.InvariantCulture, " encyclopædia Archæology")]
    [InlineData("encyclopædia Case Archæology", "Archæology", StringComparison.InvariantCulture, "encyclopædia Case ")]

    [InlineData("encyclopædia Case Archæology encyclopædia", "encyclopædia", StringComparison.InvariantCultureIgnoreCase, " Case Archæology ")]
    [InlineData("Case encyclopædia Archæology", "Case", StringComparison.InvariantCultureIgnoreCase, " encyclopædia Archæology")]
    [InlineData("encyclopædia Case Archæology", "Archæology", StringComparison.InvariantCultureIgnoreCase, "encyclopædia Case ")]

    [InlineData("encyclopædia Case Archæology encyclopædia", "encyclopædia", StringComparison.Ordinal, " Case Archæology ")]
    [InlineData("Case encyclopædia Archæology", "Case", StringComparison.Ordinal, " encyclopædia Archæology")]
    [InlineData("encyclopædia Case Archæology", "Archæology", StringComparison.Ordinal, "encyclopædia Case ")]

    [InlineData("encyclopædia Case Archæology encyclopædia", "encyclopædia", StringComparison.OrdinalIgnoreCase, " Case Archæology ")]
    [InlineData("Case encyclopædia Archæology", "Case", StringComparison.OrdinalIgnoreCase, " encyclopædia Archæology")]
    [InlineData("encyclopædia Case Archæology", "Archæology", StringComparison.OrdinalIgnoreCase, "encyclopædia Case ")]
    
	#endregion Data
	public void Trim_SetComparison_DontTrimWhitespace_Pass(string testString, string stringToRemove, StringComparison stringComparison, string expectedString)
    {
        string actual = testString.Trim(stringToRemove, stringComparison, false);

        Assert.Equal(expectedString, actual);
    }

    #region Data

	[Theory]
    [InlineData("encyclopædia Case Archæology encyclopædia", "encyclopædia", StringComparison.InvariantCulture, "Case Archæology")]
    [InlineData("Case encyclopædia Archæology", "Case", StringComparison.InvariantCulture, "encyclopædia Archæology")]
    [InlineData("encyclopædia Case Archæology", "Archæology", StringComparison.InvariantCulture, "encyclopædia Case")]

    [InlineData("encyclopædia Case Archæology encyclopædia", "encyclopædia", StringComparison.InvariantCultureIgnoreCase, "Case Archæology")]
    [InlineData("Case encyclopædia Archæology", "Case", StringComparison.InvariantCultureIgnoreCase, "encyclopædia Archæology")]
    [InlineData("encyclopædia Case Archæology", "Archæology", StringComparison.InvariantCultureIgnoreCase, "encyclopædia Case")]

    [InlineData("encyclopædia Case Archæology encyclopædia", "encyclopædia", StringComparison.Ordinal, "Case Archæology")]
    [InlineData("Case encyclopædia Archæology", "Case", StringComparison.Ordinal, "encyclopædia Archæology")]
    [InlineData("encyclopædia Case Archæology", "Archæology", StringComparison.Ordinal, "encyclopædia Case")]

    [InlineData("encyclopædia Case Archæology encyclopædia", "encyclopædia", StringComparison.OrdinalIgnoreCase, "Case Archæology")]
    [InlineData("Case encyclopædia Archæology", "Case", StringComparison.OrdinalIgnoreCase, "encyclopædia Archæology")]
    [InlineData("encyclopædia Case Archæology", "Archæology", StringComparison.OrdinalIgnoreCase, "encyclopædia Case")]
    
	#endregion Data
	public void Trim_SetComparison_TrimWhitespace_Pass(string testString, string stringToRemove, StringComparison stringComparison, string expectedString)
    {
        string actual = testString.Trim(stringToRemove, stringComparison, true);

        Assert.Equal(expectedString, actual);
    }

    #region Data

	[Theory]
    [InlineData("RemoveMe text RemoveMe", "Removeme", " text ")]
    [InlineData("RemoveMe text", "removeMe", " text")]
    [InlineData("text RemoveMe", "removeme", "text ")]
    
	#endregion Data
	public void Trim_CultureInfo_IgnoreCase_DefaultWhitespaceTrim_Pass(string testString, string stringToRemove, string expectedString)
    {
        string actual = testString.Trim(stringToRemove, true, CultureInfo.InvariantCulture);

        Assert.Equal(expectedString, actual);
    }

    #region Data

	[Theory]
    [InlineData("RemoveMe text RemoveMe", "Removeme", " text ")]
    [InlineData("RemoveMe text", "removeMe", " text")]
    [InlineData("text RemoveMe", "removeme", "text ")]
    
	#endregion Data
	public void Trim_CultureInfo_IgnoreCase_DontTrimWhitespace_Pass(string testString, string stringToRemove, string expectedString)
    {
        string actual = testString.Trim(stringToRemove, true, CultureInfo.InvariantCulture, false);

        Assert.Equal(expectedString, actual);
    }

    #region Data

	[Theory]
    [InlineData("RemoveMe text RemoveMe", "Removeme", "text")]
    [InlineData("RemoveMe text", "removeMe", "text")]
    [InlineData("text RemoveMe", "removeme", "text")]
    
	#endregion Data
	public void Trim_CultureInfo_IgnoreCase_TrimWhitespace_Pass(string testString, string stringToRemove, string expectedString)
    {
        string actual = testString.Trim(stringToRemove, true, CultureInfo.InvariantCulture, true);

        Assert.Equal(expectedString, actual);
    }

    #region Data

	[Theory]
    [InlineData("RemoveMe text RemoveMe", "RemoveMe", " text ")]
    [InlineData("RemoveMe text Removeme", "RemoveMe", " text Removeme")]
    [InlineData("removeme text RemoveMe", "RemoveMe", "removeme text ")]
    
	#endregion Data
	public void Trim_CultureInfo_ConsiderCase_DefaultWhitespaceTrim_Pass(string testString, string stringToRemove, string expectedString)
    {
        string actual = testString.Trim(stringToRemove, false, CultureInfo.InvariantCulture);

        Assert.Equal(expectedString, actual);
    }

    #region Data

	[Theory]
    [InlineData("RemoveMe text RemoveMe", "RemoveMe", " text ")]
    [InlineData("RemoveMe text Removeme", "RemoveMe", " text Removeme")]
    [InlineData("removeme text RemoveMe", "RemoveMe", "removeme text ")]
    
	#endregion Data
	public void Trim_CultureInfo_ConsiderCase_DontTrimWhitespace_Pass(string testString, string stringToRemove, string expectedString)
    {
        string actual = testString.Trim(stringToRemove, false, CultureInfo.InvariantCulture, false);

        Assert.Equal(expectedString, actual);
    }

    #region Data

	[Theory]
    [InlineData("RemoveMe text RemoveMe", "RemoveMe", "text")]
    [InlineData("RemoveMe text Removeme", "RemoveMe", "text Removeme")]
    [InlineData("removeme text RemoveMe", "RemoveMe", "removeme text")]

    #endregion Data
    public void Trim_CultureInfo_ConsiderCase_TrimWhitespace_Pass(string testString, string stringToRemove, string expectedString)
    {
        string actual = testString.Trim(stringToRemove, false, CultureInfo.InvariantCulture, true);

        Assert.Equal(expectedString, actual);
    }

    #endregion Pass

    #region Fail

    #region Data

    [Theory]
    [InlineData(" encyclopædia Case Archæology", "dummy")]
    [InlineData("Case encyclopædia Archæology ", "dummy")]
    [InlineData(" Archæology encyclopædia Case", "dummy")]
    [InlineData("archæology encyclopædia Case ", "dummy")]
    
	#endregion Data
	public void Trim_DefaultComparison_DefaultWhitespaceTrim_Fail(string testString, string stringToRemove)
    {
        string actual = testString.Trim(stringToRemove);

        Assert.Equal(testString, actual);
    }

    #region Data

	[Theory]
    [InlineData(" encyclopædia Case Archæology", "dummy", StringComparison.InvariantCulture)]
    [InlineData("Case encyclopædia Archæology ", "dummy", StringComparison.InvariantCultureIgnoreCase)]
    [InlineData(" Archæology encyclopædia Case", "dummy", StringComparison.Ordinal)]
    [InlineData("archæology encyclopædia Case ", "dummy", StringComparison.OrdinalIgnoreCase)]
    
	#endregion Data
	public void Trim_SetComparison_DefaultWhitespaceTrim_Fail(string testString, string stringToRemove, StringComparison stringComparison)
    {
        string actual = testString.Trim(stringToRemove, stringComparison);

        Assert.Equal(testString, actual);
    }

    #region Data

	[Theory]
    [InlineData(" encyclopædia Case Archæology", "dummy", StringComparison.InvariantCulture)]
    [InlineData("Case encyclopædia Archæology ", "dummy", StringComparison.InvariantCultureIgnoreCase)]
    [InlineData(" Archæology encyclopædia Case", "dummy", StringComparison.Ordinal)]
    [InlineData("archæology encyclopædia Case ", "dummy", StringComparison.OrdinalIgnoreCase)]
    
	#endregion Data
	public void Trim_SetComparison_DontTrimWhitespace_Fail(string testString, string stringToRemove, StringComparison stringComparison)
    {
        string actual = testString.Trim(stringToRemove, stringComparison, false);

        Assert.Equal(testString, actual);
    }

    #region Data

	[Theory]
    [InlineData(" encyclopædia Case Archæology", "dummy", StringComparison.InvariantCulture, "encyclopædia Case Archæology")]
    [InlineData("Case encyclopædia Archæology ", "dummy", StringComparison.InvariantCultureIgnoreCase, "Case encyclopædia Archæology")]
    [InlineData(" Archæology encyclopædia Case", "dummy", StringComparison.Ordinal, "Archæology encyclopædia Case")]
    [InlineData("archæology encyclopædia Case ", "dummy", StringComparison.OrdinalIgnoreCase, "archæology encyclopædia Case")]
    
	#endregion Data
	public void Trim_SetComparison_TrimWhitespace_Fail(string testString, string stringToRemove, StringComparison stringComparison, string expectedString)
    {
        string actual = testString.Trim(stringToRemove, stringComparison, true);

        Assert.Equal(expectedString, actual);
    }

    #region Data

	[Theory]
    [InlineData(" RemoveMe text RemoveMe", "dummy")]
    [InlineData("RemoveMe text ", "dummy")]
    [InlineData(" text RemoveMe ", "dummy")]
    
	#endregion Data
	public void Trim_CultureInfo_IgnoreCase_DefaultWhitespaceTrim_Fail(string testString, string stringToRemove)
    {
        string actual = testString.Trim(stringToRemove, true, CultureInfo.InvariantCulture);

        Assert.Equal(testString, actual);
    }

    #region Data

	[Theory]
    [InlineData(" RemoveMe text RemoveMe", "dummy")]
    [InlineData("RemoveMe text ", "dummy")]
    [InlineData(" text RemoveMe ", "dummy")]
    
	#endregion Data
	public void Trim_CultureInfo_IgnoreCase_DontTrimWhitespace_Fail(string testString, string stringToRemove)
    {
        string actual = testString.Trim(stringToRemove, true, CultureInfo.InvariantCulture, false);

        Assert.Equal(testString, actual);
    }

    #region Data

	[Theory]
    [InlineData(" RemoveMe text RemoveMe", "dummy", "RemoveMe text RemoveMe")]
    [InlineData("RemoveMe text ", "dummy", "RemoveMe text")]
    [InlineData(" text RemoveMe ", "dummy", "text RemoveMe")]
    
	#endregion Data
	public void Trim_CultureInfo_IgnoreCase_TrimWhitespace_Fail(string testString, string stringToRemove, string expectedString)
    {
        string actual = testString.Trim(stringToRemove, true, CultureInfo.InvariantCulture, true);

        Assert.Equal(expectedString, actual);
    }

    #region Data

	[Theory]
    [InlineData(" RemoveMe text RemoveMe", "dummy")]
    [InlineData("RemoveMe text ", "dummy")]
    [InlineData(" text RemoveMe ", "dummy")]
    
	#endregion Data
	public void Trim_CultureInfo_ConsiderCase_DefaultWhitespaceTrim_Fail(string testString, string stringToRemove)
    {
        string actual = testString.Trim(stringToRemove, false, CultureInfo.InvariantCulture);

        Assert.Equal(testString, actual);
    }

    #region Data

	[Theory]
    [InlineData(" RemoveMe text RemoveMe", "dummy")]
    [InlineData("RemoveMe text ", "dummy")]
    [InlineData(" text RemoveMe ", "dummy")]
    
	#endregion Data
	public void Trim_CultureInfo_ConsiderCase_DontTrimWhitespace_Fail(string testString, string stringToRemove)
    {
        string actual = testString.Trim(stringToRemove, false, CultureInfo.InvariantCulture, false);

        Assert.Equal(testString, actual);
    }

    #region Data

	[Theory]
    [InlineData(" RemoveMe text RemoveMe", "dummy", "RemoveMe text RemoveMe")]
    [InlineData("RemoveMe text ", "dummy", "RemoveMe text")]
    [InlineData(" text RemoveMe ", "dummy", "text RemoveMe")]
    
	#endregion Data
	public void Trim_CultureInfo_ConsiderCase_TrimWhitespace_Fail(string testString, string stringToRemove, string expectedString)
    {
        string actual = testString.Trim(stringToRemove, false, CultureInfo.InvariantCulture, true);

        Assert.Equal(expectedString, actual);
    }

    #endregion Fail

    #endregion Trim

    #region TrimStart

    #region Pass

    #region Data

    [Theory]
    [InlineData("encyclopædia Case Archæology ", "encyclopædia", " Case Archæology ")]
    [InlineData("Case encyclopædia Archæology", "Case", " encyclopædia Archæology")]
    [InlineData("Archæology encyclopædia Case ", "Archæology ", "encyclopædia Case ")]

    #endregion Data
    public void TrimStart_DefaultComparison_DefaultWhitespaceTrim_Pass(string testString, string stringToRemove, string expectedString)
    {
        string actual = testString.TrimStart(stringToRemove);

        Assert.Equal(expectedString, actual);
    }

    #region Data

    [Theory]
    [InlineData("encyclopædia Case Archæology", "encyclopædia", StringComparison.InvariantCulture, " Case Archæology")]
    [InlineData("Case encyclopædia Archæology", "case", StringComparison.InvariantCultureIgnoreCase, " encyclopædia Archæology")]
    [InlineData("Archæology encyclopædia Case ", "Archæology", StringComparison.Ordinal, " encyclopædia Case ")]
    [InlineData("Archæology encyclopædia Case ", "archæology", StringComparison.OrdinalIgnoreCase, " encyclopædia Case ")]
    
	#endregion Data
	public void TrimStart_SetComparison_DefaultWhitespaceTrim_Pass(string testString, string stringToRemove, StringComparison stringComparison, string expectedString)
    {
        string actual = testString.TrimStart(stringToRemove, stringComparison);

        Assert.Equal(expectedString, actual);
    }

    #region Data

    [Theory]
    [InlineData("encyclopædia Case Archæology", "encyclopædia", StringComparison.InvariantCulture, " Case Archæology")]
    [InlineData("Case encyclopædia Archæology", "case", StringComparison.InvariantCultureIgnoreCase, " encyclopædia Archæology")]
    [InlineData("Archæology encyclopædia Case ", "Archæology", StringComparison.Ordinal, " encyclopædia Case ")]
    [InlineData("Archæology encyclopædia Case ", "archæology", StringComparison.OrdinalIgnoreCase, " encyclopædia Case ")]

    #endregion Data
    public void TrimStart_SetComparison_DontTrimWhitespace_Pass(string testString, string stringToRemove, StringComparison stringComparison, string expectedString)
    {
        string actual = testString.TrimStart(stringToRemove, stringComparison, false);

        Assert.Equal(expectedString, actual);
    }

    #region Data

    [Theory]
    [InlineData("encyclopædia Case Archæology", "encyclopædia", StringComparison.InvariantCulture, "Case Archæology")]
    [InlineData("Case encyclopædia Archæology", "case", StringComparison.InvariantCultureIgnoreCase, "encyclopædia Archæology")]
    [InlineData("Archæology encyclopædia Case ", "Archæology", StringComparison.Ordinal, "encyclopædia Case ")]
    [InlineData("Archæology encyclopædia Case ", "archæology", StringComparison.OrdinalIgnoreCase, "encyclopædia Case ")]

    #endregion Data
    public void TrimStart_SetComparison_TrimWhitespace_Pass(string testString, string stringToRemove, StringComparison stringComparison, string expectedString)
    {
        string actual = testString.TrimStart(stringToRemove, stringComparison, true);

        Assert.Equal(expectedString, actual);
    }

    #region Data

    [Theory]
    [InlineData("encyclopædia Case Archæology ", "encyclopædia", " Case Archæology ")]
    [InlineData("Case encyclopædia Archæology", "Case", " encyclopædia Archæology")]
    [InlineData("Archæology encyclopædia Case ", "Archæology ", "encyclopædia Case ")]

    #endregion Data
    public void TrimStart_CultureInfo_DefaultWhitespaceTrim_Pass(string testString, string stringToRemove, string expectedString)
    {
        string actual = testString.TrimStart(stringToRemove, true, CultureInfo.InvariantCulture);

        Assert.Equal(expectedString, actual);
    }

    #region Data

    [Theory]
    [InlineData("encyclopædia Case Archæology ", "encyclopædia", " Case Archæology ")]
    [InlineData("Case encyclopædia Archæology", "Case", " encyclopædia Archæology")]
    [InlineData("Archæology encyclopædia Case ", "Archæology ", "encyclopædia Case ")]

    #endregion Data
    public void TrimStart_CultureInfo_DontTrimWhitespace_Pass(string testString, string stringToRemove, string expectedString)
    {
        string actual = testString.TrimStart(stringToRemove, true, CultureInfo.InvariantCulture, false);

        Assert.Equal(expectedString, actual);
    }

    #region Data

    [Theory]
    [InlineData("encyclopædia Case Archæology ", "encyclopædia", "Case Archæology ")]
    [InlineData("Case encyclopædia Archæology", "Case", "encyclopædia Archæology")]
    [InlineData("Archæology encyclopædia Case ", "Archæology ", "encyclopædia Case ")]

    #endregion Data
    public void TrimStart_CultureInfo_TrimWhitespace_Pass(string testString, string stringToRemove, string expectedString)
    {
        string actual = testString.TrimStart(stringToRemove, true, CultureInfo.InvariantCulture, true);

        Assert.Equal(expectedString, actual);
    }

    #endregion Pass
    
    #region Fail

    #region Data

    [Theory]
    [InlineData("encyclopædia Case Archæology ", "dummy")]
    [InlineData(" Case encyclopædia Archæology", "dummy")]
    [InlineData(" Archæology encyclopædia Case ", "dummy")]

    #endregion Data
    public void TrimStart_DefaultComparison_DefaultWhitespaceTrim_Fail(string testString, string stringToRemove)
    {
        string actual = testString.TrimStart(stringToRemove);

        Assert.Equal(testString, actual);
    }

    #region Data

    [Theory]
    [InlineData(" encyclopædia Case Archæology", "dummy", StringComparison.InvariantCulture)]
    [InlineData(" Case encyclopædia Archæology", "dummy", StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Archæology encyclopædia Case ", "dummy", StringComparison.Ordinal)]
    [InlineData(" Archæology encyclopædia Case ", "dummy", StringComparison.OrdinalIgnoreCase)]

    #endregion Data
    public void TrimStart_SetComparison_DefaultWhitespaceTrim_Fail(string testString, string stringToRemove, StringComparison stringComparison)
    {
        string actual = testString.TrimStart(stringToRemove, stringComparison);

        Assert.Equal(testString, actual);
    }

    #region Data

    [Theory]
    [InlineData(" encyclopædia Case Archæology", "dummy", StringComparison.InvariantCulture)]
    [InlineData(" Case encyclopædia Archæology", "dummy", StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Archæology encyclopædia Case ", "dummy", StringComparison.Ordinal)]
    [InlineData(" Archæology encyclopædia Case ", "dummy", StringComparison.OrdinalIgnoreCase)]

    #endregion Data
    public void TrimStart_SetComparison_DontTrimWhitespace_Fail(string testString, string stringToRemove, StringComparison stringComparison)
    {
        string actual = testString.TrimStart(stringToRemove, stringComparison, false);

        Assert.Equal(testString, actual);
    }

    #region Data

    [Theory]
    [InlineData(" encyclopædia Case Archæology", "dummy", StringComparison.InvariantCulture, "encyclopædia Case Archæology")]
    [InlineData(" Case encyclopædia Archæology", "dummy", StringComparison.InvariantCultureIgnoreCase, "Case encyclopædia Archæology")]
    [InlineData("Archæology encyclopædia Case ", "dummy", StringComparison.Ordinal, "Archæology encyclopædia Case ")]
    [InlineData(" Archæology encyclopædia Case ", "dummy", StringComparison.OrdinalIgnoreCase, "Archæology encyclopædia Case ")]

    #endregion Data
    public void TrimStart_SetComparison_TrimWhitespace_Fail(string testString, string stringToRemove, StringComparison stringComparison, string expectedString)
    {
        string actual = testString.TrimStart(stringToRemove, stringComparison, true);

        Assert.Equal(expectedString, actual);
    }

    #region Data

    [Theory]
    [InlineData("encyclopædia Case Archæology ", "dummy")]
    [InlineData(" Case encyclopædia Archæology", "dummy")]
    [InlineData(" Archæology encyclopædia Case ", "dummy")]

    #endregion Data
    public void TrimStart_CultureInfo_DefaultWhitespaceTrim_Fail(string testString, string stringToRemove)
    {
        string actual = testString.TrimStart(stringToRemove, true, CultureInfo.InvariantCulture);

        Assert.Equal(testString, actual);
    }

    #region Data

    [Theory]
    [InlineData("encyclopædia Case Archæology ", "dummy")]
    [InlineData(" Case encyclopædia Archæology", "dummy")]
    [InlineData(" Archæology encyclopædia Case ", "dummy")]

    #endregion Data
    public void TrimStart_CultureInfo_DontTrimWhitespace_Fail(string testString, string stringToRemove)
    {
        string actual = testString.TrimStart(stringToRemove, true, CultureInfo.InvariantCulture, false);

        Assert.Equal(testString, actual);
    }

    #region Data

    [Theory]
    [InlineData("encyclopædia Case Archæology ", "encyclopædia", "Case Archæology ")]
    [InlineData("Case encyclopædia Archæology", "Case", "encyclopædia Archæology")]
    [InlineData(" Archæology encyclopædia Case ", " Archæology", "encyclopædia Case ")]

    #endregion Data
    public void TrimStart_CultureInfo_TrimWhitespace_Fail(string testString, string stringToRemove, string expectedString)
    {
        string actual = testString.TrimStart(stringToRemove, true, CultureInfo.InvariantCulture, true);

        Assert.Equal(expectedString, actual);
    }

    #endregion Fail

    #endregion TrimStart

    #region TrimEnd

    #region Pass

    #region Data

    [Theory]
    [InlineData(" encyclopædia Case Archæology", "Archæology", " encyclopædia Case ")]
    [InlineData("encyclopædia Archæology Case", " Case", "encyclopædia Archæology")]
    [InlineData(" Archæology Case encyclopædia", "encyclopædia", " Archæology Case ")]

    #endregion Data
    public void TrimEnd_DefaultComparison_DefaultWhitespaceTrim_Pass(string testString, string stringToRemove, string expectedString)
    {
        string actual = testString.TrimEnd(stringToRemove);

        Assert.Equal(expectedString, actual);
    }

    #region Data

    [Theory]
    [InlineData(" encyclopædia Case Archæology", "Archæology", StringComparison.InvariantCulture, " encyclopædia Case ")]
    [InlineData("encyclopædia Archæology Case", " Case", StringComparison.InvariantCultureIgnoreCase, "encyclopædia Archæology")]
    [InlineData(" Archæology Case encyclopædia", "encyclopædia", StringComparison.Ordinal, " Archæology Case ")]
    [InlineData(" Archæology Case encyclopædia", " encyclopædia", StringComparison.OrdinalIgnoreCase, " Archæology Case")]

    #endregion Data
    public void TrimEnd_SetComparison_DefaultWhitespaceTrim_Pass(string testString, string stringToRemove, StringComparison stringComparison, string expectedString)
    {
        string actual = testString.TrimEnd(stringToRemove, stringComparison);

        Assert.Equal(expectedString, actual);
    }

    #region Data

    [Theory]
    [InlineData(" encyclopædia Case Archæology", "Archæology", StringComparison.InvariantCulture, " encyclopædia Case ")]
    [InlineData("encyclopædia Archæology Case", " Case", StringComparison.InvariantCultureIgnoreCase, "encyclopædia Archæology")]
    [InlineData(" Archæology Case encyclopædia", "encyclopædia", StringComparison.Ordinal, " Archæology Case ")]
    [InlineData(" Archæology Case encyclopædia", " encyclopædia", StringComparison.OrdinalIgnoreCase, " Archæology Case")]

    #endregion Data
    public void TrimEnd_SetComparison_DontTrimWhitespace_Pass(string testString, string stringToRemove, StringComparison stringComparison, string expectedString)
    {
        string actual = testString.TrimEnd(stringToRemove, stringComparison, false);

        Assert.Equal(expectedString, actual);
    }

    #region Data

    [Theory]
    [InlineData(" encyclopædia Case Archæology", "Archæology", StringComparison.InvariantCulture, " encyclopædia Case")]
    [InlineData("encyclopædia Archæology Case", " Case", StringComparison.InvariantCultureIgnoreCase, "encyclopædia Archæology")]
    [InlineData(" Archæology Case encyclopædia", "encyclopædia", StringComparison.Ordinal, " Archæology Case")]
    [InlineData(" Archæology Case encyclopædia", " encyclopædia", StringComparison.OrdinalIgnoreCase, " Archæology Case")]

    #endregion Data
    public void TrimEnd_SetComparison_TrimWhitespace_Pass(string testString, string stringToRemove, StringComparison stringComparison, string expectedString)
    {
        string actual = testString.TrimEnd(stringToRemove, stringComparison, true);

        Assert.Equal(expectedString, actual);
    }

    #region Data

    [Theory]
    [InlineData(" encyclopædia Case Archæology", "Archæology", " encyclopædia Case ")]
    [InlineData("encyclopædia Archæology Case", " Case", "encyclopædia Archæology")]
    [InlineData(" Archæology Case encyclopædia", "encyclopædia", " Archæology Case ")]

    #endregion Data
    public void TrimEnd_CultureInfo_DefaultWhitespaceTrim_Pass(string testString, string stringToRemove, string expectedString)
    {
        string actual = testString.TrimEnd(stringToRemove, true, CultureInfo.InvariantCulture);

        Assert.Equal(expectedString, actual);
    }

    #region Data

    [Theory]
    [InlineData(" encyclopædia Case Archæology", "Archæology", " encyclopædia Case ")]
    [InlineData("encyclopædia Archæology Case", " Case", "encyclopædia Archæology")]
    [InlineData(" Archæology Case encyclopædia", "encyclopædia", " Archæology Case ")]

    #endregion Data
    public void TrimEnd_CultureInfo_DontTrimWhitespace_Pass(string testString, string stringToRemove, string expectedString)
    {
        string actual = testString.TrimEnd(stringToRemove, true, CultureInfo.InvariantCulture, false);

        Assert.Equal(expectedString, actual);
    }

    #region Data

    [Theory]
    [InlineData(" encyclopædia Case Archæology", "Archæology", " encyclopædia Case")]
    [InlineData("encyclopædia Archæology Case", " Case", "encyclopædia Archæology")]
    [InlineData(" Archæology Case encyclopædia", "encyclopædia", " Archæology Case")]

    #endregion Data
    public void TrimEnd_CultureInfo_TrimWhitespace_Pass(string testString, string stringToRemove, string expectedString)
    {
        string actual = testString.TrimEnd(stringToRemove, true, CultureInfo.InvariantCulture, true);

        Assert.Equal(expectedString, actual);
    }

    #endregion Pass

    #region Fail

    #region Data

    [Theory]
    [InlineData("encyclopædia Case Archæology ", "dummy")]
    [InlineData(" Case encyclopædia Archæology", "dummy")]
    [InlineData(" Archæology encyclopædia Case ", "dummy")]

    #endregion Data
    public void TrimEnd_DefaultComparison_DefaultWhitespaceTrim_Fail(string testString, string stringToRemove)
    {
        string actual = testString.TrimEnd(stringToRemove);

        Assert.Equal(testString, actual);
    }

    #region Data

    [Theory]
    [InlineData(" encyclopædia Case Archæology", "dummy", StringComparison.InvariantCulture)]
    [InlineData(" Case encyclopædia Archæology", "dummy", StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Archæology encyclopædia Case ", "dummy", StringComparison.Ordinal)]
    [InlineData(" Archæology encyclopædia Case ", "dummy", StringComparison.OrdinalIgnoreCase)]

    #endregion Data
    public void TrimEnd_SetComparison_DefaultWhitespaceTrim_Fail(string testString, string stringToRemove, StringComparison stringComparison)
    {
        string actual = testString.TrimEnd(stringToRemove, stringComparison);

        Assert.Equal(testString, actual);
    }

    #region Data

    [Theory]
    [InlineData(" encyclopædia Case Archæology", "dummy", StringComparison.InvariantCulture)]
    [InlineData(" Case encyclopædia Archæology", "dummy", StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Archæology encyclopædia Case ", "dummy", StringComparison.Ordinal)]
    [InlineData(" Archæology encyclopædia Case ", "dummy", StringComparison.OrdinalIgnoreCase)]

    #endregion Data
    public void TrimEnd_SetComparison_DontTrimWhitespace_Fail(string testString, string stringToRemove, StringComparison stringComparison)
    {
        string actual = testString.TrimEnd(stringToRemove, stringComparison, false);

        Assert.Equal(testString, actual);
    }

    #region Data

    [Theory]
    [InlineData(" encyclopædia Case Archæology", "dummy", StringComparison.InvariantCulture, " encyclopædia Case Archæology")]
    [InlineData(" Case encyclopædia Archæology", "dummy", StringComparison.InvariantCultureIgnoreCase, " Case encyclopædia Archæology")]
    [InlineData("Archæology encyclopædia Case ", "dummy", StringComparison.Ordinal, "Archæology encyclopædia Case")]
    [InlineData(" Archæology encyclopædia Case ", "dummy", StringComparison.OrdinalIgnoreCase, " Archæology encyclopædia Case")]

    #endregion Data
    public void TrimEnd_SetComparison_TrimWhitespace_Fail(string testString, string stringToRemove, StringComparison stringComparison, string expectedString)
    {
        string actual = testString.TrimEnd(stringToRemove, stringComparison, true);

        Assert.Equal(expectedString, actual);
    }

    #region Data

    [Theory]
    [InlineData("encyclopædia Case Archæology ", "dummy")]
    [InlineData(" Case encyclopædia Archæology", "dummy")]
    [InlineData(" Archæology encyclopædia Case ", "dummy")]

    #endregion Data
    public void TrimEnd_CultureInfo_DefaultWhitespaceTrim_Fail(string testString, string stringToRemove)
    {
        string actual = testString.TrimEnd(stringToRemove, true, CultureInfo.InvariantCulture);

        Assert.Equal(testString, actual);
    }

    #region Data

    [Theory]
    [InlineData("encyclopædia Case Archæology ", "dummy")]
    [InlineData(" Case encyclopædia Archæology", "dummy")]
    [InlineData(" Archæology encyclopædia Case ", "dummy")]

    #endregion Data
    public void TrimEnd_CultureInfo_DontTrimWhitespace_Fail(string testString, string stringToRemove)
    {
        string actual = testString.TrimEnd(stringToRemove, true, CultureInfo.InvariantCulture, false);

        Assert.Equal(testString, actual);
    }

    #region Data

    [Theory]
    [InlineData("encyclopædia Case Archæology ", "dummy", "encyclopædia Case Archæology")]
    [InlineData(" Case encyclopædia Archæology", "dummy", " Case encyclopædia Archæology")]
    [InlineData(" Archæology encyclopædia Case ", " dummy", " Archæology encyclopædia Case")]

    #endregion Data
    public void TrimEnd_CultureInfo_TrimWhitespace_Fail(string testString, string stringToRemove, string expectedString)
    {
        string actual = testString.TrimEnd(stringToRemove, true, CultureInfo.InvariantCulture, true);

        Assert.Equal(expectedString, actual);
    }

    #endregion Fail

    #endregion TrimEnd

    public static IEnumerable<object[]> Data_Remove_DefaultComparison_Pass => new[]
            {
                new object[] { "I would have gotten the promotion, but my attendance wasn’t good enough.", new string[] { "gotten", "attendance", "would", "enough" }, "I  have  the promotion, but my  wasn’t good ." },
                new object[] { "This is the last random sentence I will be writing and I am going to stop mid-sent", new List<string>() { "random ", "writing ", " sentence" }, "This is the last I will be and I am going to stop mid-sent" },
                new object[] { "Oh, how I'd love to go!", new HashSet<string>() { "how I", ",", "go!" }, "Oh 'd love to " },
                new object[] { "Rock music approaches at high velocity.", new Queue<string>(new string[] { "Rock ", "music", " approaches", "velocity" }), " at high ." }
            };

    public static IEnumerable<object[]> Data_Remove_SetComparison_Pass => new[]
            {
                new object[] { "Case encyclopædia Archæology", new string[] { "case", "encyclopædia", "ARCHÆOLOGY" }, StringComparison.InvariantCulture, "Case  Archæology" },
                new object[] { "Case encyclopædia Archæology", new List<string>() { "Case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.InvariantCulture, " encyclopædia Archæology" },
                new object[] { "Case encyclopædia Archæology", new HashSet<string>() { "case", "encyclopaedia", "Archæology" }, StringComparison.InvariantCulture, "Case encyclopædia " },
                new object[] { "Case encyclopædia Archæology", new Queue<string>(new string[] { "Case", "encyclopædia", "Archæology" }), StringComparison.InvariantCulture, "  " },

                new object[] { "Case encyclopædia Archæology", new string[] { "case", "encyclopaedia", "ARCHAEOLOGY" }, StringComparison.InvariantCultureIgnoreCase, " encyclopædia Archæology" },
                new object[] { "Case encyclopædia Archæology", new List<string>() { "kase", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.InvariantCultureIgnoreCase, "Case encyclopædia " },
                new object[] { "Case encyclopædia Archæology", new HashSet<string>() { "kase", "ENCYCLOPÆDIA", "ARCHAEOLOGY" }, StringComparison.InvariantCultureIgnoreCase, "Case  Archæology" },
                new object[] { "Case encyclopædia Archæology", new Queue<string>(new string[] { "case", "ENCYCLOPÆDIA", "ARCHÆOLOGY" }), StringComparison.InvariantCultureIgnoreCase, "  " },

                new object[] { "Case encyclopædia Archæology", new string[] { "Case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.Ordinal, " encyclopædia Archæology" },
                new object[] { "Case encyclopædia Archæology", new List<string>() { "case", "encyclopædia", "ARCHÆOLOGY" }, StringComparison.Ordinal, "Case  Archæology" },
                new object[] { "Case encyclopædia Archæology", new HashSet<string>() { "case", "encyclopaedia", "Archæology" }, StringComparison.Ordinal, "Case encyclopædia " },
                new object[] { "Case encyclopædia Archæology", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), StringComparison.Ordinal, "Case  " },

                new object[] { "Case encyclopædia Archæology", new string[] { "case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.OrdinalIgnoreCase, " encyclopædia " },
                new object[] { "Case encyclopædia Archæology", new List<string>() { "case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.OrdinalIgnoreCase, " encyclopædia " },
                new object[] { "Case encyclopædia Archæology", new HashSet<string>() { "case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.OrdinalIgnoreCase, " encyclopædia " },
                new object[] { "Case encyclopædia Archæology", new Queue<string>(new string[] { "case", "encyclopaedia", "ARCHÆOLOGY" }), StringComparison.OrdinalIgnoreCase, " encyclopædia " }
            };

    public static IEnumerable<object[]> Data_Remove_DefaultComparison_Fail => new[]
            {
                new object[] { "I would have gotten the promotion, but my attendance wasn’t good enough.", new string[] { "dummy", "dummy", "dummy", "dummy" } },
                new object[] { "This is the last random sentence I will be writing and I am going to stop mid-sent", new List<string>() { "dummy ", "dummy ", "dummy" } },
                new object[] { "Oh, how I'd love to go!", new HashSet<string>() { "dummy", "dummy", "dummy" } },
                new object[] { "Rock music approaches at high velocity.", new Queue<string>(new string[] { "dummy", "dummy", "dummy", "dummy" }) }
            };

    public static IEnumerable<object[]> Data_Remove_SetComparison_Fail => new[]
            {
                new object[] { "Case encyclopædia Archæology", new string[] { "dummy", "dummy", "dummy" }, StringComparison.InvariantCulture },
                new object[] { "Case encyclopædia Archæology", new List<string>() { "dummy", "dummy", "dummy" }, StringComparison.InvariantCulture },
                new object[] { "Case encyclopædia Archæology", new HashSet<string>() { "dummy", "dummy", "dummy" }, StringComparison.InvariantCulture },
                new object[] { "Case encyclopædia Archæology", new Queue<string>(new string[] { "dummy", "dummy", "dummy" }), StringComparison.InvariantCulture },

                new object[] { "Case encyclopædia Archæology", new string[] { "dummy", "dummy", "dummy" }, StringComparison.InvariantCultureIgnoreCase },
                new object[] { "Case encyclopædia Archæology", new List<string>() { "dummy", "dummy", "dummy" }, StringComparison.InvariantCultureIgnoreCase },
                new object[] { "Case encyclopædia Archæology", new HashSet<string>() { "dummy", "dummy", "dummy" }, StringComparison.InvariantCultureIgnoreCase },
                new object[] { "Case encyclopædia Archæology", new Queue<string>(new string[] { "dummy", "dummy", "dummy" }), StringComparison.InvariantCultureIgnoreCase },

                new object[] { "Case encyclopædia Archæology", new string[] { "dummy", "dummy", "dummy" }, StringComparison.Ordinal },
                new object[] { "Case encyclopædia Archæology", new List<string>() { "dummy", "dummy", "dummy" }, StringComparison.Ordinal },
                new object[] { "Case encyclopædia Archæology", new HashSet<string>() { "dummy", "dummy", "dummy" }, StringComparison.Ordinal },
                new object[] { "Case encyclopædia Archæology", new Queue<string>(new string[] { "dummy", "dummy", "dummy" }), StringComparison.Ordinal },

                new object[] { "Case encyclopædia Archæology", new string[] { "dummy", "dummy", "dummy" }, StringComparison.OrdinalIgnoreCase },
                new object[] { "Case encyclopædia Archæology", new List<string>() { "dummy", "dummy", "dummy" }, StringComparison.OrdinalIgnoreCase },
                new object[] { "Case encyclopædia Archæology", new HashSet<string>() { "dummy", "dummy", "dummy" }, StringComparison.OrdinalIgnoreCase },
                new object[] { "Case encyclopædia Archæology", new Queue<string>(new string[] { "dummy", "dummy", "dummy" }), StringComparison.OrdinalIgnoreCase }
            };
}
