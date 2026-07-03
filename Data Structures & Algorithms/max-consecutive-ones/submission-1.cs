public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        //int ans = nums[0];
        int current = 0;
        int max = 0;//int.MinValue;
        for(int i = 0; i<nums.Length; i++)
        {
            if(nums[i] == 1)
            {
                current++;
                max = Math.Max(current, max);
            }
            else 
            {
                current = 0;
            }
        }
        return max;
    }
}