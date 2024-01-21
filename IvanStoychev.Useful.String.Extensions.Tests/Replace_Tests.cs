using System;
using System.Collections.Generic;
using System.Globalization;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Replace_Tests
{
    [Theory, MemberData(nameof(Data_Replace_IEnumString_Char_DefaultComparison))]
    public void Replace_IEnumString_Char_DefaultComparison(string testString, char newChar, IEnumerable<string> oldChars, string expectedString)
    {
        string actualString = testString.Replace(oldChars, newChar);

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

    public static IEnumerable<object[]> Data_Replace_IEnumString_Char_DefaultComparison
        => new[]
            {
                new object[] {"Sunset painted the sky beautifully.",     'z',    new[] { "paint", "sky ", "beaut" },                "Sunset zed the zzifully."},
                ["Sunset painted the sky beautifully.",     'z',    new List<string>() { "paint", "sky ", "beaut" },                "Sunset zed the zzifully."],
                ["Sunset painted the sky beautifully.",     'z',    new HashSet<string>() { "paint", "sky ", "beaut" },             "Sunset zed the zzifully."],
                ["Sunset painted the sky beautifully.",     'z',    new Queue<string>(new string[] { "paint", "sky ", "beaut" }),   "Sunset zed the zzifully."]
            };

    public static IEnumerable<object[]> Data_Replace_IEnumString_Char_SetComparison
        => new[]
            {
                new object[] {"Sunset painted the sky beautifully.",     'z',    new[] { "paint", "sky ", "beaut" },                GlobalVariables.InvariantCulture,               "Sunset zed the zzifully."},
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new[] { "paint", "sky ", "beaut" },                             GlobalVariables.InvariantCultureIgnoreCase,     "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new[] { "paint", "sky ", "beaut" },                             GlobalVariables.Ordinal,                        "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new[] { "paint", "sky ", "beaut" },                             GlobalVariables.OrdinalIgnoreCase,              "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new List<string>() { "paint", "sky ", "beaut" },                GlobalVariables.InvariantCulture,               "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new List<string>() { "paint", "sky ", "beaut" },                GlobalVariables.InvariantCultureIgnoreCase,     "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new List<string>() { "paint", "sky ", "beaut" },                GlobalVariables.Ordinal,                        "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new List<string>() { "paint", "sky ", "beaut" },                GlobalVariables.OrdinalIgnoreCase,              "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new HashSet<string>() { "paint", "sky ", "beaut" },             GlobalVariables.InvariantCulture,               "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new HashSet<string>() { "paint", "sky ", "beaut" },             GlobalVariables.InvariantCultureIgnoreCase,     "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new HashSet<string>() { "paint", "sky ", "beaut" },             GlobalVariables.Ordinal,                        "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new HashSet<string>() { "paint", "sky ", "beaut" },             GlobalVariables.OrdinalIgnoreCase,              "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new Queue<string>(new string[] { "paint", "sky ", "beaut" }),   GlobalVariables.InvariantCulture,               "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new Queue<string>(new string[] { "paint", "sky ", "beaut" }),   GlobalVariables.InvariantCultureIgnoreCase,     "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new Queue<string>(new string[] { "paint", "sky ", "beaut" }),   GlobalVariables.Ordinal,                        "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new Queue<string>(new string[] { "paint", "sky ", "beaut" }),   GlobalVariables.OrdinalIgnoreCase,              "SUNSET zED THE zzIFULLY."]
            };

    public static IEnumerable<object[]> Data_Replace_IEnumString_Char_CultureInfo
        => new[]
            {
                new object[] {"SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new[] { "paint", "sky ", "beaut" },                true,      "SUNSET zED THE zzIFULLY."},
                ["Sunset painted the sky beautifully.",     'z',    new[] { "paint", "sky ", "beaut" },                             false,     "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new List<string>() { "paint", "sky ", "beaut" },                true,      "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new List<string>() { "paint", "sky ", "beaut" },                false,     "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new HashSet<string>() { "paint", "sky ", "beaut" },             true,      "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new HashSet<string>() { "paint", "sky ", "beaut" },             false,     "Sunset zed the zzifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     'z',    new Queue<string>(new string[] { "paint", "sky ", "beaut" }),   true,      "SUNSET zED THE zzIFULLY."],
                ["Sunset painted the sky beautifully.",     'z',    new Queue<string>(new string[] { "paint", "sky ", "beaut" }),   false,     "Sunset zed the zzifully."]
            };

    public static IEnumerable<object[]> Data_Replace_IEnumString_String_DefaultComparison
        => new[]
            {
                new object[] {"Sunset painted the sky beautifully.",     "new",      new[] { "paint", "sky ", "beaut" },                "Sunset newed the newnewifully."},
                ["Sunset painted the sky beautifully.",     "new",      new List<string>() { "paint", "sky ", "beaut" },                "Sunset newed the newnewifully."],
                ["Sunset painted the sky beautifully.",     "new",      new HashSet<string>() { "paint", "sky ", "beaut" },             "Sunset newed the newnewifully."],
                ["Sunset painted the sky beautifully.",     "new",      new Queue<string>(new string[] { "paint", "sky ", "beaut" }),   "Sunset newed the newnewifully."]
            };

    public static IEnumerable<object[]> Data_Replace_IEnumString_String_SetComparison
        => new[]
            {
                new object[] {"Sunset painted the sky beautifully.",     "new",      new[] { "paint", "sky ", "beaut" },                GlobalVariables.InvariantCulture,               "Sunset newed the newnewifully."},
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new[] { "paint", "sky ", "beaut" },                             GlobalVariables.InvariantCultureIgnoreCase,     "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new[] { "paint", "sky ", "beaut" },                             GlobalVariables.Ordinal,                        "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new[] { "paint", "sky ", "beaut" },                             GlobalVariables.OrdinalIgnoreCase,              "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new List<string>() { "paint", "sky ", "beaut" },                GlobalVariables.InvariantCulture,               "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new List<string>() { "paint", "sky ", "beaut" },                GlobalVariables.InvariantCultureIgnoreCase,     "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new List<string>() { "paint", "sky ", "beaut" },                GlobalVariables.Ordinal,                        "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new List<string>() { "paint", "sky ", "beaut" },                GlobalVariables.OrdinalIgnoreCase,              "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new HashSet<string>() { "paint", "sky ", "beaut" },             GlobalVariables.InvariantCulture,               "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new HashSet<string>() { "paint", "sky ", "beaut" },             GlobalVariables.InvariantCultureIgnoreCase,     "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new HashSet<string>() { "paint", "sky ", "beaut" },             GlobalVariables.Ordinal,                        "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new HashSet<string>() { "paint", "sky ", "beaut" },             GlobalVariables.OrdinalIgnoreCase,              "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new Queue<string>(new string[] { "paint", "sky ", "beaut" }),   GlobalVariables.InvariantCulture,               "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new Queue<string>(new string[] { "paint", "sky ", "beaut" }),   GlobalVariables.InvariantCultureIgnoreCase,     "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new Queue<string>(new string[] { "paint", "sky ", "beaut" }),   GlobalVariables.Ordinal,                        "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new Queue<string>(new string[] { "paint", "sky ", "beaut" }),   GlobalVariables.OrdinalIgnoreCase,              "SUNSET newED THE newnewIFULLY."]
            };

    public static IEnumerable<object[]> Data_Replace_IEnumString_String_CultureInfo
        => new[]
            {
                new object[] {"SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new[] { "paint", "sky ", "beaut" },                true,      "SUNSET newED THE newnewIFULLY."},
                ["Sunset painted the sky beautifully.",     "new",      new[] { "paint", "sky ", "beaut" },                             false,     "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new List<string>() { "paint", "sky ", "beaut" },                true,      "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new List<string>() { "paint", "sky ", "beaut" },                false,     "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new HashSet<string>() { "paint", "sky ", "beaut" },             true,      "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new HashSet<string>() { "paint", "sky ", "beaut" },             false,     "Sunset newed the newnewifully."],
                ["SUNSET PAINTED THE SKY BEAUTIFULLY.",     "new",      new Queue<string>(new string[] { "paint", "sky ", "beaut" }),   true,      "SUNSET newED THE newnewIFULLY."],
                ["Sunset painted the sky beautifully.",     "new",      new Queue<string>(new string[] { "paint", "sky ", "beaut" }),   false,     "Sunset newed the newnewifully."]
            };

    public static IEnumerable<object[]> Data_Replace_IEnumChar_Char
        => new[]
            {
                new object[] {"a b 3 C r $ 9 P x # 7 o L",   'z',    new[] { 'b', '$', 'P', '#' },                      "a z 3 C r z 9 z x z 7 o L"},
                ["a b 3 C r $ 9 P x # 7 o L",   'z',    new List<char>() { 'b', '$', 'P', '#' },                        "a z 3 C r z 9 z x z 7 o L"],
                ["a b 3 C r $ 9 P x # 7 o L",   'z',    new HashSet<char>() { 'b', '$', 'P', '#' },                     "a z 3 C r z 9 z x z 7 o L"],
                ["a b 3 C r $ 9 P x # 7 o L",   'z',    new Queue<char>(new char[] { 'b', '$', 'P', '#' }),             "a z 3 C r z 9 z x z 7 o L"]
            };

    public static IEnumerable<object[]> Data_Replace_IEnumChar_String_DefaultComparison
        => new[]
            {
                new object[] {"a b 3 C r $ 9 P x # 7 o L",   "new",      new[] { 'b', '$', 'P', '#' },                      "a new 3 C r new 9 new x new 7 o L"},
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new List<char>() { 'b', '$', 'P', '#' },                        "a new 3 C r new 9 new x new 7 o L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new HashSet<char>() { 'b', '$', 'P', '#' },                     "a new 3 C r new 9 new x new 7 o L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new Queue<char>(new char[] { 'b', '$', 'P', '#' }),             "a new 3 C r new 9 new x new 7 o L"]
            };

    public static IEnumerable<object[]> Data_Replace_IEnumChar_String_SetComparison
        => new[]
            {
                new object[] {"a b 3 C r $ 9 P x # 7 o L",   "new",      new[] { 'b', '$', 'P', '#' },                      GlobalVariables.InvariantCulture,               "a new 3 C r new 9 new x new 7 o L"},
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new[] { 'b', '$', 'P', '#' },                                   GlobalVariables.InvariantCultureIgnoreCase,     "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new[] { 'b', '$', 'P', '#' },                                   GlobalVariables.Ordinal,                        "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new[] { 'b', '$', 'P', '#' },                                   GlobalVariables.OrdinalIgnoreCase,              "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new List<char>() { 'b', '$', 'P', '#' },                        GlobalVariables.InvariantCulture,               "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new List<char>() { 'b', '$', 'P', '#' },                        GlobalVariables.InvariantCultureIgnoreCase,     "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new List<char>() { 'b', '$', 'P', '#' },                        GlobalVariables.Ordinal,                        "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new List<char>() { 'b', '$', 'P', '#' },                        GlobalVariables.OrdinalIgnoreCase,              "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new HashSet<char>() { 'b', '$', 'P', '#' },                     GlobalVariables.InvariantCulture,               "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new HashSet<char>() { 'b', '$', 'P', '#' },                     GlobalVariables.InvariantCultureIgnoreCase,     "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new HashSet<char>() { 'b', '$', 'P', '#' },                     GlobalVariables.Ordinal,                        "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new HashSet<char>() { 'b', '$', 'P', '#' },                     GlobalVariables.OrdinalIgnoreCase,              "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new Queue<char>(new char[] { 'b', '$', 'P', '#' }),             GlobalVariables.InvariantCulture,               "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new Queue<char>(new char[] { 'b', '$', 'P', '#' }),             GlobalVariables.InvariantCultureIgnoreCase,     "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new Queue<char>(new char[] { 'b', '$', 'P', '#' }),             GlobalVariables.Ordinal,                        "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new Queue<char>(new char[] { 'b', '$', 'P', '#' }),             GlobalVariables.OrdinalIgnoreCase,              "A new 3 C R new 9 new X new 7 O L"]
            };

    public static IEnumerable<object[]> Data_Replace_IEnumChar_String_CultureInfo
        => new[]
            {
                new object[] {"A B 3 C R $ 9 P X # 7 O L",   "new",      new[] { 'b', '$', 'P', '#' },                      true,      "A new 3 C R new 9 new X new 7 O L"},
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new[] { 'b', '$', 'P', '#' },                                   false,     "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new List<char>() { 'b', '$', 'P', '#' },                        true,      "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new List<char>() { 'b', '$', 'P', '#' },                        false,     "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new HashSet<char>() { 'b', '$', 'P', '#' },                     true,      "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new HashSet<char>() { 'b', '$', 'P', '#' },                     false,     "a new 3 C r new 9 new x new 7 o L"],
                ["A B 3 C R $ 9 P X # 7 O L",   "new",      new Queue<char>(new char[] { 'b', '$', 'P', '#' }),             true,      "A new 3 C R new 9 new X new 7 O L"],
                ["a b 3 C r $ 9 P x # 7 o L",   "new",      new Queue<char>(new char[] { 'b', '$', 'P', '#' }),             false,     "a new 3 C r new 9 new x new 7 o L"]
            };


}
