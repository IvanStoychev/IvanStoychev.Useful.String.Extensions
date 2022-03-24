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

    public static IEnumerable<object[]> Data_Replace_DefaultComparison_Pass
    {
        get
        {
            return new[]
            {
                new object[] { "takimata amet erat invidunt diam no vel nonummy", "newWord", new string[] { "AMET", "INVIDUNT", "NO" }, "takimata newWord erat newWord diam newWord vel newWordnummy" },
                new object[] { "erat consequat euismod justo exerci sed sea tation", "newWord", new List<string>() { "CONSEQUAT", "JUSTO", "SED" }, "erat newWord euismod newWord exerci newWord sea tation" },
                new object[] { "lorem magna eros ea dolore molestie magna rebum", "newWord", new HashSet<string>() { "MAGNA", "EA", "MOLESTIE" }, "lorem newWord eros newWord dolore newWord newWord rebum" },
                new object[] { "duo clita dolore clita clita gubergren diam vel", "newWord", new Queue<string>(new string[] { "CLITA", "GUBERGREN" }), "duo newWord dolore newWord newWord newWord diam vel" }
            };
        }
    }

    public static IEnumerable<object[]> Data_Replace_SetComparison_Pass
    {
        get
        {
            return new[]
            {
                new object[] { "Control - Case encyclopaedia encyclopedia ARCHÆOLOGY; Variant - case encyclopædia Archæology", "newWord", new string[] { "Case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.InvariantCulture, "Control - newWord newWord newWord; Variant - case newWord Archæology" },
                new object[] { "Control - Case encyclopaedia encyclopedia ARCHÆOLOGY; Variant - case encyclopædia Archæology", "newWord", new List<string>() { "Case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.InvariantCulture, "Control - newWord newWord newWord; Variant - case newWord Archæology" },
                new object[] { "Control - Case encyclopaedia encyclopedia ARCHÆOLOGY; Variant - case encyclopædia Archæology", "newWord", new HashSet<string>() { "Case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.InvariantCulture, "Control - newWord newWord newWord; Variant - case newWord Archæology" },
                new object[] { "Control - Case encyclopaedia encyclopedia ARCHÆOLOGY; Variant - case encyclopædia Archæology", "newWord", new Queue<string>(new string[] { "Case", "encyclopaedia", "ARCHÆOLOGY" }), StringComparison.InvariantCulture, "Control - newWord newWord newWord; Variant - case newWord Archæology" },

                new object[] { "Control - Case encyclopaedia encyclopedia ARCHÆOLOGY; Variant - case encyclopædia Archæology", "newWord", new string[] { "Case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.InvariantCultureIgnoreCase, "Control - newWord newWord newWord; Variant - newWord newWord newWord" },
                new object[] { "Control - Case encyclopaedia encyclopedia ARCHÆOLOGY; Variant - case encyclopædia Archæology", "newWord", new List<string>() { "Case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.InvariantCultureIgnoreCase, "Control - newWord newWord newWord; Variant - newWord newWord newWord" },
                new object[] { "Control - Case encyclopaedia encyclopedia ARCHÆOLOGY; Variant - case encyclopædia Archæology", "newWord", new HashSet<string>() { "Case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.InvariantCultureIgnoreCase, "Control - newWord newWord newWord; Variant - newWord newWord newWord" },
                new object[] { "Control - Case encyclopaedia encyclopedia ARCHÆOLOGY; Variant - case encyclopædia Archæology", "newWord", new Queue<string>(new string[] { "Case", "encyclopaedia", "ARCHÆOLOGY" }), StringComparison.InvariantCultureIgnoreCase, "Control - newWord newWord newWord; Variant - newWord newWord newWord" },

                new object[] { "Control - Case encyclopaedia encyclopedia ARCHÆOLOGY; Variant - case encyclopædia Archæology", "newWord", new string[] { "Case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.Ordinal, "Control - newWord newWord newWord; Variant - case encyclopædia Archæology" },
                new object[] { "Control - Case encyclopaedia encyclopedia ARCHÆOLOGY; Variant - case encyclopædia Archæology", "newWord", new List<string>() { "Case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.Ordinal, "Control - newWord newWord newWord; Variant - case encyclopædia Archæology" },
                new object[] { "Control - Case encyclopaedia encyclopedia ARCHÆOLOGY; Variant - case encyclopædia Archæology", "newWord", new HashSet<string>() { "Case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.Ordinal, "Control - newWord newWord newWord; Variant - case encyclopædia Archæology" },
                new object[] { "Control - Case encyclopaedia encyclopedia ARCHÆOLOGY; Variant - case encyclopædia Archæology", "newWord", new Queue<string>(new string[] { "Case", "encyclopaedia", "ARCHÆOLOGY" }), StringComparison.Ordinal, "Control - newWord newWord newWord; Variant - case encyclopædia Archæology" },

                new object[] { "Control - Case encyclopaedia encyclopedia ARCHÆOLOGY; Variant - case encyclopædia Archæology", "newWord", new string[] { "Case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.OrdinalIgnoreCase, "Control - newWord newWord newWord; Variant - newWord encyclopædia newWord" },
                new object[] { "Control - Case encyclopaedia encyclopedia ARCHÆOLOGY; Variant - case encyclopædia Archæology", "newWord", new List<string>() { "Case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.OrdinalIgnoreCase, "Control - newWord newWord newWord; Variant - newWord encyclopædia newWord" },
                new object[] { "Control - Case encyclopaedia encyclopedia ARCHÆOLOGY; Variant - case encyclopædia Archæology", "newWord", new HashSet<string>() { "Case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.OrdinalIgnoreCase, "Control - newWord newWord newWord; Variant - newWord encyclopædia newWord" },
                new object[] { "Control - Case encyclopaedia encyclopedia ARCHÆOLOGY; Variant - case encyclopædia Archæology", "newWord", new Queue<string>(new string[] { "Case", "encyclopaedia", "ARCHÆOLOGY" }), StringComparison.OrdinalIgnoreCase, "Control - newWord newWord newWord; Variant - newWord encyclopædia newWord" }
            };
        }
    }
}
