Solution solution = new Solution();

string[] patterns1 = {"a", "abc", "bc", "d"};
string[] patterns2 = { "a", "b", "c" };
string[] patterns3 = { "a", "a", "a" };

Console.WriteLine($"patterns = [\"a\",\"abc\",\"bc\",\"d\"], word = \"abc\" - expected: 3 - got: {solution.NumOfStrings(patterns1, "abc")}");
Console.WriteLine($"patterns = [\"a\",\"b\",\"c\"], word = \"aaaaabbbbb\" - expected: 2 - got: {solution.NumOfStrings(patterns2, "aaaaabbbbb")}");
Console.WriteLine($"patterns = [\"a\",\"a\",\"a\"], word = \"ab\" - expected: 3 - got: {solution.NumOfStrings(patterns3, "ab")}");