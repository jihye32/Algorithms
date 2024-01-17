public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        long sum = (long)(a+b);
        if (a == b) return (long)a;
        else if (a > b){
            for (int i = 1; i < a-b;i++){
                sum += b+i;
            }
        }
        else {
            for (int i = 1; i < b-a;i++){
                sum += a+i;
            }
        }
        answer = sum;
        return answer;
    }
}