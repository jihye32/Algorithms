using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        //k 최댓값, m 포장 갯수
        int box_count = score.Length/k; //포장 가능한 박스 갯수
        if(box_count == 0) return 0; //이익이 발생하지 않을 시.
        
        int count = 0; //같은 점수의 사과 갯수
        int n = 0; //포장하고 남는 사과
        for(int j = k; j > 0; j--)
        {
            for(int i = 0; i < score.Length; i++)
            {
                if(score[i] == j)
                {
                    count++;
                }
            }
            
            answer += (count/m) * m * j; //count/m == 0 => answer += 0이 되어야함.
            n += count%m;
            if(n >= m)
            {
                answer += m * j;
                n -= m;
            }
            count = 0;
        }
        
        return answer;
    }
}