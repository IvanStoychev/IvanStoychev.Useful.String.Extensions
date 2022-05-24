using System;
using System.Collections.Generic;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Replacer_Tests
{
    [Theory, MemberData(nameof(Data_Replace_DefaultComparison_Pass))]
    public void Replace_DefaultComparison_Pass(string testString, string newString, IEnumerable<string> oldStrings, string expectedString)
    {
        string actualString = testString.Replace(newString, oldStrings);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Replace_SetComparison_Pass))]
    public void Replace_SetComparison_Pass(string testString, string newString, IEnumerable<string> oldStrings, StringComparison stringComparison, string expectedString)
    {
        string actualString = testString.Replace(newString, oldStrings, stringComparison);

        Assert.Equal(expectedString, actualString);
    }

    public static IEnumerable<object[]> Data_Replace_DefaultComparison_Pass => new[]
            {
                new object[] { "takimata amet erat invidunt diam no vel nonummy", "newWord", new string[] { "amet", "invidunt", "no" }, "takimata newWord erat newWord diam newWord vel newWordnummy" },
                new object[] { "erat consequat euismod justo exerci sed sea tation", "newWord", new List<string>() { "consequat", "justo", "sed" }, "erat newWord euismod newWord exerci newWord sea tation" },
                new object[] { "lorem magna eros ea dolore molestie magna rebum", "newWord", new HashSet<string>() { "magna", "ea", "molestie" }, "lorem newWord eros newWord dolore newWord newWord rebum" },
                new object[] { "duo clita dolore clita clita gubergren diam vel", "newWord", new Queue<string>(new string[] { "clita", "gubergren" }), "duo newWord dolore newWord newWord newWord diam vel" }
            };

    public static IEnumerable<object[]> Data_Replace_SetComparison_Pass => new[]
            {
                new object[] { "case encyclopædia Archæology", "newWord", new string[] { "case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.InvariantCulture, "newWord encyclopædia Archæology" },
                new object[] { "case encyclopædia Archæology", "newWord", new List<string>() { "Case", "encyclopædia", "ARCHÆOLOGY" }, StringComparison.InvariantCulture, "case newWord Archæology" },
                new object[] { "case encyclopædia Archæology", "newWord", new HashSet<string>() { "Case", "encyclopaedia", "Archæology" }, StringComparison.InvariantCulture, "case encyclopædia newWord" },
                new object[] { "case encyclopædia Archæology", "newWord", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), StringComparison.InvariantCulture, "newWord newWord newWord" },

                new object[] { "case encyclopædia Archæology", "newWord", new string[] { "case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.InvariantCultureIgnoreCase, "newWord encyclopædia newWord" },
                new object[] { "case encyclopædia Archæology", "newWord", new List<string>() { "Case", "encyclopædia", "ARCHÆOLOGY" }, StringComparison.InvariantCultureIgnoreCase, "newWord newWord newWord" },
                new object[] { "case encyclopædia Archæology", "newWord", new HashSet<string>() { "Case", "encyclopaedia", "Archæology" }, StringComparison.InvariantCultureIgnoreCase, "newWord encyclopædia newWord" },
                new object[] { "case encyclopædia Archæology", "newWord", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), StringComparison.InvariantCultureIgnoreCase, "newWord newWord newWord" },

                new object[] { "case encyclopædia Archæology", "newWord", new string[] { "case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.Ordinal, "newWord encyclopædia Archæology" },
                new object[] { "case encyclopædia Archæology", "newWord", new List<string>() { "Case", "encyclopædia", "ARCHÆOLOGY" }, StringComparison.Ordinal, "case newWord Archæology" },
                new object[] { "case encyclopædia Archæology", "newWord", new HashSet<string>() { "Case", "encyclopaedia", "Archæology" }, StringComparison.Ordinal, "case encyclopædia newWord" },
                new object[] { "case encyclopædia Archæology", "newWord", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), StringComparison.Ordinal, "newWord newWord newWord" },

                new object[] { "case encyclopædia Archæology", "newWord", new string[] { "kase", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.OrdinalIgnoreCase, "case encyclopædia newWord" },
                new object[] { "case encyclopædia Archæology", "newWord", new List<string>() { "Case", "encyclopædia", "ARCHAEOLOGY" }, StringComparison.OrdinalIgnoreCase, "newWord newWord Archæology" },
                new object[] { "case encyclopædia Archæology", "newWord", new HashSet<string>() { "kase", "encyclopædia", "Archæology" }, StringComparison.OrdinalIgnoreCase, "case newWord newWord" },
                new object[] { "case encyclopædia Archæology", "newWord", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), StringComparison.OrdinalIgnoreCase, "newWord newWord newWord" }
            };
}
