using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int index = 0;
        
        bool[] check = new bool[n];
        
        for(int i = 0; i < n; i++){
            
            if(index == section.Length){
                check[i] = true;
            }
            else{
                if(i == section[index] - 1){
                    check[i] = false;
                    index++;
                }   
                else check[i] = true;
            }
        }
        
        for(int j = 0; j < n; j++){
            if(!check[j]){
                answer++;
                for(int x = j; x < j+m; x++){
                    if(x == n){
                        break;
                    }
                    check[x] = true;
                }
            }
        }
        return answer;
    }
}