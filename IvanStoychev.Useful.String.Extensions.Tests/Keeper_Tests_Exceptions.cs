using System;
using Xunit;
using Xunit.Sdk;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Keeper_Tests_Exceptions
{
    [Fact]
    public void KeepOnlyLetters_NullOrigInstance()
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"KeepOnlyLetters\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.KeepOnlyLetters();

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void KeepOnlyNumbers_NullOrigInstance()
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"KeepOnlyNumbers\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.KeepOnlyNumbers();

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Fact]
    public void KeepOnlySpecialCharacters_NullOrigInstance()
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"KeepOnlySpecialCharacters\" was called is null. (Parameter 'Original string instance')";

        void testAction() => testString.KeepOnlySpecialCharacters();

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }
}
