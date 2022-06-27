using NUnit.Framework;
using Implementations.Chapter_1___Arrays_and_Strings;
using Moq;

namespace TestProject1.Chapter_1___Arrays_and_Strings_Tests; 

public class IsUniqueStringTests {

    [Test,
     TestCase("helo"),
    TestCase("abcdefg"),
    TestCase("uYjIsldKeW"),
    TestCase("a")]
    public void Test_IsUniqueString_ReturnsTrue(string s) {
        Assert.IsTrue(IsUniqueString.IsUnique_UsingArray(s));
        Assert.IsTrue(IsUniqueString.IsUnique_UsingFlags(s));
        Assert.IsTrue(IsUniqueString.IsUnique_UsingHash(s));
        Assert.IsTrue(IsUniqueString.IsUnique_BruteForce(s));
    }
    
    [Test,
     TestCase("HfhsjUH"),
     TestCase("asdgfhjklfhryuchd"),
     TestCase("UfyJSieKSlwoksLSKxncvmvnHGJ"),
    TestCase("baab")]
    public void Test_IsUniqueString_ReturnsFalse(string s) {
        Assert.IsFalse(IsUniqueString.IsUnique_UsingArray(s));
        Assert.IsFalse(IsUniqueString.IsUnique_UsingHash(s));
        Assert.IsFalse(IsUniqueString.IsUnique_UsingFlags(s));
        Assert.IsFalse(IsUniqueString.IsUnique_BruteForce(s));
    }
}
