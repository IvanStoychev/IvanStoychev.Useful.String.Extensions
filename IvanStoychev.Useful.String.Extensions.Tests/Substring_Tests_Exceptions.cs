using System;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Substring_Tests_Exceptions
{
    #region Substring(this string str, string startString, int length, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    [Fact]
    public void Substring_String_Int_EnumInvalid()
    {
        string testString = "asd";
        string expectedMessage = "The argument \"99\" given for parameter \"comparison\" of method \"Substring\" does not exist in enum \"StringComparison\"";

        void testAction() => testString.Substring("s", 1, false, (StringComparison)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Substring_String_Int_LengthTooBig()
    {
        string testString = "start12";
        string expectedMessage = "The value given for \"length\" (\"11\") of method \"Substring\" is longer than the remaining string by 9. (Parameter 'length')";

        void testAction() => testString.Substring("start", 11);

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Substring_String_Int_NegativeLength()
    {
        string testString = "start";
        string expectedMessage = "The value given for \"length\" (\"-5\") of method \"Substring\" is less than zero. (Parameter 'length')";

        void testAction() => testString.Substring("start", -5);

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Substring_String_Int_NullString()
    {
        string testString = "";
        string expectedMessage = "The argument given for parameter \"startString\" of method \"Substring\" was null. (Parameter 'startString')";

        void testAction() => testString.Substring(null, 0);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Substring_String_Int_StartStringNotFound()
    {
        string testString = "";
        string expectedMessage = "The string given for \"startString\" (\"start\") of method \"Substring\" was not found in the original instance. (Parameter 'startString')";

        void testAction() => testString.Substring("start", 0);

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Substring(this string str, string startString, int length, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    #region Substring(this string str, string startString, string endString, StringInclusionOptions stringInclusionOptions = StringInclusionOptions.IncludeNone, StringComparison comparison = StringComparison.CurrentCulture)

    [Fact]
    public void Substring_StartEndString_ArgumentException_EnumInvalid_StringInclusionOptions()
    {
        string testString = "asd";
        string expectedMessage = "The argument \"99\" given for parameter \"inclusionOptions\" of method \"Substring\" does not exist in enum \"StringInclusionOptions\"";

        void testAction() => testString.Substring("s", "d", (StringInclusionOptions)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Substring_StartEndString_ArgumentException_EnumInvalid_StringComparison()
    {
        string testString = "";
        string expectedMessage = "The argument \"99\" given for parameter \"comparison\" of method \"Substring\" does not exist in enum \"StringComparison\"";

        void testAction() => testString.Substring("sad", "end", StringInclusionOptions.IncludeNone, (StringComparison)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Substring_StartEndString_ArgumentNull_Start()
    {
        string testString = "";
        string expectedMessage = "The argument given for parameter \"startString\" of method \"Substring\" was null. (Parameter 'startString')";

        void testAction() => testString.Substring(null, "end");

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Substring_StartEndString_ArgumentNull_End()
    {
        string testString = "start";
        string expectedMessage = "The argument given for parameter \"endString\" of method \"Substring\" was null. (Parameter 'endString')";

        void testAction() => testString.Substring("start", null);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Substring_StartEndString_ArgumentOutOfRange_Start()
    {
        string testString = "";
        string expectedMessage = "The string given for \"startString\" (\"start\") of method \"Substring\" was not found in the original instance. (Parameter 'startString')";

        void testAction() => testString.Substring("start", "end");

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Substring_StartEndString_ArgumentOutOfRange_End()
    {
        string testString = "end start";
        string expectedMessage = "The string given for \"endString\" (\"end\") was not found after the given \"startString\" (\"start\") in the original instance. Name of the method throwing the exception - \"Substring\". (Parameter 'endString')";

        void testAction() => testString.Substring("start", "end");

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Substring(this string str, string startString, string endString, StringInclusionOptions stringInclusionOptions = StringInclusionOptions.IncludeNone, StringComparison comparison = StringComparison.CurrentCulture)

    #region SubstringLast(this string str, string startString, string endString, StringInclusionOptions stringInclusionOptions = StringInclusionOptions.IncludeNone, StringComparison comparison = StringComparison.CurrentCulture)

    [Fact]
    public void SubstringLast_ArgumentException_EnumInvalid_StringInclusionOptions()
    {
        string testString = "asd";
        string expectedMessage = "The argument \"99\" given for parameter \"inclusionOptions\" of method \"SubstringLast\" does not exist in enum \"StringInclusionOptions\"";

        void testAction() => testString.SubstringLast("s", "d", (StringInclusionOptions)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringLast_ArgumentException_EnumInvalid_StringComparison()
    {
        string testString = "";
        string expectedMessage = "The argument \"99\" given for parameter \"comparison\" of method \"SubstringLast\" does not exist in enum \"StringComparison\"";

        void testAction() => testString.SubstringLast("sad", "end", StringInclusionOptions.IncludeNone, (StringComparison)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringLast_ArgumentNull_StartString()
    {
        string testString = "";
        string expectedMessage = "The argument given for parameter \"startString\" of method \"SubstringLast\" was null. (Parameter 'startString')";

        void testAction() => testString.SubstringLast(null, "end");

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringLast_ArgumentNull_EndString()
    {
        string testString = "start";
        string expectedMessage = "The argument given for parameter \"endString\" of method \"SubstringLast\" was null. (Parameter 'endString')";

        void testAction() => testString.SubstringLast("start", null);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringLast_ArgumentOutOfRange_StartString()
    {
        string testString = "";
        string expectedMessage = "The string given for \"startString\" (\"start\") of method \"SubstringLast\" was not found in the original instance. (Parameter 'startString')";

        void testAction() => testString.SubstringLast("start", "end");

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringLast_ArgumentOutOfRange_EndString()
    {
        string testString = "end start";
        string expectedMessage = "The string given for \"endString\" (\"end\") was not found after the given \"startString\" (\"start\") in the original instance. Name of the method throwing the exception - \"SubstringLast\". (Parameter 'endString')";

        void testAction() => testString.SubstringLast("start", "end");

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion SubstringLast(this string str, string startString, string endString, StringInclusionOptions stringInclusionOptions = StringInclusionOptions.IncludeNone, StringComparison comparison = StringComparison.CurrentCulture)

    #region SubstringStart(this string str, string endString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    [Fact]
    public void SubstringStart_ArgumentException_EnumInvalid()
    {
        string testString = "asd";
        string expectedMessage = "The argument \"99\" given for parameter \"comparison\" of method \"SubstringStart\" does not exist in enum \"StringComparison\"";

        void testAction() => testString.SubstringStart("s", false, (StringComparison)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringStart_ArgumentNull()
    {
        string testString = "";
        string expectedMessage = "The argument given for parameter \"endString\" of method \"SubstringStart\" was null. (Parameter 'endString')";

        void testAction() => testString.SubstringStart(null);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringStart_ArgumentOutOfRange()
    {
        string testString = "";
        string expectedMessage = "The string given for \"endString\" (\"end\") of method \"SubstringStart\" was not found in the original instance. (Parameter 'endString')";

        void testAction() => testString.SubstringStart("end");

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion SubstringStart(this string str, string endString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    #region SubstringStartLast(this string str, string endString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    [Fact]
    public void SubstringStartLast_ArgumentException_EnumInvalid()
    {
        string testString = "asd";
        string expectedMessage = "The argument \"99\" given for parameter \"comparison\" of method \"SubstringStartLast\" does not exist in enum \"StringComparison\"";

        void testAction() => testString.SubstringStartLast("s", false, (StringComparison)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringStartLast_ArgumentNull()
    {
        string testString = "";
        string expectedMessage = "The argument given for parameter \"endString\" of method \"SubstringStartLast\" was null. (Parameter 'endString')";

        void testAction() => testString.SubstringStartLast(null);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringStartLast_ArgumentOutOfRange()
    {
        string testString = "";
        string expectedMessage = "The string given for \"endString\" (\"end\") of method \"SubstringStartLast\" was not found in the original instance. (Parameter 'endString')";

        void testAction() => testString.SubstringStartLast("end");

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion SubstringStartLast(this string str, string endString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    #region SubstringEnd(this string str, string startString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    [Fact]
    public void SubstringEnd_ArgumentException_EnumInvalid()
    {
        string testString = "asd";
        string expectedMessage = "The argument \"99\" given for parameter \"comparison\" of method \"SubstringEnd\" does not exist in enum \"StringComparison\"";

        void testAction() => testString.SubstringEnd("s", false, (StringComparison)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringEnd_ArgumentNull()
    {
        string testString = "";
        string expectedMessage = "The argument given for parameter \"startString\" of method \"SubstringEnd\" was null. (Parameter 'startString')";

        void testAction() => testString.SubstringEnd(null);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringEnd_ArgumentOutOfRange()
    {
        string testString = "";
        string expectedMessage = "The string given for \"startString\" (\"start\") of method \"SubstringEnd\" was not found in the original instance. (Parameter 'startString')";

        void testAction() => testString.SubstringEnd("start");

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion SubstringEnd(this string str, string startString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    #region SubstringEndLast(this string str, string startString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    [Fact]
    public void SubstringEndLast_String_ArgumentException_EnumInvalid()
    {
        string testString = "asd";
        string expectedMessage = "The argument \"99\" given for parameter \"comparison\" of method \"SubstringEndLast\" does not exist in enum \"StringComparison\"";

        void testAction() => testString.SubstringEndLast("s", false, (StringComparison)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringEndLast_String_ArgumentNull()
    {
        string testString = "";
        string expectedMessage = "The argument given for parameter \"startString\" of method \"SubstringEndLast\" was null. (Parameter 'startString')";

        void testAction() => testString.SubstringEndLast(null);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }    

    [Fact]
    public void SubstringEndLast_String_ArgumentOutOfRange()
    {
        string testString = "";
        string expectedMessage = "The string given for \"startString\" (\"start\") of method \"SubstringEndLast\" was not found in the original instance. (Parameter 'startString')";

        void testAction() => testString.SubstringEndLast("start");

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion SubstringEndLast(this string str, string startString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    #region SubstringEndLast(this string str, string startString, int length, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    [Fact]
    public void SubstringEndLast_String_Int_ArgumentException_EnumInvalid()
    {
        string testString = "asd";
        string expectedMessage = "The argument \"99\" given for parameter \"comparison\" of method \"SubstringEndLast\" does not exist in enum \"StringComparison\"";

        void testAction() => testString.SubstringEndLast("s", 0, false, (StringComparison)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringEndLast_String_Int_ArgumentNull_String()
    {
        string testString = "";
        string expectedMessage = "The argument given for parameter \"startString\" of method \"SubstringEndLast\" was null. (Parameter 'startString')";

        void testAction() => testString.SubstringEndLast(null, 0);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringEndLast_String_Int_ArgumentOutOfRange_String()
    {
        string testString = "";
        string expectedMessage = "The string given for \"startString\" (\"start\") of method \"SubstringEndLast\" was not found in the original instance. (Parameter 'startString')";

        void testAction() => testString.SubstringEndLast("start", 0);

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringEndLast_String_Int_ArgumentOutOfRange_Int()
    {
        string testString = "start12";
        string expectedMessage = "The value given for \"length\" (\"11\") of method \"SubstringEndLast\" is longer than the remaining string by 9. (Parameter 'length')";

        void testAction() => testString.SubstringEndLast("start", 11);

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringEndLast_String_Int_ArgumentOutOfRange_NegativeInt()
    {
        string testString = "start";
        string expectedMessage = "The value given for \"length\" (\"-5\") of method \"SubstringEndLast\" is less than zero. (Parameter 'length')";

        void testAction() => testString.SubstringEndLast("start", -5);

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion SubstringEndLast(this string str, string startString, int length, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)
}
