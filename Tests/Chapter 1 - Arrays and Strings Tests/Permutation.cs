using Implementations.Chapter_1___Arrays_and_Strings;
using NUnit.Framework;

namespace TestProject1.Chapter_1___Arrays_and_Strings_Tests; 

public class Permutation {

    [Test,
     TestCase("aBaaB", "BBaaa"),
    TestCase("Here we go", "woH gere e"),
    TestCase("AbcD", "cDbA")]
    public void TestPermutation_ReturnsTrue(string a, string b) {
        Assert.IsTrue(a.IsPermutation_Hash(b));
        Assert.IsTrue(a.IsPermutation(b));
    }
    
    [Test,
     TestCase("afekjsal", "ajfhek"),
    TestCase("aaaa", "aaaA"),
    TestCase("abcd", "dcbA"),
    TestCase("Kentucky","kentuckY")]
    public void TestPermutation_ReturnsFalse(string a, string b) {
        Assert.IsFalse(a.IsPermutation_Hash(b));
        Assert.IsFalse(a.IsPermutation(b));
    }
}
