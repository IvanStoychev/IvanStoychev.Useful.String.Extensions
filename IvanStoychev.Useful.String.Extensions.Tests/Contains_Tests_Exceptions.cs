using System;
using System.Collections.Generic;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Contains_Tests_Exceptions
{
    #region bool ContainsAny(this string str, IEnumerable<string> keywords, StringComparison comparison = StringComparison.Ordinal)

    [Theory, MemberData(nameof(Data_StringComparison_AllValues))]
    public void ContainsAny_IEnumString_NullArgument(StringComparison stringComparison)
    {
        string[] keywords = null;
        string expectedMessage = "The argument given for parameter \"keywords\" of method \"ContainsAny\" was null. (Parameter 'keywords')";

        void testAction() => "".ContainsAny(keywords, stringComparison);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory, MemberData(nameof(Data_StringComparison_AllValues))]
    public void ContainsAny_IEnumString_NullMember(StringComparison stringComparison)
    {
        string[] keywords = ["asd", null];
        string expectedMessage = "A member of the collection argument given for parameter \"keywords\" of method \"ContainsAny\" was null. (Parameter 'keywords')";

        void testAction() => "".ContainsAny(keywords, stringComparison);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory, MemberData(nameof(Data_StringComparison_AllValues))]
    public void ContainsAny_IEnumString_IEnumEmpty(StringComparison stringComparison)
    {
        string[] keywords = [];
        string expectedMessage = "The collection argument given for parameter \"keywords\" of method \"ContainsAny\" contains no elements. (Parameter 'keywords')";

        void testAction() => "".ContainsAny(keywords, stringComparison);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void ContainsAny_IEnumString_EnumInvalid()
    {
        string[] keywords = ["asd"];
        string expectedMessage = "The argument \"99\" given for parameter \"comparison\" of method \"ContainsAny\" does not exist in enum \"StringComparison\"";

        void testAction() => "".ContainsAny(keywords, (StringComparison)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void ContainsAny_IEnumString_NullOrigInstance()
    {
        string testString = null;
        string[] keywords = ["asd"];
        string expectedMessage = "The string instance on which \"ContainsAny\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.ContainsAny(keywords);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion bool ContainsAny(this string str, IEnumerable<string> keywords, StringComparison comparison = StringComparison.Ordinal)

    #region bool ContainsAny(this string str, IEnumerable<char> keychars, StringComparison comparison = StringComparison.Ordinal)

    [Theory, MemberData(nameof(Data_StringComparison_AllValues))]
    public void ContainsAny_IEnumChar_NullArgument(StringComparison stringComparison)
    {
        char[] keychars = null;
        string expectedMessage = "The argument given for parameter \"keychars\" of method \"ContainsAny\" was null. (Parameter 'keychars')";

        void testAction() => "".ContainsAny(keychars, stringComparison);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory, MemberData(nameof(Data_StringComparison_AllValues))]
    public void ContainsAny_IEnumChar_IEnumEmpty(StringComparison stringComparison)
    {
        char[] keychars = [];
        string expectedMessage = "The collection argument given for parameter \"keychars\" of method \"ContainsAny\" contains no elements. (Parameter 'keychars')";

        void testAction() => "".ContainsAny(keychars, stringComparison);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void ContainsAny_IEnumChar_EnumInvalid()
    {
        char[] keychars = ['c'];
        string expectedMessage = "The argument \"99\" given for parameter \"comparison\" of method \"ContainsAny\" does not exist in enum \"StringComparison\"";

        void testAction() => "".ContainsAny(keychars, (StringComparison)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void ContainsAny_IEnumChar_NullOrigInstance()
    {
        string testString = null;
        char[] keychars = ['c'];
        string expectedMessage = "The string instance on which \"ContainsAny\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.ContainsAny(keychars);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion bool ContainsAny(this string str, IEnumerable<char> keychars, StringComparison comparison = StringComparison.Ordinal)

    #region IEnumerable test data

    public static IEnumerable<object[]> Data_StringComparison_AllValues => new[]
            {
                new object[] { GlobalVariables.CurrentCulture },
                [GlobalVariables.CurrentCultureIgnoreCase],
                [GlobalVariables.InvariantCulture],
                [GlobalVariables.InvariantCultureIgnoreCase],
                [GlobalVariables.Ordinal],
                [GlobalVariables.OrdinalIgnoreCase]
            };

    #endregion IEnumerable test data
}
