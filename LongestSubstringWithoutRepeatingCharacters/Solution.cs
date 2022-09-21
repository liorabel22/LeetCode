namespace LongestSubstringWithoutRepeatingCharacters;

public class Solution
{
    int[] lut = new int[256];
    public int LengthOfLongestSubstring(string s)
    {
        int maxSum = 0;
        int currentSum = 0;


        InitialLut();
        for (int i = 0; i < s.Length; ++i)
        {
            for (int j = i; j < s.Length; ++j)
            {
                lut[s[j]]++;
                if (lut[s[j]] > 1)
                {
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                    currentSum = 0;
                    InitialLut();
                    lut[s[j]]++;
                }
                currentSum++;
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
            currentSum = 0;
            InitialLut();
        }

        return maxSum;
    }

    private void InitialLut()
    {
        for (int i = 0; i < 256; ++i)
        {
            lut[i] = 0;
        }
    }
}
