using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        char[] c = s.ToCharArray();
        
        answer[0] = -1;
        
        for(int i = 0; i < c.Length - 1; i++)
        {
            for(int j = i + 1; j < c.Length; j++){
                if(c[i] == c[j])
                {
                    answer[j] = j - i;
                    break;
                }
                else
                {
                    if(answer[j] == 0)
                    {
                        answer[j] = -1;
                    }
                }
            }
            
        }
        
        return answer;
    }
}