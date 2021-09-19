using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests
{
    public class SelectorTests_Pass
    {
        [Theory]
        [InlineData("His true character is starting to show through.", "His true character is ")]
        [InlineData("Export of the product will start soon.", "Export of the product will ")]
        [InlineData("I'm starting to lose my patience.", "I'm ")]
        public void SubstringStart_TEST(string testString, string expected)
        {
            string result = testString.SubstringStart("start");

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("His true character is starting to show through.", "His true character is start")]
        [InlineData("Export of the product will start soon.", "Export of the product will start")]
        [InlineData("I'm starting to lose my patience.", "I'm start")]
        public void SubstringStart_TEST_InclusiveTrue(string testString, string expected)
        {
            string result = testString.SubstringStart("start", true);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("His true starting character is starting to show through the start.", "His true starting character is starting to show through the ")]
        [InlineData("Export of the starting product will start soon after the start.", "Export of the starting product will start soon after the ")]
        [InlineData("I'm starting to lose my started patience by stop starting.", "I'm starting to lose my started patience by stop ")]
        public void SubstringStartLast_TEST(string testString, string expected)
        {
            string result = testString.SubstringStartLast("start");

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("His true starting character is starting to show through the start.", "His true starting character is starting to show through the start")]
        [InlineData("Export of the starting product will start soon after the start.", "Export of the starting product will start soon after the start")]
        [InlineData("I'm starting to lose my started patience by stop starting.", "I'm starting to lose my started patience by stop start")]
        public void SubstringStartLast_TEST_InclusiveTrue(string testString, string expected)
        {
            string result = testString.SubstringStartLast("start", true);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("I started sweating.", "ed sweat")]
        [InlineData("Now I have to start all over again.", " all ove")]
        [InlineData("He was told that he'd be fired if he didn't start taking his job seriously.", " taking ")]
        public void Substring_TEST_Length(string testString, string expected)
        {
            string result = testString.Substring("start", 8);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("I started sweating.", "started sweat")]
        [InlineData("Now I have to start all over again.", "start all ove")]
        [InlineData("He was told that he'd be fired if he didn't start taking his job seriously.", "start taking ")]
        public void Substring_TEST_Length_InclusiveTrue(string testString, string expected)
        {
            string result = testString.Substring("start", 8, true);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("I started starting sweating sweat.", "ed starting ")]
        [InlineData("Now I have to start starting to sweat all over sweaty again.", " starting to ")]
        [InlineData("He started to was told that he'd be fired in a sweat if he didn't start sweating on his job.", "ed to was told that he'd be fired in a ")]
        public void Substring_StartEnd_TEST(string testString, string expected)
        {
            string result = testString.Substring("start", "sweat");

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("I started starting sweating sweat.", "started starting ")]
        [InlineData("Now I have to start starting to sweat all over sweaty again.", "start starting to ")]
        [InlineData("He started to was told that he'd be fired in a sweat if he didn't start sweating on his job.", "started to was told that he'd be fired in a ")]
        public void Substring_StartEnd_TEST_IncludeStart(string testString, string expected)
        {
            string result = testString.Substring("start", "sweat", StringInclusionOptions.IncludeStart);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("I started starting sweating sweat.", "ed starting sweat")]
        [InlineData("Now I have to start starting to sweat all over sweaty again.", " starting to sweat")]
        [InlineData("He started to was told that he'd be fired in a sweat if he didn't start sweating on his job.", "ed to was told that he'd be fired in a sweat")]
        public void Substring_StartEnd_TEST_IncludeEnd(string testString, string expected)
        {
            string result = testString.Substring("start", "sweat", StringInclusionOptions.IncludeEnd);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("I started starting sweating sweat.", "started starting sweat")]
        [InlineData("Now I have to start starting to sweat all over sweaty again.", "start starting to sweat")]
        [InlineData("He started to was told that he'd be fired in a sweat if he didn't start sweating on his job.", "started to was told that he'd be fired in a sweat")]
        public void Substring_StartEnd_TEST_IncludeAll(string testString, string expected)
        {
            string result = testString.Substring("start", "sweat", StringInclusionOptions.IncludeAll);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("I started starting sweating sweat.", "ed starting sweating ")]
        [InlineData("Now I have to start starting to sweat all over sweaty again.", " starting to sweat all over ")]
        [InlineData("He started to was told that he'd be fired in a sweat if he didn't start sweating on his job.", "ed to was told that he'd be fired in a sweat if he didn't start ")]
        public void SubstringLast_StartEnd_TEST(string testString, string expected)
        {
            string result = testString.SubstringLast("start", "sweat");

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("I started starting sweating sweat.", "started starting sweating ")]
        [InlineData("Now I have to start starting to sweat all over sweaty again.", "start starting to sweat all over ")]
        [InlineData("He started to was told that he'd be fired in a sweat if he didn't start sweating on his job.", "started to was told that he'd be fired in a sweat if he didn't start ")]
        public void SubstringLast_StartEnd_TEST_IncludeStart(string testString, string expected)
        {
            string result = testString.SubstringLast("start", "sweat", StringInclusionOptions.IncludeStart);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("I started starting sweating sweat.", "ed starting sweating sweat")]
        [InlineData("Now I have to start starting to sweat all over sweaty again.", " starting to sweat all over sweat")]
        [InlineData("He started to was told that he'd be fired in a sweat if he didn't start sweating on his job.", "ed to was told that he'd be fired in a sweat if he didn't start sweat")]
        public void SubstringLast_StartEnd_TEST_IncludeEnd(string testString, string expected)
        {
            string result = testString.SubstringLast("start", "sweat", StringInclusionOptions.IncludeEnd);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("I started starting sweating sweat.", "started starting sweating sweat")]
        [InlineData("Now I have to start starting to sweat all over sweaty again.", "start starting to sweat all over sweat")]
        [InlineData("He started to was told that he'd be fired in a sweat if he didn't start sweating on his job.", "started to was told that he'd be fired in a sweat if he didn't start sweat")]
        public void SubstringLast_StartEnd_TEST_IncludeAll(string testString, string expected)
        {
            string result = testString.SubstringLast("start", "sweat", StringInclusionOptions.IncludeAll);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("I started starting sweating sweat.", "ing sweat.")]
        [InlineData("Now I have to start starting to sweat all over sweaty again.", " all over sweaty again.")]
        [InlineData("He started to was told that he'd be fired in a sweat if he didn't start sweating on his job.", " if he didn't start sweating on his job.")]
        public void SubstringEnd_TEST(string testString, string expected)
        {
            string result = testString.SubstringEnd("sweat");

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("I started starting sweating sweat.", "sweating sweat.")]
        [InlineData("Now I have to start starting to sweat all over sweaty again.", "sweat all over sweaty again.")]
        [InlineData("He started to was told that he'd be fired in a sweat if he didn't start sweating on his job.", "sweat if he didn't start sweating on his job.")]
        public void SubstringEnd_TEST_InclusiveTrue(string testString, string expected)
        {
            string result = testString.SubstringEnd("sweat", true);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("I started starting sweating sweat.", ".")]
        [InlineData("Now I have to start starting to sweat all over sweaty again.", "y again.")]
        [InlineData("He started to was told that he'd be fired in a sweat if he didn't start sweating on his job.", "ing on his job.")]
        public void SubstringEndLast_TEST(string testString, string expected)
        {
            string result = testString.SubstringEndLast("sweat");

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("I started starting sweating sweat.", "sweat.")]
        [InlineData("Now I have to start starting to sweat all over sweaty again.", "sweaty again.")]
        [InlineData("He started to was told that he'd be fired in a sweat if he didn't start sweating on his job.", "sweating on his job.")]
        public void SubstringEndLast_TEST_InclusiveTrue(string testString, string expected)
        {
            string result = testString.SubstringEndLast("sweat", true);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("I started starting sweating tonight.", "ing t")]
        [InlineData("Now I have to start starting to sweat all over sweaty again.", "y aga")]
        [InlineData("He started to was told that he'd be fired in a sweat if he didn't start sweating on his job.", "ing o")]
        public void SubstringEndLast_TEST_Length(string testString, string expected)
        {
            string result = testString.SubstringEndLast("sweat", 5);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("I started starting sweating tonight.", "sweating t")]
        [InlineData("Now I have to start starting to sweat all over sweaty again.", "sweaty aga")]
        [InlineData("He started to was told that he'd be fired in a sweat if he didn't start sweating on his job.", "sweating o")]
        public void SubstringEndLast_TEST_Length_InclusiveTrue(string testString, string expected)
        {
            string result = testString.SubstringEndLast("sweat", 5, true);

            Assert.Equal(expected, result);
        }
    }
}
