public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = new int[nums.Length*2];
        {
            int j = 0;
            for(int i = 0; i<nums.Length; i++)
            {
                ans[j] = nums[i];
                j++;
                if(j == ((nums.Length*2)))
                {
                    return ans;
                }
                if(i == nums.Length-1)
                {
                    i = -1;
                }
            }
            return ans;
        }
    }
}