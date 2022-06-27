using System.Drawing;

namespace Implementations.Chapter_1___Arrays_and_Strings; 

public static class PalindromePermutationExtensions {

    public static bool PalindromePermutation(this string str) {
        var t = new Dictionary<char, int>();
        
        foreach (var c in str.ToLower()) {
            if (char.IsWhiteSpace(c)) continue;
            if (!t.TryAdd(c, 1)) t[c]++;
        }

        var oddCount = 0;
        foreach (var (key, val) in t) {
            if (val % 2 != 0) oddCount++;

            if (oddCount >= 2) return false;
        }

        return true;
    }
    
    public static bool PalindromePermutation_SortedArray(this string str) {
        var sortedString = str.ToLower().SortString();

        var oddCount = 0;
        var currCharCount = 0;
        var currChar = sortedString[0];
        
        for (int i = 0; i < sortedString.Length; i++) {
            var c = sortedString[i];
            if (char.IsWhiteSpace(c)) continue;
             
            if (currChar == sortedString[i]) {
                currCharCount++;
                continue;
            }
            
            if (currCharCount % 2 != 0 && ++oddCount > 1) return false;

            currChar = sortedString[i];
            currCharCount = 1;
        }

        if (currCharCount % 2 != 0) oddCount++;
      
        return oddCount <= 1;
    }

    private static string SortString(this string str) {
        var charArr = str.ToCharArray();
        Array.Sort(charArr);
        return new string(charArr);
    }
}
