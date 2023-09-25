namespace Task1;
public static class Task1
{
    public static int NumbersSum(params int[] nums)
    {
        var sum = nums.Sum(x => x);
        return sum;
    }
}
