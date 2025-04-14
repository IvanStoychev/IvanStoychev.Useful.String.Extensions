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
        string expectedMessage = "The argument given for parameter \"comparison\" of method \"Substring\" does not exist in enum \"StringComparison\" (Parameter 'comparison')";

        void testAction() => testString.Substring("s", 1, false, (StringComparison)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Substring_String_Int_NullOrigInstance()
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Substring\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.Substring("a", 0);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
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
    public void Substring_String_Int_StartStringNotFound()
    {
        string testString = "";
        string expectedMessage = "The string given for \"startString\" of method \"Substring\" was not found in the original instance. (Parameter 'startString')";

        void testAction() => testString.Substring("start", 0);

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Substring(this string str, string startString, int length, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    #region Substring(this string str, string startString, string endString, StringInclusionOptions stringInclusionOptions = StringInclusionOptions.IncludeNone, StringComparison comparison = StringComparison.CurrentCulture)

    [Fact]
    public void Substring_StartEndString_EnumInvalid_StringInclusionOptions()
    {
        string testString = "asd";
        string expectedMessage = "The argument given for parameter \"inclusionOptions\" of method \"Substring\" does not exist in enum \"StringInclusionOptions\" (Parameter 'inclusionOptions')";

        void testAction() => testString.Substring("s", "d", (StringInclusionOptions)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Substring_StartEndString_EnumInvalid_StringComparison()
    {
        string testString = "";
        string expectedMessage = "The argument given for parameter \"comparison\" of method \"Substring\" does not exist in enum \"StringComparison\" (Parameter 'comparison')";

        void testAction() => testString.Substring("sad", "end", StringInclusionOptions.IncludeNone, (StringComparison)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Substring_StartEndString_NullOrigInstance()
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Substring\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.Substring("a", "b");

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Substring_StartEndString_NullStart()
    {
        string testString = "";
        string expectedMessage = "The argument given for parameter \"startString\" of method \"Substring\" was null. (Parameter 'startString')";

        void testAction() => testString.Substring(null, "end");

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Substring_StartEndString_NullEnd()
    {
        string testString = "start";
        string expectedMessage = "The argument given for parameter \"endString\" of method \"Substring\" was null. (Parameter 'endString')";

        void testAction() => testString.Substring("start", null);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Substring_StartEndString_StartOutOfRange()
    {
        string testString = "";
        string expectedMessage = "The string given for \"startString\" of method \"Substring\" was not found in the original instance. (Parameter 'startString')";

        void testAction() => testString.Substring("start", "end");

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Substring_StartEndString_EndOutOfRange()
    {
        string testString = "end start";
        string expectedMessage = "The string given for parameter \"endString\" was not found after the argument given for \"startString\" in the original instance. Name of the method throwing the exception: \"Substring\". (Parameter 'endString')";

        void testAction() => testString.Substring("start", "end");

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Substring(this string str, string startString, string endString, StringInclusionOptions stringInclusionOptions = StringInclusionOptions.IncludeNone, StringComparison comparison = StringComparison.CurrentCulture)

    #region SubstringLast(this string str, string startString, string endString, StringInclusionOptions stringInclusionOptions = StringInclusionOptions.IncludeNone, StringComparison comparison = StringComparison.CurrentCulture)

    [Fact]
    public void SubstringLast_EnumInvalid_StringInclusionOptions()
    {
        string testString = "asd";
        string expectedMessage = "The argument given for parameter \"inclusionOptions\" of method \"SubstringLast\" does not exist in enum \"StringInclusionOptions\" (Parameter 'inclusionOptions')";

        void testAction() => testString.SubstringLast("s", "d", (StringInclusionOptions)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringLast_EnumInvalid_StringComparison()
    {
        string testString = "";
        string expectedMessage = "The argument given for parameter \"comparison\" of method \"SubstringLast\" does not exist in enum \"StringComparison\" (Parameter 'comparison')";

        void testAction() => testString.SubstringLast("sad", "end", StringInclusionOptions.IncludeNone, (StringComparison)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringLast_NullOrigInstance()
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"SubstringLast\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.SubstringLast("a", "h");

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringLast_StartStringNull()
    {
        string testString = "";
        string expectedMessage = "The argument given for parameter \"startString\" of method \"SubstringLast\" was null. (Parameter 'startString')";

        void testAction() => testString.SubstringLast(null, "end");

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringLast_EndStringNull()
    {
        string testString = "start";
        string expectedMessage = "The argument given for parameter \"endString\" of method \"SubstringLast\" was null. (Parameter 'endString')";

        void testAction() => testString.SubstringLast("start", null);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringLast_StartStringOutOfRange()
    {
        string testString = "";
        string expectedMessage = "The string given for \"startString\" of method \"SubstringLast\" was not found in the original instance. (Parameter 'startString')";

        void testAction() => testString.SubstringLast("start", "end");

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringLast_EndStringOutOfRange()
    {
        string testString = "end start";
        string expectedMessage = "The string given for parameter \"endString\" was not found after the argument given for \"startString\" in the original instance. Name of the method throwing the exception: \"SubstringLast\". (Parameter 'endString')";

        void testAction() => testString.SubstringLast("start", "end");

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion SubstringLast(this string str, string startString, string endString, StringInclusionOptions stringInclusionOptions = StringInclusionOptions.IncludeNone, StringComparison comparison = StringComparison.CurrentCulture)

    #region SubstringStart(this string str, string endString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    [Fact]
    public void SubstringStart_EnumInvalid()
    {
        string testString = "asd";
        string expectedMessage = "The argument given for parameter \"comparison\" of method \"SubstringStart\" does not exist in enum \"StringComparison\" (Parameter 'comparison')";

        void testAction() => testString.SubstringStart("s", false, (StringComparison)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringStart_NullOrigInstance()
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"SubstringStart\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.SubstringStart("a");

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringStart_ArgNull()
    {
        string testString = "";
        string expectedMessage = "The argument given for parameter \"endString\" of method \"SubstringStart\" was null. (Parameter 'endString')";

        void testAction() => testString.SubstringStart(null);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringStart_ArgOutOfRange()
    {
        string testString = "";
        string expectedMessage = "The string given for \"endString\" of method \"SubstringStart\" was not found in the original instance. (Parameter 'endString')";

        void testAction() => testString.SubstringStart("end");

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion SubstringStart(this string str, string endString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    #region SubstringStartLast(this string str, string endString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    [Fact]
    public void SubstringStartLast_EnumInvalid()
    {
        string testString = "asd";
        string expectedMessage = "The argument given for parameter \"comparison\" of method \"SubstringStartLast\" does not exist in enum \"StringComparison\" (Parameter 'comparison')";

        void testAction() => testString.SubstringStartLast("s", false, (StringComparison)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringStartLast_NullOrigInstance()
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"SubstringStartLast\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.SubstringStartLast("a");

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringStartLast_ArgNull()
    {
        string testString = "";
        string expectedMessage = "The argument given for parameter \"endString\" of method \"SubstringStartLast\" was null. (Parameter 'endString')";

        void testAction() => testString.SubstringStartLast(null);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringStartLast_ArgOutOfRange()
    {
        string testString = "";
        string expectedMessage = "The string given for \"endString\" of method \"SubstringStartLast\" was not found in the original instance. (Parameter 'endString')";

        void testAction() => testString.SubstringStartLast("end");

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion SubstringStartLast(this string str, string endString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    #region SubstringEnd(this string str, string startString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    [Fact]
    public void SubstringEnd_EnumInvalid()
    {
        string testString = "asd";
        string expectedMessage = "The argument given for parameter \"comparison\" of method \"SubstringEnd\" does not exist in enum \"StringComparison\" (Parameter 'comparison')";

        void testAction() => testString.SubstringEnd("s", false, (StringComparison)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringEnd_NullOrigInstance()
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"SubstringEnd\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.SubstringEnd("a");

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringEnd_ArgNull()
    {
        string testString = "";
        string expectedMessage = "The argument given for parameter \"startString\" of method \"SubstringEnd\" was null. (Parameter 'startString')";

        void testAction() => testString.SubstringEnd(null);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringEnd_ArgOutOfRange()
    {
        string testString = "";
        string expectedMessage = "The string given for \"startString\" of method \"SubstringEnd\" was not found in the original instance. (Parameter 'startString')";

        void testAction() => testString.SubstringEnd("start");

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion SubstringEnd(this string str, string startString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    #region SubstringEndLast(this string str, string startString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    [Fact]
    public void SubstringEndLast_String_EnumInvalid()
    {
        string testString = "asd";
        string expectedMessage = "The argument given for parameter \"comparison\" of method \"SubstringEndLast\" does not exist in enum \"StringComparison\" (Parameter 'comparison')";

        void testAction() => testString.SubstringEndLast("s", false, (StringComparison)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringEndLast_String_NullOrigInstance()
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"SubstringEndLast\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.SubstringEndLast("a");

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringEndLast_String_ArgNull()
    {
        string testString = "";
        string expectedMessage = "The argument given for parameter \"startString\" of method \"SubstringEndLast\" was null. (Parameter 'startString')";

        void testAction() => testString.SubstringEndLast(null);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }    

    [Fact]
    public void SubstringEndLast_String_ArgOutOfRange()
    {
        string testString = "";
        string expectedMessage = "The string given for \"startString\" of method \"SubstringEndLast\" was not found in the original instance. (Parameter 'startString')";

        void testAction() => testString.SubstringEndLast("start");

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion SubstringEndLast(this string str, string startString, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    #region SubstringEndLast(this string str, string startString, int length, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)

    [Fact]
    public void SubstringEndLast_String_Int_EnumInvalid()
    {
        string testString = "asd";
        string expectedMessage = "The argument given for parameter \"comparison\" of method \"SubstringEndLast\" does not exist in enum \"StringComparison\" (Parameter 'comparison')";

        void testAction() => testString.SubstringEndLast("s", 0, false, (StringComparison)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringEndLast_String_Int_NullOrigInstance()
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"SubstringEndLast\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.SubstringEndLast("a", 0);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringEndLast_String_Int_ArgNull_String()
    {
        string testString = "";
        string expectedMessage = "The argument given for parameter \"startString\" of method \"SubstringEndLast\" was null. (Parameter 'startString')";

        void testAction() => testString.SubstringEndLast(null, 0);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringEndLast_String_Int_ArgOutOfRange_String()
    {
        string testString = "";
        string expectedMessage = "The string given for \"startString\" of method \"SubstringEndLast\" was not found in the original instance. (Parameter 'startString')";

        void testAction() => testString.SubstringEndLast("start", 0);

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringEndLast_String_Int_ArgOutOfRange_Int()
    {
        string testString = "start12";
        string expectedMessage = "The value given for \"length\" (\"11\") of method \"SubstringEndLast\" is longer than the remaining string by 9. (Parameter 'length')";

        void testAction() => testString.SubstringEndLast("start", 11);

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void SubstringEndLast_String_Int_ArgOutOfRange_NegativeInt()
    {
        string testString = "start";
        string expectedMessage = "The value given for \"length\" (\"-5\") of method \"SubstringEndLast\" is less than zero. (Parameter 'length')";

        void testAction() => testString.SubstringEndLast("start", -5);

        var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion SubstringEndLast(this string str, string startString, int length, bool inclusive = false, StringComparison comparison = StringComparison.CurrentCulture)
}
