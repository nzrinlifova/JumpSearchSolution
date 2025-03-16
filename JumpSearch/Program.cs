using System;

class JumpSearch
{
    public static int JumpSearchMethod(int[] nums, int target)
    {
        int n = nums.Length;
        int step = (int)Math.Sqrt(n); 

        int first = 0;
        while (nums[Math.Min(step, n) - 1] < target)
        {
            first = step;
            step += (int)Math.Sqrt(n);
            if (first >= n) return -1;
        }

       
        for (int i = first; i < Math.Min(step, n); i++)
        {
            if (nums[i] == target)
                return i;
        }

        return -1; 
    }

    static void Main()
    {
        int[] nums = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
        int target = 15;

        int index = JumpSearchMethod(nums, target);
        Console.WriteLine(index != -1 ? $"Elementin indeksi: {index}" : "Element tapılmadı");
    }
}