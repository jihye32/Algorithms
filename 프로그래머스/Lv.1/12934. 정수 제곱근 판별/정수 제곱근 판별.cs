public class Solution {
    public long solution(long n) {
        long answer = 0;
        long i = 1;
        while(i<=n){
            if(n == i*i){
                answer = (i+1) * (i+1);
                break;
            }
            else answer = -1;
            
            i++;
        }
        return answer;
    }
}