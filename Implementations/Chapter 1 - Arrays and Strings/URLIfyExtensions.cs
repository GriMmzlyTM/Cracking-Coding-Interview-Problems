using System.Text;

namespace Implementations.Chapter_1___Arrays_and_Strings; 

public static class URLIfyExtensions {

    public static string URLify_StringBuilder(this string str) {
        var sb = new StringBuilder();

        for (int i = 0; i < str.Length; i++) {
            var c = str[i];
            if (char.IsWhiteSpace(c)) continue;
            if (i != 0 && char.IsWhiteSpace(str[i - 1])) sb.Append("%20");
            sb.Append(c);
        }

        return sb.ToString();
    }
    
    public static string URLify_Array(this string str) {

        var charArr = str.ToCharArray();

        var currStringIndex = charArr.Length - 1;
        for (int i = currStringIndex; i != 0; i--) {
            var c = str[i];
            if (char.IsWhiteSpace(c)) continue;
            if (currStringIndex != charArr.Length - 1 && char.IsWhiteSpace(str[i + 1])) {
                charArr[currStringIndex--] = '0';
                charArr[currStringIndex--] = '2';
                charArr[currStringIndex--] = '%';
            }
            charArr[currStringIndex--] = c;
        }

        return new string(charArr);
    }
}
