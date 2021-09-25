using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests
{
    public class Remover_Tests_Exceptions
    {
        [Fact]
        public void Trim_Int_ArgumentOutOfRange()
        {
            string testString = "123";
            int amount = 2;
            int lengthDiff = testString.Length - amount * 2;
            string expectedMessage = $"The value given for '{nameof(amount)}' (\"{amount}\") is longer than the entire string by {Math.Abs(lengthDiff)}. (Parameter '{nameof(amount)}')";

            void testAction() => testString.TrimStart(amount);

            var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void TrimStart_Int_ArgumentOutOfRange()
        {
            string testString = "123";
            int amount = 4;
            int lengthDiff = testString.Length - amount;
            string expectedMessage = $"The value given for '{nameof(amount)}' (\"{amount}\") is longer than the entire string by {Math.Abs(lengthDiff)}. (Parameter '{nameof(amount)}')";

            void testAction() => testString.TrimStart(amount);

            var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void TrimEnd_Int_ArgumentOutOfRange()
        {
            string testString = "123";
            int amount = 4;
            int lengthDiff = testString.Length - amount;
            string expectedMessage = $"The value given for '{nameof(amount)}' (\"{amount}\") is longer than the entire string by {Math.Abs(lengthDiff)}. (Parameter '{nameof(amount)}')";

            void testAction() => testString.TrimEnd(amount);

            var exception = Assert.Throws<ArgumentOutOfRangeException>(testAction);
            Assert.Equal(expectedMessage, exception.Message);
        }
    }
}
