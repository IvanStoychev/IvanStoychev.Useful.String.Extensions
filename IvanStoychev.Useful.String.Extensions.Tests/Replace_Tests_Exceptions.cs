using System;
using System.Collections.Generic;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Replace_Tests_Exceptions
{
    #region MemberData

    const string OLD_STRING = "test";
    const string NEW_STRING = "a";
    const char OLD_CHAR = 't';
    const char NEW_CHAR = 'a';

    public static TheoryData<IEnumerable<string>> StringCollections_NotNull_DefaultComparison() =>
        CreateTheoryData(GetStringCollections_NotNull());

    public static TheoryData<IEnumerable<string>, StringComparison> StringCollections_NotNull_SetComparison() =>
        CreateTheoryDataWithComparison(GetStringCollections_NotNull());

    public static TheoryData<IEnumerable<string>, bool> StringCollections_NotNull_CultureInfo() =>
        CreateTheoryDataWithBool(GetStringCollections_NotNull());

    public static TheoryData<IEnumerable<string>> StringCollections_Null_DefaultComparison() =>
        CreateTheoryData(GetAllCollectionTypes_Null<string>());

    public static TheoryData<IEnumerable<string>, StringComparison> StringCollections_Null_SetComparison() =>
        CreateTheoryDataWithComparison(GetAllCollectionTypes_Null<string>());

    public static TheoryData<IEnumerable<string>, bool> StringCollections_Null_CultureInfo() =>
        CreateTheoryDataWithBool(GetAllCollectionTypes_Null<string>());

    public static TheoryData<IEnumerable<string>> StringCollections_Empty_DefaultComparison() =>
        CreateTheoryData(GetAllCollectionTypes_Empty<string>());

    public static TheoryData<IEnumerable<string>, StringComparison> StringCollections_Empty_SetComparison() =>
        CreateTheoryDataWithComparison(GetAllCollectionTypes_Empty<string>());

    public static TheoryData<IEnumerable<string>, bool> StringCollections_Empty_CultureInfo() =>
        CreateTheoryDataWithBool(GetAllCollectionTypes_Empty<string>());

    public static TheoryData<IEnumerable<string>> StringCollections_WithNull_DefaultComparison() =>
        CreateTheoryData(GetStringCollections_WithNull());

    public static TheoryData<IEnumerable<string>, StringComparison> StringCollections_WithNull_SetComparison() =>
        CreateTheoryDataWithComparison(GetStringCollections_WithNull());

    public static TheoryData<IEnumerable<string>, bool> StringCollections_WithNull_CultureInfo() =>
        CreateTheoryDataWithBool(GetStringCollections_WithNull());

    public static TheoryData<IEnumerable<string>> StringCollections_WithEmpty_DefaultComparison() =>
        CreateTheoryData(GetStringCollections_WithEmpty());

    public static TheoryData<IEnumerable<string>, StringComparison> StringCollections_WithEmpty_SetComparison() =>
        CreateTheoryDataWithComparison(GetStringCollections_WithEmpty());

    public static TheoryData<IEnumerable<string>, bool> StringCollections_WithEmpty_CultureInfo() =>
        CreateTheoryDataWithBool(GetStringCollections_WithEmpty());

    public static TheoryData<IEnumerable<char>> CharCollections_NotNull_DefaultComparison() =>
        CreateTheoryData(GetCharCollections_NotNull());

    public static TheoryData<IEnumerable<char>, StringComparison> CharCollections_NotNull_SetComparison() =>
        CreateTheoryDataWithComparison(GetCharCollections_NotNull());

    public static TheoryData<IEnumerable<char>, bool> CharCollections_NotNull_CultureInfo() =>
        CreateTheoryDataWithBool(GetCharCollections_NotNull());

    public static TheoryData<IEnumerable<char>> CharCollections_Null_DefaultComparison() =>
        CreateTheoryData(GetAllCollectionTypes_Null<char>());

    public static TheoryData<IEnumerable<char>, StringComparison> CharCollections_Null_SetComparison() =>
        CreateTheoryDataWithComparison(GetAllCollectionTypes_Null<char>());

    public static TheoryData<IEnumerable<char>, bool> CharCollections_Null_CultureInfo() =>
        CreateTheoryDataWithBool(GetAllCollectionTypes_Null<char>());

    public static TheoryData<IEnumerable<char>> CharCollections_Empty_DefaultComparison() =>
        CreateTheoryData(GetAllCollectionTypes_Empty<char>());

    public static TheoryData<IEnumerable<char>, StringComparison> CharCollections_Empty_SetComparison() =>
        CreateTheoryDataWithComparison(GetAllCollectionTypes_Empty<char>());

    public static TheoryData<IEnumerable<char>, bool> CharCollections_Empty_CultureInfo() =>
        CreateTheoryDataWithBool(GetAllCollectionTypes_Empty<char>());

    public static TheoryData<IEnumerable<KeyValuePair<string, string>>> KvpStringStringCollections_NotNull_DefaultComparison() =>
        CreateTheoryData(GetKvpStringStringCollections_NotNull());

    public static TheoryData<IEnumerable<KeyValuePair<string, string>>, StringComparison> KvpStringStringCollections_NotNull_SetComparison() =>
        CreateTheoryDataWithComparison(GetKvpStringStringCollections_NotNull());

    public static TheoryData<IEnumerable<KeyValuePair<string, string>>, bool> KvpStringStringCollections_NotNull_CultureInfo() =>
        CreateTheoryDataWithBool(GetKvpStringStringCollections_NotNull());

    public static TheoryData<IEnumerable<KeyValuePair<string, string?>>> KvpStringStringCollections_Null_DefaultComparison() =>
        CreateTheoryData(GetAllKvpCollectionTypes_Null<string, string?>());

    public static TheoryData<IEnumerable<KeyValuePair<string, string?>>, StringComparison> KvpStringStringCollections_Null_SetComparison() =>
        CreateTheoryDataWithComparison(GetAllKvpCollectionTypes_Null<string, string?>());

    public static TheoryData<IEnumerable<KeyValuePair<string, string?>>, bool> KvpStringStringCollections_Null_CultureInfo() =>
        CreateTheoryDataWithBool(GetAllKvpCollectionTypes_Null<string, string?>());

    public static TheoryData<IEnumerable<KeyValuePair<string, string?>>> KvpStringStringCollections_Empty_DefaultComparison() =>
        CreateTheoryData(GetAllKvpCollectionTypes_Empty<string, string?>());

    public static TheoryData<IEnumerable<KeyValuePair<string, string?>>, StringComparison> KvpStringStringCollections_Empty_SetComparison() =>
        CreateTheoryDataWithComparison(GetAllKvpCollectionTypes_Empty<string, string?>());

    public static TheoryData<IEnumerable<KeyValuePair<string, string?>>, bool> KvpStringStringCollections_Empty_CultureInfo() =>
        CreateTheoryDataWithBool(GetAllKvpCollectionTypes_Empty<string, string?>());

    public static TheoryData<IEnumerable<KeyValuePair<string, string?>>> KvpStringStringCollections_WithEmptyKey_DefaultComparison() =>
        CreateTheoryData(GetKvpStringStringCollections_WithEmptyKey());

    public static TheoryData<IEnumerable<KeyValuePair<string, string?>>, StringComparison> KvpStringStringCollections_WithEmptyKey_SetComparison() =>
        CreateTheoryDataWithComparison(GetKvpStringStringCollections_WithEmptyKey());

    public static TheoryData<IEnumerable<KeyValuePair<string, string?>>, bool> KvpStringStringCollections_WithEmptyKey_CultureInfo() =>
        CreateTheoryDataWithBool(GetKvpStringStringCollections_WithEmptyKey());

    public static TheoryData<IEnumerable<KeyValuePair<string, char>>> KvpStringCharCollections_NotNull_DefaultComparison() =>
        CreateTheoryData(GetKvpStringCharCollections_NotNull());

    public static TheoryData<IEnumerable<KeyValuePair<string, char>>, StringComparison> KvpStringCharCollections_NotNull_SetComparison() =>
        CreateTheoryDataWithComparison(GetKvpStringCharCollections_NotNull());

    public static TheoryData<IEnumerable<KeyValuePair<string, char>>, bool> KvpStringCharCollections_NotNull_CultureInfo() =>
        CreateTheoryDataWithBool(GetKvpStringCharCollections_NotNull());

    public static TheoryData<IEnumerable<KeyValuePair<string, char>>> KvpStringCharCollections_Null_DefaultComparison() =>
        CreateTheoryData(GetAllKvpCollectionTypes_Null<string, char>());

    public static TheoryData<IEnumerable<KeyValuePair<string, char>>, StringComparison> KvpStringCharCollections_Null_SetComparison() =>
        CreateTheoryDataWithComparison(GetAllKvpCollectionTypes_Null<string, char>());

    public static TheoryData<IEnumerable<KeyValuePair<string, char>>, bool> KvpStringCharCollections_Null_CultureInfo() =>
        CreateTheoryDataWithBool(GetAllKvpCollectionTypes_Null<string, char>());

    public static TheoryData<IEnumerable<KeyValuePair<string, char>>> KvpStringCharCollections_Empty_DefaultComparison() =>
        CreateTheoryData(GetAllKvpCollectionTypes_Empty<string, char>());

    public static TheoryData<IEnumerable<KeyValuePair<string, char>>, StringComparison> KvpStringCharCollections_Empty_SetComparison() =>
        CreateTheoryDataWithComparison(GetAllKvpCollectionTypes_Empty<string, char>());

    public static TheoryData<IEnumerable<KeyValuePair<string, char>>, bool> KvpStringCharCollections_Empty_CultureInfo() =>
        CreateTheoryDataWithBool(GetAllKvpCollectionTypes_Empty<string, char>());

    public static TheoryData<IEnumerable<KeyValuePair<string, char>>> KvpStringCharCollections_WithEmptyKey_DefaultComparison() =>
        CreateTheoryData(GetKvpStringCharCollections_WithEmptyKey());

    public static TheoryData<IEnumerable<KeyValuePair<string, char>>, StringComparison> KvpStringCharCollections_WithEmptyKey_SetComparison() =>
        CreateTheoryDataWithComparison(GetKvpStringCharCollections_WithEmptyKey());

    public static TheoryData<IEnumerable<KeyValuePair<string, char>>, bool> KvpStringCharCollections_WithEmptyKey_CultureInfo() =>
        CreateTheoryDataWithBool(GetKvpStringCharCollections_WithEmptyKey());

    public static TheoryData<IEnumerable<KeyValuePair<char, string?>>> KvpCharStringCollections_NotNull_DefaultComparison() =>
        CreateTheoryData(GetKvpCharStringCollections_NotNull());

    public static TheoryData<IEnumerable<KeyValuePair<char, string?>>, StringComparison> KvpCharStringCollections_NotNull_SetComparison() =>
        CreateTheoryDataWithComparison(GetKvpCharStringCollections_NotNull());

    public static TheoryData<IEnumerable<KeyValuePair<char, string?>>, bool> KvpCharStringCollections_NotNull_CultureInfo() =>
        CreateTheoryDataWithBool(GetKvpCharStringCollections_NotNull());

    public static TheoryData<IEnumerable<KeyValuePair<char, string?>>> KvpCharStringCollections_Null_DefaultComparison() =>
        CreateTheoryData(GetAllKvpCollectionTypes_Null<char, string?>());

    public static TheoryData<IEnumerable<KeyValuePair<char, string?>>, StringComparison> KvpCharStringCollections_Null_SetComparison() =>
        CreateTheoryDataWithComparison(GetAllKvpCollectionTypes_Null<char, string?>());

    public static TheoryData<IEnumerable<KeyValuePair<char, string?>>, bool> KvpCharStringCollections_Null_CultureInfo() =>
        CreateTheoryDataWithBool(GetAllKvpCollectionTypes_Null<char, string?>());

    public static TheoryData<IEnumerable<KeyValuePair<char, string?>>> KvpCharStringCollections_Empty_DefaultComparison() =>
        CreateTheoryData(GetAllKvpCollectionTypes_Empty<char, string?>());

    public static TheoryData<IEnumerable<KeyValuePair<char, string?>>, StringComparison> KvpCharStringCollections_Empty_SetComparison() =>
        CreateTheoryDataWithComparison(GetAllKvpCollectionTypes_Empty<char, string?>());

    public static TheoryData<IEnumerable<KeyValuePair<char, string?>>, bool> KvpCharStringCollections_Empty_CultureInfo() =>
        CreateTheoryDataWithBool(GetAllKvpCollectionTypes_Empty<char, string?>());

    public static TheoryData<IEnumerable<KeyValuePair<char, char>>> KvpCharCharCollections_NotNull_DefaultComparison() =>
        CreateTheoryData(GetKvpCharCharCollections_NotNull());

    public static TheoryData<IEnumerable<KeyValuePair<char, char>>> KvpCharCharCollections_Null_DefaultComparison() =>
        CreateTheoryData(GetAllKvpCollectionTypes_Null<char, char>());

    public static TheoryData<IEnumerable<KeyValuePair<char, char>>> KvpCharCharCollections_Empty_DefaultComparison() =>
        CreateTheoryData(GetAllKvpCollectionTypes_Empty<char, char>());

    // Helper methods for getting collections.
    static TheoryData<IEnumerable<T>> CreateTheoryData<T>(IEnumerable<IEnumerable<T>> collections)
    {
        var data = new TheoryData<IEnumerable<T>>();
        foreach (var collection in collections)
            data.Add(collection);
        return data;
    }

    static TheoryData<IEnumerable<T>, StringComparison> CreateTheoryDataWithComparison<T>(IEnumerable<IEnumerable<T>> collections)
    {
        var data = new TheoryData<IEnumerable<T>, StringComparison>();
        foreach (var collection in collections)
            foreach (var comparison in GetAllStringComparisons())
                data.Add(collection, comparison);
        return data;
    }

    static TheoryData<IEnumerable<T>, bool> CreateTheoryDataWithBool<T>(IEnumerable<IEnumerable<T>> collections)
    {
        var data = new TheoryData<IEnumerable<T>, bool>();
        foreach (var collection in collections)
            foreach (var boolean in GetAllBooleans())
                data.Add(collection, boolean);
        return data;
    }

    static IEnumerable<IEnumerable<string>> GetStringCollections_NotNull()
    {
        yield return new string[] { OLD_STRING };
        yield return new List<string> { OLD_STRING };
        yield return new HashSet<string> { OLD_STRING };
        yield return new Queue<string>([OLD_STRING]);
    }

    static IEnumerable<IEnumerable<string>> GetStringCollections_WithNull()
    {
        yield return new string[] { OLD_STRING, null };
        yield return new List<string> { OLD_STRING, null };
        yield return new HashSet<string> { OLD_STRING, null };
        yield return new Queue<string>([OLD_STRING, null]);
    }

    static IEnumerable<IEnumerable<string>> GetStringCollections_WithEmpty()
    {
        yield return new string[] { OLD_STRING, string.Empty };
        yield return new List<string> { OLD_STRING, string.Empty };
        yield return new HashSet<string> { OLD_STRING, string.Empty };
        yield return new Queue<string>([OLD_STRING, string.Empty]);
    }

    static IEnumerable<IEnumerable<char>> GetCharCollections_NotNull()
    {
        yield return new char[] { OLD_CHAR };
        yield return new List<char> { OLD_CHAR };
        yield return new HashSet<char> { OLD_CHAR };
        yield return new Queue<char>([OLD_CHAR]);
    }

    static IEnumerable<IEnumerable<KeyValuePair<string, string>>> GetKvpStringStringCollections_NotNull()
    {
        yield return new Dictionary<string, string?> { { OLD_STRING, NEW_STRING } };
        yield return new KeyValuePair<string, string?>[] { new(OLD_STRING, NEW_STRING) };
        yield return new List<KeyValuePair<string, string?>> { new(OLD_STRING, NEW_STRING) };
        yield return new HashSet<KeyValuePair<string, string?>> { new(OLD_STRING, NEW_STRING) };
    }

    static IEnumerable<IEnumerable<KeyValuePair<string, string>>> GetKvpStringStringCollections_WithEmptyKey()
    {
        yield return new Dictionary<string, string?> { { string.Empty, NEW_STRING } };
        yield return new KeyValuePair<string, string?>[] { new(string.Empty, NEW_STRING) };
        yield return new List<KeyValuePair<string, string?>> { new(string.Empty, NEW_STRING) };
        yield return new HashSet<KeyValuePair<string, string?>> { new(string.Empty, NEW_STRING) };
    }

    static IEnumerable<IEnumerable<KeyValuePair<string, char>>> GetKvpStringCharCollections_NotNull()
    {
        yield return new Dictionary<string, char> { { OLD_STRING, NEW_CHAR } };
        yield return new KeyValuePair<string, char>[] { new(OLD_STRING, NEW_CHAR) };
        yield return new List<KeyValuePair<string, char>> { new(OLD_STRING, NEW_CHAR) };
        yield return new HashSet<KeyValuePair<string, char>> { new(OLD_STRING, NEW_CHAR) };
    }

    static IEnumerable<IEnumerable<KeyValuePair<string, char>>> GetKvpStringCharCollections_WithEmptyKey()
    {
        yield return new Dictionary<string, char> { { string.Empty, NEW_CHAR } };
        yield return new KeyValuePair<string, char>[] { new(string.Empty, NEW_CHAR) };
        yield return new List<KeyValuePair<string, char>> { new(string.Empty, NEW_CHAR) };
        yield return new HashSet<KeyValuePair<string, char>> { new(string.Empty, NEW_CHAR) };
    }

    static IEnumerable<IEnumerable<KeyValuePair<char, string>>> GetKvpCharStringCollections_NotNull()
    {
        yield return new Dictionary<char, string?> { { OLD_CHAR, NEW_STRING } };
        yield return new KeyValuePair<char, string?>[] { new(OLD_CHAR, NEW_STRING) };
        yield return new List<KeyValuePair<char, string?>> { new(OLD_CHAR, NEW_STRING) };
        yield return new HashSet<KeyValuePair<char, string?>> { new(OLD_CHAR, NEW_STRING) };
    }

    static IEnumerable<IEnumerable<KeyValuePair<char, char>>> GetKvpCharCharCollections_NotNull()
    {
        yield return new Dictionary<char, char> { { OLD_CHAR, NEW_CHAR } };
        yield return new KeyValuePair<char, char>[] { new(OLD_CHAR, NEW_CHAR) };
        yield return new List<KeyValuePair<char, char>> { new(OLD_CHAR, NEW_CHAR) };
        yield return new HashSet<KeyValuePair<char, char>> { new(OLD_CHAR, NEW_CHAR) };
    }

    static IEnumerable<IEnumerable<T>> GetAllCollectionTypes_Empty<T>()
    {
        yield return Array.Empty<T>();
        yield return new List<T>();
        yield return new HashSet<T>();
        yield return new Queue<T>();
    }

    static IEnumerable<IEnumerable<T>> GetAllCollectionTypes_Null<T>()
    {
        yield return (T[])null;
        yield return (List<T>)null;
        yield return (HashSet<T>)null;
        yield return (Queue<T>)null;
    }

    static IEnumerable<IEnumerable<KeyValuePair<T1, T2>>> GetAllKvpCollectionTypes_Empty<T1, T2>()
    {
        yield return new Dictionary<T1, T2>();
        yield return Array.Empty<KeyValuePair<T1, T2>>();
        yield return new List<KeyValuePair<T1, T2>>();
        yield return new HashSet<KeyValuePair<T1, T2>>();
        yield return new Queue<KeyValuePair<T1, T2>>();
    }

    static IEnumerable<IEnumerable<KeyValuePair<T1, T2>>> GetAllKvpCollectionTypes_Null<T1, T2>()
    {
        yield return (Dictionary<T1, T2>)null;
        yield return (KeyValuePair<T1, T2>[])null;
        yield return (List<KeyValuePair<T1, T2>>)null;
        yield return (HashSet<KeyValuePair<T1, T2>>)null;
        yield return (Queue<KeyValuePair<T1, T2>>)null;
    }

    static IEnumerable<StringComparison> GetAllStringComparisons()
        => Enum.GetValues<StringComparison>();

    static IEnumerable<bool> GetAllBooleans()
    {
        yield return true;
        yield return false;
    }

    #endregion MemberData

    #region Replace(string str, IEnumerable<string> oldStrings, char newChar, StringComparison comparison = StringComparison.CurrentCulture)

    [Theory]
    [MemberData(nameof(StringCollections_NotNull_DefaultComparison))]
    public void Replace_IEnumStrCharStrComp_OriginalInstanceNotNull_DefaultComparison(IEnumerable<string> oldStrings)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(oldStrings, NEW_CHAR);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_NotNull_SetComparison))]
    public void Replace_IEnumStrCharStrComp_OriginalInstanceNotNull_SetComparison(IEnumerable<string> oldStrings, StringComparison comparison)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(oldStrings, NEW_CHAR, comparison);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_Null_DefaultComparison))]
    public void Replace_IEnumStrCharStrComp_NotNull_DefaultComparison(IEnumerable<string> oldStrings)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"oldStrings\" of method \"Replace\" was null. (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_CHAR);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_Null_SetComparison))]
    public void Replace_IEnumStrCharStrComp_NotNull_SetComparison(IEnumerable<string> oldStrings, StringComparison comparison)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"oldStrings\" of method \"Replace\" was null. (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_CHAR, comparison);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_Empty_DefaultComparison))]
    public void Replace_IEnumStrCharStrComp_IEnumNotEmpty_DefaultComparison(IEnumerable<string> oldStrings)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"oldStrings\" of method \"Replace\" contains no elements. (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_CHAR);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_Empty_SetComparison))]
    public void Replace_IEnumStrCharStrComp_IEnumNotEmpty_SetComparison(IEnumerable<string> oldStrings, StringComparison comparison)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"oldStrings\" of method \"Replace\" contains no elements. (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_CHAR, comparison);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_NotNull_DefaultComparison))]
    public void Replace_IEnumStrCharStrComp_EnumContainsValue(IEnumerable<string> oldStrings)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"comparison\" of method \"Replace\" does not exist in enum \"StringComparison\" (Parameter 'comparison')";
        void testAction() => testString.Replace(oldStrings, NEW_CHAR, (StringComparison)999);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_WithNull_DefaultComparison))]
    public void Replace_IEnumStrCharStrComp_NotNullMember_DefaultComparison(IEnumerable<string> oldStrings)
    {
        string testString = OLD_STRING;
        string expectedMessage = "A member of the collection argument given for parameter \"oldStrings\" of method \"Replace\" was null. (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_CHAR);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_WithNull_SetComparison))]
    public void Replace_IEnumStrCharStrComp_NotNullMember_SetComparison(IEnumerable<string> oldStrings, StringComparison comparison)
    {
        string testString = OLD_STRING;
        string expectedMessage = "A member of the collection argument given for parameter \"oldStrings\" of method \"Replace\" was null. (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_CHAR, comparison);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_WithEmpty_DefaultComparison))]
    public void Replace_IEnumStrCharStrComp_NotEmptyStringMember_DefaultComparison(IEnumerable<string> oldStrings)
    {
        string testString = OLD_STRING;
        string expectedMessage = "A member of the collection given for parameter \"oldStrings\" of method \"Replace\" is the empty string (\"\"). (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_CHAR);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_WithEmpty_SetComparison))]
    public void Replace_IEnumStrCharStrComp_NotEmptyStringMember_SetComparison(IEnumerable<string> oldStrings, StringComparison comparison)
    {
        string testString = OLD_STRING;
        string expectedMessage = "A member of the collection given for parameter \"oldStrings\" of method \"Replace\" is the empty string (\"\"). (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_CHAR, comparison);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Replace(string str, IEnumerable<string> oldStrings, char newChar, StringComparison comparison = StringComparison.CurrentCulture)

    #region Replace(string str, IEnumerable<string> oldStrings, char newChar, bool ignoreCase, CultureInfo? culture)

    [Theory]
    [MemberData(nameof(StringCollections_NotNull_CultureInfo))]
    public void Replace_IEnumStrCharBoolCultInf_OriginalInstanceNotNull_CultureInfo(IEnumerable<string> oldStrings, bool ignoreCase)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(oldStrings, NEW_CHAR, ignoreCase, null);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_Null_CultureInfo))]
    public void Replace_IEnumStrCharBoolCultInf_NotNull_CultureInfo(IEnumerable<string> oldStrings, bool ignoreCase)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"oldStrings\" of method \"Replace\" was null. (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_CHAR, ignoreCase, null);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_Empty_CultureInfo))]
    public void Replace_IEnumStrCharBoolCultInf_IEnumNotEmpty_CultureInfo(IEnumerable<string> oldStrings, bool ignoreCase)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"oldStrings\" of method \"Replace\" contains no elements. (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_CHAR, ignoreCase, null);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_WithNull_CultureInfo))]
    public void Replace_IEnumStrCharBoolCultInf_NotNullMember_CultureInfo(IEnumerable<string> oldStrings, bool ignoreCase)
    {
        string testString = OLD_STRING;
        string expectedMessage = "A member of the collection argument given for parameter \"oldStrings\" of method \"Replace\" was null. (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_CHAR, ignoreCase, null);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_WithEmpty_CultureInfo))]
    public void Replace_IEnumStrCharBoolCultInf_NotEmptyStringMember_CultureInfo(IEnumerable<string> oldStrings, bool ignoreCase)
    {
        string testString = OLD_STRING;
        string expectedMessage = "A member of the collection given for parameter \"oldStrings\" of method \"Replace\" is the empty string (\"\"). (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_CHAR, ignoreCase, null);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Replace(string str, IEnumerable<string> oldStrings, char newChar, bool ignoreCase, CultureInfo? culture)

    #region Replace(string str, IEnumerable<string> oldStrings, string? newString, StringComparison comparison = StringComparison.CurrentCulture)

    [Theory]
    [MemberData(nameof(StringCollections_NotNull_DefaultComparison))]
    public void Replace_IEnumStrStrStrComp_OriginalInstanceNotNull_DefaultComparison(IEnumerable<string> oldStrings)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(oldStrings, NEW_STRING);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_NotNull_SetComparison))]
    public void Replace_IEnumStrStrStrComp_OriginalInstanceNotNull_SetComparison(IEnumerable<string> oldStrings, StringComparison comparison)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(oldStrings, NEW_STRING, comparison);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_Null_DefaultComparison))]
    public void Replace_IEnumStrStrStrComp_NotNull_DefaultComparison(IEnumerable<string> oldStrings)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"oldStrings\" of method \"Replace\" was null. (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_STRING);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_Null_SetComparison))]
    public void Replace_IEnumStrStrStrComp_NotNull_SetComparison(IEnumerable<string> oldStrings, StringComparison comparison)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"oldStrings\" of method \"Replace\" was null. (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_STRING, comparison);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_Empty_DefaultComparison))]
    public void Replace_IEnumStrStrStrComp_IEnumNotEmpty_DefaultComparison(IEnumerable<string> oldStrings)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"oldStrings\" of method \"Replace\" contains no elements. (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_STRING);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_Empty_SetComparison))]
    public void Replace_IEnumStrStrStrComp_IEnumNotEmpty_SetComparison(IEnumerable<string> oldStrings, StringComparison comparison)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"oldStrings\" of method \"Replace\" contains no elements. (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_STRING, comparison);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_NotNull_DefaultComparison))]
    public void Replace_IEnumStrStrStrComp_EnumContainsValue(IEnumerable<string> oldStrings)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"comparison\" of method \"Replace\" does not exist in enum \"StringComparison\" (Parameter 'comparison')";
        void testAction() => testString.Replace(oldStrings, NEW_STRING, (StringComparison)999);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_WithNull_DefaultComparison))]
    public void Replace_IEnumStrStrStrComp_NotNullMember_DefaultComparison(IEnumerable<string> oldStrings)
    {
        string testString = OLD_STRING;
        string expectedMessage = "A member of the collection argument given for parameter \"oldStrings\" of method \"Replace\" was null. (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_STRING);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_WithNull_SetComparison))]
    public void Replace_IEnumStrStrStrComp_NotNullMember_SetComparison(IEnumerable<string> oldStrings, StringComparison comparison)
    {
        string testString = OLD_STRING;
        string expectedMessage = "A member of the collection argument given for parameter \"oldStrings\" of method \"Replace\" was null. (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_STRING, comparison);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_WithEmpty_DefaultComparison))]
    public void Replace_IEnumStrStrStrComp_NotEmptyStringMember_DefaultComparison(IEnumerable<string> oldStrings)
    {
        string testString = OLD_STRING;
        string expectedMessage = "A member of the collection given for parameter \"oldStrings\" of method \"Replace\" is the empty string (\"\"). (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_STRING);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_WithEmpty_SetComparison))]
    public void Replace_IEnumStrStrStrComp_NotEmptyStringMember_SetComparison(IEnumerable<string> oldStrings, StringComparison comparison)
    {
        string testString = OLD_STRING;
        string expectedMessage = "A member of the collection given for parameter \"oldStrings\" of method \"Replace\" is the empty string (\"\"). (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_STRING, comparison);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Replace(string str, IEnumerable<string> oldStrings, string? newString, StringComparison comparison = StringComparison.CurrentCulture)

    #region Replace(string str, IEnumerable<string> oldStrings, string? newString, bool ignoreCase, CultureInfo? culture)

    [Theory]
    [MemberData(nameof(StringCollections_NotNull_CultureInfo))]
    public void Replace_IEnumStrStrBoolCultInf_OriginalInstanceNotNull_CultureInfo(IEnumerable<string> oldStrings, bool ignoreCase)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(oldStrings, NEW_STRING, ignoreCase, null);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_Null_CultureInfo))]
    public void Replace_IEnumStrStrBoolCultInf_NotNull_CultureInfo(IEnumerable<string> oldStrings, bool ignoreCase)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"oldStrings\" of method \"Replace\" was null. (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_STRING, ignoreCase, null);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_Empty_CultureInfo))]
    public void Replace_IEnumStrStrBoolCultInf_IEnumNotEmpty_CultureInfo(IEnumerable<string> oldStrings, bool ignoreCase)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"oldStrings\" of method \"Replace\" contains no elements. (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_STRING, ignoreCase, null);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_WithNull_CultureInfo))]
    public void Replace_IEnumStrStrBoolCultInf_NotNullMember_CultureInfo(IEnumerable<string> oldStrings, bool ignoreCase)
    {
        string testString = OLD_STRING;
        string expectedMessage = "A member of the collection argument given for parameter \"oldStrings\" of method \"Replace\" was null. (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_STRING, ignoreCase, null);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(StringCollections_WithEmpty_CultureInfo))]
    public void Replace_IEnumStrStrBoolCultInf_NotEmptyStringMember_CultureInfo(IEnumerable<string> oldStrings, bool ignoreCase)
    {
        string testString = OLD_STRING;
        string expectedMessage = "A member of the collection given for parameter \"oldStrings\" of method \"Replace\" is the empty string (\"\"). (Parameter 'oldStrings')";
        void testAction() => testString.Replace(oldStrings, NEW_STRING, ignoreCase, null);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Replace(string str, IEnumerable<string> oldStrings, string? newString, bool ignoreCase, CultureInfo? culture)

    #region Replace(string str, IEnumerable<char> oldChars, char newChar)

    [Theory]
    [MemberData(nameof(CharCollections_NotNull_DefaultComparison))]
    public void Replace_IEnumCharChar_OriginalInstanceNotNull(IEnumerable<char> oldChars)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(oldChars, NEW_CHAR);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(CharCollections_Null_DefaultComparison))]
    public void Replace_IEnumCharChar_NotNull(IEnumerable<char> oldChars)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"oldChars\" of method \"Replace\" was null. (Parameter 'oldChars')";
        void testAction() => testString.Replace(oldChars, NEW_CHAR);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(CharCollections_Empty_DefaultComparison))]
    public void Replace_IEnumCharChar_IEnumNotEmpty(IEnumerable<char> oldChars)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"oldChars\" of method \"Replace\" contains no elements. (Parameter 'oldChars')";
        void testAction() => testString.Replace(oldChars, NEW_CHAR);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Replace(string str, IEnumerable<char> oldChars, char newChar)

    #region Replace(string str, IEnumerable<char> oldChars, string? newString, StringComparison comparison = StringComparison.CurrentCulture)

    [Theory]
    [MemberData(nameof(CharCollections_NotNull_DefaultComparison))]
    public void Replace_IEnumCharStrStrComp_OriginalInstanceNotNull_DefaultComparison(IEnumerable<char> oldChars)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(oldChars, NEW_STRING);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(CharCollections_NotNull_SetComparison))]
    public void Replace_IEnumCharStrStrComp_OriginalInstanceNotNull_SetComparison(IEnumerable<char> oldChars, StringComparison comparison)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(oldChars, NEW_STRING, comparison);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(CharCollections_Null_DefaultComparison))]
    public void Replace_IEnumCharStrStrComp_NotNull_DefaultComparison(IEnumerable<char> oldChars)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"oldChars\" of method \"Replace\" was null. (Parameter 'oldChars')";
        void testAction() => testString.Replace(oldChars, NEW_STRING);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(CharCollections_Null_SetComparison))]
    public void Replace_IEnumCharStrStrComp_NotNull_SetComparison(IEnumerable<char> oldChars, StringComparison comparison)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"oldChars\" of method \"Replace\" was null. (Parameter 'oldChars')";
        void testAction() => testString.Replace(oldChars, NEW_STRING, comparison);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(CharCollections_Empty_DefaultComparison))]
    public void Replace_IEnumCharStrStrComp_IEnumNotEmpty_DefaultComparison(IEnumerable<char> oldChars)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"oldChars\" of method \"Replace\" contains no elements. (Parameter 'oldChars')";
        void testAction() => testString.Replace(oldChars, NEW_STRING);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(CharCollections_Empty_SetComparison))]
    public void Replace_IEnumCharStrStrComp_IEnumNotEmpty_SetComparison(IEnumerable<char> oldChars, StringComparison comparison)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"oldChars\" of method \"Replace\" contains no elements. (Parameter 'oldChars')";
        void testAction() => testString.Replace(oldChars, NEW_STRING, comparison);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(CharCollections_NotNull_DefaultComparison))]
    public void Replace_IEnumCharStrStrComp_EnumContainsValue(IEnumerable<char> oldChars)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"comparison\" of method \"Replace\" does not exist in enum \"StringComparison\" (Parameter 'comparison')";
        void testAction() => testString.Replace(oldChars, NEW_STRING, (StringComparison)999);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Replace(string str, IEnumerable<char> oldChars, string? newString, StringComparison comparison = StringComparison.CurrentCulture)

    #region Replace(string str, IEnumerable<char> oldChars, string? newString, bool ignoreCase, CultureInfo? culture)

    [Theory]
    [MemberData(nameof(CharCollections_NotNull_CultureInfo))]
    public void Replace_IEnumCharStrBoolCultInf_OriginalInstanceNotNull_CultureInfo(IEnumerable<char> oldChars, bool ignoreCase)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(oldChars, NEW_STRING, ignoreCase, null);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(CharCollections_Null_CultureInfo))]
    public void Replace_IEnumCharStrBoolCultInf_NotNull_CultureInfo(IEnumerable<char> oldChars, bool ignoreCase)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"oldChars\" of method \"Replace\" was null. (Parameter 'oldChars')";
        void testAction() => testString.Replace(oldChars, NEW_STRING, ignoreCase, null);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(CharCollections_Empty_CultureInfo))]
    public void Replace_IEnumCharStrBoolCultInf_IEnumNotEmpty_CultureInfo(IEnumerable<char> oldChars, bool ignoreCase)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"oldChars\" of method \"Replace\" contains no elements. (Parameter 'oldChars')";
        void testAction() => testString.Replace(oldChars, NEW_STRING, ignoreCase, null);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Replace(string str, IEnumerable<char> oldChars, string? newString, bool ignoreCase, CultureInfo? culture)

    #region Replace(string str, IEnumerable<KeyValuePair<string, string?>> replaceData, StringComparison comparison = StringComparison.CurrentCulture)

    [Theory]
    [MemberData(nameof(KvpStringStringCollections_NotNull_DefaultComparison))]
    public void Replace_IEnumKvpStrStrStrComp_OriginalInstanceNotNull_DefaultComparison(IEnumerable<KeyValuePair<string, string?>> replaceData)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(replaceData);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringStringCollections_NotNull_SetComparison))]
    public void Replace_IEnumKvpStrStrStrComp_OriginalInstanceNotNull_SetComparison(IEnumerable<KeyValuePair<string, string?>> replaceData, StringComparison comparison)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(replaceData, comparison);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringStringCollections_Null_DefaultComparison))]
    public void Replace_IEnumKvpStrStrStrComp_NotNull_DefaultComparison(IEnumerable<KeyValuePair<string, string?>> replaceData)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"replaceData\" of method \"Replace\" was null. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringStringCollections_Null_SetComparison))]
    public void Replace_IEnumKvpStrStrStrComp_NotNull_SetComparison(IEnumerable<KeyValuePair<string, string?>> replaceData, StringComparison comparison)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"replaceData\" of method \"Replace\" was null. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData, comparison);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringStringCollections_Empty_DefaultComparison))]
    public void Replace_IEnumKvpStrStrStrComp_IEnumNotEmpty_DefaultComparison(IEnumerable<KeyValuePair<string, string?>> replaceData)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"replaceData\" of method \"Replace\" contains no elements. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringStringCollections_Empty_SetComparison))]
    public void Replace_IEnumKvpStrStrStrComp_IEnumNotEmpty_SetComparison(IEnumerable<KeyValuePair<string, string?>> replaceData, StringComparison comparison)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"replaceData\" of method \"Replace\" contains no elements. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData, comparison);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringStringCollections_NotNull_DefaultComparison))]
    public void Replace_IEnumKvpStrStrStrComp_EnumContainsValue(IEnumerable<KeyValuePair<string, string?>> replaceData)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"comparison\" of method \"Replace\" does not exist in enum \"StringComparison\" (Parameter 'comparison')";
        void testAction() => testString.Replace(replaceData, (StringComparison)999);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringStringCollections_WithEmptyKey_DefaultComparison))]
    public void Replace_IEnumKvpStrStrStrComp_NotEmptyStringKey_DefaultComparison(IEnumerable<KeyValuePair<string, string?>> replaceData)
    {
        string testString = OLD_STRING;
        string expectedMessage = "A key of the dictionary given for parameter \"replaceData\" of method \"Replace\" is the empty string (\"\"). (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringStringCollections_WithEmptyKey_SetComparison))]
    public void Replace_IEnumKvpStrStrStrComp_NotEmptyStringKey_SetComparison(IEnumerable<KeyValuePair<string, string?>> replaceData, StringComparison comparison)
    {
        string testString = OLD_STRING;
        string expectedMessage = "A key of the dictionary given for parameter \"replaceData\" of method \"Replace\" is the empty string (\"\"). (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData, comparison);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Replace(string str, IEnumerable<KeyValuePair<string, string?>> replaceData, StringComparison comparison = StringComparison.CurrentCulture)

    #region Replace(string str, IEnumerable<KeyValuePair<string, string?>> replaceData, bool ignoreCase, CultureInfo? culture)

    [Theory]
    [MemberData(nameof(KvpStringStringCollections_NotNull_CultureInfo))]
    public void Replace_IEnumKvpStrStrBoolCultInf_OriginalInstanceNotNull_CultureInfo(IEnumerable<KeyValuePair<string, string?>> replaceData, bool ignoreCase)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(replaceData, ignoreCase, null);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringStringCollections_Null_CultureInfo))]
    public void Replace_IEnumKvpStrStrBoolCultInf_NotNull_CultureInfo(IEnumerable<KeyValuePair<string, string?>> replaceData, bool ignoreCase)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"replaceData\" of method \"Replace\" was null. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData, ignoreCase, null);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringStringCollections_Empty_CultureInfo))]
    public void Replace_IEnumKvpStrStrBoolCultInf_IEnumNotEmpty_CultureInfo(IEnumerable<KeyValuePair<string, string?>> replaceData, bool ignoreCase)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"replaceData\" of method \"Replace\" contains no elements. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData, ignoreCase, null);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringStringCollections_WithEmptyKey_CultureInfo))]
    public void Replace_IEnumKvpStrStrBoolCultInf_NotEmptyStringKey_CultureInfo(IEnumerable<KeyValuePair<string, string?>> replaceData, bool ignoreCase)
    {
        string testString = OLD_STRING;
        string expectedMessage = "A key of the dictionary given for parameter \"replaceData\" of method \"Replace\" is the empty string (\"\"). (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData, ignoreCase, null);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Replace(string str, IEnumerable<KeyValuePair<string, string?>> replaceData, bool ignoreCase, CultureInfo? culture)

    #region Replace(string str, IEnumerable<KeyValuePair<string, char>> replaceData, StringComparison comparison = StringComparison.CurrentCulture)

    [Theory]
    [MemberData(nameof(KvpStringCharCollections_NotNull_DefaultComparison))]
    public void Replace_IEnumKvpStrCharStrComp_OriginalInstanceNotNull_DefaultComparison(IEnumerable<KeyValuePair<string, char>> replaceData)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(replaceData);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringCharCollections_NotNull_SetComparison))]
    public void Replace_IEnumKvpStrCharStrComp_OriginalInstanceNotNull_SetComparison(IEnumerable<KeyValuePair<string, char>> replaceData, StringComparison comparison)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(replaceData, comparison);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringCharCollections_Null_DefaultComparison))]
    public void Replace_IEnumKvpStrCharStrComp_NotNull_DefaultComparison(IEnumerable<KeyValuePair<string, char>> replaceData)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"replaceData\" of method \"Replace\" was null. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringCharCollections_Null_SetComparison))]
    public void Replace_IEnumKvpStrCharStrComp_NotNull_SetComparison(IEnumerable<KeyValuePair<string, char>> replaceData, StringComparison comparison)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"replaceData\" of method \"Replace\" was null. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData, comparison);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringCharCollections_Empty_DefaultComparison))]
    public void Replace_IEnumKvpStrCharStrComp_IEnumNotEmpty_DefaultComparison(IEnumerable<KeyValuePair<string, char>> replaceData)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"replaceData\" of method \"Replace\" contains no elements. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringCharCollections_Empty_SetComparison))]
    public void Replace_IEnumKvpStrCharStrComp_IEnumNotEmpty_SetComparison(IEnumerable<KeyValuePair<string, char>> replaceData, StringComparison comparison)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"replaceData\" of method \"Replace\" contains no elements. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData, comparison);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringCharCollections_NotNull_DefaultComparison))]
    public void Replace_IEnumKvpStrCharStrComp_EnumContainsValue(IEnumerable<KeyValuePair<string, char>> replaceData)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"comparison\" of method \"Replace\" does not exist in enum \"StringComparison\" (Parameter 'comparison')";
        void testAction() => testString.Replace(replaceData, (StringComparison)999);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringCharCollections_WithEmptyKey_DefaultComparison))]
    public void Replace_IEnumKvpStrCharStrComp_NotEmptyStringKey_DefaultComparison(IEnumerable<KeyValuePair<string, char>> replaceData)
    {
        string testString = OLD_STRING;
        string expectedMessage = "A key of the dictionary given for parameter \"replaceData\" of method \"Replace\" is the empty string (\"\"). (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringCharCollections_WithEmptyKey_SetComparison))]
    public void Replace_IEnumKvpStrCharStrComp_NotEmptyStringKey_SetComparison(IEnumerable<KeyValuePair<string, char>> replaceData, StringComparison comparison)
    {
        string testString = OLD_STRING;
        string expectedMessage = "A key of the dictionary given for parameter \"replaceData\" of method \"Replace\" is the empty string (\"\"). (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData, comparison);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Replace(string str, IEnumerable<KeyValuePair<string, char>> replaceData, StringComparison comparison = StringComparison.CurrentCulture)

    #region Replace(string str, IEnumerable<KeyValuePair<string, char>> replaceData, bool ignoreCase, CultureInfo? culture)

    [Theory]
    [MemberData(nameof(KvpStringCharCollections_NotNull_CultureInfo))]
    public void Replace_IEnumKvpStrCharBoolCultInf_OriginalInstanceNotNull_CultureInfo(IEnumerable<KeyValuePair<string, char>> replaceData, bool ignoreCase)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(replaceData, ignoreCase, null);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringCharCollections_Null_CultureInfo))]
    public void Replace_IEnumKvpStrCharBoolCultInf_NotNull_CultureInfo(IEnumerable<KeyValuePair<string, char>> replaceData, bool ignoreCase)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"replaceData\" of method \"Replace\" was null. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData, ignoreCase, null);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringCharCollections_Empty_CultureInfo))]
    public void Replace_IEnumKvpStrCharBoolCultInf_IEnumNotEmpty_CultureInfo(IEnumerable<KeyValuePair<string, char>> replaceData, bool ignoreCase)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"replaceData\" of method \"Replace\" contains no elements. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData, ignoreCase, null);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpStringCharCollections_WithEmptyKey_CultureInfo))]
    public void Replace_IEnumKvpStrCharBoolCultInf_NotEmptyStringKey_CultureInfo(IEnumerable<KeyValuePair<string, char>> replaceData, bool ignoreCase)
    {
        string testString = OLD_STRING;
        string expectedMessage = "A key of the dictionary given for parameter \"replaceData\" of method \"Replace\" is the empty string (\"\"). (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData, ignoreCase, null);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Replace(string str, IEnumerable<KeyValuePair<string, char>> replaceData, bool ignoreCase, CultureInfo? culture)

    #region Replace(string str, IEnumerable<KeyValuePair<char, string?>> replaceData, StringComparison comparison = StringComparison.CurrentCulture)

    [Theory]
    [MemberData(nameof(KvpCharStringCollections_NotNull_DefaultComparison))]
    public void Replace_IEnumKvpCharStrStrComp_OriginalInstanceNotNull_DefaultComparison(IEnumerable<KeyValuePair<char, string?>> replaceData)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(replaceData);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpCharStringCollections_NotNull_SetComparison))]
    public void Replace_IEnumKvpCharStrStrComp_OriginalInstanceNotNull_SetComparison(IEnumerable<KeyValuePair<char, string?>> replaceData, StringComparison comparison)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(replaceData, comparison);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpCharStringCollections_Null_DefaultComparison))]
    public void Replace_IEnumKvpCharStrStrComp_NotNull_DefaultComparison(IEnumerable<KeyValuePair<char, string?>> replaceData)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"replaceData\" of method \"Replace\" was null. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpCharStringCollections_Null_SetComparison))]
    public void Replace_IEnumKvpCharStrStrComp_NotNull_SetComparison(IEnumerable<KeyValuePair<char, string?>> replaceData, StringComparison comparison)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"replaceData\" of method \"Replace\" was null. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData, comparison);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpCharStringCollections_Empty_DefaultComparison))]
    public void Replace_IEnumKvpCharStrStrComp_IEnumNotEmpty_DefaultComparison(IEnumerable<KeyValuePair<char, string?>> replaceData)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"replaceData\" of method \"Replace\" contains no elements. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpCharStringCollections_Empty_SetComparison))]
    public void Replace_IEnumKvpCharStrStrComp_IEnumNotEmpty_SetComparison(IEnumerable<KeyValuePair<char, string?>> replaceData, StringComparison comparison)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"replaceData\" of method \"Replace\" contains no elements. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData, comparison);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpCharStringCollections_NotNull_DefaultComparison))]
    public void Replace_IEnumKvpCharStrStrComp_EnumContainsValue(IEnumerable<KeyValuePair<char, string?>> replaceData)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"comparison\" of method \"Replace\" does not exist in enum \"StringComparison\" (Parameter 'comparison')";
        void testAction() => testString.Replace(replaceData, (StringComparison)999);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Replace(string str, IEnumerable<KeyValuePair<char, string?>> replaceData, StringComparison comparison = StringComparison.CurrentCulture)

    #region Replace(string str, IEnumerable<KeyValuePair<char, string?>> replaceData, bool ignoreCase, CultureInfo? culture)

    [Theory]
    [MemberData(nameof(KvpCharStringCollections_NotNull_CultureInfo))]
    public void Replace_IEnumKvpCharStrBoolCultInf_OriginalInstanceNotNull_CultureInfo(IEnumerable<KeyValuePair<char, string?>> replaceData, bool ignoreCase)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(replaceData, ignoreCase, null);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpCharStringCollections_Null_CultureInfo))]
    public void Replace_IEnumKvpCharStrBoolCultInf_NotNull_CultureInfo(IEnumerable<KeyValuePair<char, string?>> replaceData, bool ignoreCase)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"replaceData\" of method \"Replace\" was null. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData, ignoreCase, null);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpCharStringCollections_Empty_CultureInfo))]
    public void Replace_IEnumKvpCharStrBoolCultInf_IEnumNotEmpty_CultureInfo(IEnumerable<KeyValuePair<char, string?>> replaceData, bool ignoreCase)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"replaceData\" of method \"Replace\" contains no elements. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData, ignoreCase, null);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Replace(string str, IEnumerable<KeyValuePair<char, string?>> replaceData, bool ignoreCase, CultureInfo? culture)

    #region Replace(string str, IEnumerable<KeyValuePair<char, char>> replaceData)

    [Theory]
    [MemberData(nameof(KvpCharCharCollections_NotNull_DefaultComparison))]
    public void Replace_IEnumKvpCharChar_OriginalInstanceNotNull(IEnumerable<KeyValuePair<char, char>> replaceData)
    {
        string testString = null;
        string expectedMessage = "The string instance on which \"Replace\" was called is null. (Parameter 'Original string instance')";
        void testAction() => testString.Replace(replaceData);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpCharCharCollections_Null_DefaultComparison))]
    public void Replace_IEnumKvpCharChar_NotNull(IEnumerable<KeyValuePair<char, char>> replaceData)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The argument given for parameter \"replaceData\" of method \"Replace\" was null. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData);
        var exception = Assert.Throws<ArgumentNullException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    [Theory]
    [MemberData(nameof(KvpCharCharCollections_Empty_DefaultComparison))]
    public void Replace_IEnumKvpCharChar_IEnumNotEmpty(IEnumerable<KeyValuePair<char, char>> replaceData)
    {
        string testString = OLD_STRING;
        string expectedMessage = "The collection argument given for parameter \"replaceData\" of method \"Replace\" contains no elements. (Parameter 'replaceData')";
        void testAction() => testString.Replace(replaceData);
        var exception = Assert.Throws<ArgumentException>(testAction);
        Assert.Equal(expectedMessage, exception.Message);
    }

    #endregion Replace(string str, IEnumerable<KeyValuePair<char, char>> replaceData)
}