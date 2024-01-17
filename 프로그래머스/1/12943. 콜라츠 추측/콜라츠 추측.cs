public class Solution {
    public int solution(int num) {
        int answer = 0;
        if (num != 1){
            int count = 0;
            while(true){
                if(num%2 ==0){
                    num /= 2;
                }
                else if (num%2 ==1) num = num * 3 + 1;
                count++;
                if(num == 1) return count;
                if(count >= 500) return -1;
            }
        }
        return answer;
    }
}