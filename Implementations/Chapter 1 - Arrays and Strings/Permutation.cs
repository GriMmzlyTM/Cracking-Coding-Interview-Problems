namespace Implementations.Chapter_1___Arrays_and_Strings; 

public static class Permutation {
    public static bool IsPermutation_Hash(this string a, string b) {
        if (a.Length != b.Length) return false;
        
        var aValues = new HashSet<char>(a);

        for (int i = 0; i < b.Length; i++) {
            if (!aValues.Contains(b[i])) return false;
        }
        
        return true;
    }

    public static bool IsPermutation(this string a, string b) {
        if (a.Length != b.Length) return false;
        if (SortString(a) != SortString(b)) return false;
        
        return true;
    }

    private static string SortString(string str) {
        var charArr = str.ToCharArray();
        Array.Sort(charArr);
        return new string(charArr);
    }  
}
