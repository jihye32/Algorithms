using System;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        int[] have = new int[n];
        
        //체육복을 도난 당하면 0 여분의 체육복이 있으면 2 자신이 사용할 체육복만 있으면 1
        for(int i = 0; i < n; i++){
            have[i] = 1;
        }
        for(int i = 0; i< lost.Length; i++){
            have[lost[i] - 1] = 0;
        }
        for(int i = 0; i< reserve.Length; i++){
            have[reserve[i] - 1] += 1;
        }
        
        for(int i = 0; i< have.Length - 1; i++){
            if(have[i] + have[i + 1] == 2){
                have[i] =1;
                have[i+1] =1;
            }
        }
        
        for(int i = 0; i < have.Length; i++){
            if(have[i] >= 1) answer++;
        }
        
        return answer;
    }
}