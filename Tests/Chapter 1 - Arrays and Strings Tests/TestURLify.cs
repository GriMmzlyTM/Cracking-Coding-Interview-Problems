using Implementations.Chapter_1___Arrays_and_Strings;
using NUnit.Framework;

namespace TestProject1.Chapter_1___Arrays_and_Strings_Tests; 

public class TestURLify {
    
    [Test,
     TestCase("Hello how are you      ", "Hello%20how%20are%20you"),
     TestCase("Alrighty", "Alrighty"),
     TestCase("That's awesome!  ", "That's%20awesome!")]
    public void TestUrlify(string given, string expected) {
        Assert.AreEqual(given.URLify_StringBuilder(), expected);
        Assert.AreEqual(given.URLify_Array(), expected);
    }
}
