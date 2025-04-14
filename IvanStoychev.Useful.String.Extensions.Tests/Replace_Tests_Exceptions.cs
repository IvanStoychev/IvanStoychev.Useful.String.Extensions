using System;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Replace_Tests_Exceptions
{
    [Fact]
    public void Replace_IEnumString_EnumInvalid()
    {
        string[] oldStrings = ["asd"];
        string expectedMessage = "The argument given for parameter \"comparison\" of method \"Replace\" does not exist in enum \"StringComparison\" (Parameter 'comparison')";

        void testAction() => "".Replace(oldStrings, "", (StringComparison)99);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Replace_IEnumString_EmptyStringMember()
    {
        string[] oldStrings = ["asd", "", "asd"];
        string expectedMessage = "A member of the collection given for parameter \"oldStrings\" of method \"Replace\" is the empty string (\"\"). (Parameter 'oldStrings')";

        void testAction() => "".Replace(oldStrings, "");

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Replace_IEnumString_IEnumEmpty()
    {
        string[] oldStrings = [];
        string expectedMessage = "The collection argument given for parameter \"oldStrings\" of method \"Replace\" contains no elements. (Parameter 'oldStrings')";

        void testAction() => "".Replace(oldStrings, "");

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Replace_IEnumString_IEnumNull()
    {
        string[] oldStrings = null;
        string expectedMessage = "The argument given for parameter \"oldStrings\" of method \"Replace\" was null. (Parameter 'oldStrings')";

        void testAction() => "".Replace(oldStrings, "");

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Replace_IEnumString_NullMember()
    {
        string[] oldStrings = ["asd", null];
        string expectedMessage = "A member of the collection argument given for parameter \"oldStrings\" of method \"Replace\" was null. (Parameter 'oldStrings')";

        void testAction() => "".Replace(oldStrings, "");

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Replace_IEnumString_NullOrigInstance()
    {
        string[] oldStrings = ["asd"];
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.Replace(oldStrings, "a");

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }
}
