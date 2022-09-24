using System.Text;

public class Solution
{
    public int ConcatenatedBinary(int n)
    {
        long startNumber = 1;
        bool enter = true;
        List<long> list = new List<long>() { startNumber };
        StringBuilder concatenatedBinary = new StringBuilder("1");

        while (n >= list.Count)
        {
            int sizeOfList = list.Count;
            for (int i = 0; i < sizeOfList - 1; ++i)
            {
                if (n == list.Count)
                {
                    enter = false;
                    break;
                }
                long numToAdd = startNumber + list[i];
                list.Add(numToAdd);
                concatenatedBinary.Append(numToAdd.ToString());
            }
            if (enter && (n > list.Count))
            {
                startNumber *= 10;
                list.Add(startNumber);
                concatenatedBinary.Append(startNumber.ToString());
            }
            else
            {
                break;
            }
        }


        
        return (int)((BinaryToDecimal(concatenatedBinary) % (long)(Math.Pow(10, 9) + 7)));
    }

    private long BinaryToDecimal(StringBuilder binary)
    {
        long result = 0;
        long multi = 1;

        while (binary.Length > 0)
        {
            result = result + (int.Parse(binary[^1].ToString()) * multi);
            multi *= 2;
            binary.Remove(binary.Length - 1, 1);
        }

        return result;
    }
}