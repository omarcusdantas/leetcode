public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        var hashS = new Dictionary<char, int>();
        var hashT = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            hashS[s[i]] = hashS.ContainsKey(s[i]) ? hashS[s[i]]++ : 1;
            hashT[t[i]] = hashT.ContainsKey(t[i]) ? hashT[t[i]]++ : 1;
        }

        foreach (var item in hashS)
        {
            if(!hashT.ContainsKey(item.Key) || hashT[item.Key] != item.Value) return false;
        }

        return true;
    }

    public bool IsAnagram2(string s, string t) {
        if(s.Length != t.Length) return false;

        var sortedS = new string(s.OrderBy(c => c).ToArray());
        var sortedT = new string(t.OrderBy(c => c).ToArray());

        return sortedS == sortedT;
    }
}
