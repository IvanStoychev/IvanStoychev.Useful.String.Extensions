﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests
{
    public class Remover_Tests
    {
        [Theory]
        [InlineData("Lorem lorem IPSUM ipsum", "Lorem   ipsum")]
        [InlineData("lorem LORem ipSUM IPSUM", " LORem ipSUM ")]
        [InlineData("lorem ipsum IPSUM", " ipsum ")]
        public void Remove_ConsiderCase(string testString, string expected)
        {
            string actual = testString.Remove("lorem", "IPSUM");

            Assert.Equal(expected, actual);
        }

        [Theory, MemberData(nameof(RemoveStringsIEnumTestData_CaseSensetive))]
        public void Remove_ConsiderCase_IEnum(string testString, IEnumerable<string> stringsToRemove, string expected)
        {
            string actual = testString.Remove(stringsToRemove);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Lorem lorem IPSUM ipsum", "   ")]
        [InlineData("lorem LORem ipSUM IPSUM", "   ")]
        [InlineData("lorem ipsum IPSUM", "  ")]
        public void Remove_IgnoreCase(string testString, string expected)
        {
            string actual = testString.Remove(true, "lorem", "IPSUM");

            Assert.Equal(expected, actual);
        }

        [Theory, MemberData(nameof(RemoveStringsIEnumTestData_CaseInsensetive))]
        public void Remove_IgnoreCase_IEnum(string testString, IEnumerable<string> stringsToRemove, string expected)
        {
            string actual = testString.Remove(true, stringsToRemove);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("b2HGLTxiVJz0cxWacceZ", "bHGLTxiVJzcxWacceZ")]
        [InlineData("S1Rsf3jsE2IPKhIML5kN", "SRsfjsEIPKhIMLkN")]
        [InlineData("xqyao0g2EwQmweZUqy6l", "xqyaogEwQmweZUqyl")]
        public void RemoveNumbers(string testString, string expected)
        {
            string actual = testString.RemoveNumbers();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(@"5riD+p-AvsnZImA@i[(r", @"5riDpAvsnZImAir")]
        [InlineData(@"qnxON$cEX\=i?]3s3MyB", @"qnxONcEXi3s3MyB")]
        [InlineData(@"^{b,H:b{ft^3TU<PZJGd", @"bHbft3TUPZJGd")]
        public void RemoveSpecialCharacters(string testString, string expected)
        {
            string actual = testString.RemoveSpecialCharacters();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(@"rMhj5(VirYg<rS7lWuGZ", @"5(<7")]
        [InlineData(@"gNa/*+Kd($@k+$%8Fj/I", @"/*+($@+$%8/")]
        [InlineData(@"bJcnmhy7<9-h%]wk[dTc", @"7<9-%][")]
        public void RemoveLetters(string testString, string expected)
        {
            string actual = testString.RemoveLetters();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("I was very proud", 1, " was very prou")]
        [InlineData("The father handed", 2, "e father hand")]
        [InlineData("In that instant", 3, "that inst")]
        [InlineData("For oil spots", 4, "oil s")]
        public void Trim_Amount(string testString, int amount, string expected)
        {
            string actual = testString.Trim(amount);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("I was very proud", 1, " was very proud")]
        [InlineData("The father handed", 2, "e father handed")]
        [InlineData("In that instant", 3, "that instant")]
        [InlineData("For oil spots", 4, "oil spots")]
        public void TrimStart_Amount(string testString, int amount, string expected)
        {
            string actual = testString.TrimStart(amount);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("If the Easter Bunny and the Tooth Fairy had babies would they take your teeth and leave chocolate for you?", "If the Easter", " Bunny and the Tooth Fairy had babies would they take your teeth and leave chocolate for you?")]
        [InlineData("As he waited for the shower to warm", "As he waited ", "for the shower to warm")]
        [InlineData("I love eating toasted cheese and tuna sandwiches.", "I lov", "e eating toasted cheese and tuna sandwiches.")]
        [InlineData("The light in his life was actually a fire burning all around him.", "The light in him", "The light in his life was actually a fire burning all around him.")]
        public void TrimStart(string testString, string stringToRemove, string expected)
        {
            string actual = testString.TrimStart(stringToRemove);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("If the Easter Bunny and the Tooth Fairy had babies would they take your teeth and leave chocolate for you?", "iF the Easter", " Bunny and the Tooth Fairy had babies would they take your teeth and leave chocolate for you?")]
        [InlineData("As he waited for the shower to warm", "As HE waited ", "for the shower to warm")]
        [InlineData("I love eating toasted cheese and tuna sandwiches.", "i LOV", "e eating toasted cheese and tuna sandwiches.")]
        [InlineData("The light in his life was actually a fire burning all around him.", "The liGht in him", "The light in his life was actually a fire burning all around him.")]
        public void TrimStart_StringComparison(string testString, string stringToRemove, string expected)
        {
            string actual = testString.TrimStart(stringToRemove, StringComparison.OrdinalIgnoreCase);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("If the Easter Bunny and the Tooth Fairy had babies would they take your teeth and leave chocolate for you?", "iF the Easter", " Bunny and the Tooth Fairy had babies would they take your teeth and leave chocolate for you?")]
        [InlineData("As he waited for the shower to warm", "As HE waited ", "for the shower to warm")]
        [InlineData("I love eating toasted cheese and tuna sandwiches.", "i LOV", "e eating toasted cheese and tuna sandwiches.")]
        [InlineData("The light in his life was actually a fire burning all around him.", "The liGht in him", "The light in his life was actually a fire burning all around him.")]
        public void TrimStart_CultureInfo(string testString, string stringToRemove, string expected)
        {
            string actual = testString.TrimStart(stringToRemove, true, CultureInfo.InvariantCulture);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("I was very proud", 1, "I was very prou")]
        [InlineData("The father handed", 2, "The father hand")]
        [InlineData("In that instant", 3, "In that inst")]
        [InlineData("For oil spots", 4, "For oil s")]
        public void TrimEnd_Amount(string testString, int amount, string expected)
        {
            string actual = testString.TrimEnd(amount);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("If the Easter Bunny and the Tooth Fairy had babies would they take your teeth and leave chocolate for you?", "they take your teeth and leave chocolate for you?", "If the Easter Bunny and the Tooth Fairy had babies would ")]
        [InlineData("As he waited for the shower to warm", "shower to warm", "As he waited for the ")]
        [InlineData("I love eating toasted cheese and tuna sandwiches.", " and tuna sandwiches.", "I love eating toasted cheese")]
        [InlineData("The light in his life was actually a fire burning all around him.", "all around her", "The light in his life was actually a fire burning all around him.")]
        public void TrimEnd(string testString, string stringToRemove, string expected)
        {
            string actual = testString.TrimEnd(stringToRemove);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("If the Easter Bunny and the Tooth Fairy had babies would they take your teeth and leave chocolate for you?", "they take your teeth AND leave chocolate for you?", "If the Easter Bunny and the Tooth Fairy had babies would ")]
        [InlineData("As he waited for the shower to warm", "shower TO warm", "As he waited for the ")]
        [InlineData("I love eating toasted cheese and tuna sandwiches.", " AND tuna sandwiches.", "I love eating toasted cheese")]
        [InlineData("The light in his life was actually a fire burning all around him.", "all around HER", "The light in his life was actually a fire burning all around him.")]
        public void TrimEnd_StringComparison(string testString, string stringToRemove, string expected)
        {
            string actual = testString.TrimEnd(stringToRemove, StringComparison.OrdinalIgnoreCase);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("If the Easter Bunny and the Tooth Fairy had babies would they take your teeth and leave chocolate for you?", "they take your teeth AND leave chocolate for you?", "If the Easter Bunny and the Tooth Fairy had babies would ")]
        [InlineData("As he waited for the shower to warm", "shower TO warm", "As he waited for the ")]
        [InlineData("I love eating toasted cheese and tuna sandwiches.", " AND tuna sandwiches.", "I love eating toasted cheese")]
        [InlineData("The light in his life was actually a fire burning all around him.", "all around HER", "The light in his life was actually a fire burning all around him.")]
        public void TrimEnd_CultureInfo(string testString, string stringToRemove, string expected)
        {
            string actual = testString.TrimEnd(stringToRemove, true, CultureInfo.InvariantCulture);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> RemoveStringsIEnumTestData_CaseSensetive
        {
            get
            {
                return new[]
                {
                    new object[] { "I would have gotten the promotion, but my attendance wasn’t good enough.", new string[] { "gotten", "attendance", "would", "enough" }, "I  have  the promotion, but my  wasn’t good ." },
                    new object[] { "This is the last random sentence I will be writing and I am going to stop mid-sent", new List<string>() { "random ", "writing ", " sentence" }, "This is the last I will be and I am going to stop mid-sent" },
                    new object[] { "Oh, how I'd love to go!", new HashSet<string>() { "how I", ",", "go!" }, "Oh 'd love to " },
                    new object[] { "Rock music approaches at high velocity.", new Queue<string>(new string[] { "Rock ", "music", " approaches", "velocity" }), " at high ." }
                };
            }
        }

        public static IEnumerable<object[]> RemoveStringsIEnumTestData_CaseInsensetive
        {
            get
            {
                return new[]
                {
                    new object[] { "I would have gotten the promotion, but my attendance wasn’t good enough.", new string[] { "gotTen", "promotion", "attenDAnce", "good " }, "I would have  the , but my  wasn’t enough." },
                    new object[] { "This is the last random sentence I will be writing and I am going to stop mid-sent", new List<string>() { "last ", "SEntence", " writing" }, "This is the random  I will be and I am going to stop mid-sent" },
                    new object[] { "Oh, how I'd love to go!", new HashSet<string>() { "Oh, how", "lovE", "GO!" }, " I'd  to " },
                    new object[] { "Rock music approaches at high velocity.", new Queue<string>(new string[] { "musiC", "approaches", "rock", "high " }), "   at velocity." }
                };
            }
        }
    }
}
