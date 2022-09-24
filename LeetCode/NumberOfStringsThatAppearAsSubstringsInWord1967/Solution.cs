public class Solution
{
    public int NumOfStrings(string[] patterns, string word)
    {
        int result = 0;
        int length = patterns.Length;
        for (int i = 0; i < length; ++i)
        {
            if (word.Contains(patterns[i]))
            {
                ++result;
            }
        }

        return result;
    }
}