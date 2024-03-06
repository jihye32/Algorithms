public class Solution {
    public int solution(int n) {
        int answer = 0;
        int f0 = 0;
        int f1 = 1;
        for(int i = 2; i <= n; i++){
            answer = f0 + f1;
            
            // int형의 범위를 벗어나지 않기 위한 예외처리
            // 나머지를 구하는 것이므로 1234567보다 작을 경우에는 answer 그대로 return
            if (answer > 1234567) answer %= 1234567;
            
            
            f0 = f1;
            f1 = answer;
        }
        
        return answer;
    }
}