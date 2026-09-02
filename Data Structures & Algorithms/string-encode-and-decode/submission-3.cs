public class Solution {

    public string Encode(IList<string> strs) {
        if(strs.Count == 0)
        return "";

        List<int> sizes = new List<int>();
        StringBuilder result = new StringBuilder();
        foreach(var s in strs){
            sizes.Add(s.Length);
        }

        foreach(var sz in sizes){
            result.Append(sz).Append(',');
        }

        result.Append('#');
        foreach(var s in strs){
            result.Append(s);
        }
        return result.ToString();
    }

    public List<string> Decode(string s) {
        if(s.Length == 0)
        return new List<string>();

        List<int> sizes = new List<int>();
        List<string> result = new List<string>();

        int i = 0;
        while(s[i] != '#'){
            int j = i;
            while(s[j] != ','){
                j++;
            }
            sizes.Add(int.Parse(s.Substring(i, j-i)));
            i = j+1;
        }

        i++;

        foreach(var sz in sizes)
        {
            result.Add(s.Substring(i, sz));
            i+= sz;
        }

        return result;
   }
}
