using System;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Replace_Tests_Exceptions
{
    [Fact]
    public void Replace_ArgumentException_Collection()
    {
        string[] oldStrings = [];
        string expectedMessage = "The collection argument given for parameter \"oldStrings\" of method \"Replace\" contains no elements. (Parameter 'oldStrings')";

        void testAction() => "".Replace(oldStrings, "");

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Replace_ArgumentException_EnumValue()
    {
        string[] oldStrings = ["asd", "", "asd"];
        string expectedMessage = "A member of the collection given for parameter \"oldStrings\" of method \"Replace\" is the empty string (\"\"). (Parameter 'oldStrings')";

        void testAction() => "".Replace(oldStrings, "");

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Replace_ArgumentException_Member()
    {
        string[] oldStrings = ["asd", "", "asd"];
        string expectedMessage = "A member of the collection given for parameter \"oldStrings\" of method \"Replace\" is the empty string (\"\"). (Parameter 'oldStrings')";

        void testAction() => "".Replace(oldStrings, "");

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Replace_ArgumentNullException_Collection()
    {
        string[] oldStrings = null;
        string expectedMessage = "The argument given for parameter \"oldStrings\" of method \"Replace\" was null. (Parameter 'oldStrings')";

        void testAction() => "".Replace(oldStrings, "");

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Replace_ArgumentNullException_Member()
    {
        string[] oldStrings = ["asd", null];
        string expectedMessage = "A member of the collection argument given for parameter \"oldStrings\" of method \"Replace\" was null. (Parameter 'oldStrings')";

        void testAction() => "".Replace(oldStrings, "");

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }
}
