using LongestSubstringWithoutRepeatingCharacters;

Solution sol = new Solution();
Console.WriteLine($"\"abcabcbb\" - expected 3 and got: {sol.LengthOfLongestSubstring("abcabcbb")}");
Console.WriteLine($"\" \" - expected 1 and got: {sol.LengthOfLongestSubstring(" ")}");
Console.WriteLine($"\"\" - expected 0 and got: {sol.LengthOfLongestSubstring("")}");
Console.WriteLine($"\"dvdf\" - expected 3 and got: {sol.LengthOfLongestSubstring("dvdf")}");