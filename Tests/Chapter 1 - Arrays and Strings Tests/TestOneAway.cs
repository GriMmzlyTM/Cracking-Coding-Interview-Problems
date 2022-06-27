using Implementations.Chapter_1___Arrays_and_Strings;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;

namespace TestProject1.Chapter_1___Arrays_and_Strings_Tests; 

public class TestOneAway {

    [Test,
    TestCase("pale", "ple"),
    TestCase("pales", "pale"),
    TestCase("pale", "bale"),
    TestCase("bake", "bale"),
    TestCase("harvard", "havard"),
    TestCase("abcde", "fabcde")]
    public void OneAway_Should_BeTrue(string a, string b) {
        Assert.IsTrue(a.OneAway(b));
    }
    
    [Test,
     TestCase("pale", "bake"),
     TestCase("pals", "bal"),
     TestCase("harvard", "havrardi"),
     TestCase("basket", "basketing"),
     TestCase("abcdefg", "abdgfg"),
     TestCase("abcde", "fabdde"),]
    public void OneAway_Should_BeFalse(string a, string b) {
        Assert.IsFalse(a.OneAway(b));
    }
}
