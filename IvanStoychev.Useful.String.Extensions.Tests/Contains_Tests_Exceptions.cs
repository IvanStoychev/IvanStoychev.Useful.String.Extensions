using System;
using System.Collections.Generic;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Contains_Tests_Exceptions
{
    #region bool Contains(this string str, IEnumerable<string> keywords, StringComparison comparison = StringComparison.Ordinal)

    [Theory, MemberData(nameof(Data_StringComparison_AllValues))]
    public void Contains_IEnumString_NullArgument(StringComparison stringComparison)
    {
        string[] keywords = null;
        string expectedMessage = "The argument given for parameter \"keywords\" of method \"Contains\" was null. (Parameter 'keywords')";

        void testAction() => "".ContainsAny(keywords, stringComparison);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory, MemberData(nameof(Data_StringComparison_AllValues))]
    public void Contains_IEnumString_NullMember(StringComparison stringComparison)
    {
        string[] keywords = ["asd", null];
        string expectedMessage = "A member of the collection argument given for parameter \"keywords\" of method \"Contains\" was null. (Parameter 'keywords')";

        void testAction() => "".ContainsAny(keywords, stringComparison);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion bool Contains(this string str, IEnumerable<string> keywords, StringComparison comparison = StringComparison.Ordinal)

    #region bool Contains(this string str, IEnumerable<char> keychars, StringComparison comparison = StringComparison.Ordinal)

    [Theory, MemberData(nameof(Data_StringComparison_AllValues))]
    public void Contains_IEnumChar_NullArgument(StringComparison stringComparison)
    {
        char[] keychars = null;
        string expectedMessage = "The argument given for parameter \"keychars\" of method \"Contains\" was null. (Parameter 'keychars')";

        void testAction() => "".ContainsAny(keychars, stringComparison);

        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion bool Contains(this string str, IEnumerable<char> keychars, StringComparison comparison = StringComparison.Ordinal)

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
