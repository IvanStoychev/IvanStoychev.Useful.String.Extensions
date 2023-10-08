using System;
using System.Collections.Generic;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Remover_Tests_Exceptions
{
    #region Remove(this string str, string removeString, StringComparison stringComparison = StringComparison.CurrentCulture)

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

    [Theory]
    [InlineData(StringComparison.Ordinal)]
    [InlineData(StringComparison.OrdinalIgnoreCase)]
    [InlineData(StringComparison.InvariantCulture)]
    [InlineData(StringComparison.InvariantCultureIgnoreCase)]
    public void Remove_String_SetComparison_EmptyString(StringComparison stringComparison)
    {
        string expectedMessage = "The argument given for parameter \"removeString\" of method \"Remove\" is the empty string (\"\"). (Parameter 'removeString')";

        void testAction() => "test".Remove("", stringComparison);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [InlineData(StringComparison.Ordinal)]
    [InlineData(StringComparison.OrdinalIgnoreCase)]
    [InlineData(StringComparison.InvariantCulture)]
    [InlineData(StringComparison.InvariantCultureIgnoreCase)]
    public void Remove_String_SetComparison_NullArgument(StringComparison stringComparison)
    {
        string expectedMessage = "The argument given for parameter \"removeString\" of method \"Remove\" was null. (Parameter 'removeString')";

        string nullString = null;
        void testAction() => "test".Remove(nullString, stringComparison);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Remove(this string str, IEnumerable<string> removeStrings, StringComparison stringComparison = StringComparison.CurrentCulture)

    #region Remove(this string str, IEnumerable<string> removeStrings, StringComparison stringComparison = StringComparison.CurrentCulture)

    [Fact]
    public void Remove_DefaultComparison_NullArgument()
    {
        IEnumerable<string> removeStrings = null;
        string testString = "testString";
        string expectedMessage = "The argument given for parameter \"removeStrings\" of method \"Remove\" was null. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory, MemberData(nameof(Data_Remove_DefaultComparison_IEnumEmpty))]
    public void Remove_DefaultComparison_IEnumEmpty(IEnumerable<string> removeStrings)
    {
        string testString = "testString";
        string expectedMessage = "The collection argument given for parameter \"removeStrings\" of method \"Remove\" contains no elements. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory, MemberData(nameof(Data_Remove_DefaultComparison_NullMember))]
    public void Remove_DefaultComparison_NullMember(IEnumerable<string> removeStrings)
    {
        string testString = "testString";
        string expectedMessage = "A member of the collection argument given for parameter \"removeStrings\" of method \"Remove\" was null. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory, MemberData(nameof(Data_Remove_DefaultComparison_EmptyStringMember))]
    public void Remove_DefaultComparison_EmptyStringMember(IEnumerable<string> removeStrings)
    {
        string testString = "testString";
        string expectedMessage = "A member of the collection given for parameter \"removeStrings\" of method \"Remove\" is the empty string (\"\"). (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Remove(this string str, IEnumerable<string> removeStrings, StringComparison stringComparison = StringComparison.CurrentCulture)

    #region Remove(this string str, IEnumerable<string> removeStrings, StringComparison stringComparison)

    [Theory, MemberData(nameof(Data_Remove_SetComparison_NullArgument))]
    public void Remove_SetComparison_NullArgument(StringComparison stringComparison)
    {
        IEnumerable<string> removeStrings = null;
        string testString = "testString";
        string expectedMessage = "The argument given for parameter \"removeStrings\" of method \"Remove\" was null. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings, stringComparison);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory, MemberData(nameof(Data_Remove_SetComparison_IEnumEmpty))]
    public void Remove_SetComparison_IEnumEmpty(IEnumerable<string> removeStrings, StringComparison stringComparison)
    {
        string testString = "testString";
        string expectedMessage = "The collection argument given for parameter \"removeStrings\" of method \"Remove\" contains no elements. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings, stringComparison);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory, MemberData(nameof(Data_Remove_SetComparison_NullMember))]
    public void Remove_SetComparison_NullMember(IEnumerable<string> removeStrings, StringComparison stringComparison)
    {
        string testString = "testString";
        string expectedMessage = "A member of the collection argument given for parameter \"removeStrings\" of method \"Remove\" was null. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings, stringComparison);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory, MemberData(nameof(Data_Remove_SetComparison_EmptyStringMember))]
    public void Remove_SetComparison_EmptyStringMember(IEnumerable<string> removeStrings, StringComparison stringComparison)
    {
        string testString = "testString";
        string expectedMessage = "A member of the collection given for parameter \"removeStrings\" of method \"Remove\" is the empty string (\"\"). (Parameter 'removeStrings')";

        void testAction() => testString.Remove(removeStrings, stringComparison);

        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Remove(this string str, IEnumerable<string> removeStrings, StringComparison stringComparison)

    #region Data

    public static IEnumerable<object[]> Data_Remove_DefaultComparison_IEnumEmpty => new[]
            {
                new object[] { new string[] { } },
                new object[] { new List<string>() { } },
                new object[] { new HashSet<string>() { } },
                new object[] { new Queue<string>(new string[] { }) },
            };

    public static IEnumerable<object[]> Data_Remove_DefaultComparison_NullMember => new[]
            {
                new object[] { new string[] { null, "asd", "asd", "asd" } },
                new object[] { new List<string>() { "asd", null, "asd", "asd" } },
                new object[] { new HashSet<string>() { "asd", "asd", null, "asd" } },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", null }) },
            };

    public static IEnumerable<object[]> Data_Remove_DefaultComparison_EmptyStringMember => new[]
            {
                new object[] { new string[] { "", "asd", "asd", "asd" } },
                new object[] { new List<string>() { "asd", "", "asd", "asd" } },
                new object[] { new HashSet<string>() { "asd", "asd", "", "asd" } },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", "" }) },
            };

    public static IEnumerable<object[]> Data_Remove_SetComparison_NullArgument => new[]
            {
                new object[] { GlobalVariables.InvariantCulture },
                new object[] { GlobalVariables.InvariantCultureIgnoreCase },
                new object[] { GlobalVariables.Ordinal },
                new object[] { GlobalVariables.OrdinalIgnoreCase }
            };

    public static IEnumerable<object[]> Data_Remove_SetComparison_IEnumEmpty => new[]
            {
                new object[] { new string[] {  }, GlobalVariables.InvariantCulture },
                new object[] { new List<string>(), GlobalVariables.InvariantCulture },
                new object[] { new HashSet<string>() {  }, GlobalVariables.InvariantCulture },
                new object[] { new Queue<string>(new string[] {  }), GlobalVariables.InvariantCulture },

                new object[] { new string[] {  }, GlobalVariables.InvariantCultureIgnoreCase },
                new object[] { new List<string>() {  }, GlobalVariables.InvariantCultureIgnoreCase },
                new object[] { new HashSet<string>() {  }, GlobalVariables.InvariantCultureIgnoreCase },
                new object[] { new Queue<string>(new string[] {  }), GlobalVariables.InvariantCultureIgnoreCase },

                new object[] { new string[] {  }, GlobalVariables.Ordinal },
                new object[] { new List<string>() {  }, GlobalVariables.Ordinal },
                new object[] { new HashSet<string>() {  }, GlobalVariables.Ordinal },
                new object[] { new Queue<string>(new string[] {  }), GlobalVariables.Ordinal },

                new object[] { new string[] {  }, GlobalVariables.OrdinalIgnoreCase },
                new object[] { new List<string>() {  }, GlobalVariables.OrdinalIgnoreCase },
                new object[] { new HashSet<string>() {  }, GlobalVariables.OrdinalIgnoreCase },
                new object[] { new Queue<string>(new string[] {  }), GlobalVariables.OrdinalIgnoreCase }
            };

    public static IEnumerable<object[]> Data_Remove_SetComparison_NullMember => new[]
            {
                new object[] { new string[] { null, "asd", "asd", "asd" }, GlobalVariables.InvariantCulture },
                new object[] { new List<string>() { "asd", null, "asd", "asd" }, GlobalVariables.InvariantCulture },
                new object[] { new HashSet<string>() { "asd", "asd", null, "asd" }, GlobalVariables.InvariantCulture },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", null }), GlobalVariables.InvariantCulture },

                new object[] { new string[] { null, "asd", "asd", "asd" }, GlobalVariables.InvariantCultureIgnoreCase },
                new object[] { new List<string>() { "asd", null, "asd", "asd" }, GlobalVariables.InvariantCultureIgnoreCase },
                new object[] { new HashSet<string>() { "asd", "asd", null, "asd" }, GlobalVariables.InvariantCultureIgnoreCase },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", null }), GlobalVariables.InvariantCultureIgnoreCase },

                new object[] { new string[] { null, "asd", "asd", "asd" }, GlobalVariables.Ordinal },
                new object[] { new List<string>() { "asd", null, "asd", "asd" }, GlobalVariables.Ordinal },
                new object[] { new HashSet<string>() { "asd", "asd", null, "asd" }, GlobalVariables.Ordinal },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", null }), GlobalVariables.Ordinal },

                new object[] { new string[] { null, "asd", "asd", "asd" }, GlobalVariables.OrdinalIgnoreCase },
                new object[] { new List<string>() { "asd", null, "asd", "asd" }, GlobalVariables.OrdinalIgnoreCase },
                new object[] { new HashSet<string>() { "asd", "asd", null, "asd" }, GlobalVariables.OrdinalIgnoreCase },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", null }), GlobalVariables.OrdinalIgnoreCase }
            };

    public static IEnumerable<object[]> Data_Remove_SetComparison_EmptyStringMember => new[]
            {
                new object[] { new string[] { "", "asd", "asd", "asd" }, GlobalVariables.InvariantCulture },
                new object[] { new List<string>() { "asd", "", "asd", "asd" }, GlobalVariables.InvariantCulture },
                new object[] { new HashSet<string>() { "asd", "asd", "", "asd" }, GlobalVariables.InvariantCulture },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", "" }), GlobalVariables.InvariantCulture },

                new object[] { new string[] { "", "asd", "asd", "asd" }, GlobalVariables.InvariantCultureIgnoreCase },
                new object[] { new List<string>() { "asd", "", "asd", "asd" }, GlobalVariables.InvariantCultureIgnoreCase },
                new object[] { new HashSet<string>() { "asd", "asd", "", "asd" }, GlobalVariables.InvariantCultureIgnoreCase },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", "" }), GlobalVariables.InvariantCultureIgnoreCase },

                new object[] { new string[] { "", "asd", "asd", "asd" }, GlobalVariables.Ordinal },
                new object[] { new List<string>() { "asd", "", "asd", "asd" }, GlobalVariables.Ordinal },
                new object[] { new HashSet<string>() { "asd", "asd", "", "asd" }, GlobalVariables.Ordinal },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", "" }), GlobalVariables.Ordinal },

                new object[] { new string[] { "", "asd", "asd", "asd" }, GlobalVariables.OrdinalIgnoreCase },
                new object[] { new List<string>() { "asd", "", "asd", "asd" }, GlobalVariables.OrdinalIgnoreCase },
                new object[] { new HashSet<string>() { "asd", "asd", "", "asd" }, GlobalVariables.OrdinalIgnoreCase },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", "" }), GlobalVariables.OrdinalIgnoreCase }
            };

    #endregion Data
}
