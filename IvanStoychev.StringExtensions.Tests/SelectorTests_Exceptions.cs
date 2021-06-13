using System;
using Xunit;

namespace IvanStoychev.StringExtensions.Tests
{
    public class SelectorTests_Exceptions
    {
        [Fact]
        public void SubstringStart_ArgumentOutOfRange()
        {
            string testString = "";
            string expectedMessage = "The string given for 'endString' (\"end\") was not found in the original instance. (Parameter 'endString')";

            Action testAction = () => testString.SubstringStart("end");

            var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void SubstringStart_ArgumentNull()
        {
            string testString = "";
            string expectedMessage = "The argument given for 'endString' was null. (Parameter 'endString')";

            Action testAction = () => testString.SubstringStart(null);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void SubstringStartLast_ArgumentOutOfRange()
        {
            string testString = "";
            string expectedMessage = "The string given for 'endString' (\"end\") was not found in the original instance. (Parameter 'endString')";

            Action testAction = () => testString.SubstringStartLast("end");

            var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void SubstringStartLast_ArgumentNull()
        {
            string testString = "";
            string expectedMessage = "The argument given for 'endString' was null. (Parameter 'endString')";

            Action testAction = () => testString.SubstringStartLast(null);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Substring_Length_ArgumentOutOfRange()
        {
            string testString = "";
            string expectedMessage = "The string given for 'startString' (\"start\") was not found in the original instance. (Parameter 'startString')";

            Action testAction = () => testString.Substring("start", 0);

            var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Substring_NegativeLength_ArgumentOutOfRange()
        {
            string testString = "start";
            string expectedMessage = "The value given for 'length' (\"-5\") is less than zero. (Parameter 'length')";

            Action testAction = () => testString.Substring("start", -5);

            var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Substring_LengthOutOfRange_ArgumentOutOfRange()
        {
            string testString = "start12";
            string expectedMessage = "The value given for 'length' (\"11\") is longer than the remaining string by 9. (Parameter 'length')";

            Action testAction = () => testString.Substring("start", 11);

            var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Substring_Length_ArgumentNull()
        {
            string testString = "";
            string expectedMessage = "The argument given for 'startString' was null. (Parameter 'startString')";

            Action testAction = () => testString.Substring(null, 0);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Substring_StartEndString_Start_ArgumentOutOfRange()
        {
            string testString = "";
            string expectedMessage = "The string given for 'startString' (\"start\") was not found in the original instance. (Parameter 'startString')";

            Action testAction = () => testString.Substring("start", "end");

            var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Substring_StartEndString_End_ArgumentOutOfRange()
        {
            string testString = "end start";
            string expectedMessage = "The string given for 'endString' (\"end\") was not found after the given 'startString' (\"start\") in the original instance. (Parameter 'endString')";

            Action testAction = () => testString.Substring("start", "end");

            var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Substring_StartEndString_Start_ArgumentNull()
        {
            string testString = "";
            string expectedMessage = "The argument given for 'startString' was null. (Parameter 'startString')";

            Action testAction = () => testString.Substring(null, "end");

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Substring_StartEndString_End_ArgumentNull()
        {
            string testString = "start";
            string expectedMessage = "The argument given for 'endString' was null. (Parameter 'endString')";

            Action testAction = () => testString.Substring("start", null);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void SubstringLast_StartString_ArgumentOutOfRange()
        {
            string testString = "";
            string expectedMessage = "The string given for 'startString' (\"start\") was not found in the original instance. (Parameter 'startString')";

            Action testAction = () => testString.SubstringLast("start", "end");

            var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void SubstringLast_EndString_ArgumentOutOfRange()
        {
            string testString = "end start";
            string expectedMessage = "The string given for 'endString' (\"end\") was not found after the given 'startString' (\"start\") in the original instance. (Parameter 'endString')";

            Action testAction = () => testString.SubstringLast("start", "end");

            var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void SubstringLast_StartString_ArgumentNull()
        {
            string testString = "";
            string expectedMessage = "The argument given for 'startString' was null. (Parameter 'startString')";

            Action testAction = () => testString.SubstringLast(null, "end");

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void SubstringLast_EndString_ArgumentNull()
        {
            string testString = "start";
            string expectedMessage = "The argument given for 'endString' was null. (Parameter 'endString')";

            Action testAction = () => testString.SubstringLast("start", null);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void SubstringEnd_ArgumentOutOfRange()
        {
            string testString = "";
            string expectedMessage = "The string given for 'startString' (\"start\") was not found in the original instance. (Parameter 'startString')";

            Action testAction = () => testString.SubstringEnd("start");

            var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void SubstringEnd_ArgumentNull()
        {
            string testString = "";
            string expectedMessage = "The argument given for 'startString' was null. (Parameter 'startString')";

            Action testAction = () => testString.SubstringEnd(null);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void SubstringEndLast_ArgumentOutOfRange()
        {
            string testString = "";
            string expectedMessage = "The string given for 'startString' (\"start\") was not found in the original instance. (Parameter 'startString')";

            Action testAction = () => testString.SubstringEndLast("start");

            var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void SubstringEndLast_ArgumentNull()
        {
            string testString = "";
            string expectedMessage = "The argument given for 'startString' was null. (Parameter 'startString')";

            Action testAction = () => testString.SubstringEndLast(null);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void SubstringEndLast_Length_ArgumentOutOfRange()
        {
            string testString = "";
            string expectedMessage = "The string given for 'startString' (\"start\") was not found in the original instance. (Parameter 'startString')";

            Action testAction = () => testString.SubstringEndLast("start", 0);

            var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void SubstringEndLast_NegativeLength_ArgumentOutOfRange()
        {
            string testString = "start";
            string expectedMessage = "The value given for 'length' (\"-5\") is less than zero. (Parameter 'length')";

            Action testAction = () => testString.SubstringEndLast("start", -5);

            var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void SubstringEndLast_LengthOutOfRange_ArgumentOutOfRange()
        {
            string testString = "start12";
            string expectedMessage = "The value given for 'length' (\"11\") is longer than the remaining string by 9. (Parameter 'length')";

            Action testAction = () => testString.SubstringEndLast("start", 11);

            var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void SubstringEndLast_Length_ArgumentNull()
        {
            string testString = "";
            string expectedMessage = "The argument given for 'startString' was null. (Parameter 'startString')";

            Action testAction = () => testString.SubstringEndLast(null, 0);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }
    }
}
