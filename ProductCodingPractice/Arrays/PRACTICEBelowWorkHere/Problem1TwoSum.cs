//TIME: 45 minutes , Easy:10pts, Med:20pts, Hard:30pts

public class Set1Problem1TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];

        for (int i = 0; i < nums.Length - 1; i++)
        {
            int j = i;
            for (j = j + 1; j < nums.Length; j++)
            {
                if ((nums[i] + nums[j]) == target)
                {
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
            }
        }

        return null;
    }

}

// SCORE: 7.5/10