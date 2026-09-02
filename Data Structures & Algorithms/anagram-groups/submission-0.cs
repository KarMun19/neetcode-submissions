public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> result = new Dictionary<string, List<string>>(); 
        foreach(var s in strs){
            char[] input = s.ToCharArray();
            Array.Sort(input);
            var ordered = new string(input);
            if(!result.ContainsKey(ordered)){
                result[ordered] = new List<string>(){};
            }           
                result[ordered].Add(s);          
        }
        List<List<string>> stringResult = new List<List<string>>();
        foreach(var r in result){
            stringResult.Add(r.Value);
        }

        return stringResult;
    }
}
