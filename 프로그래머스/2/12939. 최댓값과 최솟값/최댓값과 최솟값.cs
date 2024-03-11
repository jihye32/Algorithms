using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] str = s.Split(' ');
        List<int> list = new List<int>();
        
        foreach (string ss in str)
        {
            list.Add(int.Parse(ss));
        }
        return $"{list.Min()} {list.Max()}";
    }
}