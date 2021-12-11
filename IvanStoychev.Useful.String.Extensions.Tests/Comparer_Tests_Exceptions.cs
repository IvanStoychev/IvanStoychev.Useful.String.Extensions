using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests
{
    public class Comparer_Tests_Exceptions
    {
        #region Contains(this string str, params string[] keywords)

        [Fact]
        public void Contains_ParamsString_NullArgument()
        {
            string[] keywords = null;
            string expectedMessage = "The argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(keywords);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_ParamsString_NullMember()
        {
            string[] keywords = { "asd", null };
            string expectedMessage = "A member of the collection argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(keywords);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        #endregion Contains(this string str, params string[] keywords)

        #region Contains(this string str, StringComparison comparison, params string[] keywords)

        [Fact]
        public void Contains_InvariantCulture_ParamsString_NullArgument()
        {
            string[] keywords = null;
            string expectedMessage = "The argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(StringComparison.InvariantCulture, keywords);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_InvariantCulture_ParamsString_NullMember()
        {
            string[] keywords = { "asd", null };
            string expectedMessage = "A member of the collection argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(StringComparison.InvariantCulture, keywords);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_InvariantCultureIgnoreCase_ParamsString_NullArgument()
        {
            string[] keywords = null;
            string expectedMessage = "The argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(StringComparison.InvariantCultureIgnoreCase, keywords);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_InvariantCultureIgnoreCase_ParamsString_NullMember()
        {
            string[] keywords = { "asd", null };
            string expectedMessage = "A member of the collection argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(StringComparison.InvariantCultureIgnoreCase, keywords);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_Ordinal_ParamsString_NullArgument()
        {
            string[] keywords = null;
            string expectedMessage = "The argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(StringComparison.Ordinal, keywords);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_Ordinal_ParamsString_NullMember()
        {
            string[] keywords = { "asd", null };
            string expectedMessage = "A member of the collection argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(StringComparison.Ordinal, keywords);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_OrdinalIgnoreCase_ParamsString_NullArgument()
        {
            string[] keywords = null;
            string expectedMessage = "The argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(StringComparison.OrdinalIgnoreCase, keywords);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_OrdinalIgnoreCase_ParamsString_NullMember()
        {
            string[] keywords = { "asd", null };
            string expectedMessage = "A member of the collection argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(StringComparison.OrdinalIgnoreCase, keywords);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        #endregion Contains(this string str, StringComparison comparison, params string[] keywords)

        #region Contains(this string str, IEnumerable<string> keywords, StringComparison comparison = StringComparison.Ordinal)

        [Fact]
        public void Contains_IEnumString_Default_NullArgument()
        {
            string[] keywords = null;
            string expectedMessage = "The argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(keywords);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_IEnumString_Default_NullMember()
        {
            string[] keywords = { "asd", null };
            string expectedMessage = "A member of the collection argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(keywords);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_IEnumString_InvariantCulture_NullArgument()
        {
            string[] keywords = null;
            string expectedMessage = "The argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(keywords, StringComparison.InvariantCulture);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_IEnumString_InvariantCulture_NullMember()
        {
            string[] keywords = { "asd", null };
            string expectedMessage = "A member of the collection argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(keywords, StringComparison.InvariantCulture);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_IEnumString_InvariantCultureIgnoreCase_NullArgument()
        {
            string[] keywords = null;
            string expectedMessage = "The argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(keywords, StringComparison.InvariantCultureIgnoreCase);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_IEnumString_InvariantCultureIgnoreCase_NullMember()
        {
            string[] keywords = { "asd", null };
            string expectedMessage = "A member of the collection argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(keywords, StringComparison.InvariantCultureIgnoreCase);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_IEnumString_Ordinal_NullArgument()
        {
            string[] keywords = null;
            string expectedMessage = "The argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(keywords, StringComparison.Ordinal);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_IEnumString_Ordinal_NullMember()
        {
            string[] keywords = { "asd", null };
            string expectedMessage = "A member of the collection argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(keywords, StringComparison.Ordinal);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_IEnumString_OrdinalIgnoreCase_NullArgument()
        {
            string[] keywords = null;
            string expectedMessage = "The argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(keywords, StringComparison.OrdinalIgnoreCase);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_IEnumString_OrdinalIgnoreCase_NullMember()
        {
            string[] keywords = { "asd", null };
            string expectedMessage = "A member of the collection argument given for 'keywords' was null. (Parameter 'keywords')";

            void testAction() => "".Contains(keywords, StringComparison.OrdinalIgnoreCase);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        #endregion Contains(this string str, IEnumerable<string> keywords, StringComparison comparison = StringComparison.Ordinal)
        
        #region Contains(this string str, params char[] keychars)

        [Fact]
        public void Contains_ParamsChar_NullArgument()
        {
            char[] keychars = null;
            string expectedMessage = "The argument given for 'keychars' was null. (Parameter 'keychars')";

            void testAction() => "".Contains(keychars);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        #endregion Contains(this string str, params char[] keychars)

        #region Contains(this string str, StringComparison comparison, params char[] keychars)

        [Fact]
        public void Contains_InvariantCulture_ParamsChar_NullArgument()
        {
            char[] keychars = null;
            string expectedMessage = "The argument given for 'keychars' was null. (Parameter 'keychars')";

            void testAction() => "".Contains(StringComparison.InvariantCulture, keychars);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_InvariantCultureIgnoreCase_ParamsChar_NullArgument()
        {
            char[] keychars = null;
            string expectedMessage = "The argument given for 'keychars' was null. (Parameter 'keychars')";

            void testAction() => "".Contains(StringComparison.InvariantCultureIgnoreCase, keychars);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_Ordinal_ParamsChar_NullArgument()
        {
            char[] keychars = null;
            string expectedMessage = "The argument given for 'keychars' was null. (Parameter 'keychars')";

            void testAction() => "".Contains(StringComparison.Ordinal, keychars);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_OrdinalIgnoreCase_ParamsChar_NullArgument()
        {
            char[] keychars = null;
            string expectedMessage = "The argument given for 'keychars' was null. (Parameter 'keychars')";

            void testAction() => "".Contains(StringComparison.OrdinalIgnoreCase, keychars);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        #endregion Contains(this string str, StringComparison comparison, params char[] keychars)

        #region Contains(this string str, IEnumerable<char> keychars, StringComparison comparison = StringComparison.Ordinal)

        [Fact]
        public void Contains_IEnumChar_InvariantCulture_NullArgument()
        {
            char[] keychars = null;
            string expectedMessage = "The argument given for 'keychars' was null. (Parameter 'keychars')";

            void testAction() => "".Contains(keychars, StringComparison.InvariantCulture);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_IEnumChar_InvariantCultureIgnoreCase_NullArgument()
        {
            char[] keychars = null;
            string expectedMessage = "The argument given for 'keychars' was null. (Parameter 'keychars')";

            void testAction() => "".Contains(keychars, StringComparison.InvariantCultureIgnoreCase);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_IEnumChar_Ordinal_NullArgument()
        {
            char[] keychars = null;
            string expectedMessage = "The argument given for 'keychars' was null. (Parameter 'keychars')";

            void testAction() => "".Contains(keychars, StringComparison.Ordinal);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Contains_IEnumChar_OrdinalIgnoreCase_NullArgument()
        {
            char[] keychars = null;
            string expectedMessage = "The argument given for 'keychars' was null. (Parameter 'keychars')";

            void testAction() => "".Contains(keychars, StringComparison.OrdinalIgnoreCase);

            var exception = Assert.Throws<ArgumentNullException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        #endregion Contains(this string str, IEnumerable<char> keychars, StringComparison comparison = StringComparison.Ordinal)
    }
}
