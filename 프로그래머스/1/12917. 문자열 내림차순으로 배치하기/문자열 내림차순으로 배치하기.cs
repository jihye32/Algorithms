using System;
using System.Linq;
public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] str = s.ToCharArray();
        foreach(char st in str.OrderByDescending(x=>x)){
            answer += st.ToString();
        }
        return answer;
    }
}