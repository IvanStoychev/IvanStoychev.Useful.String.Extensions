using System;
using System.Collections.Generic;
using System.Globalization;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Trim_Tests_Exceptions
{
    #region Trim(this string str, string trimString, StringComparison comparison = StringComparison.CurrentCulture, bool trimWhitespace = false)

    [Fact]
    public void Trim_String_Comparison_DefaultComparison_DefaultSpaceTrim_NullOrigInstance()
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Trim\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.Trim(nullString);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #region Data
    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    #endregion Data
    public void Trim_String_Comparison_DefaultComparison_SetSpaceTrim_NullOrigInstance(bool whitespaceTrim)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Trim\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.Trim(nullString, trimWhitespace: whitespaceTrim);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #region Data
    [Theory]
    [InlineData(StringComparison.Ordinal)]
    [InlineData(StringComparison.OrdinalIgnoreCase)]
    [InlineData(StringComparison.InvariantCulture)]
    [InlineData(StringComparison.InvariantCultureIgnoreCase)]
    #endregion Data
    public void Trim_String_Comparison_SetComparison_DefaultSpaceTrim_NullOrigInstance(StringComparison comparison)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Trim\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.Trim(nullString, comparison);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #region Data
    [Theory]
    [InlineData(StringComparison.Ordinal, true)]
    [InlineData(StringComparison.Ordinal, false)]
    [InlineData(StringComparison.OrdinalIgnoreCase, true)]
    [InlineData(StringComparison.OrdinalIgnoreCase, false)]
    [InlineData(StringComparison.InvariantCulture, true)]
    [InlineData(StringComparison.InvariantCulture, false)]
    [InlineData(StringComparison.InvariantCultureIgnoreCase, true)]
    [InlineData(StringComparison.InvariantCultureIgnoreCase, false)]
    #endregion Data
    public void Trim_String_Comparison_SetComparison_SetSpaceTrim_NullOrigInstance(StringComparison comparison, bool whitespaceTrim)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Trim\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.Trim(nullString, comparison, whitespaceTrim);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Trim_String_Comparison_DefaultSpaceTrim_EnumInvalid()
    {
        string expectedMessage = "The argument \"99\" given for parameter \"comparison\" of method \"Trim\" does not exist in enum \"StringComparison\"";

        StringComparison comparison = (StringComparison)99;
        void testAction() => "test".Trim("asd", comparison);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #region Data
    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    #endregion Data
    public void Trim_String_Comparison_SetSpaceTrim_EnumInvalid(bool whitespaceTrim)
    {
        string expectedMessage = "The argument \"99\" given for parameter \"comparison\" of method \"Trim\" does not exist in enum \"StringComparison\"";

        StringComparison comparison = (StringComparison)99;
        void testAction() => "test".Trim("asd", comparison, whitespaceTrim);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Trim(this string str, string trimString, StringComparison comparison = StringComparison.CurrentCulture, bool trimWhitespace = false)

    #region Trim(this string str, string trimString, bool ignoreCase, CultureInfo? culture, bool trimWhitespace = false)

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void Trim_String_CultureInfo_SetCase_DefaultSpaceTrim_NullOrigInstance(bool ignoreCase)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Trim\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.Trim(nullString, ignoreCase, CultureInfo.InvariantCulture);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [InlineData(true, true)]
    [InlineData(true, false)]
    [InlineData(false, true)]
    [InlineData(false, false)]
    public void Trim_String_CultureInfo_SetCase_SetSpaceTrim_NullOrigInstance(bool ignoreCase, bool whitespaceTrim)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Trim\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.Trim(nullString, ignoreCase, CultureInfo.InvariantCulture, whitespaceTrim);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Trim(this string str, string trimString, bool ignoreCase, CultureInfo? culture, bool trimWhitespace = false)

    #region TrimStart(this string str, string trimString, StringComparison comparison = StringComparison.CurrentCulture, bool trimWhitespace = false)

    [Fact]
    public void TrimStart_String_Comparison_DefaultComparison_DefaultSpaceTrim_NullOrigInstance()
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"TrimStart\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.TrimStart(nullString);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #region Data
    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    #endregion Data
    public void TrimStart_String_Comparison_DefaultComparison_SetSpaceTrim_NullOrigInstance(bool whitespaceTrim)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"TrimStart\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.TrimStart(nullString, trimWhitespace: whitespaceTrim);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #region Data
    [Theory]
    [InlineData(StringComparison.Ordinal)]
    [InlineData(StringComparison.OrdinalIgnoreCase)]
    [InlineData(StringComparison.InvariantCulture)]
    [InlineData(StringComparison.InvariantCultureIgnoreCase)]
    #endregion Data
    public void TrimStart_String_Comparison_SetComparison_DefaultSpaceTrim_NullOrigInstance(StringComparison comparison)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"TrimStart\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.TrimStart(nullString, comparison);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #region Data
    [Theory]
    [InlineData(StringComparison.Ordinal, true)]
    [InlineData(StringComparison.Ordinal, false)]
    [InlineData(StringComparison.OrdinalIgnoreCase, true)]
    [InlineData(StringComparison.OrdinalIgnoreCase, false)]
    [InlineData(StringComparison.InvariantCulture, true)]
    [InlineData(StringComparison.InvariantCulture, false)]
    [InlineData(StringComparison.InvariantCultureIgnoreCase, true)]
    [InlineData(StringComparison.InvariantCultureIgnoreCase, false)]
    #endregion Data
    public void TrimStart_String_Comparison_SetComparison_SetSpaceTrim_NullOrigInstance(StringComparison comparison, bool whitespaceTrim)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"TrimStart\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.TrimStart(nullString, comparison, whitespaceTrim);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void TrimStart_String_Comparison_DefaultSpaceTrim_EnumInvalid()
    {
        string expectedMessage = "The argument \"99\" given for parameter \"comparison\" of method \"TrimStart\" does not exist in enum \"StringComparison\"";

        StringComparison comparison = (StringComparison)99;
        void testAction() => "test".TrimStart("asd", comparison);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #region Data
    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    #endregion Data
    public void TrimStart_String_Comparison_SetSpaceTrim_EnumInvalid(bool whitespaceTrim)
    {
        string expectedMessage = "The argument \"99\" given for parameter \"comparison\" of method \"TrimStart\" does not exist in enum \"StringComparison\"";

        StringComparison comparison = (StringComparison)99;
        void testAction() => "test".TrimStart("asd", comparison, whitespaceTrim);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion TrimStart(this string str, string trimString, StringComparison comparison = StringComparison.CurrentCulture, bool trimWhitespace = false)

    #region TrimStart(this string str, string trimString, bool ignoreCase, CultureInfo? culture, bool trimWhitespace = false)

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void TrimStart_String_CultureInfo_SetCase_DefaultSpaceTrim_NullOrigInstance(bool ignoreCase)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"TrimStart\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.TrimStart(nullString, ignoreCase, CultureInfo.InvariantCulture);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [InlineData(true, true)]
    [InlineData(true, false)]
    [InlineData(false, true)]
    [InlineData(false, false)]
    public void TrimStart_String_CultureInfo_SetCase_SetSpaceTrim_NullOrigInstance(bool ignoreCase, bool whitespaceTrim)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"TrimStart\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.TrimStart(nullString, ignoreCase, CultureInfo.InvariantCulture, whitespaceTrim);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion TrimStart(this string str, string trimString, bool ignoreCase, CultureInfo? culture, bool trimWhitespace = false)

    #region TrimEnd(this string str, string trimString, StringComparison comparison = StringComparison.CurrentCulture, bool trimWhitespace = false)

    [Fact]
    public void TrimEnd_String_Comparison_DefaultComparison_DefaultSpaceTrim_NullOrigInstance()
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"TrimEnd\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.TrimEnd(nullString);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #region Data
    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    #endregion Data
    public void TrimEnd_String_Comparison_DefaultComparison_SetSpaceTrim_NullOrigInstance(bool whitespaceTrim)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"TrimEnd\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.TrimEnd(nullString, trimWhitespace: whitespaceTrim);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #region Data
    [Theory]
    [InlineData(StringComparison.Ordinal)]
    [InlineData(StringComparison.OrdinalIgnoreCase)]
    [InlineData(StringComparison.InvariantCulture)]
    [InlineData(StringComparison.InvariantCultureIgnoreCase)]
    #endregion Data
    public void TrimEnd_String_Comparison_SetComparison_DefaultSpaceTrim_NullOrigInstance(StringComparison comparison)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"TrimEnd\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.TrimEnd(nullString, comparison);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #region Data
    [Theory]
    [InlineData(StringComparison.Ordinal, true)]
    [InlineData(StringComparison.Ordinal, false)]
    [InlineData(StringComparison.OrdinalIgnoreCase, true)]
    [InlineData(StringComparison.OrdinalIgnoreCase, false)]
    [InlineData(StringComparison.InvariantCulture, true)]
    [InlineData(StringComparison.InvariantCulture, false)]
    [InlineData(StringComparison.InvariantCultureIgnoreCase, true)]
    [InlineData(StringComparison.InvariantCultureIgnoreCase, false)]
    #endregion Data
    public void TrimEnd_String_Comparison_SetComparison_SetSpaceTrim_NullOrigInstance(StringComparison comparison, bool whitespaceTrim)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"TrimEnd\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.TrimEnd(nullString, comparison, whitespaceTrim);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void TrimEnd_String_Comparison_DefaultSpaceTrim_EnumInvalid()
    {
        string expectedMessage = "The argument \"99\" given for parameter \"comparison\" of method \"TrimEnd\" does not exist in enum \"StringComparison\"";

        StringComparison comparison = (StringComparison)99;
        void testAction() => "test".TrimEnd("asd", comparison);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #region Data
    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    #endregion Data
    public void TrimEnd_String_Comparison_SetSpaceTrim_EnumInvalid(bool whitespaceTrim)
    {
        string expectedMessage = "The argument \"99\" given for parameter \"comparison\" of method \"TrimEnd\" does not exist in enum \"StringComparison\"";

        StringComparison comparison = (StringComparison)99;
        void testAction() => "test".TrimEnd("asd", comparison, whitespaceTrim);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion TrimEnd(this string str, string trimString, StringComparison comparison = StringComparison.CurrentCulture, bool trimWhitespace = false)

    #region TrimEnd(this string str, string trimString, bool ignoreCase, CultureInfo? culture, bool trimWhitespace = false)

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void TrimEnd_String_CultureInfo_SetCase_DefaultSpaceTrim_NullOrigInstance(bool ignoreCase)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"TrimEnd\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.TrimEnd(nullString, ignoreCase, CultureInfo.InvariantCulture);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [InlineData(true, true)]
    [InlineData(true, false)]
    [InlineData(false, true)]
    [InlineData(false, false)]
    public void TrimEnd_String_CultureInfo_SetCase_SetSpaceTrim_NullOrigInstance(bool ignoreCase, bool whitespaceTrim)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"TrimEnd\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.TrimEnd(nullString, ignoreCase, CultureInfo.InvariantCulture, whitespaceTrim);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion TrimEnd(this string str, string trimString, bool ignoreCase, CultureInfo? culture, bool trimWhitespace = false)
}
