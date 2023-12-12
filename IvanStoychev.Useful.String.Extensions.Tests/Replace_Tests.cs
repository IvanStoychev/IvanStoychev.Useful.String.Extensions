using System;
using System.Collections.Generic;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Replace_Tests
{
    [Theory, MemberData(nameof(Data_Replace_DefaultComparison_Pass))]
    public void Replace_DefaultComparison_Pass(string testString, string newString, IEnumerable<string> oldStrings, string expectedString)
    {
        string actualString = testString.Replace(oldStrings, newString);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_SetComparison_Pass))]
    public void Replace_SetComparison_Pass(string testString, string newString, IEnumerable<string> oldStrings, StringComparison stringComparison, string expectedString)
    {
        string actualString = testString.Replace(oldStrings, newString, stringComparison);

        Assert.Equal(expectedString, actualString);
    }

    public static IEnumerable<object[]> Data_Replace_DefaultComparison_Pass => new[]
            {
                new object[] { "takimata amet erat invidunt diam no vel nonummy", "newWord", new string[] { "amet", "invidunt", "no" }, "takimata newWord erat newWord diam newWord vel newWordnummy" },
                ["erat consequat euismod justo exerci sed sea tation", "newWord", new List<string>() { "consequat", "justo", "sed" }, "erat newWord euismod newWord exerci newWord sea tation"],
                ["lorem magna eros ea dolore molestie magna rebum", "newWord", new HashSet<string>() { "magna", "ea", "molestie" }, "lorem newWord eros newWord dolore newWord newWord rebum"],
                ["duo clita dolore clita clita gubergren diam vel", "newWord", new Queue<string>(new string[] { "clita", "gubergren" }), "duo newWord dolore newWord newWord newWord diam vel"]
            };

    public static IEnumerable<object[]> Data_Replace_SetComparison_Pass => new[]
            {
                new object[] { "case encyclopædia Archæology", "newWord", new string[] { "case", "encyclopaedia", "ARCHÆOLOGY" }, GlobalVariables.InvariantCulture, "newWord encyclopædia Archæology" },
                ["case encyclopædia Archæology", "newWord", new List<string>() { "Case", "encyclopædia", "ARCHÆOLOGY" }, GlobalVariables.InvariantCulture, "case newWord Archæology"],
                ["case encyclopædia Archæology", "newWord", new HashSet<string>() { "Case", "encyclopaedia", "Archæology" }, GlobalVariables.InvariantCulture, "case encyclopædia newWord"],
                ["case encyclopædia Archæology", "newWord", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), GlobalVariables.InvariantCulture, "newWord newWord newWord"],

                ["case encyclopædia Archæology", "newWord", new string[] { "case", "encyclopaedia", "ARCHÆOLOGY" }, GlobalVariables.InvariantCultureIgnoreCase, "newWord encyclopædia newWord"],
                ["case encyclopædia Archæology", "newWord", new List<string>() { "Case", "encyclopædia", "ARCHÆOLOGY" }, GlobalVariables.InvariantCultureIgnoreCase, "newWord newWord newWord"],
                ["case encyclopædia Archæology", "newWord", new HashSet<string>() { "Case", "encyclopaedia", "Archæology" }, GlobalVariables.InvariantCultureIgnoreCase, "newWord encyclopædia newWord"],
                ["case encyclopædia Archæology", "newWord", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), GlobalVariables.InvariantCultureIgnoreCase, "newWord newWord newWord"],

                ["case encyclopædia Archæology", "newWord", new string[] { "case", "encyclopaedia", "ARCHÆOLOGY" }, GlobalVariables.Ordinal, "newWord encyclopædia Archæology"],
                ["case encyclopædia Archæology", "newWord", new List<string>() { "Case", "encyclopædia", "ARCHÆOLOGY" }, GlobalVariables.Ordinal, "case newWord Archæology"],
                ["case encyclopædia Archæology", "newWord", new HashSet<string>() { "Case", "encyclopaedia", "Archæology" }, GlobalVariables.Ordinal, "case encyclopædia newWord"],
                ["case encyclopædia Archæology", "newWord", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), GlobalVariables.Ordinal, "newWord newWord newWord"],

                ["case encyclopædia Archæology", "newWord", new string[] { "kase", "encyclopaedia", "ARCHÆOLOGY" }, GlobalVariables.OrdinalIgnoreCase, "case encyclopædia newWord"],
                ["case encyclopædia Archæology", "newWord", new List<string>() { "Case", "encyclopædia", "ARCHAEOLOGY" }, GlobalVariables.OrdinalIgnoreCase, "newWord newWord Archæology"],
                ["case encyclopædia Archæology", "newWord", new HashSet<string>() { "kase", "encyclopædia", "Archæology" }, GlobalVariables.OrdinalIgnoreCase, "case newWord newWord"],
                ["case encyclopædia Archæology", "newWord", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), GlobalVariables.OrdinalIgnoreCase, "newWord newWord newWord"]
            };
}
