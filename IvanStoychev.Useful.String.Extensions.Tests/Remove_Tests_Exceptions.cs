using System;
using System.Collections.Generic;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Remove_Tests_Exceptions
{
    #region Remove(this string str, string removeString, StringComparison comparison)

    [Fact]
    public void Remove_String_DefaultComparison_EmptyString()
    {
        string expectedMessage = "The argument given for parameter \"removeString\" of method \"Remove\" is the empty string (\"\"). (Parameter 'removeString')";

        static void testAction() => "test".Remove("");

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Remove_String_DefaultComparison_NullArgument()
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
    public void Remove_String_SetComparison_EmptyString(StringComparison comparison)
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
    public void Remove_String_SetComparison_NullArgument(StringComparison comparison)
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
        string expectedMessage = "The argument \"99\" given for parameter \"comparison\" of method \"Remove\" does not exist in enum \"StringComparison\"";

        StringComparison comparison = (StringComparison)99;
        void testAction() => "test".Remove("asd", comparison);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Remove(this string str, string removeString, StringComparison comparison)

    #region Remove(this string str, IEnumerable<string> removeStrings, StringComparison comparison = StringComparison.CurrentCulture)

    [Fact]
    public void Remove_IEnumString_DefaultComparison_NullArgument()
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
        IEnumerable<string> removeStrings = null;
        string testString = null;
        string expectedMessage = "The string instance on which \"Remove\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.Remove(removeStrings);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory, MemberData(nameof(Data_Remove_DefaultComparison_IEnumEmpty))]
    public void Remove_IEnumString_DefaultComparison_IEnumEmpty(IEnumerable<string> removeStrings)
    {
        string testString = "testString";
        string expectedMessage = "The collection argument given for parameter \"removeStrings\" of method \"Remove\" contains no elements. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory, MemberData(nameof(Data_Remove_DefaultComparison_NullMember))]
    public void Remove_IEnumString_DefaultComparison_NullMember(IEnumerable<string> removeStrings)
    {
        string testString = "testString";
        string expectedMessage = "A member of the collection argument given for parameter \"removeStrings\" of method \"Remove\" was null. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory, MemberData(nameof(Data_Remove_DefaultComparison_EmptyStringMember))]
    public void Remove_IEnumString_DefaultComparison_EmptyStringMember(IEnumerable<string> removeStrings)
    {
        string testString = "testString";
        string expectedMessage = "A member of the collection given for parameter \"removeStrings\" of method \"Remove\" is the empty string (\"\"). (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Remove(this string str, IEnumerable<string> removeStrings, StringComparison comparison = StringComparison.CurrentCulture)

    #region Remove(this string str, IEnumerable<string> removeStrings, StringComparison comparison)

    [Theory, MemberData(nameof(Data_Remove_SetComparison_NullArgument))]
    public void Remove_IEnumString_SetComparison_NullArgument(StringComparison comparison)
    {
        IEnumerable<string> removeStrings = null;
        string testString = "testString";
        string expectedMessage = "The argument given for parameter \"removeStrings\" of method \"Remove\" was null. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings, comparison);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory, MemberData(nameof(Data_Remove_SetComparison_IEnumEmpty))]
    public void Remove_IEnumString_SetComparison_IEnumEmpty(IEnumerable<string> removeStrings, StringComparison comparison)
    {
        string testString = "testString";
        string expectedMessage = "The collection argument given for parameter \"removeStrings\" of method \"Remove\" contains no elements. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings, comparison);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory, MemberData(nameof(Data_Remove_SetComparison_NullMember))]
    public void Remove_IEnumString_SetComparison_NullMember(IEnumerable<string> removeStrings, StringComparison comparison)
    {
        string testString = "testString";
        string expectedMessage = "A member of the collection argument given for parameter \"removeStrings\" of method \"Remove\" was null. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings, comparison);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory, MemberData(nameof(Data_Remove_SetComparison_EmptyStringMember))]
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
        string expectedMessage = "The argument \"99\" given for parameter \"comparison\" of method \"Remove\" does not exist in enum \"StringComparison\"";

        StringComparison comparison = (StringComparison)99;
        void testAction() => "test".Remove(removeStrings, comparison);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Remove_IEnumString_SetComparison_NullOrigInstance()
    {
        IEnumerable<string> removeStrings = null;
        string testString = null;
        string expectedMessage = "The string instance on which \"Remove\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.Remove(removeStrings);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Remove(this string str, IEnumerable<string> removeStrings, StringComparison comparison)

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

    public static IEnumerable<object[]> Data_Remove_DefaultComparison_IEnumEmpty => new[]
            {
                new object[] { new string[] { } },
                [new List<string>() { }],
                [new HashSet<string>() { }],
                [new Queue<string>(new string[] { })],
            };

    public static IEnumerable<object[]> Data_Remove_DefaultComparison_NullMember => new[]
            {
                new object[] { new string[] { null, "asd", "asd", "asd" } },
                [new List<string>() { "asd", null, "asd", "asd" }],
                [new HashSet<string>() { "asd", "asd", null, "asd" }],
                [new Queue<string>(new string[] { "asd", "asd", "asd", null })],
            };

    public static IEnumerable<object[]> Data_Remove_DefaultComparison_EmptyStringMember => new[]
            {
                new object[] { new string[] { "", "asd", "asd", "asd" } },
                [new List<string>() { "asd", "", "asd", "asd" }],
                [new HashSet<string>() { "asd", "asd", "", "asd" }],
                [new Queue<string>(new string[] { "asd", "asd", "asd", "" })],
            };

    public static IEnumerable<object[]> Data_Remove_SetComparison_NullArgument => new[]
            {
                new object[] { GlobalVariables.InvariantCulture },
                [GlobalVariables.InvariantCultureIgnoreCase],
                [GlobalVariables.Ordinal],
                [GlobalVariables.OrdinalIgnoreCase]
            };

    public static IEnumerable<object[]> Data_Remove_SetComparison_IEnumEmpty => new[]
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

    public static IEnumerable<object[]> Data_Remove_SetComparison_NullMember => new[]
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

    public static IEnumerable<object[]> Data_Remove_SetComparison_EmptyStringMember => new[]
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

    #endregion Data
}
