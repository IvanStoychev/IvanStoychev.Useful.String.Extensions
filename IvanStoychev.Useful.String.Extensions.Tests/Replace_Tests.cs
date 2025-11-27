using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Replace_Tests
{
    [Theory, MemberData(nameof(Data_Replace_IEnumString_Char_DefaultComparison))]
    public void Replace_IEnumString_Char_DefaultComparison(string testString, char newChar, IEnumerable<string> oldStrings, string expectedString)
    {
        string actualString = testString.Replace(oldStrings, newChar);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_IEnumString_Char_SetComparison))]
    public void Replace_IEnumString_Char_SetComparison(string testString, char newChar, IEnumerable<string> oldChars, StringComparison stringComparison, string expectedString)
    {
        string actualString = testString.Replace(oldChars, newChar, stringComparison);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_IEnumString_Char_CultureInfo))]
    public void Replace_IEnumString_Char_CultureInfo(string testString, char newChar, IEnumerable<string> oldChars, bool ignoreCase, string expectedString)
    {
        string actualString = testString.Replace(oldChars, newChar, ignoreCase, CultureInfo.InvariantCulture);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_IEnumString_String_DefaultComparison))]
    public void Replace_IEnumString_String_DefaultComparison(string testString, string newString, IEnumerable<string> oldStrings, string expectedString)
    {
        string actualString = testString.Replace(oldStrings, newString);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_IEnumString_String_SetComparison))]
    public void Replace_IEnumString_String_SetComparison(string testString, string newString, IEnumerable<string> oldStrings, StringComparison stringComparison, string expectedString)
    {
        string actualString = testString.Replace(oldStrings, newString, stringComparison);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_IEnumString_String_CultureInfo))]
    public void Replace_IEnumString_String_CultureInfo(string testString, string newString, IEnumerable<string> oldStrings, bool ignoreCase, string expectedString)
    {
        string actualString = testString.Replace(oldStrings, newString, ignoreCase, CultureInfo.InvariantCulture);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_IEnumChar_Char))]
    public void Replace_IEnumChar_Char(string testString, char newChar, IEnumerable<char> oldChars, string expectedString)
    {
        string actualString = testString.Replace(oldChars, newChar);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_IEnumChar_String_DefaultComparison))]
    public void Replace_IEnumChar_String_DefaultComparison(string testString, string newString, IEnumerable<char> oldStrings, string expectedString)
    {
        string actualString = testString.Replace(oldStrings, newString);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_IEnumChar_String_SetComparison))]
    public void Replace_IEnumChar_String_SetComparison(string testString, string newString, IEnumerable<char> oldStrings, StringComparison stringComparison, string expectedString)
    {
        string actualString = testString.Replace(oldStrings, newString, stringComparison);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_IEnumChar_String_CultureInfo))]
    public void Replace_IEnumChar_String_CultureInfo(string testString, string newString, IEnumerable<char> oldStrings, bool ignoreCase, string expectedString)
    {
        string actualString = testString.Replace(oldStrings, newString, ignoreCase, CultureInfo.InvariantCulture);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_IEnumKVPStringString_DefaultComparison))]
    public void Replace_IEnumKVPStringString_DefaultComparison(string testString, IEnumerable<KeyValuePair<string, string>> replaceData, string expectedString)
    {
        string actualString = testString.Replace(replaceData);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_IEnumKVPStringString_SetComparison))]
    public void Replace_IEnumKVPStringString_SetComparison(string testString, IEnumerable<KeyValuePair<string, string>> replaceData, StringComparison stringComparison, string expectedString)
    {
        string actualString = testString.Replace(replaceData, stringComparison);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_IEnumKVPStringString_CultureInfo))]
    public void Replace_IEnumKVPStringString_CultureInfo(string testString, IEnumerable<KeyValuePair<string, string>> replaceData, bool ignoreCase, string expectedString)
    {
        string actualString = testString.Replace(replaceData, ignoreCase, CultureInfo.InvariantCulture);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_IEnumKVPStringChar_DefaultComparison))]
    public void Replace_IEnumKVPStringChar_DefaultComparison(string testString, IEnumerable<KeyValuePair<string, char>> replaceData, string expectedString)
    {
        string actualString = testString.Replace(replaceData);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_IEnumKVPStringChar_SetComparison))]
    public void Replace_IEnumKVPStringChar_SetComparison(string testString, IEnumerable<KeyValuePair<string, char>> replaceData, StringComparison stringComparison, string expectedString)
    {
        string actualString = testString.Replace(replaceData, stringComparison);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_IEnumKVPStringChar_CultureInfo))]
    public void Replace_IEnumKVPStringChar_CultureInfo(string testString, IEnumerable<KeyValuePair<string, char>> replaceData, bool ignoreCase, string expectedString)
    {
        string actualString = testString.Replace(replaceData, ignoreCase, CultureInfo.InvariantCulture);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_IEnumKVPCharString_DefaultComparison))]
    public void Replace_IEnumKVPCharString_DefaultComparison(string testString, IEnumerable<KeyValuePair<char, string>> replaceData, string expectedString)
    {
        string actualString = testString.Replace(replaceData);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_IEnumKVPCharString_SetComparison))]
    public void Replace_IEnumKVPCharString_SetComparison(string testString, IEnumerable<KeyValuePair<char, string>> replaceData, StringComparison stringComparison, string expectedString)
    {
        string actualString = testString.Replace(replaceData, stringComparison);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_IEnumKVPCharString_CultureInfo))]
    public void Replace_IEnumKVPCharString_CultureInfo(string testString, IEnumerable<KeyValuePair<char, string>> replaceData, bool ignoreCase, string expectedString)
    {
        string actualString = testString.Replace(replaceData, ignoreCase, CultureInfo.InvariantCulture);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_IEnumKVPCharChar))]
    public void Replace_IEnumKVPCharChar(string testString, IEnumerable<KeyValuePair<char, char>> replaceData, string expectedString)
    {
        string actualString = testString.Replace(replaceData);

        Assert.Equal(expectedString, actualString);
    }


    public static IEnumerable<object[]> Data_Replace_IEnumString_Char_DefaultComparison
        =>
            [
                ["Sunset painted the sky beautifully.",     'z',    new[] { "paint", "sky ", "beaut" },                             "Sunset zed the zzifully."],
                ["Sunset painted the sky beautifully.",     'z',    new List<string>() { "paint", "sky ", "beaut" },                "Sunset zed the zzifully."],
                ["Sunset painted the sky beautifully.",     'z',    new HashSet<string>() { "paint", "sky ", "beaut" },             "Sunset zed the zzifully."],
                ["Sunset painted the sky beautifully.",     'z',    new Queue<string>(["paint", "sky ", "beaut"]),                  "Sunset zed the zzifully."]
            ];

    public static IEnumerable<object[]> Data_Replace_IEnumString_Char_SetComparison
        =>
            [
                ["Sunset painted the sky beautifully.",     'z',    new[] { "paint", "sky ", "beaut" },                             StringComparison.InvariantCulture,               "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new[] { "paint", "sky ", "beaut" },                             StringComparison.InvariantCultureIgnoreCase,     "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new[] { "paint", "sky ", "beaut" },                             StringComparison.Ordinal,                        "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new[] { "paint", "sky ", "beaut" },                             StringComparison.OrdinalIgnoreCase,              "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new List<string>() { "paint", "sky ", "beaut" },                StringComparison.InvariantCulture,               "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new List<string>() { "paint", "sky ", "beaut" },                StringComparison.InvariantCultureIgnoreCase,     "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new List<string>() { "paint", "sky ", "beaut" },                StringComparison.Ordinal,                        "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new List<string>() { "paint", "sky ", "beaut" },                StringComparison.OrdinalIgnoreCase,              "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new HashSet<string>() { "paint", "sky ", "beaut" },             StringComparison.InvariantCulture,               "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new HashSet<string>() { "paint", "sky ", "beaut" },             StringComparison.InvariantCultureIgnoreCase,     "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new HashSet<string>() { "paint", "sky ", "beaut" },             StringComparison.Ordinal,                        "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new HashSet<string>() { "paint", "sky ", "beaut" },             StringComparison.OrdinalIgnoreCase,              "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new Queue<string>(["paint", "sky ", "beaut"]),                  StringComparison.InvariantCulture,               "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new Queue<string>(["paint", "sky ", "beaut"]),                  StringComparison.InvariantCultureIgnoreCase,     "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new Queue<string>(["paint", "sky ", "beaut"]),                  StringComparison.Ordinal,                        "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new Queue<string>(["paint", "sky ", "beaut"]),                  StringComparison.OrdinalIgnoreCase,              "SUNSET zED THE zzIFULLY."]
            ];

    public static IEnumerable<object[]> Data_Replace_IEnumString_Char_CultureInfo
        =>
            [
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new[] { "paint", "sky ", "beaut" },                             true,      "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new[] { "paint", "sky ", "beaut" },                             false,     "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new List<string>() { "paint", "sky ", "beaut" },                true,      "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new List<string>() { "paint", "sky ", "beaut" },                false,     "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new HashSet<string>() { "paint", "sky ", "beaut" },             true,      "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new HashSet<string>() { "paint", "sky ", "beaut" },             false,     "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new Queue<string>(["paint", "sky ", "beaut"]),                  true,      "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new Queue<string>(["paint", "sky ", "beaut"]),                  false,     "Sunset zed the zzifully."]
            ];

    public static IEnumerable<object[]> Data_Replace_IEnumString_String_DefaultComparison
        =>
            [
                ["Sunset painted the sky beautifully.",     "new",      new[] { "paint", "sky ", "beaut" },                             "Sunset newed the newnewifully."],
                ["Sunset painted the sky beautifully.",     "new",      new List<string>() { "paint", "sky ", "beaut" },                "Sunset newed the newnewifully."],
                ["Sunset painted the sky beautifully.",     "new",      new HashSet<string>() { "paint", "sky ", "beaut" },             "Sunset newed the newnewifully."],
                ["Sunset painted the sky beautifully.",     "new",      new Queue<string>(["paint", "sky ", "beaut"]),                  "Sunset newed the newnewifully."]
            ];

    public static IEnumerable<object[]> Data_Replace_IEnumString_String_SetComparison
        =>
            [
                ["Sunset painted the sky beautifully.",     "new",      new[] { "paint", "sky ", "beaut" },                             StringComparison.InvariantCulture,               "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new[] { "paint", "sky ", "beaut" },                             StringComparison.InvariantCultureIgnoreCase,     "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new[] { "paint", "sky ", "beaut" },                             StringComparison.Ordinal,                        "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new[] { "paint", "sky ", "beaut" },                             StringComparison.OrdinalIgnoreCase,              "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new List<string>() { "paint", "sky ", "beaut" },                StringComparison.InvariantCulture,               "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new List<string>() { "paint", "sky ", "beaut" },                StringComparison.InvariantCultureIgnoreCase,     "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new List<string>() { "paint", "sky ", "beaut" },                StringComparison.Ordinal,                        "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new List<string>() { "paint", "sky ", "beaut" },                StringComparison.OrdinalIgnoreCase,              "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new HashSet<string>() { "paint", "sky ", "beaut" },             StringComparison.InvariantCulture,               "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new HashSet<string>() { "paint", "sky ", "beaut" },             StringComparison.InvariantCultureIgnoreCase,     "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new HashSet<string>() { "paint", "sky ", "beaut" },             StringComparison.Ordinal,                        "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new HashSet<string>() { "paint", "sky ", "beaut" },             StringComparison.OrdinalIgnoreCase,              "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new Queue<string>(["paint", "sky ", "beaut"]),                  StringComparison.InvariantCulture,               "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new Queue<string>(["paint", "sky ", "beaut"]),                  StringComparison.InvariantCultureIgnoreCase,     "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new Queue<string>(["paint", "sky ", "beaut"]),                  StringComparison.Ordinal,                        "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new Queue<string>(["paint", "sky ", "beaut"]),                  StringComparison.OrdinalIgnoreCase,              "SUNSET newED THE newnewIFULLY."]
            ];

    public static IEnumerable<object[]> Data_Replace_IEnumString_String_CultureInfo
        =>
            [
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new[] { "paint", "sky ", "beaut" },                             true,      "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new[] { "paint", "sky ", "beaut" },                             false,     "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new List<string>() { "paint", "sky ", "beaut" },                true,      "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new List<string>() { "paint", "sky ", "beaut" },                false,     "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new HashSet<string>() { "paint", "sky ", "beaut" },             true,      "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new HashSet<string>() { "paint", "sky ", "beaut" },             false,     "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new Queue<string>(["paint", "sky ", "beaut"]),                  true,      "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new Queue<string>(["paint", "sky ", "beaut"]),                  false,     "Sunset newed the newnewifully."]
            ];

    public static IEnumerable<object[]> Data_Replace_IEnumChar_Char
        =>
            [
                ["a b 3 C r $ 9 P x # 7 o L",   'z',    new[] { 'b', '$', 'P', '#' },                                   "a z 3 C r z 9 z x z 7 o L"],
                ["a b 3 C r $ 9 P x # 7 o L",   'z',    new List<char>() { 'b', '$', 'P', '#' },                        "a z 3 C r z 9 z x z 7 o L"],
                ["a b 3 C r $ 9 P x # 7 o L",   'z',    new HashSet<char>() { 'b', '$', 'P', '#' },                     "a z 3 C r z 9 z x z 7 o L"],
                ["a b 3 C r $ 9 P x # 7 o L",   'z',    new Queue<char>(['b', '$', 'P', '#']),                          "a z 3 C r z 9 z x z 7 o L"]
            ];

    public static IEnumerable<object[]> Data_Replace_IEnumChar_String_DefaultComparison
        =>
            [
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new[] { 'b', '$', 'P', '#' },                                   "a new 3 C r new 9 new x new 7 o L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new List<char>() { 'b', '$', 'P', '#' },                        "a new 3 C r new 9 new x new 7 o L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new HashSet<char>() { 'b', '$', 'P', '#' },                     "a new 3 C r new 9 new x new 7 o L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new Queue<char>(['b', '$', 'P', '#']),                          "a new 3 C r new 9 new x new 7 o L"]
            ];

    public static IEnumerable<object[]> Data_Replace_IEnumChar_String_SetComparison
        =>
            [
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new[] { 'b', '$', 'P', '#' },                                   StringComparison.InvariantCulture,               "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new[] { 'b', '$', 'P', '#' },                                   StringComparison.InvariantCultureIgnoreCase,     "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new[] { 'b', '$', 'P', '#' },                                   StringComparison.Ordinal,                        "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new[] { 'b', '$', 'P', '#' },                                   StringComparison.OrdinalIgnoreCase,              "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new List<char>() { 'b', '$', 'P', '#' },                        StringComparison.InvariantCulture,               "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new List<char>() { 'b', '$', 'P', '#' },                        StringComparison.InvariantCultureIgnoreCase,     "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new List<char>() { 'b', '$', 'P', '#' },                        StringComparison.Ordinal,                        "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new List<char>() { 'b', '$', 'P', '#' },                        StringComparison.OrdinalIgnoreCase,              "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new HashSet<char>() { 'b', '$', 'P', '#' },                     StringComparison.InvariantCulture,               "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new HashSet<char>() { 'b', '$', 'P', '#' },                     StringComparison.InvariantCultureIgnoreCase,     "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new HashSet<char>() { 'b', '$', 'P', '#' },                     StringComparison.Ordinal,                        "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new HashSet<char>() { 'b', '$', 'P', '#' },                     StringComparison.OrdinalIgnoreCase,              "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new Queue<char>(['b', '$', 'P', '#']),                          StringComparison.InvariantCulture,               "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new Queue<char>(['b', '$', 'P', '#']),                          StringComparison.InvariantCultureIgnoreCase,     "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new Queue<char>(['b', '$', 'P', '#']),                          StringComparison.Ordinal,                        "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new Queue<char>(['b', '$', 'P', '#']),                          StringComparison.OrdinalIgnoreCase,              "A new 3 C R new 9 new X new 7 O L"]
            ];

    public static IEnumerable<object[]> Data_Replace_IEnumChar_String_CultureInfo
        =>
            [
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new[] { 'b', '$', 'P', '#' },                                   true,      "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new[] { 'b', '$', 'P', '#' },                                   false,     "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new List<char>() { 'b', '$', 'P', '#' },                        true,      "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new List<char>() { 'b', '$', 'P', '#' },                        false,     "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new HashSet<char>() { 'b', '$', 'P', '#' },                     true,      "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new HashSet<char>() { 'b', '$', 'P', '#' },                     false,     "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new Queue<char>(['b', '$', 'P', '#']),                          true,      "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new Queue<char>(['b', '$', 'P', '#']),                          false,     "a new 3 C r new 9 new x new 7 o L"]
            ];

    public static IEnumerable<object[]> Data_Replace_IEnumKVPStringString_DefaultComparison
    =>
        [
                ["Sunset painted the sky beautifully.",     new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } },                                              "Sunset new1ed the new2new3ifully."],
                ["Sunset painted the sky beautifully.",     new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } }.AsReadOnly(),                                 "Sunset new1ed the new2new3ifully."],
                ["Sunset painted the sky beautifully.",     new SortedList<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } },                                              "Sunset new1ed the new2new3ifully."],
                ["Sunset painted the sky beautifully.",     new ConcurrentDictionary<string, string>(new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } }),    "Sunset new1ed the new2new3ifully."]
        ];

    public static IEnumerable<object[]> Data_Replace_IEnumKVPStringString_SetComparison
        =>
            [
                ["Sunset painted the sky beautifully.",     new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } },                                              StringComparison.InvariantCulture,               "Sunset new1ed the new2new3ifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } },                                              StringComparison.InvariantCultureIgnoreCase,     "SUNSET new1ED THE new2new3IFULLY."],
                ["Sunset painted the sky beautifully.",     new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } },                                              StringComparison.Ordinal,                        "Sunset new1ed the new2new3ifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } },                                              StringComparison.OrdinalIgnoreCase,              "SUNSET new1ED THE new2new3IFULLY."],
                ["Sunset painted the sky beautifully.",     new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } }.AsReadOnly(),                                 StringComparison.InvariantCulture,               "Sunset new1ed the new2new3ifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } }.AsReadOnly(),                                 StringComparison.InvariantCultureIgnoreCase,     "SUNSET new1ED THE new2new3IFULLY."],
                ["Sunset painted the sky beautifully.",     new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } }.AsReadOnly(),                                 StringComparison.Ordinal,                        "Sunset new1ed the new2new3ifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } }.AsReadOnly(),                                 StringComparison.OrdinalIgnoreCase,              "SUNSET new1ED THE new2new3IFULLY."],
                ["Sunset painted the sky beautifully.",     new SortedList<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } },                                              StringComparison.InvariantCulture,               "Sunset new1ed the new2new3ifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new SortedList<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } },                                              StringComparison.InvariantCultureIgnoreCase,     "SUNSET new1ED THE new2new3IFULLY."],
                ["Sunset painted the sky beautifully.",     new SortedList<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } },                                              StringComparison.Ordinal,                        "Sunset new1ed the new2new3ifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new SortedList<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } },                                              StringComparison.OrdinalIgnoreCase,              "SUNSET new1ED THE new2new3IFULLY."],
                ["Sunset painted the sky beautifully.",     new ConcurrentDictionary<string, string>(new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } }),    StringComparison.InvariantCulture,               "Sunset new1ed the new2new3ifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new ConcurrentDictionary<string, string>(new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } }),    StringComparison.InvariantCultureIgnoreCase,     "SUNSET new1ED THE new2new3IFULLY."],
                ["Sunset painted the sky beautifully.",     new ConcurrentDictionary<string, string>(new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } }),    StringComparison.Ordinal,                        "Sunset new1ed the new2new3ifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new ConcurrentDictionary<string, string>(new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } }),    StringComparison.OrdinalIgnoreCase,              "SUNSET new1ED THE new2new3IFULLY."]
            ];

    public static IEnumerable<object[]> Data_Replace_IEnumKVPStringString_CultureInfo
        =>
            [
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } },                                              true,      "SUNSET new1ED THE new2new3IFULLY."],
                ["Sunset painted the sky beautifully.",     new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } },                                              false,     "Sunset new1ed the new2new3ifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } }.AsReadOnly(),                                 true,      "SUNSET new1ED THE new2new3IFULLY."],
                ["Sunset painted the sky beautifully.",     new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } }.AsReadOnly(),                                 false,     "Sunset new1ed the new2new3ifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new SortedList<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } },                                              true,      "SUNSET new1ED THE new2new3IFULLY."],
                ["Sunset painted the sky beautifully.",     new SortedList<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } },                                              false,     "Sunset new1ed the new2new3ifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new ConcurrentDictionary<string, string>(new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } }),    true,      "SUNSET new1ED THE new2new3IFULLY."],
                ["Sunset painted the sky beautifully.",     new ConcurrentDictionary<string, string>(new Dictionary<string, string>() { { "paint", "new1" }, { "sky ", "new2" }, { "beaut", "new3" } }),    false,     "Sunset new1ed the new2new3ifully."]
            ];

    public static IEnumerable<object[]> Data_Replace_IEnumKVPStringChar_DefaultComparison
        =>
            [
                ["Sunset painted the sky beautifully.",     new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } },                                                         "Sunset xed the yzifully."],
                ["Sunset painted the sky beautifully.",     new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } }.AsReadOnly(),                                            "Sunset xed the yzifully."],
                ["Sunset painted the sky beautifully.",     new SortedList<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } },                                                         "Sunset xed the yzifully."],
                ["Sunset painted the sky beautifully.",     new ConcurrentDictionary<string, char>(new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } }),                 "Sunset xed the yzifully."]
            ];

    public static IEnumerable<object[]> Data_Replace_IEnumKVPStringChar_SetComparison
        =>
            [
                ["Sunset painted the sky beautifully.",     new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } },                                                         StringComparison.InvariantCulture,               "Sunset xed the yzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } },                                                         StringComparison.InvariantCultureIgnoreCase,     "SUNSET xED THE yzIFULLY."],
                ["Sunset painted the sky beautifully.",     new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } },                                                         StringComparison.Ordinal,                        "Sunset xed the yzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } },                                                         StringComparison.OrdinalIgnoreCase,              "SUNSET xED THE yzIFULLY."],
                ["Sunset painted the sky beautifully.",     new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } }.AsReadOnly(),                                            StringComparison.InvariantCulture,               "Sunset xed the yzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } }.AsReadOnly(),                                            StringComparison.InvariantCultureIgnoreCase,     "SUNSET xED THE yzIFULLY."],
                ["Sunset painted the sky beautifully.",     new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } }.AsReadOnly(),                                            StringComparison.Ordinal,                        "Sunset xed the yzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } }.AsReadOnly(),                                            StringComparison.OrdinalIgnoreCase,              "SUNSET xED THE yzIFULLY."],
                ["Sunset painted the sky beautifully.",     new SortedList<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } },                                                         StringComparison.InvariantCulture,               "Sunset xed the yzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new SortedList<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } },                                                         StringComparison.InvariantCultureIgnoreCase,     "SUNSET xED THE yzIFULLY."],
                ["Sunset painted the sky beautifully.",     new SortedList<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } },                                                         StringComparison.Ordinal,                        "Sunset xed the yzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new SortedList<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } },                                                         StringComparison.OrdinalIgnoreCase,              "SUNSET xED THE yzIFULLY."],
                ["Sunset painted the sky beautifully.",     new ConcurrentDictionary<string, char>(new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } }),                 StringComparison.InvariantCulture,               "Sunset xed the yzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new ConcurrentDictionary<string, char>(new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } }),                 StringComparison.InvariantCultureIgnoreCase,     "SUNSET xED THE yzIFULLY."],
                ["Sunset painted the sky beautifully.",     new ConcurrentDictionary<string, char>(new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } }),                 StringComparison.Ordinal,                        "Sunset xed the yzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new ConcurrentDictionary<string, char>(new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } }),                 StringComparison.OrdinalIgnoreCase,              "SUNSET xED THE yzIFULLY."]
            ];

    public static IEnumerable<object[]> Data_Replace_IEnumKVPStringChar_CultureInfo
        =>
            [
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } },                                                         true,      "SUNSET xED THE yzIFULLY."],
                ["Sunset painted the sky beautifully.",     new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } },                                                         false,     "Sunset xed the yzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } }.AsReadOnly(),                                            true,      "SUNSET xED THE yzIFULLY."],
                ["Sunset painted the sky beautifully.",     new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } }.AsReadOnly(),                                            false,     "Sunset xed the yzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new SortedList<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } },                                                         true,      "SUNSET xED THE yzIFULLY."],
                ["Sunset painted the sky beautifully.",     new SortedList<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } },                                                         false,     "Sunset xed the yzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     new ConcurrentDictionary<string, char>(new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } }),                 true,      "SUNSET xED THE yzIFULLY."],
                ["Sunset painted the sky beautifully.",     new ConcurrentDictionary<string, char>(new Dictionary<string, char>() { { "paint", 'x' }, { "sky ", 'y' }, { "beaut", 'z' } }),                 false,     "Sunset xed the yzifully."]
            ];

    public static IEnumerable<object[]> Data_Replace_IEnumKVPCharString_DefaultComparison
        =>
            [
                ["a b 3 C r $ 9 P x # 7 o L",   new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } },                                                           "a new1 3 C r new2 9 new3 x # 7 o L"],
                ["a b 3 C r $ 9 P x # 7 o L",   new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } }.AsReadOnly(),                                              "a new1 3 C r new2 9 new3 x # 7 o L"],
                ["a b 3 C r $ 9 P x # 7 o L",   new SortedList<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } },                                                           "a new1 3 C r new2 9 new3 x # 7 o L"],
                ["a b 3 C r $ 9 P x # 7 o L",   new ConcurrentDictionary<char, string>(new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } }),                   "a new1 3 C r new2 9 new3 x # 7 o L"]
            ];

    public static IEnumerable<object[]> Data_Replace_IEnumKVPCharString_SetComparison
        =>
            [
                ["a b 3 C r $ 9 P x # 7 o L",   new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } },                                                           StringComparison.InvariantCulture,               "a new1 3 C r new2 9 new3 x # 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } },                                                           StringComparison.InvariantCultureIgnoreCase,     "A new1 3 C R new2 9 new3 X # 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } },                                                           StringComparison.Ordinal,                        "a new1 3 C r new2 9 new3 x # 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } },                                                           StringComparison.OrdinalIgnoreCase,              "A new1 3 C R new2 9 new3 X # 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } }.AsReadOnly(),                                              StringComparison.InvariantCulture,               "a new1 3 C r new2 9 new3 x # 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } }.AsReadOnly(),                                              StringComparison.InvariantCultureIgnoreCase,     "A new1 3 C R new2 9 new3 X # 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } }.AsReadOnly(),                                              StringComparison.Ordinal,                        "a new1 3 C r new2 9 new3 x # 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } }.AsReadOnly(),                                              StringComparison.OrdinalIgnoreCase,              "A new1 3 C R new2 9 new3 X # 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   new SortedList<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } },                                                           StringComparison.InvariantCulture,               "a new1 3 C r new2 9 new3 x # 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   new SortedList<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } },                                                           StringComparison.InvariantCultureIgnoreCase,     "A new1 3 C R new2 9 new3 X # 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   new SortedList<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } },                                                           StringComparison.Ordinal,                        "a new1 3 C r new2 9 new3 x # 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   new SortedList<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } },                                                           StringComparison.OrdinalIgnoreCase,              "A new1 3 C R new2 9 new3 X # 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   new ConcurrentDictionary<char, string>(new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } }),                   StringComparison.InvariantCulture,               "a new1 3 C r new2 9 new3 x # 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   new ConcurrentDictionary<char, string>(new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } }),                   StringComparison.InvariantCultureIgnoreCase,     "A new1 3 C R new2 9 new3 X # 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   new ConcurrentDictionary<char, string>(new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } }),                   StringComparison.Ordinal,                        "a new1 3 C r new2 9 new3 x # 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   new ConcurrentDictionary<char, string>(new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } }),                   StringComparison.OrdinalIgnoreCase,              "A new1 3 C R new2 9 new3 X # 7 O L"]
            ];

    public static IEnumerable<object[]> Data_Replace_IEnumKVPCharString_CultureInfo
        =>
            [
                ["A B 3 C R $ 9 P X # 7 O L",   new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } },                                                           true,      "A new1 3 C R new2 9 new3 X # 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } },                                                           false,     "a new1 3 C r new2 9 new3 x # 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } }.AsReadOnly(),                                              true,      "A new1 3 C R new2 9 new3 X # 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } }.AsReadOnly(),                                              false,     "a new1 3 C r new2 9 new3 x # 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   new SortedList<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } },                                                           true,      "A new1 3 C R new2 9 new3 X # 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   new SortedList<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } },                                                           false,     "a new1 3 C r new2 9 new3 x # 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   new ConcurrentDictionary<char, string>(new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } }),                   true,      "A new1 3 C R new2 9 new3 X # 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   new ConcurrentDictionary<char, string>(new Dictionary<char, string>() { { 'b', "new1" }, { '$', "new2" }, { 'P', "new3" } }),                   false,     "a new1 3 C r new2 9 new3 x # 7 o L"]
            ];

    public static IEnumerable<object[]> Data_Replace_IEnumKVPCharChar
        =>
            [
                ["a b 3 C r $ 9 P x # 7 o L",   new Dictionary<char, char>() { { 'b', 'x' }, { '$', 'y' }, { 'P', 'z' } },                                                                      "a x 3 C r y 9 z x # 7 o L"],
                ["a b 3 C r $ 9 P x # 7 o L",   new Dictionary<char, char>() { { 'b', 'x' }, { '$', 'y' }, { 'P', 'z' } }.AsReadOnly(),                                                         "a x 3 C r y 9 z x # 7 o L"],
                ["a b 3 C r $ 9 P x # 7 o L",   new SortedList<char, char>() { { 'b', 'x' }, { '$', 'y' }, { 'P', 'z' } },                                                                      "a x 3 C r y 9 z x # 7 o L"],
                ["a b 3 C r $ 9 P x # 7 o L",   new ConcurrentDictionary<char, char>(new Dictionary<char, char>() { { 'b', 'x' }, { '$', 'y' }, { 'P', 'z' } }),                                "a x 3 C r y 9 z x # 7 o L"]
            ];
}
