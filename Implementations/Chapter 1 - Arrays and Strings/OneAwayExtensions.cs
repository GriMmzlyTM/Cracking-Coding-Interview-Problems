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

        var shorterString = have.Length > want.Length ? want : have;
        var primeString = have.Length > want.Length ? have : want;
        
        var j = 0;
        var editCount = 0;
        for (int i = 0; i < primeString.Length; i++) {
            if ( j > shorterString.Length - 1 || primeString[i] != shorterString[j]) {
                editCount++;
                if (primeString.Length - i > shorterString.Length - j) continue;
            }
            j++;
        }

        return editCount <= 1;
    }
}
