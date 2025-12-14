using System.Linq;

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Count();
        int Sum = n * (n + 1);
        int SumTotals = Sum / 2;
        int actualSum = nums.Sum();
        return SumTotals - actualSum;
    }
}
