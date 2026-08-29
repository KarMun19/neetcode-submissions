public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        return false;
        Dictionary<char,int> sMap = new Dictionary<char, int>();
        Dictionary<char,int> tMap = new Dictionary<char, int>();
        for(var i = 0; i< s.Length; i++){
            if(sMap.ContainsKey(s[i]))
                sMap[s[i]]++;
            else
                sMap.Add(s[i], 1);

                if(tMap.ContainsKey(t[i]))
                tMap[t[i]]++;
                else 
                tMap.Add(t[i],1);
        }

        foreach(var m in sMap){
            if(!tMap.ContainsKey(m.Key) || (tMap.ContainsKey(m.Key) && tMap[m.Key] != m.Value))
            return false;
        }

        return true;

    }
}
