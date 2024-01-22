public class Solution {
    public bool solution(string s) {
        bool answer = true;
        int number;
        answer = int.TryParse(s, out number);
        if(answer){
            if(s.Length ==4 ||s.Length==6) answer =true;
            else answer = false;
        }
        return answer;
    }
}