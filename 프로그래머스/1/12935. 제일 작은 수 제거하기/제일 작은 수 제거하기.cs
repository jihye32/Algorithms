using System;
public class Solution {
    public int[] solution(int[] arr) {
        int[] answer;
        if(arr.Length == 1) return answer = new int[1] {-1};
        answer = new int[arr.Length -1];
        int minNumber = arr[0];
        foreach (int n in arr){
            if(n<minNumber){
                minNumber=n;
            }
        }
        int outNumber = Array.FindIndex(arr, i=>i==minNumber);
        int num =0;
        foreach (int n in arr){
            if (n != minNumber){
                answer[num]=n;
                num++;
            } 
        }
        return answer;
    }
}