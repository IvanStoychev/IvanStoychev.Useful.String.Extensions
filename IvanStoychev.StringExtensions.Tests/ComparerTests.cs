using System;
using System.Collections.Generic;
using Xunit;

namespace IvanStoychev.StringExtensions.Tests
{
    public class ComparerTests
    {
        [Theory]
        [InlineData("Built purse maids cease her ham new seven among and", new string[] { "door", "hook", "car", "ham" })]
        [InlineData("Pulled coming wooded tended it answer remain me be", new string[] { "wood", "anybody", "word" })]
        [InlineData("So landlord by we unlocked sensible it", new string[] { "maids", "people", "unlocked" })]
        [InlineData("Fat cannot use denied excuse son law", new string[] { "man", "phone", "denied", "rang" })]
        [InlineData("Wisdom happen suffer common the appear ham beauty her had", new string[] { "Microsoft", "window", "happen", "appear" })]
        [InlineData("Or belonging zealously existence as by resources", new string[] { "zeal", "crusade", "scarlet", "diglett" })]
        public void ContainsStrings_Pass_Test(string testString, string[] keywords)
        {
            bool actual = testString.Contains(keywords);

            Assert.True(actual);
        }

        [Theory]
        [InlineData("Built purse maids cease her ham new seven among and", new string[] { "door", "hook", "car" })]
        [InlineData("Pulled coming wooded tended it answer remain me be", new string[] { "WOODED", "anybody", "word" })]
        [InlineData("So landlord by we unlocked sensible it", new string[] { "maids", "people", "cooked" })]
        [InlineData("Fat cannot use denied excuse son law", new string[] { "man", "DENIED", "vox", "rang" })]
        [InlineData("Wisdom happen suffer common the appear ham beauty her had", new string[] { "Microsoft", "window", "hapPen", "apear" })]
        [InlineData("Or belonging zealously existence as by resources", new string[] { "zeaL", "crusade", "scarlet", "diglett" })]
        public void ContainsStrings_Fail_Test(string testString, string[] keywords)
        {
            bool actual = testString.Contains(keywords);

            Assert.False(actual);
        }

        [Theory]
        [InlineData("Built purse maids cease her ham new seven among and", new string[] { "door", "hook", "car", "ham" })]
        [InlineData("Pulled coming wooded tended it answer remain me be", new string[] { "WOODED", "anybody", "word" })]
        [InlineData("So landlord by we unlocked sensible it", new string[] { "maids", "people", "unlocked" })]
        [InlineData("Fat cannot use denied excuse son law", new string[] { "man", "phone", "DENIED", "rang" })]
        [InlineData("Wisdom happen suffer common the appear ham beauty her had", new string[] { "Microsoft", "window", "happen", "appear" })]
        [InlineData("Or belonging zealously existence as by resources", new string[] { "zeaL", "crusade", "scarlet", "diglett" })]
        public void ContainsStrings_OrdinalIgnoreCase_Pass_Test(string testString, string[] keywords)
        {
            bool actual = testString.Contains(StringComparison.OrdinalIgnoreCase, keywords);

            Assert.True(actual);
        }

        [Theory]
        [InlineData("Built purse maids cease her ham new seven among and", new string[] { "door", "hook", "car" })]
        [InlineData("Pulled coming wooded tended it answer remain me be", new string[] { "woodd", "anybody", "word" })]
        [InlineData("So landlord by we unlocked sensible it", new string[] { "maids", "people", "cooked" })]
        [InlineData("Fat cannot use denied excuse son law", new string[] { "man", "phone", "vox", "rang" })]
        [InlineData("Wisdom happen suffer common the appear ham beauty her had", new string[] { "Microsoft", "window", "hapen", "apear" })]
        [InlineData("Or belonging zealously existence as by resources", new string[] { "zealu", "crusade", "scarlet", "diglett" })]
        public void ContainsStrings_OrdinalIgnoreCase_Fail_Test(string testString, string[] keywords)
        {
            bool actual = testString.Contains(StringComparison.OrdinalIgnoreCase, keywords);

            Assert.False(actual);
        }

        [Theory]
        [InlineData("Built purse maids cease her ham new seven among and", new string[] { "door", "hook", "car", "ham" })]
        [InlineData("Pulled coming wooded tended it answer remain me be", new string[] { "wood", "anybody", "word" })]
        [InlineData("So landlord by we unlocked sensible it", new string[] { "maids", "people", "unlocked" })]
        [InlineData("Fat cannot use denied excuse son law", new string[] { "man", "phone", "denied", "rang" })]
        [InlineData("Wisdom happen suffer common the appear ham beauty her had", new string[] { "Microsoft", "window", "happen", "appear" })]
        [InlineData("Or belonging zealously existence as by resources", new string[] { "zeal", "crusade", "scarlet", "diglett" })]
        public void ContainsStrings_Ordinal_Pass_Test(string testString, string[] keywords)
        {
            bool actual = testString.Contains(StringComparison.Ordinal, keywords);

            Assert.True(actual);
        }

        [Theory]
        [InlineData("Built purse maids cease her ham new seven among and", new string[] { "door", "hook", "car" })]
        [InlineData("Pulled coming wooded tended it answer remain me be", new string[] { "WOODED", "anybody", "word" })]
        [InlineData("So landlord by we unlocked sensible it", new string[] { "maids", "people", "cooked" })]
        [InlineData("Fat cannot use denied excuse son law", new string[] { "man", "phone", "vox", "DENIED", "rang" })]
        [InlineData("Wisdom happen suffer common the appear ham beauty her had", new string[] { "Microsoft", "window", "hapen", "apear" })]
        [InlineData("Or belonging zealously existence as by resources", new string[] { "zeaL", "crusade", "scarlet", "diglett" })]
        public void ContainsStrings_Ordinal_Fail_Test(string testString, string[] keywords)
        {
            bool actual = testString.Contains(StringComparison.Ordinal, keywords);

            Assert.False(actual);
        }

        [Theory]
        [InlineData("Built purse maids cease her ham new seven among and", new string[] { "door", "hook", "car", "ham" })]
        [InlineData("Pulled coming wooded tended it answer remain me be", new string[] { "wood", "anybody", "word" })]
        [InlineData("So landlord by we unlocked sensible it", new string[] { "maids", "people", "unlocked" })]
        [InlineData("Fat cannot use denied excuse son law", new string[] { "man", "phone", "denied", "rang" })]
        [InlineData("Wisdom happen suffer common the appear ham beauty her had", new string[] { "Microsoft", "window", "happen", "appear" })]
        [InlineData("Or belonging zealously existence as by resources", new string[] { "zeal", "crusade", "scarlet", "diglett" })]
        public void ContainsStrings_InvariantCulture_Pass_Test(string testString, string[] keywords)
        {
            bool actual = testString.Contains(StringComparison.InvariantCulture, keywords);

            Assert.True(actual);
        }

        [Theory]
        [InlineData("Built purse maids cease her ham new seven among and", new string[] { "door", "hook", "car" })]
        [InlineData("Pulled coming wooded tended it answer remain me be", new string[] { "WOODED", "anybody", "word" })]
        [InlineData("So landlord by we unlocked sensible it", new string[] { "maids", "people", "cooked" })]
        [InlineData("Fat cannot use denied excuse son law", new string[] { "man", "phone", "vox", "DENIED", "rang" })]
        [InlineData("Wisdom happen suffer common the appear ham beauty her had", new string[] { "Microsoft", "window", "hapen", "apear" })]
        [InlineData("Or belonging zealously existence as by resources", new string[] { "zeaL", "crusade", "scarlet", "diglett" })]
        public void ContainsStrings_InvariantCulture_Fail_Test(string testString, string[] keywords)
        {
            bool actual = testString.Contains(StringComparison.InvariantCulture, keywords);

            Assert.False(actual);
        }

        [Theory]
        [InlineData("v027CPSNRo9pwj9f", new char[] { 'z', '7', 'x' })]
        [InlineData("tPzglSBMqE6u9bvB", new char[] { 'P', '0', 'n' })]
        [InlineData("jT5BZRbC8cgwAYu2", new char[] { 'x', '3', 'C' })]
        [InlineData("U5SVGjk0hIr9Bxz0", new char[] { 'U', '4', 'H' })]
        [InlineData("Caq0r9KadJwBgFte", new char[] { 'f', '8', 'q' })]
        [InlineData("KE0evdEczTKxAmkn", new char[] { 'l', 'K', 'D' })]
        public void ContainsChars_Pass_Test(string testString, char[] keychars)
        {
            bool actual = testString.Contains(keychars);

            Assert.True(actual);
        }

        [Theory]
        [InlineData("v027CPSNRo9pwj9f", new char[] { 'z', '8', 'x' })]
        [InlineData("tPzglSBMqE6u9bvB", new char[] { 'p', '0', 'n' })]
        [InlineData("jT5BZRbC8cgwAYu2", new char[] { 'x', '3', 'y' })]
        [InlineData("U5SVGjk0hIr9Bxz0", new char[] { 'u', '4', 'H' })]
        [InlineData("Caq0r9KadJwBgFte", new char[] { 'f', '8', 'Q' })]
        [InlineData("KE0evdEczTKxAmkn", new char[] { 'l', '1', 'D' })]
        public void ContainsChars_Fail_Test(string testString, char[] keychars)
        {
            bool actual = testString.Contains(keychars);

            Assert.False(actual);
        }

        [Theory]
        [InlineData("v027CPSNRo9pwj9f", new char[] { 'z', '8', 'W' })]
        [InlineData("tPzglSBMqE6u9bvB", new char[] { 'p', '0', 'n' })]
        [InlineData("jT5BZRbC8cgwAYu2", new char[] { 'x', '3', 'c' })]
        [InlineData("U5SVGjk0hIr9Bxz0", new char[] { 'u', '4', 'H' })]
        [InlineData("Caq0r9KadJwBgFte", new char[] { 'f', '8', 'Q' })]
        [InlineData("KE0evdEczTKxAmkn", new char[] { 'l', 'k', 'D' })]
        public void ContainsChars_OrdinalIgnoreCase_Pass_Test(string testString, char[] keychars)
        {
            bool actual = testString.Contains(StringComparison.OrdinalIgnoreCase, keychars);

            Assert.True(actual);
        }

        [Theory]
        [InlineData("v027CPSNRo9pwj9f", new char[] { 'z', '8', 'x' })]
        [InlineData("tPzglSBMqE6u9bvB", new char[] { 'w', '0', 'n' })]
        [InlineData("jT5BZRbC8cgwAYu2", new char[] { 'x', '3', 'n' })]
        [InlineData("U5SVGjk0hIr9Bxz0", new char[] { 'f', '4', 'y' })]
        [InlineData("Caq0r9KadJwBgFte", new char[] { 'z', '8', 's' })]
        [InlineData("KE0evdEczTKxAmkn", new char[] { 'l', 'i', 's' })]
        public void ContainsChars_OrdinalIgnoreCase_Fail_Test(string testString, char[] keychars)
        {
            bool actual = testString.Contains(StringComparison.OrdinalIgnoreCase, keychars);

            Assert.False(actual);
        }

        [Theory]
        [InlineData("v027CPSNRo9pwj9f", new char[] { 'z', '7', 'x' })]
        [InlineData("tPzglSBMqE6u9bvB", new char[] { 'P', '0', 'n' })]
        [InlineData("jT5BZRbC8cgwAYu2", new char[] { 'x', '3', 'C' })]
        [InlineData("U5SVGjk0hIr9Bxz0", new char[] { 'U', '4', 'H' })]
        [InlineData("Caq0r9KadJwBgFte", new char[] { 'f', '8', 'q' })]
        [InlineData("KE0evdEczTKxAmkn", new char[] { 'l', 'K', 'D' })]
        public void ContainsChars_Ordinal_Pass_Test(string testString, char[] keychars)
        {
            bool actual = testString.Contains(StringComparison.Ordinal, keychars);

            Assert.True(actual);
        }

        [Theory]
        [InlineData("v027CPSNRo9pwj9f", new char[] { 'z', '8', 'x' })]
        [InlineData("tPzglSBMqE6u9bvB", new char[] { 'p', '0', 'n' })]
        [InlineData("jT5BZRbC8cgwAYu2", new char[] { 'x', '3', 'W' })]
        [InlineData("U5SVGjk0hIr9Bxz0", new char[] { 'u', '4', 'H' })]
        [InlineData("Caq0r9KadJwBgFte", new char[] { 'f', '8', 'Q' })]
        [InlineData("KE0evdEczTKxAmkn", new char[] { 'l', 't', 'D' })]
        public void ContainsChars_Ordinal_Fail_Test(string testString, char[] keychars)
        {
            bool actual = testString.Contains(StringComparison.Ordinal, keychars);

            Assert.False(actual);
        }

        [Theory]
        [InlineData("v027CPSNRo9pwj9f", new char[] { 'z', '7', 'x' })]
        [InlineData("tPzglSBMqE6u9bvB", new char[] { 'P', '0', 'n' })]
        [InlineData("jT5BZRbC8cgwAYu2", new char[] { 'x', '3', 'C' })]
        [InlineData("U5SVGjk0hIr9Bxz0", new char[] { 'U', '4', 'H' })]
        [InlineData("Caq0r9KadJwBgFte", new char[] { 'f', '8', 'q' })]
        [InlineData("KE0evdEczTKxAmkn", new char[] { 'l', 'K', 'D' })]
        public void ContainsChars_InvariantCulture_Pass_Test(string testString, char[] keychars)
        {
            bool actual = testString.Contains(StringComparison.InvariantCulture, keychars);

            Assert.True(actual);
        }

        [Theory]
        [InlineData("v027CPSNRo9pwj9f", new char[] { 'z', '8', 'x' })]
        [InlineData("tPzglSBMqE6u9bvB", new char[] { 'p', '0', 'n' })]
        [InlineData("jT5BZRbC8cgwAYu2", new char[] { 'x', '3', 'W' })]
        [InlineData("U5SVGjk0hIr9Bxz0", new char[] { 'u', '4', 'H' })]
        [InlineData("Caq0r9KadJwBgFte", new char[] { 'f', '8', 'Q' })]
        [InlineData("KE0evdEczTKxAmkn", new char[] { 'l', 't', 'D' })]
        public void ContainsChars_InvariantCulture_Fail_Test(string testString, char[] keychars)
        {
            bool actual = testString.Contains(StringComparison.InvariantCulture, keychars);

            Assert.False(actual);
        }

        [Theory, MemberData(nameof(ContainsStrings_PassTestDataCaseSensetive))]
        public void ContainsStringsIEnum_Pass_Test(string testString, IEnumerable<string> keywords)
        {
            bool actual = testString.Contains(keywords);

            Assert.True(actual);
        }

        [Theory, MemberData(nameof(ContainsStrings_FailTestDataCaseSensetive))]
        public void ContainsStringsIEnum_Fail_Test(string testString, IEnumerable<string> keywords)
        {
            bool actual = testString.Contains(keywords);

            Assert.False(actual);
        }

        [Theory, MemberData(nameof(ContainsStrings_PassTestDataCaseInsensetive))]
        public void ContainsStringsIEnum_OrdinalIgnoreCase_Pass_Test(string testString, IEnumerable<string> keywords)
        {
            bool actual = testString.Contains(StringComparison.OrdinalIgnoreCase, keywords);

            Assert.True(actual);
        }

        [Theory, MemberData(nameof(ContainsStrings_FailTestDataCaseInsensetive))]
        public void ContainsStringsIEnum_OrdinalIgnoreCase_Fail_Test(string testString, IEnumerable<string> keywords)
        {
            bool actual = testString.Contains(StringComparison.OrdinalIgnoreCase, keywords);

            Assert.False(actual);
        }

        [Theory, MemberData(nameof(ContainsStrings_PassTestDataCaseSensetive))]
        public void ContainsStringsIEnum_Ordinal_Pass_Test(string testString, IEnumerable<string> keywords)
        {
            bool actual = testString.Contains(StringComparison.Ordinal, keywords);

            Assert.True(actual);
        }

        [Theory, MemberData(nameof(ContainsStrings_FailTestDataCaseSensetive))]
        public void ContainsStringsIEnum_Ordinal_Fail_Test(string testString, IEnumerable<string> keywords)
        {
            bool actual = testString.Contains(StringComparison.Ordinal, keywords);

            Assert.False(actual);
        }

        [Theory, MemberData(nameof(ContainsStrings_PassTestDataCaseSensetive))]
        public void ContainsStringsIEnum_InvariantCulture_Pass_Test(string testString, IEnumerable<string> keywords)
        {
            bool actual = testString.Contains(StringComparison.InvariantCulture, keywords);

            Assert.True(actual);
        }

        [Theory, MemberData(nameof(ContainsStrings_FailTestDataCaseSensetive))]
        public void ContainsStringsIEnum_InvariantCulture_Fail_Test(string testString, IEnumerable<string> keywords)
        {
            bool actual = testString.Contains(StringComparison.InvariantCulture, keywords);

            Assert.False(actual);
        }

        [Theory, MemberData(nameof(ContainsChars_PassTestDataCaseSensetive))]
        public void ContainsCharsIEnum_Pass_Test(string testString, IEnumerable<char> keychars)
        {
            bool actual = testString.Contains(keychars);

            Assert.True(actual);
        }

        [Theory, MemberData(nameof(ContainsChars_FailTestDataCaseSensetive))]
        public void ContainsCharsIEnum_Fail_Test(string testString, IEnumerable<char> keychars)
        {
            bool actual = testString.Contains(keychars);

            Assert.False(actual);
        }

        [Theory, MemberData(nameof(ContainsChars_PassTestDataCaseInsensetive))]
        public void ContainsCharsIEnum_OrdinalIgnoreCase_Pass_Test(string testString, IEnumerable<char> keychars)
        {
            bool actual = testString.Contains(StringComparison.OrdinalIgnoreCase, keychars);

            Assert.True(actual);
        }

        [Theory, MemberData(nameof(ContainsChars_FailTestDataCaseInsensetive))]
        public void ContainsCharsIEnum_OrdinalIgnoreCase_Fail_Test(string testString, IEnumerable<char> keychars)
        {
            bool actual = testString.Contains(StringComparison.OrdinalIgnoreCase, keychars);

            Assert.False(actual);
        }

        [Theory, MemberData(nameof(ContainsChars_PassTestDataCaseSensetive))]
        public void ContainsCharsIEnum_Ordinal_Pass_Test(string testString, IEnumerable<char> keychars)
        {
            bool actual = testString.Contains(StringComparison.Ordinal, keychars);

            Assert.True(actual);
        }

        [Theory, MemberData(nameof(ContainsChars_FailTestDataCaseSensetive))]
        public void ContainsCharsIEnum_Ordinal_Fail_Test(string testString, IEnumerable<char> keychars)
        {
            bool actual = testString.Contains(StringComparison.Ordinal, keychars);

            Assert.False(actual);
        }

        [Theory, MemberData(nameof(ContainsChars_PassTestDataCaseSensetive))]
        public void ContainsCharsIEnum_InvariantCulture_Pass_Test(string testString, IEnumerable<char> keychars)
        {
            bool actual = testString.Contains(StringComparison.InvariantCulture, keychars);

            Assert.True(actual);
        }

        [Theory, MemberData(nameof(ContainsChars_FailTestDataCaseSensetive))]
        public void ContainsCharsIEnum_InvariantCulture_Fail_Test(string testString, IEnumerable<char> keychars)
        {
            bool actual = testString.Contains(StringComparison.InvariantCulture, keychars);

            Assert.False(actual);
        }

        public static IEnumerable<object[]> ContainsChars_PassTestDataCaseSensetive
        {
            get
            {
                return new[]
                {
                    new object[] { "v027CPSNRo9pwj9f", new char[] { 'z', '7', 'x' } },
                    new object[] { "tPzglSBMqE6u9bvB", new List<char>() { 'P', '0', 'n' } },
                    new object[] { "jT5BZRbC8cgwAYu2", new HashSet<char>() { 'x', '3', 'w' } },
                    new object[] { "U5SVGjk0hIr9Bxz0", new Queue<char>(new char[] { 'U', '4', 'h' }) }
                };
            }
        }

        public static IEnumerable<object[]> ContainsChars_PassTestDataCaseInsensetive
        {
            get
            {
                return new[]
                {
                    new object[] { "v027CPSNRo9pwj9f", new char[] { 'z', '7', 'x' } },
                    new object[] { "tPzglSBMqE6u9bvB", new List<char>() { 'p', '0', 'n' } },
                    new object[] { "jT5BZRbC8cgwAYu2", new HashSet<char>() { 'x', '3', 'W' } },
                    new object[] { "U5SVGjk0hIr9Bxz0", new Queue<char>(new char[] { 'u', '4', 'H' }) }
                };
            }
        }

        public static IEnumerable<object[]> ContainsChars_FailTestDataCaseSensetive
        {
            get
            {
                return new[]
                {
                    new object[] { "v027CPSNRo9pwj9f", new char[] { 'z', '3', 'x' } },
                    new object[] { "tPzglSBMqE6u9bvB", new List<char>() { 'p', '0', 'n' } },
                    new object[] { "jT5BZRbC8cgwAYu2", new HashSet<char>() { 'x', '3', 'W' } },
                    new object[] { "U5SVGjk0hIr9Bxz0", new Queue<char>(new char[] { 'u', '4', 'H' }) }
                };
            }
        }

        public static IEnumerable<object[]> ContainsChars_FailTestDataCaseInsensetive
        {
            get
            {
                return new[]
                {
                    new object[] { "v027CPSNRo9pwj9f", new char[] { 'z', '3', 'x' } },
                    new object[] { "tPzglSBMqE6u9bvB", new List<char>() { 'i', '0', 'n' } },
                    new object[] { "jT5BZRbC8cgwAYu2", new HashSet<char>() { 'x', '3', 'h' } },
                    new object[] { "U5SVGjk0hIr9Bxz0", new Queue<char>(new char[] { 'f', '4', 'q' }) }
                };
            }
        }

        public static IEnumerable<object[]> ContainsStrings_PassTestDataCaseSensetive
        {
            get
            {
                return new[]
                {
                    new object[] { "Built purse maids cease her ham new seven among and", new string[] { "door", "hook", "car", "ham" } },
                    new object[] { "Pulled coming wooded tended it answer remain me be", new List<string>() { "wood", "anybody", "word" } },
                    new object[] { "So landlord by we unlocked sensible it", new HashSet<string>() { "maids", "people", "unlocked" } },
                    new object[] { "Fat cannot use denied excuse son law", new Queue<string>(new string[] { "man", "phone", "denied", "rang" }) }
                };
            }
        }

        public static IEnumerable<object[]> ContainsStrings_PassTestDataCaseInsensetive
        {
            get
            {
                return new[]
                {
                    new object[] { "Built purse maids cease her ham new seven among and", new string[] { "door", "hook", "car", "HAM" } },
                    new object[] { "Pulled coming wooded tended it answer remain me be", new List<string>() { "WOOD", "anybody", "word" } },
                    new object[] { "So landlord by we unlocked sensible it", new HashSet<string>() { "maids", "people", "uNLocked" } },
                    new object[] { "Fat cannot use denied excuse son law", new Queue<string>(new string[] { "man", "phone", "DeNIeD", "rang" }) }
                };
            }
        }

        public static IEnumerable<object[]> ContainsStrings_FailTestDataCaseSensetive
        {
            get
            {
                return new[]
                {
                    new object[] { "Built purse maids cease her ham new seven among and", new string[] { "door", "hook", "car", "HAM" } },
                    new object[] { "Pulled coming wooded tended it answer remain me be", new List<string>() { "WOOD", "anybody", "word" } },
                    new object[] { "So landlord by we unlocked sensible it", new HashSet<string>() { "maids", "people", "uNLocked" } },
                    new object[] { "Fat cannot use denied excuse son law", new Queue<string>(new string[] { "man", "phone", "DeNIeD", "rang" }) }
                };
            }
        }

        public static IEnumerable<object[]> ContainsStrings_FailTestDataCaseInsensetive
        {
            get
            {
                return new[]
                {
                    new object[] { "Built purse maids cease her ham new seven among and", new string[] { "door", "hook", "car", "news" } },
                    new object[] { "Pulled coming wooded tended it answer remain me be", new List<string>() { "hard", "anybody", "word" } },
                    new object[] { "So landlord by we unlocked sensible it", new HashSet<string>() { "maids", "people", "pig" } },
                    new object[] { "Fat cannot use denied excuse son law", new Queue<string>(new string[] { "man", "phone", "rang" }) }
                };
            }
        }
    }
}
