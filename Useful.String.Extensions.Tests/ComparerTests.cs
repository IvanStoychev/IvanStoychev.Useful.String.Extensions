using System;
using Xunit;

namespace Useful.String.Extensions.Tests
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
    }
}
