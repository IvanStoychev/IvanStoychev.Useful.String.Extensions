using System;
using System.Collections.Generic;
using System.Globalization;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Remove_Tests_Exceptions
{
    #region Remove(this string str, string removeString, StringComparison comparison)

    [Fact]
    public void Remove_String_DefaultComparison_StringEmpty()
    {
        string expectedMessage = "The argument given for parameter \"removeString\" of method \"Remove\" is the empty string (\"\"). (Parameter 'removeString')";

        static void testAction() => "test".Remove("");

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Remove_String_DefaultComparison_StringNull()
    {
        string expectedMessage = "The argument given for parameter \"removeString\" of method \"Remove\" was null. (Parameter 'removeString')";

        string nullString = null;
        void testAction() => "test".Remove(nullString);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Remove_String_DefaultComparison_NullOrigInstance()
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Remove\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.Remove(nullString);

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
    public void Remove_String_SetComparison_StringEmpty(StringComparison comparison)
    {
        string expectedMessage = "The argument given for parameter \"removeString\" of method \"Remove\" is the empty string (\"\"). (Parameter 'removeString')";

        void testAction() => "test".Remove("", comparison);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #region Data
    [Theory]
    [InlineData(StringComparison.Ordinal)]
    [InlineData(StringComparison.OrdinalIgnoreCase)]
    [InlineData(StringComparison.InvariantCulture)]
    [InlineData(StringComparison.InvariantCultureIgnoreCase)]
    #endregion Data
    public void Remove_String_SetComparison_StringNull(StringComparison comparison)
    {
        string expectedMessage = "The argument given for parameter \"removeString\" of method \"Remove\" was null. (Parameter 'removeString')";

        string nullString = null;
        void testAction() => "test".Remove(nullString, comparison);

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
    public void Remove_String_SetComparison_NullOrigInstance(StringComparison comparison)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Remove\" was called is null. (Parameter 'Original string instance')";

        string nullString = null;
        void testAction() => testString.Remove(nullString, comparison);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Remove_String_SetComparison_EnumInvalid()
    {
        string expectedMessage = "The argument given for parameter \"comparison\" of method \"Remove\" does not exist in enum \"StringComparison\" (Parameter 'comparison')";

        StringComparison comparison = (StringComparison)99;
        void testAction() => "test".Remove("asd", comparison);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Remove(this string str, string removeString, StringComparison comparison)

    #region Remove(this string str, string removeString, bool ignoreCase, CultureInfo? culture)

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void Remove_String_CultureInfo_StringEmpty(bool ignoreCase)
    {
        string expectedMessage = "The argument given for parameter \"removeString\" of method \"Remove\" is the empty string (\"\"). (Parameter 'removeString')";

        void testAction() => "test".Remove("", ignoreCase, CultureInfo.InvariantCulture);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void Remove_String_CultureInfo_StringNull(bool ignoreCase)
    {
        string expectedMessage = "The argument given for parameter \"removeString\" of method \"Remove\" was null. (Parameter 'removeString')";

        string nullString = null;
        void testAction() => "test".Remove(nullString, ignoreCase, CultureInfo.InvariantCulture);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void Remove_String_CultureInfo_NullOrigInstance(bool ignoreCase)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Remove\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.Remove("asd", ignoreCase, CultureInfo.InvariantCulture);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }


    #endregion Remove(this string str, string removeString, bool ignoreCase, CultureInfo? culture)

    #region Remove(this string str, IEnumerable<string> removeStrings, StringComparison comparison)


    [Theory, MemberData(nameof(Data_Remove_IEnumString_SetComparison_NullArgument))]
    public void Remove_IEnumString_SetComparison_IEnumNull(StringComparison comparison)
    {
        IEnumerable<string> removeStrings = null;
        string testString = "testString";
        string expectedMessage = "The argument given for parameter \"removeStrings\" of method \"Remove\" was null. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings, comparison);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }


    [Theory, MemberData(nameof(Data_Remove_IEnumString_SetComparison_IEnumEmpty))]
    public void Remove_IEnumString_SetComparison_IEnumEmpty(IEnumerable<string> removeStrings, StringComparison comparison)
    {
        string testString = "testString";
        string expectedMessage = "The collection argument given for parameter \"removeStrings\" of method \"Remove\" contains no elements. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings, comparison);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }


    [Theory, MemberData(nameof(Data_Remove_IEnumString_SetComparison_NullMember))]
    public void Remove_IEnumString_SetComparison_NullMember(IEnumerable<string> removeStrings, StringComparison comparison)
    {
        string testString = "testString";
        string expectedMessage = "A member of the collection argument given for parameter \"removeStrings\" of method \"Remove\" was null. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings, comparison);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }


    [Theory, MemberData(nameof(Data_Remove_IEnumString_SetComparison_EmptyStringMember))]
    public void Remove_IEnumString_SetComparison_EmptyStringMember(IEnumerable<string> removeStrings, StringComparison comparison)
    {
        string testString = "testString";
        string expectedMessage = "A member of the collection given for parameter \"removeStrings\" of method \"Remove\" is the empty string (\"\"). (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings, comparison);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Remove_IEnumString_SetComparison_EnumInvalid()
    {
        IEnumerable<string> removeStrings = ["asd"];
        string expectedMessage = "The argument given for parameter \"comparison\" of method \"Remove\" does not exist in enum \"StringComparison\" (Parameter 'comparison')";

        StringComparison comparison = (StringComparison)99;
        void testAction() => "test".Remove(removeStrings, comparison);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Remove_IEnumString_SetComparison_NullOrigInstance()
    {
        IEnumerable<string> removeStrings = ["asd"];
        string testString = null;
        string expectedMessage = "The string instance on which \"Remove\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.Remove(removeStrings);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Remove(this string str, IEnumerable<string> removeStrings, StringComparison comparison)

    #region Remove(this string str, IEnumerable<string> removeStrings, StringComparison comparison = StringComparison.CurrentCulture)

    [Fact]
    public void Remove_IEnumString_DefaultComparison_IEnumNull()
    {
        IEnumerable<string> removeStrings = null;
        string testString = "testString";
        string expectedMessage = "The argument given for parameter \"removeStrings\" of method \"Remove\" was null. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Remove_IEnumString_DefaultComparison_NullOrigInstance()
    {
        IEnumerable<string> removeStrings = ["asd"];
        string testString = null;
        string expectedMessage = "The string instance on which \"Remove\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.Remove(removeStrings);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }


    [Theory, MemberData(nameof(Data_Remove_IEnumString_DefaultComparison_IEnumEmpty))]
    public void Remove_IEnumString_DefaultComparison_IEnumEmpty(IEnumerable<string> removeStrings)
    {
        string testString = "testString";
        string expectedMessage = "The collection argument given for parameter \"removeStrings\" of method \"Remove\" contains no elements. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }


    [Theory, MemberData(nameof(Data_Remove_IEnumString_DefaultComparison_NullMember))]
    public void Remove_IEnumString_DefaultComparison_NullMember(IEnumerable<string> removeStrings)
    {
        string testString = "testString";
        string expectedMessage = "A member of the collection argument given for parameter \"removeStrings\" of method \"Remove\" was null. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }


    [Theory, MemberData(nameof(Data_Remove_IEnumString_DefaultComparison_EmptyStringMember))]
    public void Remove_IEnumString_DefaultComparison_EmptyStringMember(IEnumerable<string> removeStrings)
    {
        string testString = "testString";
        string expectedMessage = "A member of the collection given for parameter \"removeStrings\" of method \"Remove\" is the empty string (\"\"). (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }


    #endregion Remove(this string str, IEnumerable<string> removeStrings, StringComparison comparison = StringComparison.CurrentCulture)

    #region Remove(this string str, IEnumerable<string> removeStrings, bool ignoreCase, CultureInfo? culture)

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void Remove_IEnumString_CultureInfo_IEnumNull(bool ignoreCase)
    {
        IEnumerable<string> removeStrings = null;
        string testString = "testString";
        string expectedMessage = "The argument given for parameter \"removeStrings\" of method \"Remove\" was null. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings, ignoreCase, CultureInfo.InvariantCulture);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void Remove_IEnumString_CultureInfo_NullOrigInstance(bool ignoreCase)
    {
        IEnumerable<string> removeStrings = ["asd"];
        string testString = null;
        string expectedMessage = "The string instance on which \"Remove\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.Remove(removeStrings, ignoreCase, CultureInfo.InvariantCulture);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }


    [Theory, MemberData(nameof(Data_Remove_IEnumString_CultureInfo_IEnumEmpty))]
    public void Remove_IEnumString_CultureInfo_IEnumEmpty(IEnumerable<string> removeStrings, bool ignoreCase)
    {
        string testString = "testString";
        string expectedMessage = "The collection argument given for parameter \"removeStrings\" of method \"Remove\" contains no elements. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings, ignoreCase, CultureInfo.InvariantCulture);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }


    [Theory, MemberData(nameof(Data_Remove_IEnumString_CultureInfo_NullMember))]
    public void Remove_IEnumString_CultureInfo_NullMember(IEnumerable<string> removeStrings, bool ignoreCase)
    {
        string testString = "testString";
        string expectedMessage = "A member of the collection argument given for parameter \"removeStrings\" of method \"Remove\" was null. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings, ignoreCase, CultureInfo.InvariantCulture);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }


    [Theory, MemberData(nameof(Data_Remove_IEnumString_CultureInfo_EmptyStringMember))]
    public void Remove_IEnumString_CultureInfo_EmptyStringMember(IEnumerable<string> removeStrings, bool ignoreCase)
    {
        string testString = "testString";
        string expectedMessage = "A member of the collection given for parameter \"removeStrings\" of method \"Remove\" is the empty string (\"\"). (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings, ignoreCase, CultureInfo.InvariantCulture);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Remove(this string str, IEnumerable<string> removeStrings, bool ignoreCase, CultureInfo? culture)

    #region Remove(this string str, IEnumerable<char> removeChars, StringComparison comparison)


    [Theory, MemberData(nameof(Data_Remove_IEnumChar_SetComparison_NullArgument))]
    public void Remove_IEnumChar_SetComparison_IEnumNull(StringComparison comparison)
    {
        IEnumerable<char> removeChars = null;
        string testString = "testString";
        string expectedMessage = "The argument given for parameter \"removeChars\" of method \"Remove\" was null. (Parameter 'removeChars')";

        void testAction() => testString.Remove(removeChars, comparison);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }


    [Theory, MemberData(nameof(Data_Remove_IEnumChar_SetComparison_IEnumEmpty))]
    public void Remove_IEnumChar_SetComparison_IEnumEmpty(IEnumerable<char> removeChars, StringComparison comparison)
    {
        string testString = "testString";
        string expectedMessage = "The collection argument given for parameter \"removeChars\" of method \"Remove\" contains no elements. (Parameter 'removeChars')";

        void testAction() => testString.Remove(removeChars, comparison);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Remove_IEnumChar_SetComparison_EnumInvalid()
    {
        IEnumerable<char> removeChars = ['a'];
        string expectedMessage = "The argument given for parameter \"comparison\" of method \"Remove\" does not exist in enum \"StringComparison\" (Parameter 'comparison')";

        StringComparison comparison = (StringComparison)99;
        void testAction() => "test".Remove(removeChars, comparison);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Remove_IEnumChar_SetComparison_NullOrigInstance()
    {
        IEnumerable<char> removeChars = null;
        string testString = null;
        string expectedMessage = "The string instance on which \"Remove\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.Remove(removeChars);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }


    #endregion Remove(this string str, IEnumerable<char> removeChars, StringComparison comparison)

    #region Remove(this string str, IEnumerable<char> removeChars, StringComparison comparison = StringComparison.CurrentCulture)

    [Fact]
    public void Remove_IEnumChar_DefaultComparison_IEnumNull()
    {
        IEnumerable<char> removeChars = null;
        string testString = "testString";
        string expectedMessage = "The argument given for parameter \"removeChars\" of method \"Remove\" was null. (Parameter 'removeChars')";

        void testAction() => testString.Remove(removeChars);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Remove_IEnumChar_DefaultComparison_NullOrigInstance()
    {
        IEnumerable<char> removeChars = ['d'];
        string testString = null;
        string expectedMessage = "The string instance on which \"Remove\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.Remove(removeChars);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }


    [Theory, MemberData(nameof(Data_Remove_IEnumChar_DefaultComparison_IEnumEmpty))]
    public void Remove_IEnumChar_DefaultComparison_IEnumEmpty(IEnumerable<char> removeChars)
    {
        string testString = "testString";
        string expectedMessage = "The collection argument given for parameter \"removeChars\" of method \"Remove\" contains no elements. (Parameter 'removeChars')";

        void testAction() => testString.Remove(removeChars);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }


    #endregion Remove(this string str, IEnumerable<char> removeChars, StringComparison comparison = StringComparison.CurrentCulture)

    #region Remove(this string str, IEnumerable<char> removeChars, bool ignoreCase, CultureInfo? culture)

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void Remove_IEnumChar_CultureInfo_IEnumNull(bool ignoreCase)
    {
        IEnumerable<char> removeChars = null;
        string testString = "testString";
        string expectedMessage = "The argument given for parameter \"removeChars\" of method \"Remove\" was null. (Parameter 'removeChars')";

        void testAction() => testString.Remove(removeChars, ignoreCase, CultureInfo.InvariantCulture);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void Remove_IEnumChar_CultureInfo_NullOrigInstance(bool ignoreCase)
    {
        IEnumerable<char> removeChars = ['a'];
        string testString = null;
        string expectedMessage = "The string instance on which \"Remove\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.Remove(removeChars, ignoreCase, CultureInfo.InvariantCulture);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }


    [Theory, MemberData(nameof(Data_Remove_IEnumChar_CultureInfo_IEnumEmpty))]
    public void Remove_IEnumChar_CultureInfo_IEnumEmpty(IEnumerable<char> removeChars, bool ignoreCase)
    {
        string testString = "testString";
        string expectedMessage = "The collection argument given for parameter \"removeChars\" of method \"Remove\" contains no elements. (Parameter 'removeChars')";

        void testAction() => testString.Remove(removeChars, ignoreCase, CultureInfo.InvariantCulture);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Remove(this string str, IEnumerable<char> removeChars, bool ignoreCase, CultureInfo? culture)

    [Fact]
    public void RemoveLetters_NullOrigInstance()
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"RemoveLetters\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.RemoveLetters();

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void RemoveNumbers_NullOrigInstance()
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"RemoveNumbers\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.RemoveNumbers();

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void RemoveSpecialCharacters_NullOrigInstance()
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"RemoveSpecialCharacters\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.RemoveSpecialCharacters();

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #region Data

    public static IEnumerable<object[]> Data_Remove_IEnumString_DefaultComparison_IEnumEmpty
       => new[]
            {
                new object[] { new string[] { } },
                [new List<string>() { }],
                [new HashSet<string>() { }],
                [new Queue<string>(new string[] { })],
            };

    public static IEnumerable<object[]> Data_Remove_IEnumString_DefaultComparison_NullMember
       => new[]
            {
                new object[] { new string[] { null, "asd", "asd", "asd" } },
                [new List<string>() { "asd", null, "asd", "asd" }],
                [new HashSet<string>() { "asd", "asd", null, "asd" }],
                [new Queue<string>(new string[] { "asd", "asd", "asd", null })],
            };

    public static IEnumerable<object[]> Data_Remove_IEnumString_DefaultComparison_EmptyStringMember
       => new[]
            {
                new object[] { new string[] { "", "asd", "asd", "asd" } },
                [new List<string>() { "asd", "", "asd", "asd" }],
                [new HashSet<string>() { "asd", "asd", "", "asd" }],
                [new Queue<string>(new string[] { "asd", "asd", "asd", "" })],
            };

    public static IEnumerable<object[]> Data_Remove_IEnumString_SetComparison_NullArgument
       => new[]
            {
                new object[] { GlobalVariables.InvariantCulture },
                [GlobalVariables.InvariantCultureIgnoreCase],
                [GlobalVariables.Ordinal],
                [GlobalVariables.OrdinalIgnoreCase]
            };

    public static IEnumerable<object[]> Data_Remove_IEnumString_SetComparison_IEnumEmpty
       => new[]
            {
                new object[] { new string[] {  }, GlobalVariables.InvariantCulture },
                [new List<string>(), GlobalVariables.InvariantCulture],
                [new HashSet<string>() {  }, GlobalVariables.InvariantCulture],
                [new Queue<string>(new string[] {  }), GlobalVariables.InvariantCulture],

                [new string[] {  }, GlobalVariables.InvariantCultureIgnoreCase],
                [new List<string>() {  }, GlobalVariables.InvariantCultureIgnoreCase],
                [new HashSet<string>() {  }, GlobalVariables.InvariantCultureIgnoreCase],
                [new Queue<string>(new string[] {  }), GlobalVariables.InvariantCultureIgnoreCase],

                [new string[] {  }, GlobalVariables.Ordinal],
                [new List<string>() {  }, GlobalVariables.Ordinal],
                [new HashSet<string>() {  }, GlobalVariables.Ordinal],
                [new Queue<string>(new string[] {  }), GlobalVariables.Ordinal],

                [new string[] {  }, GlobalVariables.OrdinalIgnoreCase],
                [new List<string>() {  }, GlobalVariables.OrdinalIgnoreCase],
                [new HashSet<string>() {  }, GlobalVariables.OrdinalIgnoreCase],
                [new Queue<string>(new string[] {  }), GlobalVariables.OrdinalIgnoreCase]
            };

    public static IEnumerable<object[]> Data_Remove_IEnumString_SetComparison_NullMember
       => new[]
            {
                new object[] { new string[] { null, "asd", "asd", "asd" }, GlobalVariables.InvariantCulture },
                [new List<string>() { "asd", null, "asd", "asd" }, GlobalVariables.InvariantCulture],
                [new HashSet<string>() { "asd", "asd", null, "asd" }, GlobalVariables.InvariantCulture],
                [new Queue<string>(new string[] { "asd", "asd", "asd", null }), GlobalVariables.InvariantCulture],

                [new string[] { null, "asd", "asd", "asd" }, GlobalVariables.InvariantCultureIgnoreCase],
                [new List<string>() { "asd", null, "asd", "asd" }, GlobalVariables.InvariantCultureIgnoreCase],
                [new HashSet<string>() { "asd", "asd", null, "asd" }, GlobalVariables.InvariantCultureIgnoreCase],
                [new Queue<string>(new string[] { "asd", "asd", "asd", null }), GlobalVariables.InvariantCultureIgnoreCase],

                [new string[] { null, "asd", "asd", "asd" }, GlobalVariables.Ordinal],
                [new List<string>() { "asd", null, "asd", "asd" }, GlobalVariables.Ordinal],
                [new HashSet<string>() { "asd", "asd", null, "asd" }, GlobalVariables.Ordinal],
                [new Queue<string>(new string[] { "asd", "asd", "asd", null }), GlobalVariables.Ordinal],

                [new string[] { null, "asd", "asd", "asd" }, GlobalVariables.OrdinalIgnoreCase],
                [new List<string>() { "asd", null, "asd", "asd" }, GlobalVariables.OrdinalIgnoreCase],
                [new HashSet<string>() { "asd", "asd", null, "asd" }, GlobalVariables.OrdinalIgnoreCase],
                [new Queue<string>(new string[] { "asd", "asd", "asd", null }), GlobalVariables.OrdinalIgnoreCase]
            };

    public static IEnumerable<object[]> Data_Remove_IEnumString_SetComparison_EmptyStringMember
       => new[]
            {
                new object[] { new string[] { "", "asd", "asd", "asd" }, GlobalVariables.InvariantCulture },
                [new List<string>() { "asd", "", "asd", "asd" }, GlobalVariables.InvariantCulture],
                [new HashSet<string>() { "asd", "asd", "", "asd" }, GlobalVariables.InvariantCulture],
                [new Queue<string>(new string[] { "asd", "asd", "asd", "" }), GlobalVariables.InvariantCulture],

                [new string[] { "", "asd", "asd", "asd" }, GlobalVariables.InvariantCultureIgnoreCase],
                [new List<string>() { "asd", "", "asd", "asd" }, GlobalVariables.InvariantCultureIgnoreCase],
                [new HashSet<string>() { "asd", "asd", "", "asd" }, GlobalVariables.InvariantCultureIgnoreCase],
                [new Queue<string>(new string[] { "asd", "asd", "asd", "" }), GlobalVariables.InvariantCultureIgnoreCase],

                [new string[] { "", "asd", "asd", "asd" }, GlobalVariables.Ordinal],
                [new List<string>() { "asd", "", "asd", "asd" }, GlobalVariables.Ordinal],
                [new HashSet<string>() { "asd", "asd", "", "asd" }, GlobalVariables.Ordinal],
                [new Queue<string>(new string[] { "asd", "asd", "asd", "" }), GlobalVariables.Ordinal],

                [new string[] { "", "asd", "asd", "asd" }, GlobalVariables.OrdinalIgnoreCase],
                [new List<string>() { "asd", "", "asd", "asd" }, GlobalVariables.OrdinalIgnoreCase],
                [new HashSet<string>() { "asd", "asd", "", "asd" }, GlobalVariables.OrdinalIgnoreCase],
                [new Queue<string>(new string[] { "asd", "asd", "asd", "" }), GlobalVariables.OrdinalIgnoreCase]
            };

    public static IEnumerable<object[]> Data_Remove_IEnumString_CultureInfo_IEnumEmpty
       => new[]
            {
                new object[]
                { new string[] { }, true },
                [new List<string>() { }, true],
                [new HashSet<string>() { }, true],
                [new Queue<string>(new string[] { }), true],
                [new string[] { }, false],
                [new List<string>() { }, false],
                [new HashSet<string>() { }, false],
                [new Queue<string>(new string[] { }), false],
            };

    public static IEnumerable<object[]> Data_Remove_IEnumString_CultureInfo_NullMember
       => new[]
            {
                new object[]
                { new string[] { null, "asd", "asd", "asd" }, true },
                [new List<string>() { "asd", null, "asd", "asd" }, true],
                [new HashSet<string>() { "asd", "asd", null, "asd" }, true],
                [new Queue<string>(new string[] { "asd", "asd", "asd", null }), true],
                [new string[] { null, "asd", "asd", "asd" }, false],
                [new List<string>() { "asd", null, "asd", "asd" }, false],
                [new HashSet<string>() { "asd", "asd", null, "asd" }, false],
                [new Queue<string>(new string[] { "asd", "asd", "asd", null }), false]
            };

    public static IEnumerable<object[]> Data_Remove_IEnumString_CultureInfo_EmptyStringMember
       => new[]
            {
                new object[]
                { new string[] { "", "asd", "asd", "asd" }, true },
                [new List<string>() { "asd", "", "asd", "asd" }, true],
                [new HashSet<string>() { "asd", "asd", "", "asd" }, true],
                [new Queue<string>(new string[] { "asd", "asd", "asd", "" }), true],
                [new string[] { "", "asd", "asd", "asd" }, false],
                [new List<string>() { "asd", "", "asd", "asd" }, false],
                [new HashSet<string>() { "asd", "asd", "", "asd" }, false],
                [new Queue<string>(new string[] { "asd", "asd", "asd", "" }), false]
            };

    public static IEnumerable<object[]> Data_Remove_IEnumChar_DefaultComparison_IEnumEmpty
       => new[]
            {
                new object[] { new char[] { } },
                [new List<char>() { }],
                [new HashSet<char>() { }],
                [new Queue<char>(new char[] { })],
            };

    public static IEnumerable<object[]> Data_Remove_IEnumChar_SetComparison_NullArgument
       => new[]
            {
                new object[] { GlobalVariables.InvariantCulture },
                [GlobalVariables.InvariantCultureIgnoreCase],
                [GlobalVariables.Ordinal],
                [GlobalVariables.OrdinalIgnoreCase]
            };

    public static IEnumerable<object[]> Data_Remove_IEnumChar_SetComparison_IEnumEmpty
       => new[]
            {
                new object[] { new char[] {  }, GlobalVariables.InvariantCulture },
                [new List<char>(), GlobalVariables.InvariantCulture],
                [new HashSet<char>() {  }, GlobalVariables.InvariantCulture],
                [new Queue<char>(new char[] {  }), GlobalVariables.InvariantCulture],

                [new char[] {  }, GlobalVariables.InvariantCultureIgnoreCase],
                [new List<char>() {  }, GlobalVariables.InvariantCultureIgnoreCase],
                [new HashSet<char>() {  }, GlobalVariables.InvariantCultureIgnoreCase],
                [new Queue<char>(new char[] {  }), GlobalVariables.InvariantCultureIgnoreCase],

                [new char[] {  }, GlobalVariables.Ordinal],
                [new List<char>() {  }, GlobalVariables.Ordinal],
                [new HashSet<char>() {  }, GlobalVariables.Ordinal],
                [new Queue<char>(new char[] {  }), GlobalVariables.Ordinal],

                [new char[] {  }, GlobalVariables.OrdinalIgnoreCase],
                [new List<char>() {  }, GlobalVariables.OrdinalIgnoreCase],
                [new HashSet<char>() {  }, GlobalVariables.OrdinalIgnoreCase],
                [new Queue<char>(new char[] {  }), GlobalVariables.OrdinalIgnoreCase]
            };

    public static IEnumerable<object[]> Data_Remove_IEnumChar_CultureInfo_IEnumEmpty
       => new[]
            {
                new object[]
                { new char[] {  }, true },
                [new List<char>(), true],
                [new HashSet<char>() {  }, true],
                [new Queue<char>(new char[] {  }), true],

                [new char[] {  }, false],
                [new List<char>() {  }, false],
                [new HashSet<char>() {  }, false],
                [new Queue<char>(new char[] {  }), false]
            };

    #endregion Data
}
