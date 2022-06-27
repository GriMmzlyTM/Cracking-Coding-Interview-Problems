namespace Implementations.Chapter_1___Arrays_and_Strings; 

public static class OneAwayExtensions {

    /// <summary>
    /// O(N) time, where n is largest string length
    /// O(1) space 
    /// </summary>
    /// <param name="have"></param>
    /// <param name="want"></param>
    /// <returns></returns>
    public static bool OneAway(this string have, string want) {
        if (Math.Abs(have.Length - want.Length) > 1) return false;

        var j = 0;
        var editCount = 0;
        for (int i = 0; i < have.Length; i++) {
            if ( j > want.Length - 1 || have[i] != want[j]) {
                editCount++;
                if (have.Length - i > want.Length - j) continue;
                if (have.Length - i < want.Length - j) i--;
            }
            j++;
        }

        return editCount <= 1;
    }
}
