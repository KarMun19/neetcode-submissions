public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        return false;
        Dictionary<char,int> map = new Dictionary<char, int>();

        foreach(var c in s){
            if(map.ContainsKey(c)){
                map[c]++;
            }
            else{
                map.Add(c, 1);
            }
        }

        foreach(var c in t){
            if(map.ContainsKey(c))
            map[c]--;
            else
            return false;
        }

        return map.Values.All(x=>x == 0);

    }
}
