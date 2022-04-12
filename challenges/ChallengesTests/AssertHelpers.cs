using NUnit.Framework;

namespace ChallengesTests;

public static class AssertHelpers
{
    public static void ShouldBe(this object actual, object expected)
    {
        Assert.AreEqual(expected, actual);
    }
}