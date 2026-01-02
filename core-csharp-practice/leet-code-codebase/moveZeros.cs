using System;

class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int index = 0; // position for next non-zero element

        // Move all non-zero elements to the front
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[index] = nums[i];
                index++;
            }
        }

        // Fill remaining positions with zero
        for (int i = index; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}
