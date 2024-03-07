using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        int same = 0;
        int diff = 0;
        
        char first = s[0];
        
        for (int i = 0; i < s.Length; i++)
        {
            if(same == 0) first = s[i];
            if(first == s[i]) same++;
            else diff++;
            
            if(same == diff){
                answer++;
                same = 0;
                diff = 0;
            }
            else
            {
                if(i+1 >= s.Length) answer++;
            }
        }
        
        
        return answer;
    }
}