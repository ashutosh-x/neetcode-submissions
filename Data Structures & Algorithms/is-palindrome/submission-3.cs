public class Solution {
    public bool IsPalindrome(string s) {
        string cleaned = "";
        foreach (var item in s) {
            if (char.IsLetterOrDigit(item)) {
                cleaned += char.ToLower(item);
            }
        }
        cleaned = cleaned.Replace(" ", "");

        int i = 0;
        int j = cleaned.Length - 1;

        if (cleaned.Length == 0) {
            return true;
        }
        if (cleaned.Length >= 1 && cleaned.Length <= 1000) {
            while (i < j) {
                if (cleaned[i] != cleaned[j]) {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        } else {
            return false;
        }
    }
}