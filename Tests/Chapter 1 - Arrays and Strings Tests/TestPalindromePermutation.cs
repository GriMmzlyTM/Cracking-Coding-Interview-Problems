using Implementations.Chapter_1___Arrays_and_Strings;
using NUnit.Framework;

namespace TestProject1.Chapter_1___Arrays_and_Strings_Tests; 

public class TestPalindromePermutation {
    [Test,
        TestCase("Tact Coa"),
    TestCase("nun"),
    TestCase("Madam"),
    TestCase("RaceCar")]
    public void TestPalindrome_ReturnsTrue(string str) {
        Assert.IsTrue(str.PalindromePermutation());
        Assert.IsTrue(str.PalindromePermutation_SortedArray());
    }
    
    [Test,
     TestCase("Tact Coaa"),
     TestCase("nuon"),
     TestCase("Neuron"),
     TestCase("Alphabet")]
    public void TestPalindrome_ReturnsFalse(string str) {
        Assert.IsFalse(str.PalindromePermutation());
        Assert.IsFalse(str.PalindromePermutation_SortedArray());
    }
}
