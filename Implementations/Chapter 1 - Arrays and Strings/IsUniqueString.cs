namespace Implementations.Chapter_1___Arrays_and_Strings; 

public static class IsUniqueString {

    // Does Case sensitive uniqueness
    public static bool IsUnique_UsingHash(string s) {
        var existingValues = new HashSet<char>();

        for (int i = 0; i < s.Length; i++) {
            if (!existingValues.Add(s[i])) return false;
        }

        return true;
    }

    /// <summary>
     /// O(n) time, O(1) space
     /// </summary>
     /// <param name="s"></param>
     /// <returns></returns>
    public static bool IsUnique_UsingFlags(string s) {
        var existingValues = 0;

        for (int i = 0; i < s.Length; i++) {
            var val = s[i];

            if ((existingValues & (1 << val)) > 0) return false;
            existingValues |= (1 << val);
        }

        return true;
    }

    /// <summary>
    /// O(n) time complexity
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static bool IsUnique_UsingArray(string s) {
        if (s.Length > 128) return false;
        
        var existingValues = new bool[128];

        for (int i = 0; i < s.Length; i++) {
            var val = char.ToLower(s[i]) - 'a';

            if (existingValues[val]) return false;
            existingValues[val] = true;
        }

        return true;
    }

    /// <summary>
    /// O(N^2) time complexity
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static bool IsUnique_BruteForce(string s) {
        for (int i = 0; i < s.Length; i++) {
            for (int j = i + 1; j < s.Length; j++) {
                if (s[i] == s[j]) return false;
            }
        }

        return true;
    }
}
