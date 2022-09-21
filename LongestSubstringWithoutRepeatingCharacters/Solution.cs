namespace LongestSubstringWithoutRepeatingCharacters;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int[] lut = new int[128];
        int maxLength = 0;
        int left = 0;
        int stringLength = s.Length;


        for (int right = 0; right < stringLength; ++right)
        {
            char charAtRight = s[right];
            int index = lut[charAtRight];
            if (index != 0)
            {
                
                left = Math.Max(index, left);
            }
            lut[charAtRight] = right + 1;
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
