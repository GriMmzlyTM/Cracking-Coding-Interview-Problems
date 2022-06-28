using System.Text;

namespace Implementations.Chapter_1___Arrays_and_Strings; 

public static class StringCompressionExtensions {
    
    /// <summary>
    /// O(N) time
    /// O(N) space complexity (Stringbuilder)
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string CompressString_Brute(this string str) {
        if (str.Length <= 1) return str;

        var sb = new StringBuilder();
        
        var lastChar = str[0];
        var charCount = 1;
        
        for (int i = 1; i < str.Length; i++) {
            var val = str[i];

            if (lastChar == val) charCount++;
            else {
                sb.Append($"{lastChar}{charCount}");
                lastChar = val;
                charCount = 1;
            }
            
            if (i == str.Length - 1)
                sb.Append($"{lastChar}{charCount}");
        }

        var compressedString = sb.ToString();
        return compressedString.Length < str.Length ? compressedString : str;
    }
}
