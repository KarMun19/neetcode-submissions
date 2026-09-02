public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequency = new Dictionary<int, int>();

        foreach(var n in nums){
            if(!frequency.ContainsKey(n))
                frequency[n] = 0;
            frequency[n]++;
        }
 
        int[] result = new int[k];
        List<int> sorted = frequency.OrderByDescending(x=>x.Value).Select(x=>x.Key).ToList();
        for(int i = 0; i < k; i++){
            result[i] = sorted[i];
        }
        return result;
    }
}
