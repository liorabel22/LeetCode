using System.Text;

public class Solution
{
    public int ConcatenatedBinary(int n)
    {
        long result = 0;
        int mod = ((int)Math.Pow(10, 9) + 7);

        for (int i = 1; i <= n; ++i)
        {
            int length = (int)Math.Log2(i) + 1;
            result = (((result << length) % mod) + i) % mod;
        }


        return (int)result;
    }
}