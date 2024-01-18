public class Solution {
    public string solution(string s) {
        string answer = "";
        answer = ((s.Length % 2 == 1) ? "" : s[s.Length / 2 - 1].ToString())+s[s.Length / 2].ToString();
        return answer;
    }
}