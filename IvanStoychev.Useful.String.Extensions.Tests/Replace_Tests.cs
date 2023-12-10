using System;
using System.Collections.Generic;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Replace_Tests
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
                new object[] { "case encyclopædia Archæology", "newWord", new string[] { "case", "encyclopaedia", "ARCHÆOLOGY" }, GlobalVariables.InvariantCulture, "newWord encyclopædia Archæology" },
                new object[] { "case encyclopædia Archæology", "newWord", new List<string>() { "Case", "encyclopædia", "ARCHÆOLOGY" }, GlobalVariables.InvariantCulture, "case newWord Archæology" },
                new object[] { "case encyclopædia Archæology", "newWord", new HashSet<string>() { "Case", "encyclopaedia", "Archæology" }, GlobalVariables.InvariantCulture, "case encyclopædia newWord" },
                new object[] { "case encyclopædia Archæology", "newWord", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), GlobalVariables.InvariantCulture, "newWord newWord newWord" },

                new object[] { "case encyclopædia Archæology", "newWord", new string[] { "case", "encyclopaedia", "ARCHÆOLOGY" }, GlobalVariables.InvariantCultureIgnoreCase, "newWord encyclopædia newWord" },
                new object[] { "case encyclopædia Archæology", "newWord", new List<string>() { "Case", "encyclopædia", "ARCHÆOLOGY" }, GlobalVariables.InvariantCultureIgnoreCase, "newWord newWord newWord" },
                new object[] { "case encyclopædia Archæology", "newWord", new HashSet<string>() { "Case", "encyclopaedia", "Archæology" }, GlobalVariables.InvariantCultureIgnoreCase, "newWord encyclopædia newWord" },
                new object[] { "case encyclopædia Archæology", "newWord", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), GlobalVariables.InvariantCultureIgnoreCase, "newWord newWord newWord" },

                new object[] { "case encyclopædia Archæology", "newWord", new string[] { "case", "encyclopaedia", "ARCHÆOLOGY" }, GlobalVariables.Ordinal, "newWord encyclopædia Archæology" },
                new object[] { "case encyclopædia Archæology", "newWord", new List<string>() { "Case", "encyclopædia", "ARCHÆOLOGY" }, GlobalVariables.Ordinal, "case newWord Archæology" },
                new object[] { "case encyclopædia Archæology", "newWord", new HashSet<string>() { "Case", "encyclopaedia", "Archæology" }, GlobalVariables.Ordinal, "case encyclopædia newWord" },
                new object[] { "case encyclopædia Archæology", "newWord", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), GlobalVariables.Ordinal, "newWord newWord newWord" },

                new object[] { "case encyclopædia Archæology", "newWord", new string[] { "kase", "encyclopaedia", "ARCHÆOLOGY" }, GlobalVariables.OrdinalIgnoreCase, "case encyclopædia newWord" },
                new object[] { "case encyclopædia Archæology", "newWord", new List<string>() { "Case", "encyclopædia", "ARCHAEOLOGY" }, GlobalVariables.OrdinalIgnoreCase, "newWord newWord Archæology" },
                new object[] { "case encyclopædia Archæology", "newWord", new HashSet<string>() { "kase", "encyclopædia", "Archæology" }, GlobalVariables.OrdinalIgnoreCase, "case newWord newWord" },
                new object[] { "case encyclopædia Archæology", "newWord", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), GlobalVariables.OrdinalIgnoreCase, "newWord newWord newWord" }
            };
}
