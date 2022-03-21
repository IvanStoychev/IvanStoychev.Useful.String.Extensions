using System;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Replacer_Tests_Exceptions
{
    [Fact]
    public void Replace_ArgumentException()
    {
        string[] oldStrings = new[] { "asd", "", "asd" };
        string expectedMessage = "Object reference not set to an instance of an object.";

        void testAction() => "".Replace("", oldStrings);

        var exception = Assert.Throws<NullReferenceException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Replace_ArgumentNullException_Collection()
    {
        string[] oldStrings = null;
        string expectedMessage = "Value cannot be null. (Parameter 'replacement')";

        void testAction() => "".Replace("", oldStrings);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void Replace_ArgumentNullException_Member()
    {
        string[] oldStrings = { "asd", null };
        string expectedMessage = "Value cannot be null. (Parameter 'replacement')";

        void testAction() => "".Replace("", oldStrings);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }
}
