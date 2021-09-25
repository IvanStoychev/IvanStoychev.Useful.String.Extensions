using System;
using System.Collections.Generic;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests
{
    public class Comparer_Tests
    {
        #region Contains(this string str, params string[] keywords)

        [Theory]
        [InlineData("Built purse maids cease her ham new seven among and", new string[] { "door", "hook", "car", "ham" })]
        [InlineData("Pulled coming wooded tended it answer remain me be", new string[] { "wood", "anybody", "word" })]
        [InlineData("So landlord by we unlocked sensible it", new string[] { "maids", "people", "unlocked" })]
        [InlineData("Fat cannot use denied excuse son law", new string[] { "man", "phone", "denied", "rang" })]
        [InlineData("Wisdom happen suffer common the appear ham beauty her had", new string[] { "Microsoft", "window", "happen", "appear" })]
        [InlineData("Or belonging zealously existence as by resources", new string[] { "zeal", "crusade", "scarlet", "diglett" })]
        public void Contains_StringArray_Pass(string testString, string[] keywords)
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
        public void Contains_StringArray_Fail(string testString, string[] keywords)
        {
            bool actual = testString.Contains(keywords);

            Assert.False(actual);
        }

        #endregion Contains(this string str, params string[] keywords)

        #region Contains(this string str, StringComparison comparison, params string[] keywords)

        [Theory]
        [InlineData("Built purse maids cease her ham new seven among and", new string[] { "door", "hook", "car", "ham" })]
        [InlineData("Pulled coming wooded tended it answer remain me be", new string[] { "wood", "anybody", "word" })]
        [InlineData("So landlord by we unlocked sensible it", new string[] { "maids", "people", "unlocked" })]
        [InlineData("Fat cannot use denied excuse son law", new string[] { "man", "phone", "denied", "rang" })]
        [InlineData("Wisdom happen suffer common the appear ham beauty her had", new string[] { "Microsoft", "window", "happen", "appear" })]
        [InlineData("Or belonging zealously existence as by resources", new string[] { "zeal", "crusade", "scarlet", "diglett" })]
        public void Contains_Ordinal_StringArray_Pass(string testString, string[] keywords)
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
        public void Contains_Ordinal_StringArray_Fail(string testString, string[] keywords)
        {
            bool actual = testString.Contains(StringComparison.Ordinal, keywords);

            Assert.False(actual);
        }

        [Theory]
        [InlineData("Built purse maids cease her ham new seven among and", new string[] { "door", "hook", "car", "ham" })]
        [InlineData("Pulled coming wooded tended it answer remain me be", new string[] { "WOODED", "anybody", "word" })]
        [InlineData("So landlord by we unlocked sensible it", new string[] { "maids", "people", "unlocked" })]
        [InlineData("Fat cannot use denied excuse son law", new string[] { "man", "phone", "DENIED", "rang" })]
        [InlineData("Wisdom happen suffer common the appear ham beauty her had", new string[] { "Microsoft", "window", "happen", "appear" })]
        [InlineData("Or belonging zealously existence as by resources", new string[] { "zeaL", "crusade", "scarlet", "diglett" })]
        public void Contains_OrdinalIgnoreCase_StringArray_Pass(string testString, string[] keywords)
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
        public void Contains_OrdinalIgnoreCase_StringArray_Fail(string testString, string[] keywords)
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
        public void Contains_InvariantCulture_StringArray_Pass(string testString, string[] keywords)
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
        public void Contains_InvariantCulture_StringArray_Fail(string testString, string[] keywords)
        {
            bool actual = testString.Contains(StringComparison.InvariantCulture, keywords);

            Assert.False(actual);
        }

        [Theory]
        [InlineData("Built purse maids cease her ham new seven among and", new string[] { "door", "hook", "car", "hAm" })]
        [InlineData("Pulled coming wooded tended it answer remain me be", new string[] { "wOod", "anybody", "word" })]
        [InlineData("So landlord by we unlocked sensible it", new string[] { "maids", "people", "unloCKed" })]
        [InlineData("Fat cannot use denied excuse son law", new string[] { "man", "phone", "dEnIed", "rang" })]
        [InlineData("Wisdom happen suffer common the appear ham beauty her had", new string[] { "Microsoft", "window", "hapPEN", "appear" })]
        [InlineData("Or belonging zealously existence as by resources", new string[] { "ZEAL", "crusade", "scarlet", "diglett" })]
        public void Contains_InvariantCultureIgnoreCase_StringArray_Pass(string testString, string[] keywords)
        {
            bool actual = testString.Contains(StringComparison.InvariantCultureIgnoreCase, keywords);

            Assert.True(actual);
        }

        [Theory]
        [InlineData("Built purse maids cease her ham new seven among and", new string[] { "door", "hook", "car" })]
        [InlineData("Pulled coming wooded tended it answer remain me be", new string[] { "anybody", "word" })]
        [InlineData("So landlord by we unlocked sensible it", new string[] { "maids", "people", "cooked" })]
        [InlineData("Fat cannot use denied excuse son law", new string[] { "man", "phone", "vox", "rang" })]
        [InlineData("Wisdom happen suffer common the appear ham beauty her had", new string[] { "Microsoft", "window", "hapen", "apear" })]
        [InlineData("Or belonging zealously existence as by resources", new string[] { "crusade", "scarlet", "diglett" })]
        public void Contains_InvariantCultureIgnoreCase_StringArray_Fail(string testString, string[] keywords)
        {
            bool actual = testString.Contains(StringComparison.InvariantCultureIgnoreCase, keywords);

            Assert.False(actual);
        }

        #endregion Contains(this string str, StringComparison comparison, params string[] keywords)

        #region Contains(this string str, IEnumerable<string> keywords, StringComparison comparison)

        [Theory, MemberData(nameof(Contains_IEnumString_CaseSensetive_Pass))]
        public void Contains_IEnumString_StringComparisonDefault_Pass(string testString, IEnumerable<string> keywords)
        {
            bool actual = testString.Contains(keywords);

            Assert.True(actual);
        }

        [Theory, MemberData(nameof(Contains_IEnumString_CaseSensetive_Fail))]
        public void Contains_IEnumString_StringComparisonDefault_Fail(string testString, IEnumerable<string> keywords)
        {
            bool actual = testString.Contains(keywords);

            Assert.False(actual);
        }

        [Theory, MemberData(nameof(Contains_IEnumString_CaseSensetive_Pass))]
        public void Contains_IEnumString_StringComparisonOrdinal_Pass(string testString, IEnumerable<string> keywords)
        {
            bool actual = testString.Contains(keywords, StringComparison.Ordinal);

            Assert.True(actual);
        }

        [Theory, MemberData(nameof(Contains_IEnumString_CaseSensetive_Fail))]
        public void Contains_IEnumString_StringComparisonOrdinal_Fail(string testString, IEnumerable<string> keywords)
        {
            bool actual = testString.Contains(keywords, StringComparison.Ordinal);

            Assert.False(actual);
        }

        [Theory, MemberData(nameof(Contains_IEnumString_CaseInsensetive_Pass))]
        public void Contains_IEnumString_StringComparisonOrdinalIgnoreCase_Pass(string testString, IEnumerable<string> keywords)
        {
            bool actual = testString.Contains(keywords, StringComparison.OrdinalIgnoreCase);

            Assert.True(actual);
        }

        [Theory, MemberData(nameof(Contains_IEnumString_CaseInsensetive_Fail))]
        public void Contains_IEnumString_StringComparisonOrdinalIgnoreCase_Fail(string testString, IEnumerable<string> keywords)
        {
            bool actual = testString.Contains(keywords, StringComparison.OrdinalIgnoreCase);

            Assert.False(actual);
        }

        [Theory, MemberData(nameof(Contains_IEnumString_CaseSensetive_Pass))]
        public void Contains_IEnumString_StringComparisonInvariantCulture_Pass(string testString, IEnumerable<string> keywords)
        {
            bool actual = testString.Contains(keywords, StringComparison.InvariantCulture);

            Assert.True(actual);
        }

        [Theory, MemberData(nameof(Contains_IEnumString_CaseSensetive_Fail))]
        public void Contains_IEnumString_StringComparisonInvariantCulture_Fail(string testString, IEnumerable<string> keywords)
        {
            bool actual = testString.Contains(keywords, StringComparison.InvariantCulture);

            Assert.False(actual);
        }

        [Theory, MemberData(nameof(Contains_IEnumString_CaseInsensetive_Pass))]
        public void Contains_IEnumString_StringComparisonInvariantCultureIgnoreCase_Pass(string testString, IEnumerable<string> keywords)
        {
            bool actual = testString.Contains(keywords, StringComparison.InvariantCultureIgnoreCase);

            Assert.True(actual);
        }

        [Theory, MemberData(nameof(Contains_IEnumString_CaseInsensetive_Fail))]
        public void Contains_IEnumString_StringComparisonInvariantCultureIgnoreCase_Fail(string testString, IEnumerable<string> keywords)
        {
            bool actual = testString.Contains(keywords, StringComparison.InvariantCultureIgnoreCase);

            Assert.False(actual);
        }

        #endregion Contains(this string str, IEnumerable<string> keywords, StringComparison comparison)

        #region Contains(this string str, params char[] keychars)

        [Theory]
        [InlineData("v027CPSNRo9pwj9f", new char[] { 'z', '7', 'x' })]
        [InlineData("tPzglSBMqE6u9bvB", new char[] { 'P', '0', 'n' })]
        [InlineData("jT5BZRbC8cgwAYu2", new char[] { 'x', '3', 'C' })]
        [InlineData("U5SVGjk0hIr9Bxz0", new char[] { 'U', '4', 'H' })]
        [InlineData("Caq0r9KadJwBgFte", new char[] { 'f', '8', 'q' })]
        [InlineData("KE0evdEczTKxAmkn", new char[] { 'l', 'K', 'D' })]
        public void Contains_IEnumChar_Pass(string testString, char[] keychars)
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
        public void Contains_IEnumChar_Fail(string testString, char[] keychars)
        {
            bool actual = testString.Contains(keychars);

            Assert.False(actual);
        }

        #endregion Contains(this string str, params char[] keychars)

        #region Contains(this string str, StringComparison comparison, params char[] keychars)

        [Theory]
        [InlineData("v027CPSNRo9pwj9f", new char[] { 'z', '7', 'x' })]
        [InlineData("tPzglSBMqE6u9bvB", new char[] { 'P', '0', 'n' })]
        [InlineData("jT5BZRbC8cgwAYu2", new char[] { 'x', '3', 'C' })]
        [InlineData("U5SVGjk0hIr9Bxz0", new char[] { 'U', '4', 'H' })]
        [InlineData("Caq0r9KadJwBgFte", new char[] { 'f', '8', 'q' })]
        [InlineData("KE0evdEczTKxAmkn", new char[] { 'l', 'K', 'D' })]
        public void Contains_IEnumChar_Ordinal_Pass(string testString, char[] keychars)
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
        public void Contains_IEnumChar_Ordinal_Fail(string testString, char[] keychars)
        {
            bool actual = testString.Contains(StringComparison.Ordinal, keychars);

            Assert.False(actual);
        }

        [Theory]
        [InlineData("v027CPSNRo9pwj9f", new char[] { 'z', '8', 'W' })]
        [InlineData("tPzglSBMqE6u9bvB", new char[] { 'p', '0', 'n' })]
        [InlineData("jT5BZRbC8cgwAYu2", new char[] { 'x', '3', 'c' })]
        [InlineData("U5SVGjk0hIr9Bxz0", new char[] { 'u', '4', 'H' })]
        [InlineData("Caq0r9KadJwBgFte", new char[] { 'f', '8', 'Q' })]
        [InlineData("KE0evdEczTKxAmkn", new char[] { 'l', 'k', 'D' })]
        public void Contains_OrdinalIgnoreCase_CharArray_Pass(string testString, char[] keychars)
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
        public void Contains_OrdinalIgnoreCase_CharArray_Fail(string testString, char[] keychars)
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
        public void Contains_InvariantCulture_CharArray_Pass(string testString, char[] keychars)
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
        public void Contains_InvariantCulture_CharArray_Fail(string testString, char[] keychars)
        {
            bool actual = testString.Contains(StringComparison.InvariantCulture, keychars);

            Assert.False(actual);
        }

        [Theory]
        [InlineData("v027CPSNRo9pwj9f", new char[] { 'z', '7', 'x' })]
        [InlineData("tPzglSBMqE6u9bvB", new char[] { 'P', '0', 'n' })]
        [InlineData("jT5BZRbC8cgwAYu2", new char[] { 'x', '3', 'C' })]
        [InlineData("U5SVGjk0hIr9Bxz0", new char[] { 'U', '4', 'H' })]
        [InlineData("Caq0r9KadJwBgFte", new char[] { 'f', '8', 'q' })]
        [InlineData("KE0evdEczTKxAmkn", new char[] { 'l', 'K', 'D' })]
        public void Contains_InvariantCultureIgnoreCase_CharArray_Pass(string testString, char[] keychars)
        {
            bool actual = testString.Contains(StringComparison.InvariantCultureIgnoreCase, keychars);

            Assert.True(actual);
        }

        [Theory]
        [InlineData("v027CPSNRo9pwj9f", new char[] { 'z', '8', 'x' })]
        [InlineData("tPzglSBMqE6u9bvB", new char[] { 'w', '0', 'n' })]
        [InlineData("jT5BZRbC8cgwAYu2", new char[] { 'x', '3', 'n' })]
        [InlineData("U5SVGjk0hIr9Bxz0", new char[] { 'f', '4', 'y' })]
        [InlineData("Caq0r9KadJwBgFte", new char[] { 'z', '8', 's' })]
        [InlineData("KE0evdEczTKxAmkn", new char[] { 'l', 'i', 's' })]
        public void Contains_InvariantCultureIgnoreCase_CharArray_Fail(string testString, char[] keychars)
        {
            bool actual = testString.Contains(StringComparison.InvariantCultureIgnoreCase, keychars);

            Assert.False(actual);
        }

        #endregion Contains(this string str, StringComparison comparison, params char[] keychars)

        #region Contains(this string str, IEnumerable<char> keychars, StringComparison comparison)

        [Theory, MemberData(nameof(Contains_IEnumChar_CaseSensetive_Pass))]
        public void Contains_IEnumChar_StringComparisonDefault_Pass(string testString, IEnumerable<char> keychars)
        {
            bool actual = testString.Contains(keychars);

            Assert.True(actual);
        }

        [Theory, MemberData(nameof(Contains_IEnumChar_CaseSensetive_Fail))]
        public void Contains_IEnumChar_StringComparisonDefault_Fail(string testString, IEnumerable<char> keychars)
        {
            bool actual = testString.Contains(keychars);

            Assert.False(actual);
        }

        [Theory, MemberData(nameof(Contains_IEnumChar_CaseSensetive_Pass))]
        public void Contains_IEnumChar_StringComparisonOrdinal_Pass(string testString, IEnumerable<char> keychars)
        {
            bool actual = testString.Contains(keychars, StringComparison.Ordinal);

            Assert.True(actual);
        }

        [Theory, MemberData(nameof(Contains_IEnumChar_CaseSensetive_Fail))]
        public void Contains_IEnumChar_StringComparisonOrdinal_Fail(string testString, IEnumerable<char> keychars)
        {
            bool actual = testString.Contains(keychars, StringComparison.Ordinal);

            Assert.False(actual);
        }

        [Theory, MemberData(nameof(Contains_IEnumChar_CaseInsensetive_Pass))]
        public void Contains_IEnumChar_StringComparisonOrdinalIgnoreCase_Pass(string testString, IEnumerable<char> keychars)
        {
            bool actual = testString.Contains(keychars, StringComparison.OrdinalIgnoreCase);

            Assert.True(actual);
        }

        [Theory, MemberData(nameof(Contains_IEnumChar_CaseInsensetive_Fail))]
        public void Contains_IEnumChar_StringComparisonOrdinalIgnoreCase_Fail(string testString, IEnumerable<char> keychars)
        {
            bool actual = testString.Contains(keychars, StringComparison.OrdinalIgnoreCase);

            Assert.False(actual);
        }

        [Theory, MemberData(nameof(Contains_IEnumChar_CaseSensetive_Pass))]
        public void Contains_IEnumChar_StringComparisonInvariantCulture_Pass(string testString, IEnumerable<char> keychars)
        {
            bool actual = testString.Contains(keychars, StringComparison.InvariantCulture);

            Assert.True(actual);
        }

        [Theory, MemberData(nameof(Contains_IEnumChar_CaseSensetive_Fail))]
        public void Contains_IEnumChar_StringComparisonInvariantCulture_Fail(string testString, IEnumerable<char> keychars)
        {
            bool actual = testString.Contains(keychars, StringComparison.InvariantCulture);

            Assert.False(actual);
        }

        [Theory, MemberData(nameof(Contains_IEnumChar_CaseInsensetive_Pass))]
        public void Contains_IEnumChar_StringComparisonInvariantCultureIgnoreCase_Pass(string testString, IEnumerable<char> keychars)
        {
            bool actual = testString.Contains(keychars, StringComparison.InvariantCultureIgnoreCase);

            Assert.True(actual);
        }

        [Theory, MemberData(nameof(Contains_IEnumChar_CaseInsensetive_Fail))]
        public void Contains_IEnumChar_StringComparisonInvariantCultureIgnoreCase_Fail(string testString, IEnumerable<char> keychars)
        {
            bool actual = testString.Contains(keychars, StringComparison.InvariantCultureIgnoreCase);

            Assert.False(actual);
        }

        #endregion Contains(this string str, IEnumerable<char> keychars, StringComparison comparison)

        #region IEnumerable test data

        public static IEnumerable<object[]> Contains_IEnumString_CaseSensetive_Pass
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

        public static IEnumerable<object[]> Contains_IEnumString_CaseSensetive_Fail
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

        public static IEnumerable<object[]> Contains_IEnumString_CaseInsensetive_Pass
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

        public static IEnumerable<object[]> Contains_IEnumString_CaseInsensetive_Fail
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

        public static IEnumerable<object[]> Contains_IEnumChar_CaseSensetive_Pass
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

        public static IEnumerable<object[]> Contains_IEnumChar_CaseSensetive_Fail
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

        public static IEnumerable<object[]> Contains_IEnumChar_CaseInsensetive_Pass
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

        public static IEnumerable<object[]> Contains_IEnumChar_CaseInsensetive_Fail
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

        #endregion IEnumerable test data
    }
}