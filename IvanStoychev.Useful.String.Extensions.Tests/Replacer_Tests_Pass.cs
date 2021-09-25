using System.Collections.Generic;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests
{
    public class Replacer_Tests_Pass
    {
        [Theory]
        [InlineData("eos sed elitr sit lorem eos zzril lorem", "newWord", new string[] { "sed", "sit", "eos" }, "newWord newWord elitr newWord lorem newWord zzril lorem")]
        public void ReplaceTest_Pass(string testString, string newString, string[] oldStrings, string expectedString)
        {
            string actualString = testString.Replace(newString, oldStrings);

            Assert.Equal(expectedString, actualString);
        }

        [Theory]
        [InlineData(true, "et ut esse duis magna sit eirmod sea", "newWord", new string[] { "UT", "DUIS", "SIT" }, "et newWord esse newWord magna newWord eirmod sea")]
        [InlineData(true, "lorem eros sed et sed clita illum dolor", "newWord", new string[] { "EROS", "ET", "CLITA" }, "lorem newWord sed newWord sed newWord illum dolor")]
        [InlineData(true, "vulputate et autem adipiscing amet gubergren dolore suscipit", "newWord", new string[] { "ET", "ADIPISCING", "GUBERGREN" }, "vulputate newWord autem newWord amnewWord newWord dolore suscipit")]
        [InlineData(true, "sea esse takimata feugait erat ipsum eirmod sanctus", "newWord", new string[] { "ESSE", "FEUGAIT", "IPSUM" }, "sea newWord takimata newWord erat newWord eirmod sanctus")]
        public void ReplaceTest_IgnoreCase_Pass(bool ignoreCase, string testString, string newString, string[] oldStrings, string expectedString)
        {
            string actualString = testString.Replace(ignoreCase, newString, oldStrings);

            Assert.Equal(expectedString, actualString);
        }

        [Theory]
        [InlineData(false, "quis diam dolores ut et suscipit dolores amet", "newWord", new string[] { "diam", "ut", "suscipit" }, "quis newWord dolores newWord et newWord dolores amet")]
        [InlineData(false, "ipsum duo accusam gubergren dolor ut eirmod duo", "newWord", new string[] { "duo", "gubergren", "ut" }, "ipsum newWord accusam newWord dolor newWord eirmod newWord")]
        [InlineData(false, "et molestie amet justo gubergren sed labore duis", "newWord", new string[] { "molestie", "justo", "sed" }, "et newWord amet newWord gubergren newWord labore duis")]
        [InlineData(false, "blandit eu eirmod nonumy dolor ut ipsum aliquyam", "newWord", new string[] { "eu", "nonumy", "ut" }, "blandit newWord eirmod newWord dolor newWord ipsum aliquyam")]
        [InlineData(false, "velit veniam stet augue diam eleifend justo labore", "newWord", new string[] { "VENIAM", "AUGUE", "ELEIFEND" }, "velit veniam stet augue diam eleifend justo labore")]
        [InlineData(false, "dolores adipiscing assum eirmod eum lorem et gubergren", "newWord", new string[] { "ADIPISCING", "EIRMOD", "LOREM" }, "dolores adipiscing assum eirmod eum lorem et gubergren")]
        [InlineData(false, "et sit et gubergren ex eum tincidunt clita", "newWord", new string[] { "SIT", "GUBERGREN", "EUM" }, "et sit et gubergren ex eum tincidunt clita")]
        public void ReplaceTest_ConsiderCase_Pass(bool ignoreCase, string testString, string newString, string[] oldStrings, string expectedString)
        {
            string actualString = testString.Replace(ignoreCase, newString, oldStrings);

            Assert.Equal(expectedString, actualString);
        }

        [Theory, MemberData(nameof(ReplaceStringsIEnumTestData_ConsiderCase))]
        public void ReplaceTestIEnum_ConsiderCase_Pass(string testString, IEnumerable<string> oldStrings, string newString, string expectedString)
        {
            string actualString = testString.Replace(oldStrings, newString);

            Assert.Equal(expectedString, actualString);
        }

        [Theory, MemberData(nameof(ReplaceStringsIEnumTestData_ConsiderCase))]
        public void ReplaceTestIEnumBool_ConsiderCase_Pass(string testString, IEnumerable<string> oldStrings, string newString, string expectedString)
        {
            string actualString = testString.Replace(oldStrings, newString, false);

            Assert.Equal(expectedString, actualString);
        }

        [Theory, MemberData(nameof(ReplaceStringsIEnumTestData_IgnoreCase))]
        public void ReplaceTestIEnumBool_IgnoreCase_Pass(string testString, IEnumerable<string> oldStrings, string newString, string expectedString)
        {
            string actualString = testString.Replace(oldStrings, newString, true);

            Assert.Equal(expectedString, actualString);
        }

        [Theory]
        [InlineData("t34ROgYYYY2p2TlJ4JYsa2yyyylJts0hLujF72", "t34ROgYYYY2p2TlJ4JYsa2XXXXlJts0hLujF72")]
        [InlineData("SpyyyytLUHHxYYYYJnPltTikZZZZl8FuOOzzzzc091F2Yk", "SpXXXXtLUHHxYYYYJnPltTikXXXXl8FuOOzzzzc091F2Yk")]
        [InlineData("svAZzZzEYqjq8YyYy0hVKuFRyyyyl2ry4eZZZZauLCe6V", "svAZzZzEYqjq8YyYy0hVKuFRXXXXl2ry4eXXXXauLCe6V")]
        public void ReplaceString_Test_ConsiderCase(string testString, string expected)
        {
            string actual = testString.Replace(new[] { "yyyy", "ZZZZ" }, "XXXX", false);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("t34ROgYYYY2p2TlJ4JYsa2yyyylJts0hLujF72", "t34ROgXXXX2p2TlJ4JYsa2XXXXlJts0hLujF72")]
        [InlineData("SpyyyytLUHHxYYYYJnPltTikZZZZl8FuOOzzzzc091F2Yk", "SpXXXXtLUHHxXXXXJnPltTikXXXXl8FuOOXXXXc091F2Yk")]
        [InlineData("svAZzZzEYqjq8YyYy0hVKuFRyyyyl2ry4eZZZZauLCe6V", "svAXXXXEYqjq8XXXX0hVKuFRXXXXl2ry4eXXXXauLCe6V")]
        public void ReplaceString_Test_IgnoreCase(string testString, string expected)
        {
            string actual = testString.Replace(new[] { "ZZZZ", "yyyy" }, "XXXX", true);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> ReplaceStringsIEnumTestData_IgnoreCase
        {
            get
            {
                return new[]
                {
                    new object[] { "takimata amet erat invidunt diam no vel nonummy", new string[] { "AMET", "INVIDUNT", "NO" }, "newWord", "takimata newWord erat newWord diam newWord vel newWordnummy" },
                    new object[] { "erat consequat euismod justo exerci sed sea tation", new List<string>() { "CONSEQUAT", "JUSTO", "SED" }, "newWord", "erat newWord euismod newWord exerci newWord sea tation" },
                    new object[] { "lorem magna eros ea dolore molestie magna rebum", new HashSet<string>() { "MAGNA", "EA", "MOLESTIE" }, "newWord", "lorem newWord eros newWord dolore newWord newWord rebum" },
                    new object[] { "duo clita dolore clita clita gubergren diam vel", new Queue<string>(new string[] { "CLITA", "GUBERGREN" }), "newWord", "duo newWord dolore newWord newWord newWord diam vel" }
                };
            }
        }

        public static IEnumerable<object[]> ReplaceStringsIEnumTestData_ConsiderCase
        {
            get
            {
                return new[]
                {
                    new object[] { "takimata vErO ut sED voluptua SaNCtUS tempor et", new string[] { "vErO", "sED", "SaNCtUS" }, "newWord", "takimata newWord ut newWord voluptua newWord tempor et" },
                    new object[] { "diam euM eirmod amEt ullamcorper sEA dolor et", new List<string>() { "euM", "amEt", "sEA" }, "newWord", "diam newWord eirmod newWord ullamcorper newWord dolor et" },
                    new object[] { "eirmod KASD duis eT eirmod aMeT et sanctus", new HashSet<string>() { "KASD", "eT", "aMeT" }, "newWord", "eirmod newWord duis newWord eirmod aMnewWord et sanctus" },
                    new object[] { "est IPsuM kasd ut gubergren eirMOD eos at", new Queue<string>(new string[] { "IPsuM", "ut", "eirMOD" }), "newWord", "est newWord kasd newWord gubergren newWord eos at" }                };
            }
        }
    }
}
