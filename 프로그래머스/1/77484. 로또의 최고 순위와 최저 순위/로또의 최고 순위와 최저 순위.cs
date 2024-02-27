using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2]; //최소 등수, 최대 등수
        
        int zero_count = 0;
        int equal_count = 0;
        for(int i = 0; i< lottos.Length; i++){
            if(lottos[i]==0) zero_count++;
            else{
                for(int j = 0; j < win_nums.Length;j++){
                    if(lottos[i] == win_nums[j]){
                        equal_count++;
                        break;
                    }
                }
            }
        }
        //최대값
        answer[0] = 7 - equal_count - zero_count;
        if(answer[0] == 7){
            answer[0] = 6;
        }
        //최소값
        answer[1] = 7 - equal_count;
        if(answer[1] == 7){
            answer[1] = 6;
        }
        return answer;
    }
}