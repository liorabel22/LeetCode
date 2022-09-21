namespace LongestSubstringWithoutRepeatingCharacters;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int[] lut = new int[256];
        int maxLength = 0;
        int left = 0;


        for (int right = 0; right < s.Length; ++right)
        {
            int index = lut[(int)s[right]];
            if (index == 0)
            {
                lut[(int)s[right]] = right + 1;
            }
            else
            {
                left = (index > left) ? index : left;
                lut[(int)s[right]] = right + 1;
            }
            maxLength = CheckLength(maxLength, left, right + 1);
        }

        return maxLength;
    }

    private int CheckLength(int maxLength, int leftIndex, int rightIndex)
    {
        return ((maxLength > (rightIndex - leftIndex)) ? maxLength : (rightIndex - leftIndex));
    }
}
