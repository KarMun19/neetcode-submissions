public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder result = new StringBuilder();
        foreach(string s in strs){
            result.Append(s.Length).Append('#').Append(s);
        }
        return result.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();

        int i =0;
        while(i< s.Length){
            int j=i;
            while(s[j]!='#'){
                j++;
            }

            int length = int.Parse(s.Substring(i, j-i));
            i = j+1;
            j= i+length;
            result.Add(s.Substring(i, length));
            i=j;
        }
        return result;
   }
}
