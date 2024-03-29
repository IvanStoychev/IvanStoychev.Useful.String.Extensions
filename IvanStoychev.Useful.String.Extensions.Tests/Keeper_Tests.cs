﻿using Xunit;

namespace IvanStoychev.Useful.String.Extensions.Tests;

public class Keeper_Tests
{
    [Theory]
    [InlineData("awd1dkb33aljfo39d109j1082jd", "133391091082")]
    [InlineData("PTwXUV2zFdtYHtUMltxF", "2")]
    [InlineData("0PhTjDt3prG0ixqqmFf5", "0305")]
    public void KeepOnlyNumbers(string testString, string expected)
    {
        string actual = testString.KeepOnlyNumbers();

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(@"F*H3g=n*-!9ZaHL)k%uPQ=", @"*=*-!)%=")]
    [InlineData(@"*Uk%%K+Re6&e!u9wV/)PC", @"*%%+&!/)")]
    [InlineData(@"YckU$QV%-1d*-6MDRKnQq", @"$%-*-")]
    public void KeepOnlySpecialCharacters(string testString, string expected)
    {
        string actual = testString.KeepOnlySpecialCharacters();

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(@"6=XKjumEULTE54j%%W6g", @"XKjumEULTEjWg")]
    [InlineData(@"bzKGOeQS)+59caKeE#f9", @"bzKGOeQScaKeEf")]
    [InlineData(@"f(KRiWrbn5sNn8/JHatr", @"fKRiWrbnsNnJHatr")]
    public void KeepOnlyLetters(string testString, string expected)
    {
        string actual = testString.KeepOnlyLetters();

        Assert.Equal(expected, actual);
    }
}
