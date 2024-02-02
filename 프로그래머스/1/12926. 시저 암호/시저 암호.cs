using System;
public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        char[] ch = s.ToCharArray();
        int temp = 0;
        for(int i = 0; i<ch.Length; i++){
            temp = ch[i];
            if(temp == 32){
                answer += "";
            }
            else if((temp >= 65 && temp <= 90 && temp + n > 90)||(temp >= 97 && temp <= 122 && temp + n > 122)){
                temp = temp + n - 26;
            }
            else{
                temp += n;
            }
            answer += Convert.ToChar(temp).ToString();
        }
        
        return answer;
    }
}