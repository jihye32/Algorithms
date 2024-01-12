using System;

public class Solution {
    public int solution(int n) {
        int i = 0;
        int answer = 0;
        while (i <= n){
            answer += i;
            i += 2;
        }
        return answer;
    }
}