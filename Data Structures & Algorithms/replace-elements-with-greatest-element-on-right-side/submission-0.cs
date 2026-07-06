public class Solution {
    public int[] ReplaceElements(int[] arr) {
        for(int i=0; i<arr.Length - 1 ; i++)
        {
            int max = int.MinValue;
            for(int j=i+1; j<arr.Length; j++)
            {
                max = Math.Max(max,arr[j]);
            }
            arr[i] = max;
        }
        arr[arr.Length-1] = -1;
        return arr;
    }
    
}