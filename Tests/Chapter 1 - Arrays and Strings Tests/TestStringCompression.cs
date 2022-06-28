using Implementations.Chapter_1___Arrays_and_Strings;
using NUnit.Framework;

namespace TestProject1.Chapter_1___Arrays_and_Strings_Tests; 

public class TestStringCompression {

    [Test,
    TestCase("aabccccaaa", "a2b1c4a3"),
    TestCase("abcddDefghijabcdd", "abcddDefghijabcdd"),
    TestCase("aabbccddeeffgg", "aabbccddeeffgg"),
    TestCase("aabbccdddeeffgg", "a2b2c2d3e2f2g2"),
    TestCase("aabbbbc", "a2b4c1"),
    TestCase("a", "a"),
    TestCase("aa", "aa"),
    TestCase("EEE", "E3"),
    TestCase("", "")]
    public void StringCompression_Should_Succeed(string given, string expected) {
        Assert.AreEqual(expected, given.CompressString_Brute());
    }
}
