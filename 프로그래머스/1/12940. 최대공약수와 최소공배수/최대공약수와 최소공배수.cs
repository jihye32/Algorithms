public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        long small = (n > m) ? m : n;
        if (small == 1) {
            answer[0] = (int)small;
            answer[1] = n * m;
        }
        else{
            for(long i = 2; i <= small ; i++){
                if(n%i == 0 && m%i == 0){
                    answer[0] = (int)i;
                }
                if(answer[0] == 0) answer[0] = 1;
            }
        }
        answer[1] = m/answer[0] * n;
        return answer;
    }
}