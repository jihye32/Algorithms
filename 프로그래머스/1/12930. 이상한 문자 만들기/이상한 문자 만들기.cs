public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] str = s.Split(" ");
        for(int i =0; i<str.Length;i++){
            for(int j = 0; j<str[i].Length;j++){
                string uplow = str[i];
                if(j%2 == 0){
                    answer += uplow[j].ToString().ToUpper();
                }
                else if(j%2==1){
                    answer += uplow[j].ToString().ToLower();
                }
            }
            if(i != str.Length -1) answer += " ";
            else break;
        }
        return answer;
    }
}