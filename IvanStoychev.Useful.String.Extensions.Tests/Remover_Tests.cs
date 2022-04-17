﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Remover_Tests
{
    #region public static string Remove(this string str, IEnumerable<string> removeStrings, StringComparison stringComparison = StringComparison.CurrentCulture)

    [Theory, MemberData(nameof(Data_Remove_DefaultComparison_Pass))]
    public void Remove_DefaultComparison_Pass(string testString, IEnumerable<string> removeStrings, string expectedString)
    {
        string actualString = testString.Remove(removeStrings);

        Assert.Equal(expectedString, actualString);
    }

    [Theory, MemberData(nameof(Data_Remove_SetComparison_Pass))]
    public void Remove_SetComparison_Pass(string testString, IEnumerable<string> removeStrings, StringComparison stringComparison, string expectedString)
    {
        string actualString = testString.Remove(removeStrings, stringComparison);

        Assert.Equal(expectedString, actualString);
    }

    #endregion public static string Remove(this string str, IEnumerable<string> removeStrings, StringComparison stringComparison = StringComparison.CurrentCulture)

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

    #region TrimStart

    [Theory]
    [InlineData("If the Easter Bunny and the Tooth Fairy had babies would they take your teeth and leave chocolate for you?", "If the Easter", " Bunny and the Tooth Fairy had babies would they take your teeth and leave chocolate for you?")]
    [InlineData("As he waited for the shower to warm", "As he waited ", "for the shower to warm")]
    [InlineData("I love eating toasted cheese and tuna sandwiches.", "I lov", "e eating toasted cheese and tuna sandwiches.")]
    [InlineData("The light in his life was actually a fire burning all around him.", "The light in him", "The light in his life was actually a fire burning all around him.")]
    public void TrimStart_DefaultComparison_Pass(string testString, string stringToRemove, string expected)
    {
        string actual = testString.TrimStart(stringToRemove);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("encyclopædia Case Archæology", "encyclopædia", StringComparison.InvariantCulture, " Case Archæology")]
    [InlineData("Case encyclopædia Archæology", "case", StringComparison.InvariantCultureIgnoreCase, " encyclopædia Archæology")]
    [InlineData("Archæology encyclopædia Case", "Archæology", StringComparison.Ordinal, " encyclopædia Case")]
    [InlineData("Archæology encyclopædia Case", "archæology", StringComparison.OrdinalIgnoreCase, " encyclopædia Case")]
    public void TrimStart_SetComparison_Pass(string testString, string stringToRemove, StringComparison stringComparison, string expectedString)
    {
        string actual = testString.TrimStart(stringToRemove, stringComparison);

        Assert.Equal(expectedString, actual);
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

    #endregion TrimStart

    #region TrimEnd

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
    [InlineData("Case Archæology encyclopædia", "encyclopædia", StringComparison.InvariantCulture, "Case Archæology ")]
    [InlineData("encyclopædia Archæology Case", "case", StringComparison.InvariantCultureIgnoreCase, "encyclopædia Archæology ")]
    [InlineData("encyclopædia Case Archæology", "Archæology", StringComparison.Ordinal, "encyclopædia Case ")]
    [InlineData("encyclopædia Case Archæology", "archæology", StringComparison.OrdinalIgnoreCase, "encyclopædia Case ")]
    public void TrimEnd_SetComparison_Pass(string testString, string stringToRemove, StringComparison stringComparison, string expectedString)
    {
        string actual = testString.TrimEnd(stringToRemove, stringComparison);

        Assert.Equal(expectedString, actual);
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

    #endregion TrimEnd

    public static IEnumerable<object[]> Data_Remove_DefaultComparison_Pass
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

    public static IEnumerable<object[]> Data_Remove_SetComparison_Pass
    {
        get
        {
            return new[]
            {
                new object[] { "Case encyclopædia Archæology", new string[] { "case", "encyclopædia", "ARCHÆOLOGY" }, StringComparison.InvariantCulture, "Case  Archæology" },
                new object[] { "Case encyclopædia Archæology", new List<string>() { "Case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.InvariantCulture, " encyclopædia Archæology" },
                new object[] { "Case encyclopædia Archæology", new HashSet<string>() { "case", "encyclopaedia", "Archæology" }, StringComparison.InvariantCulture, "Case encyclopædia " },
                new object[] { "Case encyclopædia Archæology", new Queue<string>(new string[] { "Case", "encyclopædia", "Archæology" }), StringComparison.InvariantCulture, "  " },

                new object[] { "Case encyclopædia Archæology", new string[] { "case", "encyclopaedia", "ARCHAEOLOGY" }, StringComparison.InvariantCultureIgnoreCase, " encyclopædia Archæology" },
                new object[] { "Case encyclopædia Archæology", new List<string>() { "kase", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.InvariantCultureIgnoreCase, "Case encyclopædia " },
                new object[] { "Case encyclopædia Archæology", new HashSet<string>() { "kase", "ENCYCLOPÆDIA", "ARCHAEOLOGY" }, StringComparison.InvariantCultureIgnoreCase, "Case  Archæology" },
                new object[] { "Case encyclopædia Archæology", new Queue<string>(new string[] { "case", "ENCYCLOPÆDIA", "ARCHÆOLOGY" }), StringComparison.InvariantCultureIgnoreCase, "  " },

                new object[] { "Case encyclopædia Archæology", new string[] { "Case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.Ordinal, " encyclopædia Archæology" },
                new object[] { "Case encyclopædia Archæology", new List<string>() { "case", "encyclopædia", "ARCHÆOLOGY" }, StringComparison.Ordinal, "Case  Archæology" },
                new object[] { "Case encyclopædia Archæology", new HashSet<string>() { "case", "encyclopaedia", "Archæology" }, StringComparison.Ordinal, "Case encyclopædia " },
                new object[] { "Case encyclopædia Archæology", new Queue<string>(new string[] { "case", "encyclopædia", "Archæology" }), StringComparison.Ordinal, "Case  " },

                new object[] { "Case encyclopædia Archæology", new string[] { "case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.OrdinalIgnoreCase, " encyclopædia " },
                new object[] { "Case encyclopædia Archæology", new List<string>() { "case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.OrdinalIgnoreCase, " encyclopædia " },
                new object[] { "Case encyclopædia Archæology", new HashSet<string>() { "case", "encyclopaedia", "ARCHÆOLOGY" }, StringComparison.OrdinalIgnoreCase, " encyclopædia " },
                new object[] { "Case encyclopædia Archæology", new Queue<string>(new string[] { "case", "encyclopaedia", "ARCHÆOLOGY" }), StringComparison.OrdinalIgnoreCase, " encyclopædia " }
            };
        }
    }
}
