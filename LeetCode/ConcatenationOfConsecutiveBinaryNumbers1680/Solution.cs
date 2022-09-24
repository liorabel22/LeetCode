using System.Text;

public class Solution
{
    public int ConcatenatedBinary(int n)
    {
        StringBuilder concatenatedBinary = new StringBuilder();

        for (int i = 1; i <= n; ++i)
        {
            long num = 0;
            concatenatedBinary.Append(Convert.ToString(i, toBase: 2));
            num = Convert.ToInt64(concatenatedBinary.ToString(), fromBase: 2) % (int)(Math.Pow(10, 9) + 7);
            concatenatedBinary.Clear();
            concatenatedBinary.Append(Convert.ToString(num, toBase: 2));
        }


        return (int)(Convert.ToInt64(concatenatedBinary.ToString(), fromBase: 2) % (int)(Math.Pow(10, 9) + 7));
    }
}