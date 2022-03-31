using System;
using System.Collections.Generic;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Remover_Tests_Exceptions
{
    #region Remove(this string str, IEnumerable<string> removeStrings, StringComparison stringComparison = StringComparison.CurrentCulture)

    [Fact]
    public void Remove_DefaultComparison_NullArgument()
    {
        string testString = "testString";
        string expectedMessage = "The argument given for parameter \"removeStrings\" of method \"Remove\" was null. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(null);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory, MemberData(nameof(Data_Remove_DefaultComparison_IEnumNotEmpty))]
    public void Remove_DefaultComparison_IEnumNotEmpty(IEnumerable<string> removeStrings)
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
        string testString = "testString";
        string expectedMessage = "The argument given for parameter \"removeStrings\" of method \"Remove\" was null. (Parameter 'removeStrings')";

        void testAction() => testString.Remove(null, stringComparison);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory, MemberData(nameof(Data_Remove_SetComparison_IEnumNotEmpty))]
    public void Remove_SetComparison_IEnumNotEmpty(IEnumerable<string> removeStrings, StringComparison stringComparison)
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

    public static IEnumerable<object[]> Data_Remove_DefaultComparison_IEnumNotEmpty
    {
        get
        {
            return new[]
            {
                new object[] { new string[] { } },
                new object[] { new List<string>() { } },
                new object[] { new HashSet<string>() { } },
                new object[] { new Queue<string>(new string[] { }) },
            };
        }
    }

    public static IEnumerable<object[]> Data_Remove_DefaultComparison_NullMember
    {
        get
        {
            return new[]
            {
                new object[] { new string[] { null, "asd", "asd", "asd" } },
                new object[] { new List<string>() { "asd", null, "asd", "asd" } },
                new object[] { new HashSet<string>() { "asd", "asd", null, "asd" } },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", null }) },
            };
        }
    }

    public static IEnumerable<object[]> Data_Remove_DefaultComparison_EmptyStringMember
    {
        get
        {
            return new[]
            {
                new object[] { new string[] { "", "asd", "asd", "asd" } },
                new object[] { new List<string>() { "asd", "", "asd", "asd" } },
                new object[] { new HashSet<string>() { "asd", "asd", "", "asd" } },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", "" }) },
            };
        }
    }

    public static IEnumerable<object[]> Data_Remove_SetComparison_NullArgument
    {
        get
        {
            return new[]
            {
                new object[] { StringComparison.InvariantCulture },
                new object[] { StringComparison.InvariantCultureIgnoreCase },
                new object[] { StringComparison.Ordinal },
                new object[] { StringComparison.OrdinalIgnoreCase }
            };
        }
    }

    public static IEnumerable<object[]> Data_Remove_SetComparison_IEnumNotEmpty
    {
        get
        {
            return new[]
            {
                new object[] { new string[] {  }, StringComparison.InvariantCulture },
                new object[] { new List<string>(), StringComparison.InvariantCulture },
                new object[] { new HashSet<string>() {  }, StringComparison.InvariantCulture },
                new object[] { new Queue<string>(new string[] {  }), StringComparison.InvariantCulture },

                new object[] { new string[] {  }, StringComparison.InvariantCultureIgnoreCase },
                new object[] { new List<string>() {  }, StringComparison.InvariantCultureIgnoreCase },
                new object[] { new HashSet<string>() {  }, StringComparison.InvariantCultureIgnoreCase },
                new object[] { new Queue<string>(new string[] {  }), StringComparison.InvariantCultureIgnoreCase },

                new object[] { new string[] {  }, StringComparison.Ordinal },
                new object[] { new List<string>() {  }, StringComparison.Ordinal },
                new object[] { new HashSet<string>() {  }, StringComparison.Ordinal },
                new object[] { new Queue<string>(new string[] {  }), StringComparison.Ordinal },

                new object[] { new string[] {  }, StringComparison.OrdinalIgnoreCase },
                new object[] { new List<string>() {  }, StringComparison.OrdinalIgnoreCase },
                new object[] { new HashSet<string>() {  }, StringComparison.OrdinalIgnoreCase },
                new object[] { new Queue<string>(new string[] {  }), StringComparison.OrdinalIgnoreCase }
            };
        }
    }

    public static IEnumerable<object[]> Data_Remove_SetComparison_NullMember
    {
        get
        {
            return new[]
            {
                new object[] { new string[] { null, "asd", "asd", "asd" }, StringComparison.InvariantCulture },
                new object[] { new List<string>() { "asd", null, "asd", "asd" }, StringComparison.InvariantCulture },
                new object[] { new HashSet<string>() { "asd", "asd", null, "asd" }, StringComparison.InvariantCulture },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", null }), StringComparison.InvariantCulture },

                new object[] { new string[] { null, "asd", "asd", "asd" }, StringComparison.InvariantCultureIgnoreCase },
                new object[] { new List<string>() { "asd", null, "asd", "asd" }, StringComparison.InvariantCultureIgnoreCase },
                new object[] { new HashSet<string>() { "asd", "asd", null, "asd" }, StringComparison.InvariantCultureIgnoreCase },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", null }), StringComparison.InvariantCultureIgnoreCase },

                new object[] { new string[] { null, "asd", "asd", "asd" }, StringComparison.Ordinal },
                new object[] { new List<string>() { "asd", null, "asd", "asd" }, StringComparison.Ordinal },
                new object[] { new HashSet<string>() { "asd", "asd", null, "asd" }, StringComparison.Ordinal },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", null }), StringComparison.Ordinal },

                new object[] { new string[] { null, "asd", "asd", "asd" }, StringComparison.OrdinalIgnoreCase },
                new object[] { new List<string>() { "asd", null, "asd", "asd" }, StringComparison.OrdinalIgnoreCase },
                new object[] { new HashSet<string>() { "asd", "asd", null, "asd" }, StringComparison.OrdinalIgnoreCase },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", null }), StringComparison.OrdinalIgnoreCase }
            };
        }
    }

    public static IEnumerable<object[]> Data_Remove_SetComparison_EmptyStringMember
    {
        get
        {
            return new[]
            {
                new object[] { new string[] { "", "asd", "asd", "asd" }, StringComparison.InvariantCulture },
                new object[] { new List<string>() { "asd", "", "asd", "asd" }, StringComparison.InvariantCulture },
                new object[] { new HashSet<string>() { "asd", "asd", "", "asd" }, StringComparison.InvariantCulture },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", "" }), StringComparison.InvariantCulture },

                new object[] { new string[] { "", "asd", "asd", "asd" }, StringComparison.InvariantCultureIgnoreCase },
                new object[] { new List<string>() { "asd", "", "asd", "asd" }, StringComparison.InvariantCultureIgnoreCase },
                new object[] { new HashSet<string>() { "asd", "asd", "", "asd" }, StringComparison.InvariantCultureIgnoreCase },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", "" }), StringComparison.InvariantCultureIgnoreCase },

                new object[] { new string[] { "", "asd", "asd", "asd" }, StringComparison.Ordinal },
                new object[] { new List<string>() { "asd", "", "asd", "asd" }, StringComparison.Ordinal },
                new object[] { new HashSet<string>() { "asd", "asd", "", "asd" }, StringComparison.Ordinal },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", "" }), StringComparison.Ordinal },

                new object[] { new string[] { "", "asd", "asd", "asd" }, StringComparison.OrdinalIgnoreCase },
                new object[] { new List<string>() { "asd", "", "asd", "asd" }, StringComparison.OrdinalIgnoreCase },
                new object[] { new HashSet<string>() { "asd", "asd", "", "asd" }, StringComparison.OrdinalIgnoreCase },
                new object[] { new Queue<string>(new string[] { "asd", "asd", "asd", "" }), StringComparison.OrdinalIgnoreCase }
            };
        }
    }

    #endregion Data
}
