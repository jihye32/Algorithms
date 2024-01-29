using System;

public class Solution {
    public int solution(int[] number) {
        int sum = 0;
        int count =0;
        for (int i = 0; i < number.Length-2; i++){
            for(int j = i+1;j<number.Length-1;j++){
                for(int l = j+1;l<number.Length;l++){
                    sum = number[i]+number[j]+number[l];
                    if (sum == 0){
                        sum = 0;
                        count++;
                    }
                    else sum = 0;
                }
            }
        }
        return count;
    }
}