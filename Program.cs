using System;

class Program
{
    static void Main()
    {
        int samDaily = Convert.ToInt32(Console.ReadLine());
        int kellyDaily =Convert.ToInt32(Console.ReadLine());
        int difference = Convert.ToInt32(Console.ReadLine());

        int result = MinNum(samDaily, kellyDaily, difference);
        Console.WriteLine($"Minimum days for Kelly to surpass Sam: {result}");
    }

    static int MinNum(int samDaily, int kellyDaily, int difference)
    {
        int days = 0;

        if (kellyDaily <= samDaily)
            return -1;

        while (difference >= 0)
        {
            difference += samDaily;
            difference -= kellyDaily;
            days++;

            if (difference <= 0)
                return days;
        }

        return -1;
    }

class Cala2
{
    static void Cala()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        int result = FindLongestSubsequence(arr);
        Console.WriteLine($"Length of the longest subsequence: {result}");
    }

    static int FindLongestSubsequence(int[] arr)

    {
        //cala
        int n = arr.Length;
        int maxLen = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int[] subsequence = arr.Skip(i).Take(j - i + 1).ToArray();
                Array.Sort(subsequence);

                int sumOfDifferences = subsequence.Zip(subsequence.Skip(1), (a, b) => b - a).Sum();

                if (sumOfDifferences % 2 == 0)
                {
                    maxLen = Math.Max(maxLen, subsequence.Length);
                }
            }
        }

    
        return maxLen;
    }
    
}

}
