using challenges;
using challenges.Challenges;
using NUnit.Framework;

namespace ChallengesTests.Challenges;

public class WhatsTheTimeTests
{
    private WhatsTheTime GetChallenge => new WhatsTheTime();
    
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("01:35", "1110010000111011110101100100010100101001000011101111010010010001000111101110001110111")]
    [TestCase("02:46", "1110111000101010010100010101010100101011100011101111010100010001010111101110000010111")]
    [TestCase("17:29", "0100111000111011111000010100010101010000100011101110100001010100000111100010001110001")]
    [TestCase("23:58", "1110111000111011100100010101000101111011100011101111000001010001010111101110001110111")]
    public void Solve_TestInput_HasCorrectResponse(
        string expected,
        string input)
    {
        var challenge = GetChallenge;
        var result = challenge.Solve(input);
        result.ShouldBe(expected);
    }
    
    [TestCase("01:35", "1110010000111011110101100100010100101001000011101111010010010001000111101110001110111")]
    public void Solve_TestInput_FindsFirstNumber(
        string expected,
        string input)
    {
        var challenge = GetChallenge;
        var result = challenge.Solve(input);
        result[0].ShouldBe(expected[0]);
    }
    
    [TestCase("01:35", "1110010000111011110101100100010100101001000011101111010010010001000111101110001110111")]
    public void Solve_TestInput_FindsSecondNumber(
        string expected,
        string input)
    {
        var challenge = GetChallenge;
        var result = challenge.Solve(input);
        result[1].ShouldBe(expected[1]);
    }
    
    [TestCase("01:35", "1110010000111011110101100100010100101001000011101111010010010001000111101110001110111")]
    public void Solve_TestInput_FindsSeperatorNumber(
        string expected,
        string input)
    {
        var challenge = GetChallenge;
        var result = challenge.Solve(input);
        result[2].ShouldBe(expected[2]);
    }
    
    [TestCase("01:35", "1110010000111011110101100100010100101001000011101111010010010001000111101110001110111")]
    public void Solve_TestInput_FindsThirdNumber(
        string expected,
        string input)
    {
        var challenge = GetChallenge;
        var result = challenge.Solve(input);
        result[3].ShouldBe(expected[3]);
    }
        
    [TestCase("01:35", "1110010000111011110101100100010100101001000011101111010010010001000111101110001110111")]
    public void Solve_TestInput_FindsFourthNumber(
        string expected,
        string input)
    {
        var challenge = GetChallenge;
        var result = challenge.Solve(input);
        result[4].ShouldBe(expected[4]);
    }
}