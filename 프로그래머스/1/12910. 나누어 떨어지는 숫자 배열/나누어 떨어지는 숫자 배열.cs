using System.Collections.Generic;
using System.Linq;
using System;
public class Solution {
    public int[] solution(int[] arr, int divisor) {
        List<int> number = new List<int>();
        int[] answer;
        for (int i = 0; i < arr.Length; i++){
            if(arr[i]%divisor == 0) number.Add(arr[i]);
        }
        if (number.Count==0) {
            answer =  new int[] {(-1)};
        }
        else {
            answer = new int[number.Count];
            int i = 0;
            foreach (int n in number){
                answer[i] = n;
                i++;
            }
            Array.Sort(answer);
        }
        return answer;
    }
}