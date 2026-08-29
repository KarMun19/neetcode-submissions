public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int,int> needed = new Dictionary<int,int>();
        for(int i = 0; i<nums.Length; i++){
           var curr = nums[i];
           if(needed.ContainsKey(curr))
           return new int[]{needed[curr],i};
           
           var newTarget = target - curr;
           needed[newTarget] =i;
        }

        return Array.Empty<int>();
    }
}
