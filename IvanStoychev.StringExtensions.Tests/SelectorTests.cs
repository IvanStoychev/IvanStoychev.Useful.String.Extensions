using Xunit;
using System;

namespace IvanStoychev.StringExtensions.Tests
{
    public class SelectorTests
    {
        #region "Pass" tests section

        #region Substring(string, string, StringInclusionOptions)

        /// <summary>
        /// Tests whether the returned value includes the "startString".
        /// </summary>
        [Theory]
        [InlineData("Don't step on the broken glass.", "step on the ")]
        [InlineData("He didn’t step on the dentist, yet he broken anyway.", "step on the dentist, yet he ")]
        [InlineData("The quick brown fox steps over the broken dog.", "steps over the ")]
        public void Substring__string_string_StringInclusionOptions__IncludeStart_Pass(string testString, string expected)
        {
            string actual = testString.Substring("step", "broken", StringInclusionOptions.IncludeStart);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Tests whether the returned value includes the "endString".
        /// </summary>
        [Theory]
        [InlineData("She did not cheat on the test, for it was not the right thing to do.", " on the test, for it was not the right")]
        [InlineData("I love eating cheat cheese and tuna right.", " cheese and tuna right")]
        [InlineData("The cheat right the meal.", " right")]
        public void Substring__string_string_StringInclusionOptions__IncludeEnd_Pass(string testString, string expected)
        {
            string result = testString.Substring("cheat", "right", StringInclusionOptions.IncludeEnd);

            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Tests whether the returned value includes both "startString" and "endString".
        /// </summary>
        [Theory]
        [InlineData("The waves were crashing on the shore; it was a lovely sight.", "waves were crashing on the shore")]
        [InlineData("She did waves best to help shore.", "waves best to help shore")]
        [InlineData("I'd rather be a waves shore a fish.", "waves shore")]
        public void Substring__string_string_StringInclusionOptions__IncludeBoth_Pass(string testString, string expected)
        {
            string actual = testString.Substring("waves", "shore", StringInclusionOptions.IncludeAll);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Tests whether the returned value does not include neither "startString" nor "endString".
        /// </summary>
        [Theory]
        [InlineData("Is the snatch safety better than the virus?", " safety better than the ")]
        [InlineData("It was then the snatch mess met virus unwitting cut.", " mess met ")]
        [InlineData("snatch the complete boyfriend really tip the virus?", " the complete boyfriend really tip the ")]
        public void Substring__string_string_StringInclusionOptions__IncludeNone_Pass(string testString, string expected)
        {
            string actual = testString.Substring("snatch", "virus", StringInclusionOptions.IncludeNone);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Tests whether the method will work as expected when the "startString" and "endString" are the same.
        /// </summary>
        [Theory]
        [InlineData("The hand sanitizer was actually hand glue.", "hand", "hand sanitizer was actually hand")]
        [InlineData("Plans for this weekend include turning Plans into water.", "Plans", "Plans for this weekend include turning Plans")]
        [InlineData("Please tell me you don't tell in a morgue.", "tell", "tell me you don't tell")]
        public void Substring__string_string_StringInclusionOptions__SameString_Pass(string testString, string substring, string expected)
        {
            string actual = testString.Substring(substring, substring, StringInclusionOptions.IncludeAll);

            Assert.Equal(expected, actual);
        }

        #endregion Substring(string, string, StringInclusionOptions)

        #region Substring(string, bool)

        /// <summary>
        /// Tests whether the returned value includes "startString".
        /// </summary>
        [Theory]
        [InlineData("I started sweating.", "started sweating.")]
        [InlineData("Now I have to start all over again.", "start all over again.")]
        [InlineData("He was told that he'd be fired if he didn't start taking his job seriously.", "start taking his job seriously.")]
        public void Substring__string_bool__Inclusive_Pass(string testString, string expected)
        {
            string actual = testString.Substring("start", true);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Tests whether the returned value does not include "startString".
        /// </summary>
        [Theory]
        [InlineData("I started sweating.", "ed sweating.")]
        [InlineData("Now I have to start all over again.", " all over again.")]
        [InlineData("He was told that he'd be fired if he didn't start taking his job seriously.", " taking his job seriously.")]
        public void Substring__string_bool__Exclusive_Pass(string testString, string expected)
        {
            string actual = testString.Substring("start", false);

            Assert.Equal(expected, actual);
        }

        #endregion Substring(string, bool)

        #region Substring(string, int, bool)

        /// <summary>
        /// Tests whether the returned value is of the given length and includes "startString".
        /// </summary>
        [Theory]
        [InlineData("His true character is starting to show through.", 9, "starting ")]
        [InlineData("Export of the product will start soon.", 11, "start soon.")]
        [InlineData("I'm starting to lose my patience.", 29, "starting to lose my patience.")]
        public void Substring__string_int_bool__Inclusive_Pass(string testString, int expectedLength, string expected)
        {
            string actual = testString.Substring("start", expectedLength, true);
            int actualLength = actual.Length;

            Assert.Equal(expectedLength, actualLength);
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Tests whether the returned value is of the given length and does not include "startString".
        /// </summary>
        [Theory]
        [InlineData("His true character is starting to show through.", 4, "ing ")]
        [InlineData("Export of the product will start soon.", 6, " soon.")]
        [InlineData("I'm starting to lose my patience.", 24, "ing to lose my patience.")]
        public void Substring__string_int_bool__Exclusive_Pass(string testString, int expectedLength, string expected)
        {
            string actual = testString.Substring("start", expectedLength, false);
            int actualLength = actual.Length;

            Assert.Equal(expectedLength, actualLength);
            Assert.Equal(expected, actual);
        }

        #endregion Substring(string, int, bool)

        #endregion "Pass" tests section

        #region "Exception" tests section

        #region Substring(string, bool)

        /// <summary>
        /// Tests if an <see cref="ArgumentOutOfRangeException"/> exception, with an appropriate message,
        /// is thrown when the given "startString" is not present in the original string.
        /// </summary>
        [Fact]
        public void Substring__string_bool__ArgumentOutOfRange_Exception()
        {
            string testString = "Test";
            string expectedMessage = "The string given for 'startString' (\"Not present\") was not found in the original string. (Parameter 'startString')";
            Action action = () => testString.Substring("Not present", false);
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(action);
            Assert.Equal(expectedMessage, ex.Message);
        }

        #endregion Substring(string, bool)

        #region Substring(string, int, bool)

        /// <summary>
        /// Tests if an <see cref="ArgumentOutOfRangeException"/> exception, with an appropriate message,
        /// is thrown when the given "startString" is not present in the original string.
        /// </summary>
        [Fact]
        public void Substring__string_int_bool__ArgumentOutOfRange_Exception()
        {
            string testString = "Test.";
            string expectedMessage = "The string given for 'startString' (\"Not present\") was not found in the original string. (Parameter 'startString')";
            Action action = () => testString.Substring("Not present", 3, false);
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(action);
            Assert.Equal(expectedMessage, ex.Message);
        }

        #endregion Substring(string, int, bool)

        #region Substring(string, string, StringInclusionOptions)

        /// <summary>
        /// Tests if an <see cref="ArgumentOutOfRangeException"/> exception, with an appropriate message,
        /// is thrown when the given "startString" is not present in the original string.
        /// </summary>
        [Fact]
        public void Substring__string_string_StringInclusionOptions__ArgumentOutOfRange_Exception_startString()
        {
            string testString = "Test.";
            string expectedMessage = "The string given for 'startString' (\"Not present\") was not found in the original string. (Parameter 'startString')";
            Action action = () => testString.Substring("Not present", "Test", StringInclusionOptions.IncludeAll);
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(action);
            Assert.Equal(expectedMessage, ex.Message);
        }

        /// <summary>
        /// Tests if an <see cref="ArgumentOutOfRangeException"/> exception, with an appropriate message,
        /// is thrown when the given "endString" is not present in the original string.
        /// </summary>
        [Fact]
        public void Substring__string_string_StringInclusionOptions__ArgumentOutOfRange_Exception_endString()
        {
            string testString = "Test.";
            string expectedMessage = "The string given for 'endString' (\"Not present\") was not found in the original string. (Parameter 'endString')";
            Action action = () => testString.Substring("Test", "Not present", StringInclusionOptions.IncludeAll);
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(action);
            Assert.Equal(expectedMessage, ex.Message);
        }

        #endregion Substring(string, string, StringInclusionOptions)

        #endregion "Exception" tests section
    }
}
